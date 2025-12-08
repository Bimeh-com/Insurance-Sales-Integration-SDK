using Bimehcom.Client;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.Auth.Requests;
using Bimehcom.Samples.SampleData;
using System.Text.Json;
using Bimehcom.Samples;
var sampleDataPath = Path.Combine(AppContext.BaseDirectory, "SampleData", "sample-user.json");
var sampleUser = JsonSerializer.Deserialize<SampleUserData>(File.ReadAllText(sampleDataPath));

IBimehcomClient client = new BimehcomClientBuilder((opt) =>
{
    opt.BaseApiUrl = new Uri(sampleUser.BaseApiURL);
    opt.ApiKey = sampleUser.ApiKey;
    opt.PublicKey = sampleUser.PublicKey;
}).Build();

#region Authentication
var localLoginRequest = new AuthLocalLoginRequest
{
    Username = sampleUser.Username,
    Password = sampleUser.Password
};
var loginResponse = await client.Auth.LocalLoginAsync(localLoginRequest);
#endregion


// User Client
//await new UserClientSamples(client).RunAsync();

// Fire Insurance
//await new FireInsuranceSamples(client).RunAsync();

// Third Party Insurance
//await new CarThirdPartyInsuranceSamples(client).RunAsync();

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
//await new SportsInsuranceSamples(client).RunAsync();

// Pilgrimage Insurance
//await new PilgrimageInsuranceSamples(client).RunAsync();

// Travel Plus Insurance
//await new TravelPlusInsuranceSamples(client).RunAsync();