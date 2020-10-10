namespace Microsoft.Graph.Authentication.Test.Common
{
    using Microsoft.Graph.Authentication.Test.Mocks;
    using Microsoft.Graph.PowerShell.Authentication;
    using Microsoft.Graph.PowerShell.Authentication.Common;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;
    using Xunit;

    public class GraphSettingsTests
    {
        [Fact]
        public void ShouldSerializeAndDeserializeSettings()
        {
            GraphSession.Initialize(() => new GraphSession());

            // Arrange
            GraphSession.Instance.DataStore = new MockDataStore();
            GraphSettings settings = new GraphSettings(ProtectedFileProvider.CreateFileProvider(Constants.SettingFilePath, FileProtection.SharedRead));

            GraphEnvironment userDefinedEnv = new GraphEnvironment
            {
                Name = "TestCloud",
                Type = GraphEnvironmentConstants.EnvironmentType.UserDefined,
                AzureADEndpoint = "https://tester.com",
                GraphEndpoint = "https://tester.com"
            };

            settings.EnvironmentTable[userDefinedEnv.Name] = userDefinedEnv;

            // Act
            string serializedSettings = settings.ToString();
            settings.TryDeserializeObject(serializedSettings, out GraphSettings deserializedSettings, new GraphSettingsConverter());
            deserializedSettings.TryGetEnvironment(userDefinedEnv.Name, out IGraphEnvironment deserializedEnv);

            // Assert
            Assert.NotNull(deserializedSettings);
            Assert.NotNull(deserializedEnv);
            Assert.Equal(serializedSettings, deserializedSettings.ToString());
            Assert.Equal(userDefinedEnv.GraphEndpoint, deserializedEnv.GraphEndpoint);

            GraphSession.Reset();
        }

        [Fact]
        public void ShouldSaveSettingsToConfiguredDataStore()
        {
            GraphSession.Initialize(() => new GraphSession());

            // Arrange
            GraphSession.Instance.DataStore = new MockDataStore();
            GraphSettings settings = new GraphSettings(ProtectedFileProvider.CreateFileProvider(Constants.SettingFilePath, FileProtection.SharedRead));

            GraphEnvironment userDefinedEnv = new GraphEnvironment
            {
                Name = "TestCloud",
                Type = GraphEnvironmentConstants.EnvironmentType.UserDefined,
                AzureADEndpoint = "https://tester.com",
                GraphEndpoint = "https://tester.com"
            };
            string expectedSettingsContent = @"{
  ""EnvironmentTable"": {
    ""TestCloud"": {
      ""Name"": ""TestCloud"",
      ""AzureADEndpoint"": ""https://tester.com"",
      ""GraphEndpoint"": ""https://tester.com"",
      ""Type"": ""User-defined""
    }
  }
}";

            // Act
            // Saves settings to disk store.
            settings.TrySetEnvironment(userDefinedEnv, out IGraphEnvironment savedEnvironment);
            string settingsContent = GraphSession.Instance.DataStore.ReadFileAsText(Constants.SettingFilePath).Substring(1).TrimEnd(new[] { '\0' });

            // Assert
            Assert.NotEmpty(settingsContent);
            Assert.Equal(expectedSettingsContent, settingsContent);

            GraphSession.Reset();
        }

        [Fact]
        public void ShouldLoadSettingsFromConfiguredDataStore()
        {
            GraphSession.Initialize(() => new GraphSession());

            // Arrange
            GraphSession.Instance.DataStore = new MockDataStore();
            string settingsContent = @"{
  ""EnvironmentTable"": {
    ""MyNewCloud"": {
      ""Name"": ""MyNewCloud"",
      ""AzureADEndpoint"": ""https://login.MyNewCloud.com"",
      ""GraphEndpoint"": ""https://graph.MyNewCloud.com"",
      ""Type"": ""User-defined""
    },
    ""TrialCloud"": {
      ""Name"": ""MyNewCloud"",
      ""AzureADEndpoint"": ""https://login.TrialCloud.com"",
      ""GraphEndpoint"": ""https://graph.TrialCloud.com"",
      ""Type"": ""User-defined""
    }
  }
}";
            GraphSession.Instance.DataStore.WriteFile(Constants.SettingFilePath, settingsContent);

            // Act
            // Loads settings from disk store.
            GraphSettings settings = new GraphSettings(ProtectedFileProvider.CreateFileProvider(Constants.SettingFilePath, FileProtection.SharedRead));

            settings.TryGetEnvironment("MyNewCloud", out IGraphEnvironment loadedEnvironment);

            // Assert
            Assert.NotNull(loadedEnvironment);
            // 5 built-in + 2 user-defined
            Assert.Equal(7, settings.Environments.Count());
            Assert.Equal("https://login.MyNewCloud.com", loadedEnvironment.AzureADEndpoint);
            Assert.Equal("https://graph.MyNewCloud.com", loadedEnvironment.GraphEndpoint);
            Assert.Equal(GraphEnvironmentConstants.EnvironmentType.UserDefined, loadedEnvironment.Type);

            GraphSession.Reset();
        }

        [Fact]
        public void ShouldRemoveSettingsFromConfiguredDataStore()
        {
            GraphSession.Initialize(() => new GraphSession());

            // Arrange
            GraphSession.Instance.DataStore = new MockDataStore();
            GraphSettings settings = new GraphSettings(ProtectedFileProvider.CreateFileProvider(Constants.SettingFilePath, FileProtection.SharedRead));
            GraphEnvironment myNewCloudEnv = new GraphEnvironment
            {
                Name = "MyNewCloud",
                Type = GraphEnvironmentConstants.EnvironmentType.UserDefined,
                AzureADEndpoint = "https://login.MyNewCloud.com",
                GraphEndpoint = "https://graph.MyNewCloud.com"
            };
            GraphEnvironment trialCloudEnv = new GraphEnvironment
            {
                Name = "TrialCloud",
                Type = GraphEnvironmentConstants.EnvironmentType.UserDefined,
                AzureADEndpoint = "https://login.TrialCloud.com",
                GraphEndpoint = "https://graph.TrialCloud.com"
            };
            settings.TrySetEnvironment(myNewCloudEnv, out IGraphEnvironment mergedMyNewCloudEnv);
            settings.TrySetEnvironment(trialCloudEnv, out IGraphEnvironment mergedTrialCloudEnv);

            // Act
            settings.RemoveEnvironment(trialCloudEnv.Name);
            string settingsContent = GraphSession.Instance.DataStore.ReadFileAsText(Constants.SettingFilePath);

            // Assert
            Assert.NotEmpty(settingsContent);
            // 5 built-in + 1 user-defined
            Assert.Equal(6, settings.Environments.Count());

            GraphSession.Reset();
        }
    }
}
