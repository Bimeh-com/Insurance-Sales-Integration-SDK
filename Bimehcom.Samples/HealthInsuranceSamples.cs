using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.Base.ExtraInsured;
using Bimehcom.Core.Models.SubClients.Health.Requests;
using Bimehcom.Core.Models.SubClients.Health.Responses;
namespace Bimehcom.Samples
{
    internal class HealthInsuranceSamples
    {
        public IBimehcomClient Client { get; }
        public HealthInsuranceSamples(IBimehcomClient client)
        {
            Client = client;
        }

        public async Task RunAsync()
        {
            //Basic Data

            HealthInsuranceBasicDataResponse basicDataResponse = await Client.Health.GetBasicDataAsync();


            // Inquiry
            var inquiryRequest = new HealthInsuranceInquiryRequest
            {
                BasicInsuranceId = 1,
                BirthDate = DateTime.Parse("1995/3/21"),
                FamilyMembers = new List<HealthInqueryItem>
                {
                    new HealthInqueryItem {
                    BirthDate = DateTime.Parse("2016/3/20"),
                    BasicInsuranceId = 1
                }
                }
            };
            HealthInsuranceInquiryResponse inquiryResponse = await Client.Health.InquiryAsync(inquiryRequest);

            // Create
            var createRequest = new HealthInsuranceCreateRequest
            {
                UniqueId = inquiryResponse.Inquiries.FirstOrDefault()?.UniqueId
            };

            HealthInsuranceCreateResponse createResponse = await Client.Health.CreateAsync(createRequest);

            var insuranceRequestId = createResponse.InsuranceRequestId;

            // Get Info
            HealthInsuranceInfoResponse getInfoResponse = await Client.Health.GetInfoAsync(insuranceRequestId);


            // Set Info
            var userAddresses = await Client.User.GetAddressesAsync();
            var setInfoRequest = new HealthInsuranceSetInfoRequest
            {
                AddressId = 1725179,
                DelayUploadImageIds = [],
                FatherName = "تسته پدر",
                FirstName = "تست",
                LastName = "تست پور",
                GenderId = 0,
                IdNumber = "0021191808",
                MobileNumber = "09309959493",
                NationalCode = "0021191808",
                TypeId = 0,
            };

            HealthInsuranceSetInfoResponse setInfoResponse = await Client.Health.SetInfoAsync(insuranceRequestId, setInfoRequest);


            // Extra Insured
            HealthInsuranceGetExtraInsuredResponse extraInsuredResponse = await Client.Health.GetExtraInsuredAsync(insuranceRequestId);

            var filePath = Path.Combine(AppContext.BaseDirectory, "Files", "bimehdotcom_logo.jfif");

            foreach (var extraInsured in extraInsuredResponse.ExtraInsureds)
            {
                foreach (var file in extraInsured.RequiredFiles)
                {
                    using var stream = File.OpenRead(filePath);

                    await Client.Health.UploadExtraInsuredRequiredFileAsync(insuranceRequestId, extraInsured.Id, stream, "test", file.FileName);
                }
            }


            var extraInsureds = new List<HealthPersonDetails>();

            foreach(var extraInsured in extraInsuredResponse.ExtraInsureds)
            {
                extraInsureds.Add(new HealthPersonDetails
                {
                    NationalCode = "0021191808",
                    RelationshipId = 5,
                    Id = extraInsured.Id
                });
            }

            var setExtraInsuredInfoRequest = new HealthInsuranceSetExtraInsuredInfoRequest
            {
                ExtraInsureds = extraInsureds,
            };

            HealthInsuranceSetExtraInsuredInfoResponse setExtraInsuredInfoResponse = await Client.Health.SetExtraInsuredInfoAsync(insuranceRequestId, setExtraInsuredInfoRequest);

            // Required File

            HealthInsuranceRequiredFileResponse requiredFileResponse = await Client.Health.RequiredFileAsync(insuranceRequestId);

            foreach (var requiredFile in requiredFileResponse.RequiredFiles)
            {
                using var stream = File.OpenRead(filePath);

                HealthInsuranceUploadRequiredFileResponse uploadFileResponse = await Client.Health.UploadRequiredFileAsync(insuranceRequestId, stream, "test", requiredFile.FileName);
            }

            // Logistics Requirements
            HealthInsuranceLogisticsRequirementsResponse logisticsRequirements = await Client.Health.LogisticsRequirementsAsync(insuranceRequestId);

            // Delivery Addresses
            HealthInsuranceDevlieryAddressesResponse deliveryAddresses = await Client.Health.DeliveryAddressesAsync(insuranceRequestId);

            var deliveryDateTimeRequest = new HealthInsuranceDeliveryDateTimeRequest
            {
                AddressId = deliveryAddresses.SelectedId
            };

            // Delivery Date/Time 
            HealthInsuranceDeliveryDateTimeResponse deliveryDateTimeResponse = await Client.Health.DeliveryDateTimeAsync(insuranceRequestId, deliveryDateTimeRequest);

            var setLogisticsRequirementsRequest = new HealthInsuranceSetLogisticsRequirementsRequest
            {
                UniqueId = deliveryDateTimeResponse.Deliveries.FirstOrDefault(x => !x.Disabled)?.Times.FirstOrDefault(t => !t.Disabled)?.UniqueId,
                Description = "جهت تست نرم افزار",
                Email = "",
                ReceiverFullName = "تست تست پور",
                ReceiverMobileNumber = "09309959493"
            };

            // Set Logistics Requirements
            HealthInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.Health.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


            // Validate
            var validationResult = await Client.Health.ValidationAsync(insuranceRequestId);
        }
    }
}
