using Bimehcom.Core;
using Bimehcom.Core.Models.SubClients.MotorcycleThirdParty.Requests;
using Bimehcom.Core.Models.SubClients.MotorcycleThirdParty.Responses;

namespace Bimehcom.Samples
{
    public class MotorcycleThirdPartyInsuranceSamples
    {
        public IBimehcomClient Client { get; }
        public MotorcycleThirdPartyInsuranceSamples(IBimehcomClient client)
        {
            Client = client;
        }

        public async Task RunAsync()
        {
            // Basic Data
            MotorcycleThirdPartyInsuranceBasicDataResponse basicData = await Client.MotorcycleThirdParty.GetBasicDataAsync();

            // Inquiry

            var inquiryRequest = new MotorcycleThirdPartyInsuranceInquiryRequest
            {
                MotorTypeId = 7,
                PreviousInsuranceStatusId = 0,
                ProductionYearId = 2025,
                ReleaseDate = DateTime.Parse("2025/12/2"),
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
            var setInfoRequest = new MotorcycleThirdPartyInsuranceSetInfoRequest
            {
                AddressId = 1725179,
                BirthDate = DateTime.Parse("1996/3/20"),
                FirstName = "اشکان",
                LastName = "افشارپور",
                MobileNumber = "09309959493",
                NationalCode = "0021191808",
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
                Description = ""
            };

            // Set Logistics Requirements
            MotorcycleThirdPartyInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.MotorcycleThirdParty.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


            // Validate
            var validationResult = await Client.MotorcycleThirdParty.ValidationAsync(insuranceRequestId);

            // Get Gateway Options
            MotorcycleThirdPartyInsuranceGetGatewayOptionsResponse paymentGatewayOptions = await Client.MotorcycleThirdParty.GetPaymentGatewayOptionsAsync(insuranceRequestId);


            // Redirect to Payment Gateway
            var redirectToGatewayRequest = new MotorcycleThirdPartyInsuranceRedirectToGatewayRequest
            {
                GatewayId = paymentGatewayOptions.Gateways.FirstOrDefault()?.Id,
                FaildReturnURL = $"https://bimeh.com/ins/paymentfailed?id={(object)insuranceRequestId}",
                SuccessReturnURL = $"https://bimeh.com/ins/paymentconfirm?id={(object)insuranceRequestId}"
            };

            MotorcycleThirdPartyInsuranceRedirectToGatewayResponse redirectToGatewayResponse = await Client.MotorcycleThirdParty.RedirectToPaymentGatewayAsync(insuranceRequestId, redirectToGatewayRequest);
        }
    }
}
