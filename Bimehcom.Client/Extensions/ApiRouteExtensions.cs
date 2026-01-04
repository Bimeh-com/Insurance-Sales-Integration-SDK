using System;

namespace Bimehcom.Client.Extensions
{
    internal static class ApiRoutes
    {
        // Auth
        internal static string LocalLogin() => $"authentication/local-login";

        // User
        internal static string UserAddress() => $"user/address";
        internal static string DeleteUserAddress(long addressId) => $"user/address/{addressId}";
        internal static string GetUserAddressProvinces() => $"insurance/province";
        internal static string GetUserAddressProvinceCities(long provinceId) => $"insurance/province/{provinceId}/city";
        internal static string GetUserPolicyOwners() => $"user/policy-owner";
        internal static string AddUserPlaque() => $"user/plaque";
        internal static string GetUserPlaques() => $"user/plaque";
        internal static string GetContactUsInformation() => $"public/contact-us";
        internal static string SubmitContactUs() => $"public/contact-us";
        internal static string GetUserProfileInformations() => $"user/info";
        internal static string UpdateUserProfileInformations() => $"user/info";
        internal static string GetUserPurchases() => $"user/request";
        internal static string GetUserInstallments() => $"user/Installment-purchases";

        // Vehicle Insurance
        internal static string CarModels(string subClientName, int brandId, int categoryId) => $"insurance/{subClientName}/car-model/{brandId}/{categoryId}";
        internal static string PlaqueIInquiry() => $"public/plaque";

        // Electronic Equipment
        internal static string GetElectronicEquipmentBrands(long deviceId) => $"insurance/electronic-equipment/brand/{deviceId}";
        internal static string GetElectronicEquipmentModels(long brandId) => $"insurance/electronic-equipment/model/{brandId}";

        // General Insurance Sales Workflow
        internal static string BasicData(string subClientName) => $"insurance/{subClientName}/basic-data";
        internal static string Inquiry(string subClientName) => $"insurance/{subClientName}/inquiry";
        internal static string GetInstallments() => $"payment/installment";
        internal static string Create(string subClientName) => $"insurance/{subClientName}/create";
        internal static string GetInfo(dynamic insuranceRequestId) => $"insurance/{insuranceRequestId}/info";
        internal static string SetInfo(string subClientName, dynamic insuranceRequestId) => $"insurance/{subClientName}/{insuranceRequestId}/info";
        internal static string RequiredFile(dynamic insuranceRequestId) => $"insurance/{insuranceRequestId}/required-file";
        internal static string LogisticsRequirements(dynamic insuranceRequestId) => $"insurance/{insuranceRequestId}/logistics-requirement";
        internal static string VisitAddresses(dynamic insuranceRequestId) => $"insurance/{insuranceRequestId}/visit-address";
        internal static string VisitDateTime(dynamic insuranceRequestId) => $"insurance/{insuranceRequestId}/visit-date-time";
        internal static string VisitCenterProvinces() => $"insurance/visitcenter/province";
        internal static string VisitCenterProvinceCities(long provinceId) => $"insurance/visitcenter/province/{provinceId}/city";
        internal static string VisitCenterDateTime(dynamic insuranceRequestId) => $"insurance/{insuranceRequestId}/visitcenter-date-time";
        internal static string DeliveryAddresses(dynamic insuranceRequestId) => $"insurance/{insuranceRequestId}/delivery-address";
        internal static string DeliveryDateTime(dynamic insuranceRequestId) => $"insurance/{insuranceRequestId}/delivery-date-time";
        internal static string Validation(dynamic insuranceRequestId) => $"insurance/{insuranceRequestId}/validation";
        internal static string GetPaymentOptions(dynamic insuranceRequestId) => $"payment/gateway/{insuranceRequestId}";
        internal static string RedirectToGateway(dynamic insuranceRequestId) => $"payment/redirect-to-payment/{insuranceRequestId}";

        // Health Insurance Extra Workflows
        internal static string ExtraInsured(dynamic insuranceRequestId) => $"insurance/health/{insuranceRequestId}/extra-insured";
        internal static string ExtraInsuredRequiredFileUpload(dynamic insuranceRequestId,Guid extraInsuredId) => $"insurance/{insuranceRequestId}/extra-insured/{extraInsuredId}/required-file";


        internal static string GetEndorsementBasicData() => $"endorsement/basic-data";
        internal static string CreateEndorsement() => $"endorsement/create";
        internal static string GetEndorsementInformation(string endorsementId) => $"endorsement/{endorsementId}/info";
        internal static string UploadEndorsementFile(string endorsementId) => $"endorsement/{endorsementId}/upload-and-confirm";
        internal static string GetEndorsementPrintFile(string endorsementId) => $"endorsement/{endorsementId}/file";
        internal static string EndorsementValidation(string endorsementId) => $"endorsement/{endorsementId}/validation";


        internal static string SubmitInsuranceRequestPaymentInformationAsync(dynamic insuranceRequestId) => $"payment/accept/encrypted/{insuranceRequestId}";
        internal static string SubmitEndorsementPaymentInformationAsync(string endorsementId) => $"payment/accept/encrypted/endorsement/{endorsementId}";


    }
}