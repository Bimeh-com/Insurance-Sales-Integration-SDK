
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.Elevator.Requests;
using Bimehcom.Core.Models.SubClients.Elevator.Responses;

namespace Bimehcom.Samples
{
    internal class ElevatorInsuranceSamples
    {
        private IBimehcomClient Client;

        public ElevatorInsuranceSamples(IBimehcomClient client)
        {
            Client = client;
        }

        public async Task RunAsync()
        {
            // Basic Data
            ElevatorInsuranceBasicDataResponse basicData = await Client.Elevator.GetBasicDataAsync();

            // Inquiry

            var inquiryRequest = new ElevatorInsuranceInquiryRequest
            {
                ElevatorAge = 5,
                ElevatorCapacity = 3,
                ElevatorUsageId = 0,
                FloorsCount = 3,
                HasInteriorDoor = true
            };


            ElevatorInsuranceInquiryResponse inquiryResponse = await Client.Elevator.InquiryAsync(inquiryRequest);


            // Create
            var createRequest = new ElevatorInsuranceCreateRequest
            {
                UniqueId = inquiryResponse.Inquiries.FirstOrDefault()?.UniqueId
            };

            ElevatorInsuranceCreateResponse createResponse = await Client.Elevator.CreateAsync(createRequest);

            var insuranceRequestId = createResponse.InsuranceRequestId;

            // Get Info
            ElevatorInsuranceInfoResponse getInfoResponse = await Client.Elevator.GetInfoAsync(insuranceRequestId);


            // Set Info
            var userAddresses = await Client.User.GetAddressesAsync();
            var setInfoRequest = new ElevatorInsuranceSetInfoRequest
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

            ElevatorInsuranceSetInfoResponse setInfoResponse = await Client.Elevator.SetInfoAsync(insuranceRequestId, setInfoRequest);

            // Required File
            ElevatorInsuranceRequiredFileResponse requiredFileResponse = await Client.Elevator.RequiredFileAsync(insuranceRequestId);

            var filePath = Path.Combine(AppContext.BaseDirectory, "Files", "bimehdotcom_logo.jfif");

            foreach (var requiredFile in requiredFileResponse.RequiredFiles)
            {
                using var stream = File.OpenRead(filePath);

                ElevatorInsuranceUploadRequiredFileResponse uploadFileResponse = await Client.Elevator.UploadRequiredFileAsync(insuranceRequestId, stream, "test", requiredFile.FileName);
            }

            // Logistics Requirements
            ElevatorInsuranceLogisticsRequirementsResponse logisticsRequirements = await Client.Elevator.LogisticsRequirementsAsync(insuranceRequestId);

            // Delivery Addresses
            ElevatorInsuranceDevlieryAddressesResponse deliveryAddresses = await Client.Elevator.DeliveryAddressesAsync(insuranceRequestId);

            var deliveryDateTimeRequest = new ElevatorInsuranceDeliveryDateTimeRequest
            {
                AddressId = deliveryAddresses.SelectedId
            };

            // Delivery Date/Time 
            ElevatorInsuranceDeliveryDateTimeResponse deliveryDateTimeResponse = await Client.Elevator.DeliveryDateTimeAsync(insuranceRequestId, deliveryDateTimeRequest);

            var setLogisticsRequirementsRequest = new ElevatorInsuranceSetLogisticsRequirementsRequest
            {
                UniqueId = deliveryDateTimeResponse.Deliveries.FirstOrDefault(x => !x.Disabled)?.Times.FirstOrDefault(t => !t.Disabled)?.UniqueId,
                Description = "جهت تست نرم افزار",
                Email = "",
                ReceiverFullName = "تست تست پور",
                ReceiverMobileNumber = "09309959493"
            };

            // Set Logistics Requirements
            ElevatorInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.Elevator.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


            // Validate
            var validationResult = await Client.Elevator.ValidationAsync(insuranceRequestId);

            // Get Gateway Options
            ElevatorInsuranceGetGatewayOptionsResponse paymentGatewayOptions = await Client.Elevator.GetPaymentGatewayOptionsAsync(insuranceRequestId);


            // Redirect to Payment Gateway
            var redirectToGatewayRequest = new ElevatorInsuranceRedirectToGatewayRequest
            {
                GatewayId = paymentGatewayOptions.Gateways.FirstOrDefault()?.Id,
                FaildReturnURL = $"https://bimeh.com/ins/paymentfailed?id={(object)insuranceRequestId}",
                SuccessReturnURL = $"https://bimeh.com/ins/paymentconfirm?id={(object)insuranceRequestId}"
            };

            ElevatorInsuranceRedirectToGatewayResponse redirectToGatewayResponse = await Client.Elevator.RedirectToPaymentGatewayAsync(insuranceRequestId, redirectToGatewayRequest);

        }

    }
}
