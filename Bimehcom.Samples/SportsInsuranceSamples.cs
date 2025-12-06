using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.Sports.Requests;
using Bimehcom.Core.Models.SubClients.Sports.Responses;

namespace Bimehcom.Samples
{
    internal class SportsInsuranceSamples
    {
        public IBimehcomClient Client { get; }
        public SportsInsuranceSamples(IBimehcomClient client)
        {
            Client = client;
        }

        public async Task RunAsync()
        {
            // Basic Data
            SportsInsuranceBasicDataResponse basicData = await Client.Sports.GetBasicDataAsync();

            // Inquiry

            var inquiryRequest = new SportsInsuranceInquiryRequest
            {
                BirthDate = DateTime.Parse("1998/3/20"),
                CareerId = 1
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
                BirthDate = DateTime.Parse("1998/3/20"),
                FirstName = "تست",
                LastName = "تست پور",
                MobileNumber = "09309959493",
                NationalCode = "0021191808",
                Phone = "09309959493",
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

            // Get Gateway Options
            SportsInsuranceGetGatewayOptionsResponse paymentGatewayOptions = await Client.Sports.GetPaymentGatewayOptionsAsync(insuranceRequestId);


            // Redirect to Payment Gateway
            var redirectToGatewayRequest = new SportsInsuranceRedirectToGatewayRequest
            {
                GatewayId = paymentGatewayOptions.Gateways.FirstOrDefault()?.Id,
                FaildReturnURL = $"https://bimeh.com/ins/paymentfailed?id={(object)insuranceRequestId}",
                SuccessReturnURL = $"https://bimeh.com/ins/paymentconfirm?id={(object)insuranceRequestId}"
            };

            SportsInsuranceRedirectToGatewayResponse redirectToGatewayResponse = await Client.Sports.RedirectToPaymentGatewayAsync(insuranceRequestId, redirectToGatewayRequest);

        }

    }
}
