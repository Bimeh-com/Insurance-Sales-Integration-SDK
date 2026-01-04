using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.Base.Info.Set;
using Bimehcom.Core.Models.SubClients.Pilgrimage.Requests;
using Bimehcom.Core.Models.SubClients.Pilgrimage.Responses;
using Bimehcom.Samples.SampleData;
using System.Text.Json;

namespace Bimehcom.Samples
{
    public class PilgrimageInsuranceSamples
    {
        public IBimehcomClient Client { get; }
        public PilgrimageInsuranceSamples(IBimehcomClient client)
        {
            Client = client;
        }

        public async Task<bool> RunAsync()
        {
            var sampleUser = JsonSerializer.Deserialize<SampleUserData>(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "SampleData", "sample-user.json")));
            // Basic Data
            PilgrimageInsuranceBasicDataResponse basicData = await Client.Pilgrimage.GetBasicDataAsync();

            // Inquiry

            var inquiryRequest = new PilgrimageInsuranceInquiryRequest
            {
                BirthDate = DateTime.Parse(sampleUser.BirthDate),
                TravelStartDate = DateTime.UtcNow.AddDays(1),
            };


            PilgrimageInsuranceInquiryResponse inquiryResponse = await Client.Pilgrimage.InquiryAsync(inquiryRequest);


            // Create
            var createRequest = new PilgrimageInsuranceCreateRequest
            {
                UniqueId = inquiryResponse.Inquiries.FirstOrDefault()?.UniqueId
            };

            PilgrimageInsuranceCreateResponse createResponse = await Client.Pilgrimage.CreateAsync(createRequest);

            var insuranceRequestId = createResponse.InsuranceRequestId;

            // Get Info
            PilgrimageInsuranceInfoResponse getInfoResponse = await Client.Pilgrimage.GetInfoAsync(insuranceRequestId);


            // Set Info
            var userAddresses = await Client.User.GetAddressesAsync();
            var setInfoRequest = new PilgrimageInsuranceSetInfoRequest
            {
                AddressId = userAddresses.Addresses.FirstOrDefault().Id,
                BirthDate = DateTime.Parse(sampleUser.BirthDate),
                FirstName = sampleUser.FirstName,
                LastName = sampleUser.LastName,
                MobileNumber = sampleUser.Phone,
                NationalCode = sampleUser.NationalCode,
                Phone = sampleUser.Phone,
                Gender = Gender.Male,
                TypeId = 0,
            };

            PilgrimageInsuranceSetInfoResponse setInfoResponse = await Client.Pilgrimage.SetInfoAsync(insuranceRequestId, setInfoRequest);

            // Required File
            PilgrimageInsuranceRequiredFileResponse requiredFileResponse = await Client.Pilgrimage.RequiredFileAsync(insuranceRequestId);

            var filePath = Path.Combine(AppContext.BaseDirectory, "Files", "bimehdotcom_logo.jfif");

            foreach (var requiredFile in requiredFileResponse.RequiredFiles)
            {
                using var stream = File.OpenRead(filePath);

                PilgrimageInsuranceUploadRequiredFileResponse uploadFileResponse = await Client.Pilgrimage.UploadRequiredFileAsync(insuranceRequestId, stream, "test", requiredFile.FileName);
            }

            // Logistics Requirements
            PilgrimageInsuranceLogisticsRequirementsResponse logisticsRequirements = await Client.Pilgrimage.LogisticsRequirementsAsync(insuranceRequestId);

            var setLogisticsRequirementsRequest = new PilgrimageInsuranceSetLogisticsRequirementsRequest
            {
                Description = "جهت تست نرم افزار",
            };

            // Set Logistics Requirements
            PilgrimageInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.Pilgrimage.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


            // Validate
            var validationResult = await Client.Pilgrimage.ValidationAsync(insuranceRequestId);
            return validationResult;
        }
    }
}
