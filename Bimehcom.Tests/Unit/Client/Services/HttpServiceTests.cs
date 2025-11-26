using Bimehcom.Client.Services;
using Bimehcom.Core.Exceptions;
using Bimehcom.Core.Options;
using FluentAssertions;
using Moq;
using Moq.Protected;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Bimehcom.Tests.Unit.Client.Services
{
    public class HttpServiceTests
    {
        private readonly BimehcomClientOptions _options;

        public HttpServiceTests()
        {
            _options = new BimehcomClientOptions
            {
                ApiKey = "testkey",
                BaseApiUrl = new Uri("https://example.com"),
                ApiVersion = "v1"
            };
        }

        private HttpService CreateService(HttpResponseMessage response)
        {
            var handlerMock = new Mock<HttpMessageHandler>();
            handlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(response);

            var client = new HttpClient(handlerMock.Object)
            {
                BaseAddress = _options.BaseApiUrl
            };

            return new HttpService(_options, client);
        }

        private class TestGetResponse
        {
            public string Name { get; set; }
        }

        private class TestPostResponse
        {
            public bool Success { get; set; }
        }

        private class TestPutResponse
        {
            public bool Updated { get; set; }
        }

        [Fact]
        public async Task GetAsync_ShouldReturnDeserializedObject()
        {
            var expected = new TestGetResponse { Name = "Test" };
            var json = JsonSerializer.Serialize(expected);

            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var service = CreateService(response);

            var result = await service.GetAsync<TestGetResponse>("test");

            result.Name.Should().Be("Test");
        }

        [Fact]
        public async Task GetAsync_ShouldThrowApiException_On4xx()
        {
            var response = new HttpResponseMessage(HttpStatusCode.BadRequest)
            {
                Content = new StringContent("{\"error\":\"bad request\"}", Encoding.UTF8, "application/json")
            };

            var service = CreateService(response);

            Func<Task> act = async () => await service.GetAsync<TestGetResponse>("test");

            await act.Should().ThrowAsync<BimehcomApiException>()
                .Where(e => e.StatusCode == 400);
        }

        [Fact]
        public async Task GetAsync_ShouldThrowHttpException_On5xx()
        {
            var response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new StringContent("server error")
            };

            var service = CreateService(response);

            Func<Task> act = async () => await service.GetAsync<TestGetResponse>("test");

            await act.Should().ThrowAsync<BimehcomHttpException>();
        }

        [Fact]
        public async Task PostAsync_ShouldSendBodyAndReturnResponse()
        {
            var expected = new TestPostResponse { Success = true };
            var json = JsonSerializer.Serialize(expected);

            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var service = CreateService(response);

            var body = new { Name = "X" };
            var result = await service.PostAsync<object, TestPostResponse>("test", body);

            result.Success.Should().BeTrue();
        }

        [Fact]
        public async Task PutAsync_ShouldReturnDeserializedObject()
        {
            var expected = new TestPutResponse { Updated = true };
            var json = JsonSerializer.Serialize(expected);

            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var service = CreateService(response);

            var body = new { Name = "Y" };
            var result = await service.PutAsync<object, TestPutResponse>("test", body);

            result.Updated.Should().BeTrue();
        }

        [Fact]
        public async Task DeleteAsync_ShouldReturnTrue_OnSuccess()
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("{}")
            };

            var service = CreateService(response);

            var result = await service.DeleteAsync("test");

            result.Should().BeTrue();
        }

        [Fact]
        public async Task DeleteAsync_ShouldThrowApiException_On4xx()
        {
            var response = new HttpResponseMessage(HttpStatusCode.BadRequest)
            {
                Content = new StringContent("{\"error\":\"bad request\"}")
            };

            var service = CreateService(response);

            Func<Task> act = async () => await service.DeleteAsync("test");

            await act.Should().ThrowAsync<BimehcomApiException>()
                .Where(e => e.StatusCode == 400);
        }

        [Fact]
        public async Task ApplyGlobalHeaders_ShouldIncludeApiKeyAndCustomHeaders()
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("{}")
            };

            var service = CreateService(response);

            var customHeaders = new System.Collections.Generic.Dictionary<string, string>
            {
                { "Custom", "HeaderValue" }
            };

            await service.GetAsync<TestGetResponse>("test", customHeaders);

            var httpClient = typeof(HttpService)
                .GetField("_httpClient", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.GetValue(service) as HttpClient;

            httpClient.DefaultRequestHeaders.Contains("Token").Should().BeTrue();
            httpClient.DefaultRequestHeaders.Contains("Custom").Should().BeTrue();
        }
    }
}
