
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.Elevator.Requests;
using Bimehcom.Core.Models.SubClients.Elevator.Responses;
using Bimehcom.Samples.SampleData;
using System.Text.Json;

namespace Bimehcom.Samples
{
    public class ElevatorInsuranceSamples
    {
        private IBimehcomClient Client;

        public ElevatorInsuranceSamples(IBimehcomClient client)
        {
            Client = client;
        }

        public async Task<bool> RunAsync()
        {
            var sampleUser = JsonSerializer.Deserialize<SampleUserData>(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "SampleData", "sample-user.json")));
            // Basic Data
            ElevatorInsuranceBasicDataResponse basicData = await Client.Elevator.GetBasicDataAsync();

            // Inquiry

            var inquiryRequest = new ElevatorInsuranceInquiryRequest
            {
                ElevatorAge = basicData.ElevatorAge.FirstOrDefault()?.Id,
                ElevatorCapacity = basicData.ElevatorCapacity.FirstOrDefault()?.Id,
                ElevatorUsageId = basicData.ElevatorUsages.FirstOrDefault()?.Id,
                FloorsCount = basicData.FloorsCount.FirstOrDefault()?.Id,
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
                BirthDate = DateTime.Parse(sampleUser.BirthDate),
                FirstName = sampleUser.FirstName,
                LastName = sampleUser.LastName,
                MobileNumber = sampleUser.Phone,
                NationalCode = sampleUser.NationalCode,
                Phone = sampleUser.Phone,
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
            ElevatorInsuranceDeliveryAddressesResponse deliveryAddresses = await Client.Elevator.DeliveryAddressesAsync(insuranceRequestId);

            var deliveryDateTimeRequest = new ElevatorInsuranceDeliveryDateTimeRequest
            {
                AddressId = deliveryAddresses.SelectedId
            };

            // Delivery Date/Time 
            ElevatorInsuranceDeliveryDateTimeResponse deliveryDateTimeResponse = await Client.Elevator.DeliveryDateTimeAsync(insuranceRequestId, deliveryDateTimeRequest);

            var setLogisticsRequirementsRequest = new ElevatorInsuranceSetLogisticsRequirementsRequest
            {
                UniqueId = deliveryDateTimeResponse.Deliveries.FirstOrDefault(x => !x.Disabled && x.Times.Any(x => !x.Disabled))?.Times.FirstOrDefault(t => !t.Disabled)?.UniqueId,
                Description = "جهت تست نرم افزار",
                Email = sampleUser.Email,
                ReceiverFullName = string.Join(" ", new[] { sampleUser.FirstName, sampleUser.LastName }),
                ReceiverMobileNumber = sampleUser.Phone
            };

            // Set Logistics Requirements
            ElevatorInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.Elevator.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


            // Validate
            var validationResult = await Client.Elevator.ValidationAsync(insuranceRequestId);
            return validationResult;

        }

    }
}
