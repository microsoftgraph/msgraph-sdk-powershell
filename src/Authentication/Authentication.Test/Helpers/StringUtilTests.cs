using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using Microsoft.Graph.PowerShell.Authentication.Helpers;

using Xunit;

namespace Microsoft.Graph.Authentication.Test.Helpers
{
    public class StringUtilTests
    {
        private const string TestJsonArray = "{\"@odata.context\": \"https://graph.microsoft.com/v1.0/$metadata#users\"," + "\"value\": [{\"id\": \"6e7b768e-07e2-4810-8459-485f84f8f204\"},{\"id\": \"87d349ed-44d7-43e1-9a83-5f2406dee5bd\"}]}";

        private const string TestJsonObject = "{\"@odata.context\": \"https://graph.microsoft.com/v1.0/$metadata#users/$entity\",\"businessPhones\": [\"+1 412 555 0109\"],\"displayName\": \"Megan Bowen\",\"givenName\": \"Megan\",\"jobTitle\": \"Auditor\",\"mail\": \"MeganB@M365x214355.onmicrosoft.com\",    \"mobilePhone\": null,    \"officeLocation\": \"12/1110\",\"preferredLanguage\": \"en-US\",\"surname\": \"Bowen\",\"userPrincipalName\": \"MeganB@M365x214355.onmicrosoft.com\",\"id\": \"48d31887-5fad-4d73-a9f5-3c356e68a038\"}";

        [Theory]
        [MemberData(nameof(TestJsonData))]
        public void ShouldReturnCaseInsensitiveDictionaries(string jsonString)
        {
            Exception ex = null;
            var converted = jsonString.TryConvertToJson(out var jsonObj, ref ex);

            Assert.True(converted);
            Assert.IsType<Hashtable>(jsonObj);
            var jsonHashTable = (Hashtable)jsonObj;
            Assert.Equal(jsonHashTable["Value"], jsonHashTable["value"]);
        }
        public static IEnumerable<object[]> TestJsonData =>
            new List<object[]>
            {
                new object[] { TestJsonArray},
                new object[] { TestJsonObject}
            };
    }
}
