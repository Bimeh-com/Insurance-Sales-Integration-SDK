using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.TravelPlus.Requests;
using Bimehcom.Core.Models.SubClients.TravelPlus.Responses;
using Bimehcom.Samples.SampleData;
using System.Text.Json;

namespace Bimehcom.Samples
{
    public class TravelPlusInsuranceSamples
    {
        public IBimehcomClient Client { get; }
        public TravelPlusInsuranceSamples(IBimehcomClient client)
        {
            Client = client;
        }

        public async Task<bool> RunAsync()
        {
            var sampleUser = JsonSerializer.Deserialize<SampleUserData>(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "SampleData", "sample-user.json")));
            // Basic Data
            TravelPlusInsuranceBasicDataResponse basicData = await Client.TravelPlus.GetBasicDataAsync();

            // Inquiry

            var inquiryRequest = new TravelPlusInsuranceInquiryRequest
            {
                BirthDate = DateTime.Parse(sampleUser.BirthDate),
                CountryId = basicData.Countries.FirstOrDefault()?.Id,
                DurationId = basicData.Durations.FirstOrDefault()?.Id,
                VisaTypeId = basicData.VisaTypes.FirstOrDefault()?.Id,
            };


            TravelPlusInsuranceInquiryResponse inquiryResponse = await Client.TravelPlus.InquiryAsync(inquiryRequest);


            // Create
            var createRequest = new TravelPlusInsuranceCreateRequest
            {
                UniqueId = inquiryResponse.Inquiries.FirstOrDefault()?.UniqueId
            };

            TravelPlusInsuranceCreateResponse createResponse = await Client.TravelPlus.CreateAsync(createRequest);

            var insuranceRequestId = createResponse.InsuranceRequestId;

            // Get Info
            TravelPlusInsuranceInfoResponse getInfoResponse = await Client.TravelPlus.GetInfoAsync(insuranceRequestId);


            // Set Info
            var userAddresses = await Client.User.GetAddressesAsync();
            var setInfoRequest = new TravelPlusInsuranceSetInfoRequest
            {
                FirstName = sampleUser.FirstName,
                LastName = sampleUser.LastName,
                MobileNumber = sampleUser.Phone,
                NationalCode = sampleUser.NationalCode,
                TypeId = 0,
                GenderId = 0,
                LatinFirstName = sampleUser.LatinFirstName,
                LatinLastName = sampleUser.LatinLastName,
                PassportNumber = "A123456789",
            };

            TravelPlusInsuranceSetInfoResponse setInfoResponse = await Client.TravelPlus.SetInfoAsync(insuranceRequestId, setInfoRequest);

            // Required File
            TravelPlusInsuranceRequiredFileResponse requiredFileResponse = await Client.TravelPlus.RequiredFileAsync(insuranceRequestId);

            var filePath = Path.Combine(AppContext.BaseDirectory, "Files", "bimehdotcom_logo.jfif");

            foreach (var requiredFile in requiredFileResponse.RequiredFiles)
            {
                using var stream = File.OpenRead(filePath);

                TravelPlusInsuranceUploadRequiredFileResponse uploadFileResponse = await Client.TravelPlus.UploadRequiredFileAsync(insuranceRequestId, stream, "test", requiredFile.FileName);
            }

            // Logistics Requirements
            TravelPlusInsuranceLogisticsRequirementsResponse logisticsRequirements = await Client.TravelPlus.LogisticsRequirementsAsync(insuranceRequestId);

            var setLogisticsRequirementsRequest = new TravelPlusInsuranceSetLogisticsRequirementsRequest
            {
                Description = "جهت تست نرم افزار",
            };

            // Set Logistics Requirements
            TravelPlusInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.TravelPlus.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


            // Validate
            var validationResult = await Client.TravelPlus.ValidationAsync(insuranceRequestId);
            return validationResult;
        }
    }
}