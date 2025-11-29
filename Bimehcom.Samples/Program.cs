using Bimehcom.Client;
using Bimehcom.Core;
using Bimehcom.Core.Models.SubClients.Auth.Requests;
using Bimehcom.Core.Models.SubClients.Fire.Requests;
using Bimehcom.Core.Models.SubClients.Fire.Responses;
using Bimehcom.Core.Models.SubClients.User.Responses;

IBimehcomClient client = new BimehcomClientBuilder((opt) =>
{
    opt.ApiKey = "da4aa2f8-70d9-4d56-b577-3162dfae2c0f";
    opt.BaseApiUrl = new Uri("https://coreapi.bimeh.com");
    opt.ApiVersion = "v1";
}).Build();

#region Authentication
var localLoginRequest = new AuthLocalLoginRequest
{
    Username = "09309959493",
    Password = "ash@1234"
};
var loginResponse = await client.Auth.LocalLoginAsync(localLoginRequest);

#endregion

#region User
GetUserAddressesResponse addresses = await client.User.GetAddressesAsync();

GetUserPolicyOwnersResponse policyOwners = await client.User.GetPolicyOwnersAsync();
#endregion

#region Fire Insurance
//Basic Data

FireInsuranceBasicDataResponse basicDataResponse = await client.Fire.GetBasicDataAsync();


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
FireInsuranceInquiryResponse inquiryResponse = await client.Fire.InquiryAsync(inquiryRequest);

// Create
var createRequest = new FireInsuranceCreateRequest
{
    UniqueId = inquiryResponse.Inquiries.FirstOrDefault()?.UniqueId
};

FireInsuranceCreateResponse createResponse = await client.Fire.CreateAsync(createRequest);

var insuranceRequestId = createResponse.InsuranceRequestId;

// Get Info
FireInsuranceInfoResponse getInfoResponse = await client.Fire.GetInfoAsync(insuranceRequestId);


// Set Info
var setInfoRequest = new FireInsuranceSetInfoRequest
{
    AddressId = 1725179,
    BirthDate = "1998/3/20",
    ConstructingDate = 1404,
    FirstName = "John",
    LastName = "Doe",
    FloorCount = 1,
    MobileNumber = "09309959493",
    NationalCode = "0021191808",
    OwnershipTypeId = 1,
    TypeId = 0
};

FireInsuranceSetInfoResponse setInfoResponse = await client.Fire.SetInfoAsync(insuranceRequestId, setInfoRequest);


FireInsuranceRequiredFileResponse requiredFileResponse = await client.Fire.RequiredFileAsync(insuranceRequestId);


FireInsuranceLogisticsRequirementsResponse logisticsRequirements = await client.Fire.LogisticsRequirementsAsync(insuranceRequestId);


FireInsuranceDevlieryAddressesResponse deliveryAddresses = await client.Fire.DeliveryAddressesAsync(insuranceRequestId);

var deliveryDateTimeRequest = new FireInsuranceDeliveryDateTimeRequest
{
    AddressId = deliveryAddresses.SelectedId
};

FireInsuranceDeliveryDateTimeResponse deliveryDateTimeResponse = await client.Fire.DeliveryDateTimeAsync(insuranceRequestId, deliveryDateTimeRequest);

var setLogisticsRequirementsRequest = new FireInsuranceSetLogisticsRequirementsRequest
{
    UniqueId = deliveryDateTimeResponse.Deliveries.FirstOrDefault()?.Times.FirstOrDefault()?.UniqueId,
    Description = "",
    Email = "",
    ReceiverFullName = "John Doe",
    ReceiverMobileNumber = "09309959493"
};
FireInsuranceSetLogisticsRequirementsResponse setLogisticsRequirementsResponse = await client.Fire.SetLogisticsRequirementsAsync(insuranceRequestId, setLogisticsRequirementsRequest);


var validationResult = await client.Fire.ValidationAsync(insuranceRequestId);

FireInsuranceGetGatewayOptionsResponse paymentGatewayOptions = await client.Fire.GetPaymentGatewayOptionsAsync(insuranceRequestId);

var redirectToGatewayRequest = new FireInsuranceRedirectToGatewayRequest
{
    GatewayId = paymentGatewayOptions.Gateways.FirstOrDefault()?.Id,
    FaildReturnURL = $"https://bimeh.com/ins/paymentfailed?id={(object)insuranceRequestId}",
    SuccessReturnURL = $"https://bimeh.com/ins/paymentconfirm?id={(object)insuranceRequestId}"
};

FireInsuranceRedirectToGatewayResponse redirectToGatewayResponse = await client.Fire.RedirectToGatewayAsync(insuranceRequestId, redirectToGatewayRequest);

#endregion

Console.WriteLine();