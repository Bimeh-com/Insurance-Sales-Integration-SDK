using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.Fire.Requests;
using Bimehcom.Core.Models.SubClients.Fire.Responses;

namespace Bimehcom.Samples
{
    internal class FireInsuranceSamples
    {
        public IBimehcomClient Client { get; }
        public FireInsuranceSamples(IBimehcomClient client)
        {
            this.Client = client;
        }


        public async Task RunAsync()
        {
            //Basic Data

            FireInsuranceBasicDataResponse basicDataResponse = await Client.Fire.GetBasicDataAsync();


            // Inquiry
            var inquiryRequest = new FireInsuranceInquiryRequest
            {
                EstateTypeId = 1,
                StructureTypeId = 3,
                TotalArea = 100,
                AppliancesValue = 1500000000,
                AreaUnitPriceId = 5,
                CoverageIds = [],
                ApartmentUnitCount = null
            };
            FireInsuranceInquiryResponse inquiryResponse = await Client.Fire.InquiryAsync(inquiryRequest);

            // Create
            var createRequest = new FireInsuranceCreateRequest
            {
                UniqueId = inquiryResponse.Inquiries.FirstOrDefault()?.UniqueId
            };

            FireInsuranceCreateResponse createResponse = await Client.Fire.CreateAsync(createRequest);

            var insuranceRequestId = createResponse.InsuranceRequestId;

            // Get Info
            FireInsuranceInfoResponse getInfoResponse = await Client.Fire.GetInfoAsync(insuranceRequestId);


            // Set Info
            var userAddresses = await Client.User.GetAddressesAsync();
            var setInfoRequest = new FireInsuranceSetInfoRequest
            {
                AddressId = userAddresses.Addresses.FirstOrDefault().Id,
                BirthDate = DateTime.Parse("1998/3/20"),
                ConstructingDate = 1404,
                FirstName = "تست",
                LastName = "تست پور",
                FloorCount = 1,
                MobileNumber = "09309959493",
                NationalCode = "0021191808",
                OwnershipTypeId = 1,
                TypeId = 0
            };

            FireInsuranceSetInfoResponse setInfoResponse = await Client.Fire.SetInfoAsync(insuranceRequestId, setInfoRequest);

            // Required File

            FireInsuranceRequiredFileResponse requiredFileResponse = await Client.Fire.RequiredFileAsync(insuranceRequestId);

            // Logistics Requirements
            FireInsuranceLogisticsRequirementsResponse logisticsRequirements = await Client.Fire.LogisticsRequirementsAsync(insuranceRequestId);

            // Delivery Addresses
            FireInsuranceDevlieryAddressesResponse deliveryAddresses = await Client.Fire.DeliveryAddressesAsync(insuranceRequestId);

            var deliveryDateTimeRequest = new FireInsuranceDeliveryDateTimeRequest
            {
                AddressId = deliveryAddresses.SelectedId
            };

            // Delivery Date/Time 
            FireInsuranceDeliveryDateTimeResponse deliveryDateTimeResponse = await Client.Fire.DeliveryDateTimeAsync(insuranceRequestId, deliveryDateTimeRequest);

            var setLogisticsRequirementsRequest = new FireInsuranceSetLogisticsRequirementsRequest
            {
                UniqueId = deliveryDateTimeResponse.Deliveries.FirstOrDefault(x => !x.Disabled)?.Times.FirstOrDefault(t => !t.Disabled)?.UniqueId,
                Description = "جهت تست نرم افزار",
                Email = "",
                ReceiverFullName = "تست تست پور",
                ReceiverMobileNumber = "09309959493"
            };

            // Set Logistics Requirements
            FireInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.Fire.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


            // Validate
            var validationResult = await Client.Fire.ValidationAsync(insuranceRequestId);

            // Get Gateway Options
            FireInsuranceGetGatewayOptionsResponse paymentGatewayOptions = await Client.Fire.GetPaymentGatewayOptionsAsync(insuranceRequestId);


            // Redirect to Payment Gateway
            var redirectToGatewayRequest = new FireInsuranceRedirectToGatewayRequest
            {
                GatewayId = paymentGatewayOptions.Gateways.FirstOrDefault()?.Id,
                FaildReturnURL = $"https://bimeh.com/ins/paymentfailed?id={(object)insuranceRequestId}",
                SuccessReturnURL = $"https://bimeh.com/ins/paymentconfirm?id={(object)insuranceRequestId}"
            };

            FireInsuranceRedirectToGatewayResponse redirectToGatewayResponse = await Client.Fire.RedirectToPaymentGatewayAsync(insuranceRequestId, redirectToGatewayRequest);

        }
    }
}
