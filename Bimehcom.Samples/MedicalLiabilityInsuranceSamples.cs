using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.MedicalLiability.Requests;
using Bimehcom.Core.Models.SubClients.MedicalLiability.Responses;

internal class MedicalLiabilityInsuranceSamples
{
    private IBimehcomClient Client;

    public MedicalLiabilityInsuranceSamples(IBimehcomClient client)
    {
        Client = client;
    }

    public async Task RunAsync()
    {

        // Basic Data
        MedicalLiabilityInsuranceBasicDataResponse basicData = await Client.MedicalLiability.GetBasicDataAsync();

        // Inquiry

        var inquiryRequest = new MedicalLiabilityInsuranceInquiryRequest
        {
            HasMedicalSystemCode = true,
            IsResident = true,
            IsStudent = true,
            MedicalExpertiseId = 214,
            MedicalTypeId = 0,
            NoDamageDiscountId = 10
        };


        MedicalLiabilityInsuranceInquiryResponse inquiryResponse = await Client.MedicalLiability.InquiryAsync(inquiryRequest);


        // Create
        var createRequest = new MedicalLiabilityInsuranceCreateRequest
        {
            UniqueId = inquiryResponse.Inquiries.FirstOrDefault()?.UniqueId
        };

        MedicalLiabilityInsuranceCreateResponse createResponse = await Client.MedicalLiability.CreateAsync(createRequest);

        var insuranceRequestId = createResponse.InsuranceRequestId;

        // Get Info
        MedicalLiabilityInsuranceInfoResponse getInfoResponse = await Client.MedicalLiability.GetInfoAsync(insuranceRequestId);


        // Set Info
        var userAddresses = await Client.User.GetAddressesAsync();
        var setInfoRequest = new MedicalLiabilityInsuranceSetInfoRequest
        {
            AddressId = userAddresses.Addresses.FirstOrDefault().Id,
            BirthDate = DateTime.Parse("1998/3/20"),
            FirstName = "تست",
            LastName = "تست پور",
            MobileNumber = "09309959493",
            NationalCode = "0021191808",
            Phone = "09309959493",
            TypeId = 0,
            
            GradeId = 2,
            HasOffice = true,
            InjectionLicensed = true,
            MedicalCenterAddress = "tehran",
            MedicalCenterPhone = "09309959493",
            MinorSurgeriesLicensed = true,
            UniversityName = "tehran",
        };

        MedicalLiabilityInsuranceSetInfoResponse setInfoResponse = await Client.MedicalLiability.SetInfoAsync(insuranceRequestId, setInfoRequest);

        // Required File
        MedicalLiabilityInsuranceRequiredFileResponse requiredFileResponse = await Client.MedicalLiability.RequiredFileAsync(insuranceRequestId);

        var filePath = Path.Combine(AppContext.BaseDirectory, "Files", "bimehdotcom_logo.jfif");

        foreach (var requiredFile in requiredFileResponse.RequiredFiles)
        {
            using var stream = File.OpenRead(filePath);

            MedicalLiabilityInsuranceUploadRequiredFileResponse uploadFileResponse = await Client.MedicalLiability.UploadRequiredFileAsync(insuranceRequestId, stream, "test", requiredFile.FileName);
        }

        // Logistics Requirements
        MedicalLiabilityInsuranceLogisticsRequirementsResponse logisticsRequirements = await Client.MedicalLiability.LogisticsRequirementsAsync(insuranceRequestId);

        // Delivery Addresses
        MedicalLiabilityInsuranceDeliveryAddressesResponse deliveryAddresses = await Client.MedicalLiability.DeliveryAddressesAsync(insuranceRequestId);

        var deliveryDateTimeRequest = new MedicalLiabilityInsuranceDeliveryDateTimeRequest
        {
            AddressId = deliveryAddresses.SelectedId
        };

        // Delivery Date/Time 
        MedicalLiabilityInsuranceDeliveryDateTimeResponse deliveryDateTimeResponse = await Client.MedicalLiability.DeliveryDateTimeAsync(insuranceRequestId, deliveryDateTimeRequest);

        var setLogisticsRequirementsRequest = new MedicalLiabilityInsuranceSetLogisticsRequirementsRequest
        {
            UniqueId = deliveryDateTimeResponse.Deliveries.FirstOrDefault(x => !x.Disabled)?.Times.FirstOrDefault(t => !t.Disabled)?.UniqueId,
            Description = "جهت تست نرم افزار",
            Email = "",
            ReceiverFullName = "تست تست پور",
            ReceiverMobileNumber = "09309959493"
        };

        // Set Logistics Requirements
        MedicalLiabilityInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.MedicalLiability.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


        // Validate
        var validationResult = await Client.MedicalLiability.ValidationAsync(insuranceRequestId);

    }
}