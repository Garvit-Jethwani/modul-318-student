// ********RoostGPT********
// Test generated by RoostGPT for test csharp-coding-examples using AI Type Open AI and AI Model gpt-4



// ********RoostGPT********
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SwissTransport.Models;
using NUnit.Framework;
using SwissTransport.Core;

namespace SwissTransport.Core.Test
{
    public class Dispose_b753ff24a4
    {
        private Transport _transport;
        private HttpClient _httpClient;

        [SetUp]
        public void SetUp()
        {
            _httpClient = new HttpClient();
            _transport = new Transport(_httpClient);
        }

        [Test]
        public void Dispose_Test()
        {
            _transport.Dispose();

            var exception = Assert.Throws<ObjectDisposedException>(() => _httpClient.GetAsync("https://transport.opendata.ch/v1/locations?query=test"));
            Assert.AreEqual("Cannot access a disposed object.\r\nObject name: 'System.Net.Http.HttpClient'.", exception.Message);
        }

        [Test]
        public void Dispose_MultipleCall_Test()
        {
            _transport.Dispose();
            _transport.Dispose();

            var exception = Assert.Throws<ObjectDisposedException>(() => _httpClient.GetAsync("https://transport.opendata.ch/v1/locations?query=test"));
            Assert.AreEqual("Cannot access a disposed object.\r\nObject name: 'System.Net.Http.HttpClient'.", exception.Message);
        }

        [TearDown]
        public void TearDown()
        {
            _transport = null;
            _httpClient = null;
        }
    }
}
