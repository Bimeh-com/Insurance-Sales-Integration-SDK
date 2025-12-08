using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.Fire.Requests;
using Bimehcom.Core.Models.SubClients.Fire.Responses;
using Bimehcom.Samples.SampleData;
using System.Text.Json;

namespace Bimehcom.Samples
{
    public class FireInsuranceSamples
    {
        public IBimehcomClient Client { get; }
        public FireInsuranceSamples(IBimehcomClient client)
        {
            this.Client = client;
        }


        public async Task<bool> RunAsync()
        {
            var sampleUser = JsonSerializer.Deserialize<SampleUserData>(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "SampleData", "sample-user.json")));

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
                BirthDate = DateTime.Parse(sampleUser.BirthDate),
                FirstName = sampleUser.FirstName,
                LastName = sampleUser.LastName,
                GenderId = 0,
                MobileNumber = sampleUser.Phone,
                NationalCode = sampleUser.NationalCode,
                ConstructingDate = 1404,
                FloorCount = 1,
                OwnershipTypeId = 1,
                TypeId = 0,
            };

            FireInsuranceSetInfoResponse setInfoResponse = await Client.Fire.SetInfoAsync(insuranceRequestId, setInfoRequest);

            // Required File

            FireInsuranceRequiredFileResponse requiredFileResponse = await Client.Fire.RequiredFileAsync(insuranceRequestId);

            // Logistics Requirements
            FireInsuranceLogisticsRequirementsResponse logisticsRequirements = await Client.Fire.LogisticsRequirementsAsync(insuranceRequestId);

            // Delivery Addresses
            FireInsuranceDeliveryAddressesResponse deliveryAddresses = await Client.Fire.DeliveryAddressesAsync(insuranceRequestId);

            var deliveryDateTimeRequest = new FireInsuranceDeliveryDateTimeRequest
            {
                AddressId = deliveryAddresses.SelectedId
            };

            // Delivery Date/Time 
            FireInsuranceDeliveryDateTimeResponse deliveryDateTimeResponse = await Client.Fire.DeliveryDateTimeAsync(insuranceRequestId, deliveryDateTimeRequest);

            var setLogisticsRequirementsRequest = new FireInsuranceSetLogisticsRequirementsRequest
            {
                UniqueId = deliveryDateTimeResponse.Deliveries.FirstOrDefault(x => !x.Disabled && x.Times.Any(x => !x.Disabled))?.Times.FirstOrDefault(t => !t.Disabled)?.UniqueId,
                Description = "جهت تست نرم افزار",
                Email = sampleUser.Email,
                ReceiverFullName = string.Join(" ", new[] { sampleUser.FirstName, sampleUser.LastName }),
                ReceiverMobileNumber = sampleUser.Phone
            };

            // Set Logistics Requirements
            FireInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.Fire.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


            // Validate
            var validationResult = await Client.Fire.ValidationAsync(insuranceRequestId);
            return validationResult;
        }
    }
}
