using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.Base.Inquiry;
using Bimehcom.Core.Models.SubClients.TravelPlus.Requests;
using Bimehcom.Core.Models.SubClients.TravelPlus.Responses;

namespace Bimehcom.Samples
{
    internal class TravelPlusInsuranceSamples
    {
        public IBimehcomClient Client { get; }
        public TravelPlusInsuranceSamples(IBimehcomClient client)
        {
            Client = client;
        }

        public async Task RunAsync()
        {
            // Basic Data
            TravelPlusInsuranceBasicDataResponse basicData = await Client.TravelPlus.GetBasicDataAsync();

            // Inquiry

            var inquiryRequest = new TravelPlusInsuranceInquiryRequest
            {
                BirthDate = DateTime.Parse("1998/3/20"),
                CountryId = 2,
                DurationId = 12,
                VisaTypeId = EnInsVisaType.One,
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
                FirstName = "تست",
                LastName = "تست پور",
                MobileNumber = "09309959493",
                NationalCode = "0021191808",
                TypeId = 0,
                GenderId = 0,
                LatinFirstName = "Test",
                LatinLastName = "Testpour",
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

            // Get Gateway Options
            TravelPlusInsuranceGetGatewayOptionsResponse paymentGatewayOptions = await Client.TravelPlus.GetPaymentGatewayOptionsAsync(insuranceRequestId);


            // Redirect to Payment Gateway
            var redirectToGatewayRequest = new TravelPlusInsuranceRedirectToGatewayRequest
            {
                GatewayId = paymentGatewayOptions.Gateways.FirstOrDefault()?.Id,
                FaildReturnURL = $"https://bimeh.com/ins/paymentfailed?id={(object)insuranceRequestId}",
                SuccessReturnURL = $"https://bimeh.com/ins/paymentconfirm?id={(object)insuranceRequestId}"
            };

            TravelPlusInsuranceRedirectToGatewayResponse redirectToGatewayResponse = await Client.TravelPlus.RedirectToPaymentGatewayAsync(insuranceRequestId, redirectToGatewayRequest);

        }
    }
}