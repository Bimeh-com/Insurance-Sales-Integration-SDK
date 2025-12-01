namespace Bimehcom.Client.Extensions
{
    internal static class ApiRoutes
    {
        // Auth
        internal static string LocalLogin() => $"authentication/local-login";

        // User
        internal static string GetUserAddresses() => $"user/address";
        internal static string GetUserPolicyOwners() => $"user/policy-owner";

        // Vehicle Insurance
        internal static string CarModels(string subClientName, int brandId, int categoryId) => $"insurance/{subClientName}/car-model/{brandId}/{categoryId}";

        // General Insurance Sales Workflow
        internal static string BasicData(string subClientName) => $"insurance/{subClientName}/basic-data";
        internal static string Inquiry(string subClientName) => $"insurance/{subClientName}/inquiry";
        internal static string GetInstallments() => $"payment/installment";
        internal static string Create(string subClientName) => $"insurance/{subClientName}/create";
        internal static string GetInfo(dynamic insuranceRequestId) => $"insurance/{insuranceRequestId}/info";
        internal static string SetInfo(string subClientName, dynamic insuranceRequestId) => $"insurance/{subClientName}/{insuranceRequestId}/info";
        internal static string RequiredFile(dynamic insuranceRequestId) => $"insurance/{insuranceRequestId}/required-file";
        internal static string LogisticsRequirements(dynamic insuranceRequestId) => $"insurance/{insuranceRequestId}/logistics-requirement";
        internal static string DeliveryAddresses(dynamic insuranceRequestId) => $"insurance/{insuranceRequestId}/delivery-address";
        internal static string DeliveryDateTime(dynamic insuranceRequestId) => $"insurance/{insuranceRequestId}/delivery-date-time";
        internal static string Validation(dynamic insuranceRequestId) => $"insurance/{insuranceRequestId}/validation";
        internal static string GetPaymentOptions(dynamic insuranceRequestId) => $"payment/gateway/{insuranceRequestId}";
        internal static string RedirectToGateway(dynamic insuranceRequestId) => $"payment/redirect-to-payment/{insuranceRequestId}";
    }
}