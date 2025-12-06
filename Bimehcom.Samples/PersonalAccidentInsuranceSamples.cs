using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.PersonalAccident.Requests;
using Bimehcom.Core.Models.SubClients.PersonalAccident.Responses;

namespace Bimehcom.Samples
{
    internal class PersonalAccidentInsuranceSamples
    {
        public IBimehcomClient Client { get; }
        public PersonalAccidentInsuranceSamples(IBimehcomClient client)
        {
            Client = client;
        }

        public async Task RunAsync()
        {
            // Basic Data
            PersonalAccidentInsuranceBasicDataResponse basicData = await Client.PersonalAccident.GetBasicDataAsync();

            // Inquiry

            var inquiryRequest = new PersonalAccidentInsuranceInquiryRequest
            {
                BirthDate = DateTime.Parse("1998/3/20"),
                CareerId = 8
            };


            PersonalAccidentInsuranceInquiryResponse inquiryResponse = await Client.PersonalAccident.InquiryAsync(inquiryRequest);


            // Create
            var createRequest = new PersonalAccidentInsuranceCreateRequest
            {
                UniqueId = inquiryResponse.Inquiries.FirstOrDefault()?.UniqueId
            };

            PersonalAccidentInsuranceCreateResponse createResponse = await Client.PersonalAccident.CreateAsync(createRequest);

            var insuranceRequestId = createResponse.InsuranceRequestId;

            // Get Info
            PersonalAccidentInsuranceInfoResponse getInfoResponse = await Client.PersonalAccident.GetInfoAsync(insuranceRequestId);


            // Set Info
            var userAddresses = await Client.User.GetAddressesAsync();
            var setInfoRequest = new PersonalAccidentInsuranceSetInfoRequest
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

            PersonalAccidentInsuranceSetInfoResponse setInfoResponse = await Client.PersonalAccident.SetInfoAsync(insuranceRequestId, setInfoRequest);

            // Required File
            PersonalAccidentInsuranceRequiredFileResponse requiredFileResponse = await Client.PersonalAccident.RequiredFileAsync(insuranceRequestId);

            var filePath = Path.Combine(AppContext.BaseDirectory, "Files", "bimehdotcom_logo.jfif");

            foreach (var requiredFile in requiredFileResponse.RequiredFiles)
            {
                using var stream = File.OpenRead(filePath);

                PersonalAccidentInsuranceUploadRequiredFileResponse uploadFileResponse = await Client.PersonalAccident.UploadRequiredFileAsync(insuranceRequestId, stream, "test", requiredFile.FileName);
            }

            // Logistics Requirements
            PersonalAccidentInsuranceLogisticsRequirementsResponse logisticsRequirements = await Client.PersonalAccident.LogisticsRequirementsAsync(insuranceRequestId);

            var setLogisticsRequirementsRequest = new PersonalAccidentInsuranceSetLogisticsRequirementsRequest
            {
                Description = "جهت تست نرم افزار",
            };

            // Set Logistics Requirements
            PersonalAccidentInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.PersonalAccident.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


            // Validate
            var validationResult = await Client.PersonalAccident.ValidationAsync(insuranceRequestId);

            // Get Gateway Options
            PersonalAccidentInsuranceGetGatewayOptionsResponse paymentGatewayOptions = await Client.PersonalAccident.GetPaymentGatewayOptionsAsync(insuranceRequestId);


            // Redirect to Payment Gateway
            var redirectToGatewayRequest = new PersonalAccidentInsuranceRedirectToGatewayRequest
            {
                GatewayId = paymentGatewayOptions.Gateways.FirstOrDefault()?.Id,
                FaildReturnURL = $"https://bimeh.com/ins/paymentfailed?id={(object)insuranceRequestId}",
                SuccessReturnURL = $"https://bimeh.com/ins/paymentconfirm?id={(object)insuranceRequestId}"
            };

            PersonalAccidentInsuranceRedirectToGatewayResponse redirectToGatewayResponse = await Client.PersonalAccident.RedirectToPaymentGatewayAsync(insuranceRequestId, redirectToGatewayRequest);

        }

    }
}
