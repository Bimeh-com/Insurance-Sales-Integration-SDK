using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.Base.Vehicle.Requests;
using Bimehcom.Core.Models.SubClients.Base.Vehicle.Responses;
using Bimehcom.Core.Models.SubClients.CarBody.Requests;
using Bimehcom.Core.Models.SubClients.CarBody.Responses;
using Bimehcom.Samples.SampleData;
using System.Text.Json;
namespace Bimehcom.Samples
{
    public class CarBodyInsuranceSamples
    {
        public IBimehcomClient Client { get; }
        public CarBodyInsuranceSamples(IBimehcomClient client)
        {
            Client = client;
        }


        public async Task<bool> RunAsync()
        {
            var sampleUser = JsonSerializer.Deserialize<SampleUserData>(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "SampleData", "sample-user.json")));
            // Basic Data
            CarBodyInsuranceBasicDataResponse basicData = await Client.CarBody.GetBasicDataAsync();

            // Plque Inquiry
            var plaqueInquiryRequest = new VehicleClientPlaqueInquiryRequest
            {
                LeftSide = sampleUser.PlaqueLeftSide,
                LetterId = sampleUser.PlaqueLetterId,
                RightSide = sampleUser.PlaqueRightSide,
                IranCode = sampleUser.PlaqueIranCode,
                NationalCode = sampleUser.PlaqueNationalCode,
            };
            //VehicleClientPlaqueInquiryResponse plaqueInquiryResponse = await Client.CarBody.PlaqueInquiry(plaqueInquiryRequest);


            // Car Models
            VehicleClientCarModelsResponse carModels = await Client.CarBody.GetCarModelsByCategoryAndBrand(1001, 1);

            // Inquiry

            var inquiryRequest = new CarBodyInsuranceInquiryRequest
            {
                CarBodyNoDamageYearId = null,
                Imported = false,
                ModelId = carModels.Models.FirstOrDefault()?.Id,
                Price = 12000000000,
                ProductionDate = DateTime.Parse("2025/1/1"),
                ThirdPartyCompanyId = basicData.Companies.FirstOrDefault()?.Id,
                ThirdPartyDiscountId = basicData.ThirdPartyDiscounts.FirstOrDefault()?.Id,
                UsingTypeId = basicData.UsingTypes.FirstOrDefault()?.Id,
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
                BirthDate = DateTime.Parse(sampleUser.BirthDate),
                FirstName = sampleUser.FirstName,
                LastName = sampleUser.LastName,
                MobileNumber = sampleUser.Phone,
                NationalCode = sampleUser.NationalCode,
                Phone = sampleUser.Phone,
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
            CarBodyInsuranceDeliveryAddressesResponse deliveryAddresses = await Client.CarBody.DeliveryAddressesAsync(insuranceRequestId);

            // First Visit Method
            //// Visit Information
            //CarBodyInsuranceVisitAddressesResponse visitAddresses = await Client.CarBody.VisitAddressesAsync(insuranceRequestId);

            //var visitDateTimeRequest = new CarBodyInsuranceVisitDateTimeRequest
            //{
            //    AddressId = userAddresses.Addresses.FirstOrDefault().Id,
            //};

            //CarBodyInsuranceVisitDateTimeResponse visitDateTimeResponse = await Client.CarBody.VisitDateTimeAsync(insuranceRequestId, visitDateTimeRequest);



            //// Delivery Date/Time 
            //var deliveryDateTimeRequest = new CarBodyInsuranceDeliveryDateTimeRequest
            //{
            //    AddressId = userAddresses.Addresses.FirstOrDefault().Id,
            //    VisitUniqueId = visitDateTimeResponse.Visits.Where(x => x.Disabled == false && x.Times.Any(x => !x.Disabled)).FirstOrDefault()?.Times.Where(t => t.Disabled == false).FirstOrDefault()?.UniqueId

            //};

            // Second Visit Method
            // Visit Center Province
            CarBodyInsuranceVisitCenterProvinceResponse visitCenterProvinces = await Client.CarBody.VisitCenterProvincesAsync(insuranceRequestId);

            CarBodyInsuranceVisitCenterProvinceCitiesResponse visitCenterProvinceCities = await Client.CarBody.VisitCenterProvinceCitiesAsync(visitCenterProvinces.Provinces.FirstOrDefault().Id);
            // Visit Center Date/Time
            CarBodyInsuranceVisitCenterDateTimeRequest visitCenterDateTimeRequest = new CarBodyInsuranceVisitCenterDateTimeRequest
            {
                CityId = visitCenterProvinceCities.Cities.FirstOrDefault().Id
            };

            CarBodyInsuranceVisitCenterDateTimeResponse visitCenterDateTime = await Client.CarBody.VisitCenterDateTimeAsync(insuranceRequestId, visitCenterDateTimeRequest);

            // Delivery Date/Time 
            var deliveryDateTimeRequest = new CarBodyInsuranceDeliveryDateTimeRequest
            {
                AddressId = userAddresses.Addresses.FirstOrDefault().Id,
                VisitUniqueId = visitCenterDateTime.VisitCenters.FirstOrDefault().Dates.FirstOrDefault(x => !x.Disabled && x.Times.Any(x => !x.Disabled))?.Times.FirstOrDefault(t => !t.Disabled)?.UniqueId
            };

            // Third Visit Method
            // Delivery Date/Time 
            //var deliveryDateTimeRequest = new CarBodyInsuranceDeliveryDateTimeRequest
            //{
            //    AddressId = userAddresses.Addresses.FirstOrDefault().Id,
            //    VisitUniqueId = logisticsRequirements.Visit.Methods.LastOrDefault()?.UniqueId
            //};

            CarBodyInsuranceDeliveryDateTimeResponse deliveryDateTimeResponse = await Client.CarBody.DeliveryDateTimeAsync(insuranceRequestId, deliveryDateTimeRequest);

            var setLogisticsRequirementsRequest = new CarBodyInsuranceSetLogisticsRequirementsRequest
            {
                UniqueId = logisticsRequirements.Visit.Methods.LastOrDefault()?.UniqueId,
                Description = "جهت تست نرم افزار",
                Email = sampleUser.Email,
                ReceiverFullName = string.Join(" ", [sampleUser.FirstName, sampleUser.LastName]),
                ReceiverMobileNumber = sampleUser.Phone
            };

            // Set Logistics Requirements
            CarBodyInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.CarBody.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


            // Validate
            var validationResult = await Client.CarBody.ValidationAsync(insuranceRequestId);
            return validationResult;
        }
    }
}
