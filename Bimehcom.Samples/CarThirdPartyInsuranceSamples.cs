using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.Base.Vehicle.Requests;
using Bimehcom.Core.Models.SubClients.Base.Vehicle.Responses;
using Bimehcom.Core.Models.SubClients.CarThirdParty.Requests;
using Bimehcom.Core.Models.SubClients.CarThirdParty.Responses;
using Bimehcom.Samples.SampleData;
using System.Text.Json;
namespace Bimehcom.Samples
{
    public class CarThirdPartyInsuranceSamples
    {
        public IBimehcomClient Client { get; }
        public CarThirdPartyInsuranceSamples(IBimehcomClient client)
        {
            Client = client;
        }


        public async Task<bool> RunAsync()
        {
            var sampleUser = JsonSerializer.Deserialize<SampleUserData>(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "SampleData", "sample-user.json")));
        
            // Basic Data
            CarThirdPartyInsuranceBasicDataResponse basicData = await Client.CarThirdParty.GetBasicDataAsync();

            // Plque Inquiry
            var plaqueInquiryRequest = new VehicleClientPlaqueInquiryRequest
            {
                RightSide = sampleUser.PlaqueRightSide,
                LetterId = sampleUser.PlaqueLetterId,
                LeftSide = sampleUser.PlaqueLeftSide,
                IranCode = sampleUser.PlaqueIranCode,
                NationalCode = sampleUser.PlaqueNationalCode,
            };
            //VehicleClientPlaqueInquiryResponse plaqueInquiryResponse = await Client.CarThirdParty.PlaqueInquiry(plaqueInquiryRequest);


            // Car Models
            VehicleClientCarModelsResponse carModels = await Client.CarThirdParty.GetCarModelsByCategoryAndBrand(1001, 1);

            // Inquiry

            var inquiryRequest = new CarThirdPartyInsuranceInquiryRequest
            {
                ModelId = carModels.Models.FirstOrDefault()?.Id,
                PreviousInsuranceStatusId = 0,
                ProductionYearId = 2025,
                ReleaseDate = DateTime.Parse("2025/1/1"),
                UsingTypeId = 1,
            };

            CarThirdPartyInsuranceInquiryResponse inquiryResponse = await Client.CarThirdParty.InquiryAsync(inquiryRequest);

            // Installments

            var getInstallmentsRequest = new CarThirdPartyInsuranceGetInstallmentsRequest
            {
                UniqueId = inquiryResponse.Inquiries.FirstOrDefault(x => x.HasInstallments == true)?.UniqueId
            };

            CarThirdPartyInsuranceGetInstallmentsResponse installmentsResponse = await Client.CarThirdParty.GetInstallmentsAsync(getInstallmentsRequest);

            // Create
            var createRequest = new CarThirdPartyInsuranceCreateRequest
            {
                UniqueId = inquiryResponse.Inquiries.FirstOrDefault()?.UniqueId
            };

            var createRequestWithInstallment = new CarThirdPartyInsuranceCreateRequest
            {
                UniqueId = installmentsResponse.Installments.FirstOrDefault()?.UniqueId
            };

            CarThirdPartyInsuranceCreateResponse createResponse = await Client.CarThirdParty.CreateAsync(createRequest);

            var insuranceRequestId = createResponse.InsuranceRequestId;

            // Get Info
            CarThirdPartyInsuranceInfoResponse getInfoResponse = await Client.CarThirdParty.GetInfoAsync(insuranceRequestId);


            // Set Info
            var userAddresses = await Client.User.GetAddressesAsync();
            var setInfoRequest = new CarThirdPartyInsuranceSetInfoRequest
            {
                AddressId = userAddresses.Addresses.FirstOrDefault().Id,
                BirthDate = DateTime.Parse(sampleUser.BirthDate),
                FirstName = sampleUser.FirstName,
                LastName = sampleUser.LastName,
                MobileNumber = sampleUser.Phone,
                NationalCode = sampleUser.NationalCode,
                PolicyOwnerIsCarOwner = true,
                Phone = sampleUser.Phone,
                TypeId = 0,

            };

            CarThirdPartyInsuranceSetInfoResponse setInfoResponse = await Client.CarThirdParty.SetInfoAsync(insuranceRequestId, setInfoRequest);

            // Required File
            CarThirdPartyInsuranceRequiredFileResponse requiredFileResponse = await Client.CarThirdParty.RequiredFileAsync(insuranceRequestId);

            var filePath = Path.Combine(AppContext.BaseDirectory, "Files", "bimehdotcom_logo.jfif");

            foreach (var requiredFile in requiredFileResponse.RequiredFiles)
            {

                using var stream = File.OpenRead(filePath);


                CarThirdPartyInsuranceUploadRequiredFileResponse uploadFileResponse = await Client.CarThirdParty.UploadRequiredFileAsync(insuranceRequestId, stream, "test", requiredFile.FileName);
            }

            // Logistics Requirements
            CarThirdPartyInsuranceLogisticsRequirementsResponse logisticsRequirements = await Client.CarThirdParty.LogisticsRequirementsAsync(insuranceRequestId);

            // Delivery Addresses
            CarThirdPartyInsuranceDeliveryAddressesResponse deliveryAddresses = await Client.CarThirdParty.DeliveryAddressesAsync(insuranceRequestId);

            var deliveryDateTimeRequest = new CarThirdPartyInsuranceDeliveryDateTimeRequest
            {
                AddressId = deliveryAddresses.SelectedId
            };

            // Delivery Date/Time 
            CarThirdPartyInsuranceDeliveryDateTimeResponse deliveryDateTimeResponse = await Client.CarThirdParty.DeliveryDateTimeAsync(insuranceRequestId, deliveryDateTimeRequest);

            var setLogisticsRequirementsRequest = new CarThirdPartyInsuranceSetLogisticsRequirementsRequest
            {
                UniqueId = deliveryDateTimeResponse.Deliveries.FirstOrDefault(x => !x.Disabled && x.Times.Any(x => !x.Disabled))?.Times.FirstOrDefault(t => !t.Disabled)?.UniqueId,
                Description = "جهت تست نرم افزار",
                Email = sampleUser.Email,
                ReceiverFullName = string.Join(" ", new[] { sampleUser.FirstName, sampleUser.LastName }),
                ReceiverMobileNumber = sampleUser.Phone
            };

            // Set Logistics Requirements
            CarThirdPartyInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.CarThirdParty.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


            // Validate
            var validationResult = await Client.CarThirdParty.ValidationAsync(insuranceRequestId);
            return validationResult;
        }
    }
}
