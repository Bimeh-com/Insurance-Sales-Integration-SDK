using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.MedicalLiability.Requests;
using Bimehcom.Core.Models.SubClients.MedicalLiability.Responses;
using Bimehcom.Samples.SampleData;
using System.Text.Json;

public class MedicalLiabilityInsuranceSamples
{
    private IBimehcomClient Client;

    public MedicalLiabilityInsuranceSamples(IBimehcomClient client)
    {
        Client = client;
    }

    public async Task<bool> RunAsync()
    {
        var sampleUser = JsonSerializer.Deserialize<SampleUserData>(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "SampleData", "sample-user.json")));

        // Basic Data
        MedicalLiabilityInsuranceBasicDataResponse basicData = await Client.MedicalLiability.GetBasicDataAsync();

        // Inquiry

        var inquiryRequest = new MedicalLiabilityInsuranceInquiryRequest
        {
            HasMedicalSystemCode = true,
            IsResident = true,
            IsStudent = true,
            MedicalExpertiseId = basicData.MedicalExpertises.FirstOrDefault()?.Id,
            MedicalTypeId = basicData.MedicalTypes.FirstOrDefault()?.Id,
            NoDamageDiscountId = basicData.NoDamageDiscounts.FirstOrDefault()?.Id,
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
            BirthDate = DateTime.Parse(sampleUser.BirthDate),
            FirstName = sampleUser.FirstName,
            LastName = sampleUser.LastName,
            MobileNumber = sampleUser.Phone,
            NationalCode = sampleUser.NationalCode,
            Phone = sampleUser.Phone,
            TypeId = 0,
            
            GradeId = 2,
            HasOffice = true,
            InjectionLicensed = true,
            MedicalCenterAddress = "Tehran",
            MedicalCenterPhone = "09120000000",
            MinorSurgeriesLicensed = true,
            UniversityName = "Tehran",
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
            UniqueId = deliveryDateTimeResponse.Deliveries.Where(x => x.Disabled == false && x.Times.Any(x => !x.Disabled)).FirstOrDefault()?.Times.Where(t => t.Disabled == false).FirstOrDefault()?.UniqueId,
            Description = "جهت تست نرم افزار",
            Email = sampleUser.Email,
            ReceiverFullName = string.Join(" ", [sampleUser.FirstName, sampleUser.LastName]),
            ReceiverMobileNumber = sampleUser.Phone
        };

        // Set Logistics Requirements
        MedicalLiabilityInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await Client.MedicalLiability.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


        // Validate
        var validationResult = await Client.MedicalLiability.ValidationAsync(insuranceRequestId);
        return validationResult;
    }
}