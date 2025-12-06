using Bimehcom.Client;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.Auth.Requests;
using Bimehcom.Samples;

IBimehcomClient client = new BimehcomClientBuilder((opt) =>
{
    opt.ApiKey = "da4aa2f8-70d9-4d56-b577-3162dfae2c0f";
}).Build();

#region Authentication
var localLoginRequest = new AuthLocalLoginRequest
{
    Username = "09309959493",
    Password = "C26wZPZN7wLDkrz"
};
var loginResponse = await client.Auth.LocalLoginAsync(localLoginRequest);
#endregion


// User Client
//await new UserClientSamples(client).RunAsync();

// Fire Insurance
//await new FireInsuranceSamples(client).RunAsync();

// Third Party Insurance
//await new ThirdPartyInsuranceSamples(client).RunAsync();

// Car Body Insurance
//await new CarBodyInsuranceSamples(client).RunAsync();

// Motorcycle Third Party Insurance
//await new MotorcycleThirdPartyInsuranceSamples(client).RunAsync();

// Health Insurance
//await new HealthInsuranceSamples(client).RunAsync();

// Medical Liability Insurance
//await new MedicalLiabilityInsuranceSamples(client).RunAsync();

// Elevator Insurance
//await new ElevatorInsuranceSamples(client).RunAsync();

// Personal Accident Insurance
//await new PersonalAccidentInsuranceSamples(client).RunAsync();

// Sports Insurance
await new SportsInsuranceSamples(client).RunAsync();