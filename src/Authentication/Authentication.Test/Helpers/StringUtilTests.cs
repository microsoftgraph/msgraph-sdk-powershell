namespace Microsoft.Graph.Authentication.Test.Helpers
{

    using System.Collections;
    using System.Collections.Generic;
    using System.Management.Automation;

    using Microsoft.Graph.PowerShell.Authentication.Helpers;

    using Xunit;

    public class StringUtilTests
    {
        private const string TestJsonArray = "{\"@odata.context\": \"https://graph.microsoft.com/v1.0/$metadata#users\"," + "\"value\": [{\"id\": \"6e7b768e-07e2-4810-8459-485f84f8f204\"},{\"id\": \"87d349ed-44d7-43e1-9a83-5f2406dee5bd\"}]}";

        private const string TestJsonObject = "{\"@odata.context\": \"https://graph.microsoft.com/v1.0/$metadata#users/$entity\",\"businessPhones\": [\"+1 412 555 0109\"],\"displayName\": \"Megan Bowen\",\"givenName\": \"Megan\",\"jobTitle\": \"Auditor\",\"mail\": \"MeganB@M365x214355.onmicrosoft.com\",    \"mobilePhone\": null,    \"officeLocation\": \"12/1110\",\"preferredLanguage\": \"en-US\",\"surname\": \"Bowen\",\"userPrincipalName\": \"MeganB@M365x214355.onmicrosoft.com\",\"id\": \"48d31887-5fad-4d73-a9f5-3c356e68a038\"}";
        public static IEnumerable<object[]> TestJsonData =>
            new List<object[]>
            {
                new object[] { TestJsonArray},
                new object[] { TestJsonObject}
            };

        [Theory]
        [MemberData(nameof(TestJsonData))]
        public void ShouldReturnCaseInsensitiveDictionaries(string jsonString)
        {
            var hashTable = jsonString.ConvertFromJson(true, null, out _);

            Assert.NotNull(hashTable);
            var jsonHashTable = (Hashtable)hashTable;
            Assert.Equal(jsonHashTable["Value"], jsonHashTable["value"]);
        }

        [Theory]
        [MemberData(nameof(TestJsonData))]
        public void ShouldReturnPsObject(string jsonString)
        {
            var psObject = jsonString.ConvertFromJson(false, null, out _);

            Assert.NotNull(psObject);
            Assert.IsType<PSObject>(psObject);
        }

        [Theory]
        [MemberData(nameof(TestJsonData))]
        public void ShouldReturnHashTable(string jsonString)
        {
            var hashTable = jsonString.ConvertFromJson(true, null, out _);

            Assert.NotNull(hashTable);
            Assert.IsType<Hashtable>(hashTable);
        }
    }
}
