using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.Base.Info.Set;
using Bimehcom.Core.Models.SubClients.Pilgrimage.Requests;
using Bimehcom.Core.Models.SubClients.Pilgrimage.Responses;

namespace Bimehcom.Samples
{
    internal class PilgrimageInsuranceSamples
    {
        public IBimehcomClient Client { get; }
        public PilgrimageInsuranceSamples(IBimehcomClient client)
        {
            Client = client;
        }

        public async Task RunAsync()
        {
            // Basic Data
            PilgrimageInsuranceBasicDataResponse basicData = await Client.Pilgrimage.GetBasicDataAsync();

            // Inquiry

            var inquiryRequest = new PilgrimageInsuranceInquiryRequest
            {
                BirthDate = DateTime.Parse("1998/3/20"),
                TravelStartDate = DateTime.Parse("2025/12/30"),
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
                BirthDate = DateTime.Parse("1998/3/20"),
                FirstName = "تست",
                LastName = "تست پور",
                MobileNumber = "09309959493",
                NationalCode = "0021191808",
                Phone = "09309959493",
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

            // Get Gateway Options
            PilgrimageInsuranceGetGatewayOptionsResponse paymentGatewayOptions = await Client.Pilgrimage.GetPaymentGatewayOptionsAsync(insuranceRequestId);


            // Redirect to Payment Gateway
            var redirectToGatewayRequest = new PilgrimageInsuranceRedirectToGatewayRequest
            {
                GatewayId = paymentGatewayOptions.Gateways.FirstOrDefault()?.Id,
                FaildReturnURL = $"https://bimeh.com/ins/paymentfailed?id={(object)insuranceRequestId}",
                SuccessReturnURL = $"https://bimeh.com/ins/paymentconfirm?id={(object)insuranceRequestId}"
            };

            PilgrimageInsuranceRedirectToGatewayResponse redirectToGatewayResponse = await Client.Pilgrimage.RedirectToPaymentGatewayAsync(insuranceRequestId, redirectToGatewayRequest);

        }
    }
}
