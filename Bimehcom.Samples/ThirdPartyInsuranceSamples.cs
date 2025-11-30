using Bimehcom.Core;
using Bimehcom.Core.Models.SubClients.ThirdParty.Requests;
using Bimehcom.Core.Models.SubClients.ThirdParty.Responses;
using Bimehcom.Core.Models.SubClients.Vehicle.Responses;

namespace Bimehcom.Samples
{
    internal class ThirdPartyInsuranceSamples
    {
        public IBimehcomClient Client { get; }
        public ThirdPartyInsuranceSamples(IBimehcomClient client)
        {
            Client = client;
        }


        public async Task RunAsync()
        {
            // Basic Data
            ThirdPartyInsuranceBasicDataResponse basicData = await Client.ThirdParty.GetBasicDataAsync();

            // Car Models
            VehicleClientCarModelsResponse carModels = await Client.ThirdParty.GetCarModelsByCategoryAndBrand(1001, 1);

            // Inquiry

            var inquiryRequest = new ThirdPartyInsuranceInquiryRequest
            {
                InquiryUrl = "https://bimeh.com/thirdparty/planlist?UsingTypeId=1&BrandId=1001&ModelId=1001&VehicleCategoryId=1&ProductionYearId=2025&PreviousInsuranceStatusId=0&ReleaseDate=2025/11/30&isRenewal=false",
                ModelId = 1001,
                PreviousInsuranceStatusId = 0,
                ProductionYearId = 2025,
                ReleaseDate = DateTime.Parse("2025/11/30"),
                UsingTypeId = 1,
            };

            ThirdPartyInsuranceInquiryResponse inquiryResponse = await Client.ThirdParty.InquiryAsync(inquiryRequest);


            // Create
            var createRequest = new ThirdPartyInsuranceCreateRequest
            {
                UniqueId = inquiryResponse.Inquiries.FirstOrDefault()?.UniqueId
            };

            ThirdPartyInsuranceCreateResponse createResponse = await Client.ThirdParty.CreateAsync(createRequest);

            var insuranceRequestId = createResponse.InsuranceRequestId;

            // Get Info
            ThirdPartyInsuranceInfoResponse getInfoResponse = await Client.ThirdParty.GetInfoAsync(insuranceRequestId);


            // Set Info
            var setInfoRequest = new ThirdPartyInsuranceSetInfoRequest
            {
                AddressId = 1725179,
                BirthDate = DateTime.Parse("1998/3/20"),
                FirstName = "John",
                LastName = "Doe",
                MobileNumber = "09309959493",
                NationalCode = "0021191808",
                PolicyOwnerIsCarOwner = true,
                TypeId = 0,
                
            };

            ThirdPartyInsuranceSetInfoResponse setInfoResponse = await Client.ThirdParty.SetInfoAsync(insuranceRequestId, setInfoRequest);

            // Required File

            ThirdPartyInsuranceRequiredFileResponse requiredFileResponse = await Client.ThirdParty.RequiredFileAsync(insuranceRequestId);

            // Logistics Requirements
            ThirdPartyInsuranceLogisticsRequirementsResponse logisticsRequirements = await Client.ThirdParty.LogisticsRequirementsAsync(insuranceRequestId);

            // Delivery Addresses
            ThirdPartyInsuranceDevlieryAddressesResponse deliveryAddresses = await Client.ThirdParty.DeliveryAddressesAsync(insuranceRequestId);

            var deliveryDateTimeRequest = new ThirdPartyInsuranceDeliveryDateTimeRequest
            {
                AddressId = deliveryAddresses.SelectedId
            };

            // Delivery Date/Time 
            ThirdPartyInsuranceDeliveryDateTimeResponse deliveryDateTimeResponse = await Client.ThirdParty.DeliveryDateTimeAsync(insuranceRequestId, deliveryDateTimeRequest);

            var setLogisticsRequirementsRequest = new ThirdPartyInsuranceSetLogisticsRequirementsRequest
            {
                UniqueId = deliveryDateTimeResponse.Deliveries.FirstOrDefault()?.Times.FirstOrDefault()?.UniqueId,
                Description = "",
                Email = "",
                ReceiverFullName = "John Doe",
                ReceiverMobileNumber = "09309959493"
            };

            // Set Logistics Requirements
            ThirdPartyInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.ThirdParty.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


            // Validate
            var validationResult = await Client.ThirdParty.ValidationAsync(insuranceRequestId);

            // Get Gateway Options
            ThirdPartyInsuranceGetGatewayOptionsResponse paymentGatewayOptions = await Client.ThirdParty.GetPaymentGatewayOptionsAsync(insuranceRequestId);


            // Redirect to Payment Gateway
            var redirectToGatewayRequest = new ThirdPartyInsuranceRedirectToGatewayRequest
            {
                GatewayId = paymentGatewayOptions.Gateways.FirstOrDefault()?.Id,
                FaildReturnURL = $"https://bimeh.com/ins/paymentfailed?id={(object)insuranceRequestId}",
                SuccessReturnURL = $"https://bimeh.com/ins/paymentconfirm?id={(object)insuranceRequestId}"
            };

            ThirdPartyInsuranceRedirectToGatewayResponse redirectToGatewayResponse = await Client.ThirdParty.RedirectToPaymentGatewayAsync(insuranceRequestId, redirectToGatewayRequest);

        }
    }
}
