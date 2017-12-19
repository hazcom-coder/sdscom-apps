using System;
using Xunit;
using SDSComApps.Controllers;
using Moq;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;

namespace SDSComAppsTestProject
{  

    public class BaseTests
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;


        public BaseTests()
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Fact]
        public async Task ReturnHelloWorld()
        {
            string responseString = "";

            try
            {
                // Act
                var response = await _client.GetAsync("/");
                response.EnsureSuccessStatusCode();

                responseString = await response.Content.ReadAsStringAsync();
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
            // Assert
            Assert.Equal("Hello World!",responseString);
        }

    }
}
