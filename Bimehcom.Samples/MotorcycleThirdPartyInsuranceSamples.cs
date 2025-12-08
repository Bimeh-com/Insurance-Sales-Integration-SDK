using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.MotorcycleThirdParty.Requests;
using Bimehcom.Core.Models.SubClients.MotorcycleThirdParty.Responses;
using Bimehcom.Samples.SampleData;
using System.Text.Json;

namespace Bimehcom.Samples
{
    public class MotorcycleThirdPartyInsuranceSamples
    {
        public IBimehcomClient Client { get; }
        public MotorcycleThirdPartyInsuranceSamples(IBimehcomClient client)
        {
            Client = client;
        }

        public async Task<bool> RunAsync()
        {
            var sampleUser = JsonSerializer.Deserialize<SampleUserData>(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "SampleData", "sample-user.json")));

            // Basic Data
            MotorcycleThirdPartyInsuranceBasicDataResponse basicData = await Client.MotorcycleThirdParty.GetBasicDataAsync();

            // Inquiry

            var inquiryRequest = new MotorcycleThirdPartyInsuranceInquiryRequest
            {
                MotorTypeId = basicData.MotorTypes.FirstOrDefault()?.Id,
                PreviousInsuranceStatusId = 0,
                ProductionYearId = 2025,
                ReleaseDate = DateTime.Parse("2025/1/1"),
            };


            MotorcycleThirdPartyInsuranceInquiryResponse inquiryResponse = await Client.MotorcycleThirdParty.InquiryAsync(inquiryRequest);

            // Create
            var createRequest = new MotorcycleThirdPartyInsuranceCreateRequest
            {
                UniqueId = inquiryResponse.Inquiries.FirstOrDefault()?.UniqueId
            };

            MotorcycleThirdPartyInsuranceCreateResponse createResponse = await Client.MotorcycleThirdParty.CreateAsync(createRequest);

            var insuranceRequestId = createResponse.InsuranceRequestId;

            // Get Info
            MotorcycleThirdPartyInsuranceInfoResponse getInfoResponse = await Client.MotorcycleThirdParty.GetInfoAsync(insuranceRequestId);


            // Set Info
            var userAddresses = await Client.User.GetAddressesAsync();
            var setInfoRequest = new MotorcycleThirdPartyInsuranceSetInfoRequest
            {
                AddressId = userAddresses.Addresses.FirstOrDefault().Id,
                BirthDate = DateTime.Parse(sampleUser.BirthDate),
                FirstName = sampleUser.FirstName,
                LastName = sampleUser.LastName,
                MobileNumber = sampleUser.Phone,
                NationalCode = sampleUser.NationalCode,
                PolicyOwnerIsCarOwner = true,
                TypeId = 0,
            };

            MotorcycleThirdPartyInsuranceSetInfoResponse setInfoResponse = await Client.MotorcycleThirdParty.SetInfoAsync(insuranceRequestId, setInfoRequest);

            // Required File
            MotorcycleThirdPartyInsuranceRequiredFileResponse requiredFileResponse = await Client.MotorcycleThirdParty.RequiredFileAsync(insuranceRequestId);

            var filePath = Path.Combine(AppContext.BaseDirectory, "Files", "bimehdotcom_logo.jfif");

            foreach (var requiredFile in requiredFileResponse.RequiredFiles)
            {

                using var stream = File.OpenRead(filePath);


                MotorcycleThirdPartyInsuranceUploadRequiredFileResponse uploadFileResponse = await Client.MotorcycleThirdParty.UploadRequiredFileAsync(insuranceRequestId, stream, "test", requiredFile.FileName);
            }


            var setLogisticsRequirementsRequest = new MotorcycleThirdPartyInsuranceSetLogisticsRequirementsRequest
            {
                Description = "جهت تست نرم افزار"
            };

            // Set Logistics Requirements
            MotorcycleThirdPartyInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.MotorcycleThirdParty.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


            // Validate
            var validationResult = await Client.MotorcycleThirdParty.ValidationAsync(insuranceRequestId);
            return validationResult;
         
        }
    }
}
