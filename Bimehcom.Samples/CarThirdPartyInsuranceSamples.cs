using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.Base.Vehicle.Requests;
using Bimehcom.Core.Models.SubClients.Base.Vehicle.Responses;
using Bimehcom.Core.Models.SubClients.CarThirdParty.Requests;
using Bimehcom.Core.Models.SubClients.CarThirdParty.Responses;
namespace Bimehcom.Samples
{
    internal class CarThirdPartyInsuranceSamples
    {
        public IBimehcomClient Client { get; }
        public CarThirdPartyInsuranceSamples(IBimehcomClient client)
        {
            Client = client;
        }


        public async Task RunAsync()
        {
        
            // Basic Data
            CarThirdPartyInsuranceBasicDataResponse basicData = await Client.CarThirdParty.GetBasicDataAsync();

            // Plque Inquiry
            var plaqueInquiryRequest = new VehicleClientPlaqueInquiryRequest
            {
                RightSide = 123,
                LetterId = 4,
                LeftSide = 56,
                IranCode = 78,
                NationalCode = "1234567890",
            };
            VehicleClientPlaqueInquiryResponse plaqueInquiryResponse = await Client.CarThirdParty.PlaqueInquiry(plaqueInquiryRequest);


            // Car Models
            VehicleClientCarModelsResponse carModels = await Client.CarThirdParty.GetCarModelsByCategoryAndBrand(1001, 1);

            // Inquiry

            var inquiryRequest = new CarThirdPartyInsuranceInquiryRequest
            {
                ModelId = 1001,
                PreviousInsuranceStatusId = 0,
                ProductionYearId = 2025,
                ReleaseDate = DateTime.Parse("2025/11/30"),
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
                BirthDate = DateTime.Parse("1998/3/20"),
                FirstName = "تست",
                LastName = "تست پور",
                MobileNumber = "09309959493",
                NationalCode = "0021191808",
                PolicyOwnerIsCarOwner = true,
                Phone = "09309959493",
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
            CarThirdPartyInsuranceDevlieryAddressesResponse deliveryAddresses = await Client.CarThirdParty.DeliveryAddressesAsync(insuranceRequestId);

            var deliveryDateTimeRequest = new CarThirdPartyInsuranceDeliveryDateTimeRequest
            {
                AddressId = deliveryAddresses.SelectedId
            };

            // Delivery Date/Time 
            CarThirdPartyInsuranceDeliveryDateTimeResponse deliveryDateTimeResponse = await Client.CarThirdParty.DeliveryDateTimeAsync(insuranceRequestId, deliveryDateTimeRequest);

            var setLogisticsRequirementsRequest = new CarThirdPartyInsuranceSetLogisticsRequirementsRequest
            {
                UniqueId = deliveryDateTimeResponse.Deliveries.FirstOrDefault(x => !x.Disabled)?.Times.FirstOrDefault(t => !t.Disabled)?.UniqueId,
                Description = "جهت تست نرم افزار",
                Email = "",
                ReceiverFullName = "تست تست پور",
                ReceiverMobileNumber = "09309959493"
            };

            // Set Logistics Requirements
            CarThirdPartyInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.CarThirdParty.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


            // Validate
            var validationResult = await Client.CarThirdParty.ValidationAsync(insuranceRequestId);

        }
    }
}
