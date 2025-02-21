namespace JsonUtilitiesTest;
using System;
using Newtonsoft.Json.Linq;
using Xunit;
using NamespacePrefixPlaceholder.PowerShell.JsonUtilities;

public class JsonExtensionsTests
{
    [Fact]
    public void RemoveDefaultNullProperties_ShouldRemoveDefaultNullValues()
    {
        // Arrange
        JObject json = JObject.Parse(@"{
            ""displayname"": ""Tim"",
            ""position"": ""defaultnull"",
            ""salary"": 2000000,
            ""team"": ""defaultnull""
        }");

        // Act
        string cleanedJson = json.RemoveDefaultNullProperties();
        JObject result = JObject.Parse(cleanedJson);

        // Assert
        Assert.False(result.ContainsKey("position"));
        Assert.False(result.ContainsKey("team"));
        Assert.Equal("Tim", result["displayname"]?.ToString());
        Assert.Equal(2000000, result["salary"]?.ToObject<int>());
    }

    [Fact]
    public void RemoveDefaultNullProperties_ShouldConvertStringNullToJsonNull()
    {
        // Arrange
        JObject json = JObject.Parse(@"{
            ""displayname"": ""Tim"",
            ""position"": ""null"",
            ""salary"": 2000000,
            ""team"": """"
        }");

        // Act
        string cleanedJson = json.RemoveDefaultNullProperties();
        JObject result = JObject.Parse(cleanedJson);

        // Assert
        Assert.Null(result["position"]?.Value<string>());
        Assert.Equal("", result["team"]?.ToString());
        Assert.Equal("Tim", result["displayname"]?.ToString());
        Assert.Equal(2000000, result["salary"]?.ToObject<int>());
    }

    [Fact]
    public void RemoveDefaultNullProperties_ShouldHandleNestedObjects()
    {
        // Arrange
        JObject json = JObject.Parse(@"{
            ""displayname"": ""Tim"",
            ""professions"": {
            },
            ""passwordProfile"": {
                ""password"": ""pass123"",
                ""forceChangePasswordNextSignIn"": false,
                ""forcePassWitMfa"" : ""defaultnull""
            },
            ""metadata"": {
                ""phone"": ""defaultnull"",
                ""location"": ""null"",
                ""address"": {
                    ""city"": ""Nairobi"",
                    ""street"": ""defaultnull""
                },
                ""station"": {
                }
            }
        }");

        // Act
        string cleanedJson = json.RemoveDefaultNullProperties();
        JObject result = JObject.Parse(cleanedJson);

        // Assert
        Assert.False(result["metadata"]?.ToObject<JObject>()?.ContainsKey("phone"));
        Assert.Equal("pass123", result["passwordProfile"]?["password"]?.ToString());
        Assert.Equal("Nairobi", result["metadata"]?["address"]?["city"]?.ToString());
        Assert.Null(result["metadata"]?["location"]?.Value<string>());
        // Check if emptynested object is removed
        Assert.False(result["metadata"]?.ToObject<JObject>()?.ContainsKey("station "));
        Assert.False(result?.ToObject<JObject>()?.ContainsKey("professions"));
    }

    [Fact]
    public void RemoveDefaultNullProperties_ShouldHandleEmptyJsonObject()
    {
        // Arrange
        JObject json = JObject.Parse(@"{}");

        // Act
        string cleanedJson = json.RemoveDefaultNullProperties();
        JObject result = JObject.Parse(cleanedJson);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void RemoveDefaultNullProperties_ShouldHandleJsonArrays()
    {
        // Arrange
        JObject json = JObject.Parse(@"{
            ""users"": [
                { ""displayname"": ""Tim"", ""email"": ""defaultnull"" },
                { ""displayname"": ""Mayabi"", ""email"": ""mayabi@example.com"" }
            ]
        }");

        // Act
        string cleanedJson = json.RemoveDefaultNullProperties();
        JObject result = JObject.Parse(cleanedJson);

        // Assert
        Assert.Equal("Tim", result["users"]?[0]?["displayname"]?.ToString());
        Assert.Equal("mayabi@example.com", result["users"]?[1]?["email"]?.ToString());
    }

    [Fact]
    public void RemoveDefaultNullProperties_ShouldNotAlterValidData()
    {
        // Arrange
        JObject json = JObject.Parse(@"{
            ""displayname"": ""Tim"",
            ""email"": ""mayabi@example.com"",
            ""salary"": 2000000
        }");

        // Act
        string cleanedJson = json.RemoveDefaultNullProperties();
        JObject result = JObject.Parse(cleanedJson);

        // Assert
        Assert.Equal("Tim", result["displayname"]?.ToString());
        Assert.Equal("mayabi@example.com", result["email"]?.ToString());
        Assert.Equal(2000000, result["salary"]?.ToObject<int>());
    }

    //Add tests for json arrays
    [Fact]
    public void RemoveDefaultNullProperties_ShouldRemoveDefaultNullValuesInJsonArray()
    {
        // Arrange
        JArray json = JArray.Parse(@"[
                { ""displayname"": ""Tim"", ""email"": ""defaultnull"" }

        ]");

        // Act
        string cleanedJson = json.RemoveDefaultNullProperties();
        JArray result = JArray.Parse(cleanedJson);

        // Assert
        Assert.Equal("Tim", result[0]?["displayname"]?.ToString());
        Assert.False(result[0].ToObject<JObject>().ContainsKey("email"));

    }

    [Fact]
    public void RemoveDefaultNullProperties_ShouldRemoveDefaultNullValuesInJsonObjectWithBothDeeplyNestedObjectsAndArrays(){
        // Arrange
        JObject json = JObject.Parse(@"{
            ""body"":{
                ""users"": [
                    { ""displayname"": ""Tim"", ""email"": ""defaultnull"", ""metadata"": { ""phone"": ""254714390915"" } }
                ]
            },
            ""users"": [
                { ""displayname"": ""Tim"", ""email"": ""defaultnull"", ""metadata"": { ""phone"": ""254714390915"" } }]}");

        // Act
        string cleanedJson = json.RemoveDefaultNullProperties();
        JObject result = JObject.Parse(cleanedJson);

        // Assert
        Assert.False(result["users"][0]?.ToObject<JObject>().ContainsKey("email"));
        Assert.True(result["users"][0]?["metadata"]?.ToObject<JObject>().ContainsKey("phone"));
        Assert.False(result["body"]?["users"][0]?.ToObject<JObject>().ContainsKey("email"));
        Assert.True(result["body"]?["users"][0]?["metadata"]?.ToObject<JObject>().ContainsKey("phone"));
    }
}

