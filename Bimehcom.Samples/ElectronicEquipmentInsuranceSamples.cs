using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.ElectronicEquipment.Requests;
using Bimehcom.Core.Models.SubClients.ElectronicEquipment.Responses;
using Bimehcom.Samples.SampleData;
using System.Text.Json;

namespace Bimehcom.Samples
{
    public class ElectronicEquipmentInsuranceSamples
    {
        public IBimehcomClient Client { get; }
        public ElectronicEquipmentInsuranceSamples(IBimehcomClient client)
        {
            Client = client;
        }

        public async Task<bool> RunAsync()
        {
            var sampleUser = JsonSerializer.Deserialize<SampleUserData>(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "SampleData", "sample-user.json")));
            // Basic Data
            ElectronicEquipmentInsuranceBasicDataResponse basicData = await Client.ElectronicEquipment.GetBasicDataAsync();

            var deviceId = (long)basicData.Devices.FirstOrDefault()?.Id;
            ElectronicEquipmentInsuranceGetBrandsResponse brands = await Client.ElectronicEquipment.GetBrandsAsync(deviceId);

            var brandId = (long)brands.Brands.FirstOrDefault()?.Id;
            ElectronicEquipmentInsuranceGetModelsResponse models = await Client.ElectronicEquipment.GetModelsAsync(brandId);

            // Inquiry

            var inquiryRequest = new ElectronicEquipmentInsuranceInquiryRequest
            {
                DeviceId = (int)deviceId,
                BrandId = (int)brandId,
                ModelId = (int)models.Models.FirstOrDefault()?.Id,
                Price = 15000000
            };


            ElectronicEquipmentInsuranceInquiryResponse inquiryResponse = await Client.ElectronicEquipment.InquiryAsync(inquiryRequest);


            // Create
            var createRequest = new ElectronicEquipmentInsuranceCreateRequest
            {
                UniqueId = inquiryResponse.Inquiries.FirstOrDefault()?.UniqueId
            };

            ElectronicEquipmentInsuranceCreateResponse createResponse = await Client.ElectronicEquipment.CreateAsync(createRequest);

            var insuranceRequestId = createResponse.InsuranceRequestId;

            // Get Info
            ElectronicEquipmentInsuranceInfoResponse getInfoResponse = await Client.ElectronicEquipment.GetInfoAsync(insuranceRequestId);


            // Set Info
            var userAddresses = await Client.User.GetAddressesAsync();
            var setInfoRequest = new ElectronicEquipmentInsuranceSetInfoRequest
            {
                AddressId = userAddresses.Addresses.FirstOrDefault().Id,
                BirthDate = DateTime.Parse(sampleUser.BirthDate),
                FirstName = sampleUser.FirstName,
                LastName = sampleUser.LastName,
                NationalCode = sampleUser.NationalCode,
                IdentityNo = sampleUser.IdentityNumber,
                MobileNumber = sampleUser.Phone,
                TypeId = 0,
                Serial = sampleUser.SerialNumber,
            };

            ElectronicEquipmentInsuranceSetInfoResponse setInfoResponse = await Client.ElectronicEquipment.SetInfoAsync(insuranceRequestId, setInfoRequest);

            // Required File
            ElectronicEquipmentInsuranceRequiredFileResponse requiredFileResponse = await Client.ElectronicEquipment.RequiredFileAsync(insuranceRequestId);

            var filePath = Path.Combine(AppContext.BaseDirectory, "Files", "bimehdotcom_logo.jfif");

            foreach (var requiredFile in requiredFileResponse.RequiredFiles)
            {
                using var stream = File.OpenRead(filePath);

                ElectronicEquipmentInsuranceUploadRequiredFileResponse uploadFileResponse = await Client.ElectronicEquipment.UploadRequiredFileAsync(insuranceRequestId, stream, "test", requiredFile.FileName);
            }

            // Logistics Requirements
            ElectronicEquipmentInsuranceLogisticsRequirementsResponse logisticsRequirements = await Client.ElectronicEquipment.LogisticsRequirementsAsync(insuranceRequestId);

            var setLogisticsRequirementsRequest = new ElectronicEquipmentInsuranceSetLogisticsRequirementsRequest
            {
                Description = "جهت تست نرم افزار",
            };

            // Set Logistics Requirements
            ElectronicEquipmentInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.ElectronicEquipment.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


            // Validate
            var validationResult = await Client.ElectronicEquipment.ValidationAsync(insuranceRequestId);
            return validationResult;
        }

    }
}
