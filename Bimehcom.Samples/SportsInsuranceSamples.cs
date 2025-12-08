using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.Sports.Requests;
using Bimehcom.Core.Models.SubClients.Sports.Responses;
using Bimehcom.Samples.SampleData;
using System.Text.Json;

namespace Bimehcom.Samples
{
    public class SportsInsuranceSamples
    {
        public IBimehcomClient Client { get; }
        public SportsInsuranceSamples(IBimehcomClient client)
        {
            Client = client;
        }

        public async Task<bool> RunAsync()
        {
            var sampleUser = JsonSerializer.Deserialize<SampleUserData>(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "SampleData", "sample-user.json")));
            // Basic Data
            SportsInsuranceBasicDataResponse basicData = await Client.Sports.GetBasicDataAsync();

            // Inquiry

            var inquiryRequest = new SportsInsuranceInquiryRequest
            {
                BirthDate = DateTime.Parse(sampleUser.BirthDate),
                CareerId = basicData.Careers.FirstOrDefault()?.Id
            };


            SportsInsuranceInquiryResponse inquiryResponse = await Client.Sports.InquiryAsync(inquiryRequest);


            // Create
            var createRequest = new SportsInsuranceCreateRequest
            {
                UniqueId = inquiryResponse.Inquiries.FirstOrDefault()?.UniqueId
            };

            SportsInsuranceCreateResponse createResponse = await Client.Sports.CreateAsync(createRequest);

            var insuranceRequestId = createResponse.InsuranceRequestId;

            // Get Info
            SportsInsuranceInfoResponse getInfoResponse = await Client.Sports.GetInfoAsync(insuranceRequestId);


            // Set Info
            var userAddresses = await Client.User.GetAddressesAsync();
            var setInfoRequest = new SportsInsuranceSetInfoRequest
            {
                AddressId = userAddresses.Addresses.FirstOrDefault().Id,
                BirthDate = DateTime.Parse(sampleUser.BirthDate),
                FirstName = sampleUser.FirstName,
                LastName = sampleUser.LastName,
                MobileNumber = sampleUser.Phone,
                NationalCode = sampleUser.NationalCode,
                Phone = sampleUser.Phone,
                TypeId = 0,
            };

            SportsInsuranceSetInfoResponse setInfoResponse = await Client.Sports.SetInfoAsync(insuranceRequestId, setInfoRequest);

            // Required File
            SportsInsuranceRequiredFileResponse requiredFileResponse = await Client.Sports.RequiredFileAsync(insuranceRequestId);

            var filePath = Path.Combine(AppContext.BaseDirectory, "Files", "bimehdotcom_logo.jfif");

            foreach (var requiredFile in requiredFileResponse.RequiredFiles)
            {
                using var stream = File.OpenRead(filePath);

                SportsInsuranceUploadRequiredFileResponse uploadFileResponse = await Client.Sports.UploadRequiredFileAsync(insuranceRequestId, stream, "test", requiredFile.FileName);
            }

            // Logistics Requirements
            SportsInsuranceLogisticsRequirementsResponse logisticsRequirements = await Client.Sports.LogisticsRequirementsAsync(insuranceRequestId);

            var setLogisticsRequirementsRequest = new SportsInsuranceSetLogisticsRequirementsRequest
            {
                Description = "جهت تست نرم افزار",
            };

            // Set Logistics Requirements
            SportsInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.Sports.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


            // Validate
            var validationResult = await Client.Sports.ValidationAsync(insuranceRequestId);
            return validationResult;
        }

    }
}
