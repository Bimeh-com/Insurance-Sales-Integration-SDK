using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.Base.Vehicle.Requests;
using Bimehcom.Core.Models.SubClients.Base.Vehicle.Responses;
using Bimehcom.Core.Models.SubClients.CarBody.Requests;
using Bimehcom.Core.Models.SubClients.CarBody.Responses;
namespace Bimehcom.Samples
{
    internal class CarBodyInsuranceSamples
    {
        public IBimehcomClient Client { get; }
        public CarBodyInsuranceSamples(IBimehcomClient client)
        {
            Client = client;
        }


        public async Task RunAsync()
        {

            // Basic Data
            CarBodyInsuranceBasicDataResponse basicData = await Client.CarBody.GetBasicDataAsync();

            // Plque Inquiry
            var plaqueInquiryRequest = new VehicleClientPlaqueInquiryRequest
            {
                LeftSide = 56,
                LetterId = 4,
                RightSide = 123,
                IranCode = 78,
                NationalCode = "1234567890",
            };
            VehicleClientPlaqueInquiryResponse plaqueInquiryResponse = await Client.CarBody.PlaqueInquiry(plaqueInquiryRequest);


            // Car Models
            VehicleClientCarModelsResponse carModels = await Client.CarBody.GetCarModelsByCategoryAndBrand(1001, 1);

            // Inquiry

            var inquiryRequest = new CarBodyInsuranceInquiryRequest
            {
                CarBodyNoDamageYearId = null,
                Imported = false,
                ModelId = 1001,
                Price = 12000000000,
                ProductionDate = DateTime.Parse("2021/03/21"),
                ThirdPartyCompanyId = 1026,
                ThirdPartyDiscountId = 0,
                UsingTypeId = 1,
            };


            CarBodyInsuranceInquiryResponse inquiryResponse = await Client.CarBody.InquiryAsync(inquiryRequest);

            // Installments

            var getInstallmentsRequest = new CarBodyInsuranceGetInstallmentsRequest
            {
                UniqueId = inquiryResponse.Inquiries.FirstOrDefault(x => x.HasInstallments == true)?.UniqueId
            };

            CarBodyInsuranceGetInstallmentsResponse installmentsResponse = await Client.CarBody.GetInstallmentsAsync(getInstallmentsRequest);

            // Create
            var createRequest = new CarBodyInsuranceCreateRequest
            {
                UniqueId = inquiryResponse.Inquiries.FirstOrDefault()?.UniqueId
            };

            var createRequestWithInstallment = new CarBodyInsuranceCreateRequest
            {
                UniqueId = installmentsResponse.Installments.FirstOrDefault()?.UniqueId
            };

            CarBodyInsuranceCreateResponse createResponse = await Client.CarBody.CreateAsync(createRequest);

            var insuranceRequestId = createResponse.InsuranceRequestId;

            // Get Info
            CarBodyInsuranceInfoResponse getInfoResponse = await Client.CarBody.GetInfoAsync(insuranceRequestId);


            // Set Info
            var userAddresses = await Client.User.GetAddressesAsync();
            var setInfoRequest = new CarBodyInsuranceSetInfoRequest
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

            CarBodyInsuranceSetInfoResponse setInfoResponse = await Client.CarBody.SetInfoAsync(insuranceRequestId, setInfoRequest);

            // Required File
            CarBodyInsuranceRequiredFileResponse requiredFileResponse = await Client.CarBody.RequiredFileAsync(insuranceRequestId);

            var filePath = Path.Combine(AppContext.BaseDirectory, "Files", "bimehdotcom_logo.jfif");

            foreach (var requiredFile in requiredFileResponse.RequiredFiles)
            {
                using var stream = File.OpenRead(filePath);

                CarBodyInsuranceUploadRequiredFileResponse uploadFileResponse = await Client.CarBody.UploadRequiredFileAsync(insuranceRequestId, stream, "test", requiredFile.FileName);
            }

            // Logistics Requirements
            CarBodyInsuranceLogisticsRequirementsResponse logisticsRequirements = await Client.CarBody.LogisticsRequirementsAsync(insuranceRequestId);

            // Delivery Addresses
            CarBodyInsuranceDevlieryAddressesResponse deliveryAddresses = await Client.CarBody.DeliveryAddressesAsync(insuranceRequestId);

            var deliveryDateTimeRequest = new CarBodyInsuranceDeliveryDateTimeRequest
            {
                AddressId = deliveryAddresses.SelectedId
            };

            // Delivery Date/Time 
            CarBodyInsuranceDeliveryDateTimeResponse deliveryDateTimeResponse = await Client.CarBody.DeliveryDateTimeAsync(insuranceRequestId, deliveryDateTimeRequest);

            var setLogisticsRequirementsRequest = new CarBodyInsuranceSetLogisticsRequirementsRequest
            {
                UniqueId = deliveryDateTimeResponse.Deliveries.FirstOrDefault(x => !x.Disabled)?.Times.FirstOrDefault(t => !t.Disabled)?.UniqueId,
                Description = "جهت تست نرم افزار",
                Email = "",
                ReceiverFullName = "تست تست پور",
                ReceiverMobileNumber = "09309959493"
            };

            // Set Logistics Requirements
            CarBodyInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.CarBody.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


            // Validate
            var validationResult = await Client.CarBody.ValidationAsync(insuranceRequestId);

        }
    }
}
