using System.Collections;
using System.Management.Automation;
using System.Net.Http;

using Microsoft.Graph.PowerShell.Authentication.Cmdlets;
using Microsoft.Graph.PowerShell.Authentication.Helpers;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Xunit;

namespace Microsoft.Graph.Authentication.Test.Helpers
{
    public class PSObjectJsonConverterTests
    {
        [Fact]
        public void ShouldSerializePSObjectWrappedStringAsPlainString()
        {
            // Mimics a value produced by the PowerShell pipeline, e.g. bare $_ in ForEach-Object.
            // See https://github.com/microsoftgraph/msgraph-sdk-powershell/issues/3654.
            var body = new Hashtable
            {
                {
                    "message", new Hashtable
                    {
                        {
                            "toRecipients", new object[]
                            {
                                new Hashtable
                                {
                                    {
                                        "emailAddress", new Hashtable
                                        {
                                            { "address", PSObject.AsPSObject("recipient@example.com") }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                { "saveToSentItems", true }
            };

            var json = JsonConvert.SerializeObject(body, new PSObjectJsonConverter());

            var parsedBody = JObject.Parse(json);
            Assert.Equal("recipient@example.com",
                parsedBody.SelectToken("message.toRecipients[0].emailAddress.address").Value<string>());
            Assert.True(parsedBody.SelectToken("saveToSentItems").Value<bool>());
        }

        [Fact]
        public void ShouldSerializePSObjectWrappedPrimitivesAsUnderlyingValues()
        {
            var body = new Hashtable
            {
                { "count", PSObject.AsPSObject(42) },
                { "enabled", PSObject.AsPSObject(true) }
            };

            var json = JsonConvert.SerializeObject(body, new PSObjectJsonConverter());

            var parsedBody = JObject.Parse(json);
            Assert.Equal(42, parsedBody.SelectToken("count").Value<int>());
            Assert.True(parsedBody.SelectToken("enabled").Value<bool>());
        }

        [Fact]
        public void ShouldSerializePSObjectWrappedDictionary()
        {
            var body = new Hashtable
            {
                {
                    "emailAddress", PSObject.AsPSObject(new Hashtable
                    {
                        { "address", PSObject.AsPSObject("recipient@example.com") }
                    })
                }
            };

            var json = JsonConvert.SerializeObject(body, new PSObjectJsonConverter());

            var parsedBody = JObject.Parse(json);
            Assert.Equal("recipient@example.com",
                parsedBody.SelectToken("emailAddress.address").Value<string>());
        }

        [Fact]
        public void ShouldSerializePSCustomObjectAsJsonObject()
        {
            var emailAddress = new PSObject();
            emailAddress.Properties.Add(new PSNoteProperty("address", PSObject.AsPSObject("recipient@example.com")));
            var body = new Hashtable
            {
                { "emailAddress", emailAddress }
            };

            var json = JsonConvert.SerializeObject(body, new PSObjectJsonConverter());

            var parsedBody = JObject.Parse(json);
            Assert.Equal("recipient@example.com",
                parsedBody.SelectToken("emailAddress.address").Value<string>());
        }

        [Fact]
        public void SetRequestContentShouldSerializeDictionaryWithPSObjectWrappedValues()
        {
            var cmdlet = new InvokeMgGraphRequest();
            using (var request = new HttpRequestMessage(HttpMethod.Post,
                "https://graph.microsoft.com/v1.0/users/sender@example.com/sendMail"))
            {
                var body = new Hashtable
                {
                    {
                        "message", new Hashtable
                        {
                            {
                                "toRecipients", new object[]
                                {
                                    new Hashtable
                                    {
                                        {
                                            "emailAddress", new Hashtable
                                            {
                                                { "address", PSObject.AsPSObject("recipient@example.com") }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    { "saveToSentItems", true }
                };

                var contentLength = cmdlet.SetRequestContent(request, body);

                Assert.True(contentLength > 0);
                var json = request.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var parsedBody = JObject.Parse(json);
                Assert.Equal("recipient@example.com",
                    parsedBody.SelectToken("message.toRecipients[0].emailAddress.address").Value<string>());
            }
        }
    }
}
