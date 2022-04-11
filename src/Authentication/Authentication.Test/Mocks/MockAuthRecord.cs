using System;
using System.IO;
using System.Text.Json;

namespace Microsoft.Graph.Authentication.Test.Mocks
{
    internal class MockAuthRecord
    {
        private readonly string authRecordPath;
        public MockAuthRecord(string username, string tenantId = null)
        {
            Username = username;
            TenantId = tenantId ?? Guid.NewGuid().ToString();
            var objectId = Guid.NewGuid().ToString();
            HomeAccountId = $"{objectId}.{TenantId}";
            Authority = "login.windows.net";
            ClientId = Guid.NewGuid().ToString();
            Version = "1.0";

            authRecordPath = PowerShell.Authentication.Core.Constants.AuthRecordPath;
        }
        public string Username { get; }
        public string TenantId { get; }
        public string HomeAccountId { get; }
        public string Authority { get; }
        public string ClientId { get; }
        public string Version { get; }

        public void SerializeToFile()
        {
            string jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(authRecordPath, jsonString);
        }

        public void DeleteCache()
        {
            File.Delete(authRecordPath);
        }

    }
}
