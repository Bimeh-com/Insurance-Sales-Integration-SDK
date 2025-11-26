using Bimehcom.Client;
using Bimehcom.Core;

IBimehcomClient client = new BimehcomClientBuilder((opt)  =>
{
    opt.ApiKey = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
    opt.BaseApiUrl = new Uri("https://coreapi.bimeh.com");
    opt.ApiVersion = "v1";
}).Build();