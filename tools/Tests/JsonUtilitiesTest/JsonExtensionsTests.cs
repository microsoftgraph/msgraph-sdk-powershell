namespace JsonUtilitiesTest;
using System;
using System.Text.Json;
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
            ""jobProfile"": {
                ""dept"": ""ICT"",
                ""manager"": false,
                ""supervisor"" : ""defaultnull""
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
        Assert.Equal("ICT", result["jobProfile"]?["dept"]?.ToString());
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
    public void ReplaceAndRemoveSlashes_Should_Preserve_Json_Property_Values()
    {
        // Arrange
        string inputJson = @"{
            ""RedirectUris"": [""http://localhost/.auth/login/aad/callback""],
            ""DirectoryPath"": ""/this/is/a/directory/and/should/not/be/removed""
        }";

        string expectedJson = @"{
            ""RedirectUris"": [""http://localhost/.auth/login/aad/callback""],
            ""DirectoryPath"": ""/this/is/a/directory/and/should/not/be/removed""
        }";

        // Act
        string result = inputJson.ReplaceAndRemoveSlashes();

        // Assert
        Assert.Equal(NormalizeJson(expectedJson), NormalizeJson(result));
    }

    [Fact]
    public void ReplaceAndRemoveSlashes_Should_Remove_Backslashes()
    {
        // Arrange
        string input = @"Some \random \slashes that \should be removed.";
        string expected = "Some random slashes that should be removed.";

        // Act
        string result = input.ReplaceAndRemoveSlashes();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReplaceAndRemoveSlashes_Should_Handle_Invalid_Json_Gracefully()
    {
        // Arrange
        string invalidJson = "{Invalid Json \\with /slashes}";

        // Act
        string result = invalidJson.ReplaceAndRemoveSlashes();

        // Assert
        Assert.DoesNotContain("\\", result);
    }

    /// <summary>
    /// Normalizes JSON for comparison (removes formatting differences).
    /// </summary>
    private string NormalizeJson(string json)
    {
        using var doc = JsonDocument.Parse(json);
        return JsonSerializer.Serialize(doc.RootElement, new JsonSerializerOptions
        {
            WriteIndented = false,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        });
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

    /*
    Test for unescaping json object while maintaining original property definition of values
    instead of auto inferencing the type of the value
    "fields": "{\r\n  \"BasicTag\": \"v2.31.0\",\r\n  \"BuildID\": \"3599\",\r\n  \"MWSCommitID\": \"a5c7998252f2366c8cbbb03ba46e9b\",\r\n  \"MWSTag\": \"v2.21.0\",\r\n  \"BasicCommitID\": \"9c3d0f36362dd25caa0da2ecab06a1859ce2\",\r\n  \"CustomerCommitID\": \"c40241be9fd2f1cd2f2f2fc961c37f720c\"\r\n}"
    */
    [Fact]
    public void RemoveDefaultNullProperties_ShouldUnescapeJsonString(){
        // Arrange
        JObject json = JObject.Parse(@"{
            ""fields"": ""{\r\n  \""BasicTag\"": \""v2.31.0\"",\r\n  \""BuildID\"": \""3599\"",\r\n  \""MWSCommitID\"": \""a5c7998252f2366c8cbbb03ba46e9b\"",\r\n  \""MWSTag\"": \""v2.21.0\"",\r\n  \""BasicCommitID\"": \""9c3d0f36362dd25caa0da2ecab06a1859ce2\"",\r\n  \""CustomerCommitID\"": \""c40241be9fd2f1cd2f2f2fc961c37f720c\""\r\n}""
        }");

        String expectedJson = @"{
            ""fields"": {
                ""BasicTag"": ""v2.31.0"",
                ""BuildID"": ""3599"",
                ""MWSCommitID"": ""a5c7998252f2366c8cbbb03ba46e9b"",
                ""MWSTag"": ""v2.21.0"",
                ""BasicCommitID"": ""9c3d0f36362dd25caa0da2ecab06a1859ce2"",
                ""CustomerCommitID"": ""c40241be9fd2f1cd2f2f2fc961c37f720c""
            }
        }";

        // Act
        //Convert Json object to string  then pass it to RemoveAndReplaceSlashes method
        string cleanedJson = json.ToString()?.ReplaceAndRemoveSlashes();

        // Assert
        Assert.Equal(NormalizeJson(expectedJson), NormalizeJson(cleanedJson));
    }

    
    
}

