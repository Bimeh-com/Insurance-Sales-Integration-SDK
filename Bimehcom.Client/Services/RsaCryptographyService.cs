using Bimehcom.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Bimehcom.Client.Services
{
    internal class RsaCryptographyService
    {
        private RSACryptoServiceProvider _RSACryptoServiceProvider;

        public string PrivateKey
        {
            get
            {
                return _RSACryptoServiceProvider.ToXmlString(true);
            }
        }

        public string PublicKey
        {
            get
            {
                return _RSACryptoServiceProvider.ToXmlString(false);
            }
        }
        public RsaCryptographyService(int keySize = 2048)
        {
            _RSACryptoServiceProvider = new RSACryptoServiceProvider(keySize);
        }
        public static string Encrypt(string data, string publicKey, int keySize = 2048)
        {
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(keySize);
                rsa.FromXmlString(publicKey);
                var byteData = Encoding.UTF8.GetBytes(data);
                var encrypt = rsa.Encrypt(byteData, false);
                return Convert.ToBase64String(encrypt);
            }
            catch (Exception ex)
            {

                throw new BimehcomException("مشکل در رمزگذاری");
            }
        }

        public static string Decrypt(string data, string privateKey, int keySize = 2048)
        {
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(keySize);
                rsa.FromXmlString(privateKey);
                var byteData = Convert.FromBase64String(data);
                var decrypt = rsa.Decrypt(byteData, false);
                var result = Encoding.UTF8.GetString(decrypt);
                return result;
            }
            catch (Exception ex)
            {

                throw new BimehcomException("مشکل در رمزگشایی");
            }
        }

        public static string Decrypt(string data, string key, int? businessId, int keySize = 2048)
        {
            switch (businessId)
            {
                // iran zamin
                case 10:
                    {
                        var jwt = Decode(data, key, true);
                        try
                        {
                            DateTime epoch = new DateTime(1970, 1, 1, 3, 30, 0, DateTimeKind.Utc);
                            epoch = epoch.AddSeconds((long)jwt["exp"]);

                            if (jwt["scope"].ToString().Contains("iranzamin.bimeh.com"))
                            {
                                if (jwt.ContainsKey("mobileNumber"))
                                {
                                    return JsonSerializer.Serialize(new { UserName = jwt["mobileNumber"], DisplayName = jwt["mobileNumber"] });
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new BimehcomException("خطا در بررسی scope", ex);
                        }
                        throw new BimehcomException("خطا در ورود");
                    }
                default:
                    {
                        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(keySize);
                        rsa.FromXmlString(key);
                        var byteData = Convert.FromBase64String(data);
                        var decrypt = rsa.Decrypt(byteData, false);
                        var result = Encoding.UTF8.GetString(decrypt);
                        return result;
                    }
            }
        }

        public static Dictionary<string, object?> Decode(string token, string key, bool verify = true)
        {
            string[] parts = token.Split('.');
            if (parts.Length != 3)
                throw new ApplicationException("Invalid token format");

            string header = parts[0];
            string payload = parts[1];
            byte[] signature = Base64UrlDecode(parts[2]);

            // Decode JSON
            string headerJson = Encoding.UTF8.GetString(Base64UrlDecode(header));
            string payloadJson = Encoding.UTF8.GetString(Base64UrlDecode(payload));

            // Convert JSON to dictionary
            var headerData = JsonSerializer.Deserialize<Dictionary<string, object?>>(headerJson);
            var payloadData = JsonSerializer.Deserialize<Dictionary<string, object?>>(payloadJson);

            if (payloadData == null)
                throw new ApplicationException("Invalid payload");

            // Signature verification
            if (verify)
            {
                using var rsa = new RSACryptoServiceProvider(2048);
                rsa.FromXmlString(key);

                using var sha256 = SHA256.Create();
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(parts[0] + "." + parts[1]));

                var rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                rsaDeformatter.SetHashAlgorithm("SHA256");

                if (!rsaDeformatter.VerifySignature(hash, signature))
                    throw new ApplicationException("Invalid signature");
            }

            return payloadData;
        }
        private static byte[] Base64UrlDecode(string input)
        {
            string output = input.Replace('-', '+').Replace('_', '/');
            switch (output.Length % 4)
            {
                case 0: break;
                case 1: output += "==="; break;
                case 2: output += "=="; break;
                case 3: output += "="; break;
            }
            return Convert.FromBase64String(output);
        }
    }
}
