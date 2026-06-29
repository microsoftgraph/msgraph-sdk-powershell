namespace JsonUtilitiesTest;
using System;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using Xunit;
using NamespacePrefixPlaceholder.PowerShell.JsonUtilities;

public class JsonExtensionsTests
{
    [Fact]
    public void RemoveDefaultNullProperties_ShouldConvertStringNullToJsonNull()
    {
        // Arrange
        JToken json = JToken.Parse(@"{
            ""displayname"": ""null"",
        }");

        // Act
        string cleanedJson = json.RemoveDefaultNullProperties();
        String expectedJson = @"{
            ""displayname"": null
        }";
        // Assert
        Assert.Equal(NormalizeJson(expectedJson), NormalizeJson(cleanedJson));
    }

    [Fact]
    public void RemoveDefaultNullProperties_ShouldConvertNullToJsonNull()
    {
        // Arrange
        JToken json = JToken.Parse(@"{
            ""displayname"": null,
        }");

        // Act
        string cleanedJson = json.RemoveDefaultNullProperties();
        String expectedJson = @"{
            ""displayname"": null
        }";
        // Assert
        Assert.Equal(NormalizeJson(expectedJson), NormalizeJson(cleanedJson));
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
                ""supervisor"" : ""null""
            },
            ""metadata"": {
                ""phone"": ""null"",
                ""location"": ""null"",
                ""address"": {
                    ""city"": ""Nairobi"",
                    ""street"": ""null""
                },
                ""station"": {
                }
            }
        }");

        // Act
        string cleanedJson = json.RemoveDefaultNullProperties();
        string expectedJson = @"{
            ""displayname"": ""Tim"",
            ""professions"": {},
            ""jobProfile"": {
                ""dept"": ""ICT"",
                ""manager"": false,
                ""supervisor"": null
            },
            ""metadata"": {
                ""phone"": null,
                ""location"": null,
                ""address"": {
                    ""city"": ""Nairobi"",
                    ""street"": null
                },
                ""station"": {}
            }
        }";

        // Assert
        Assert.Equal(NormalizeJson(expectedJson), NormalizeJson(cleanedJson));
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
                { ""displayname"": ""Tim"", ""email"": ""null"" },
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
    public void RemoveDefaultNullProperties_ShouldConvertNullStringValuesIntoNullInJsonArray()
    {
        // Arrange
        JArray json = JArray.Parse(@"[
                { ""displayname"": ""Tim"", ""email"": ""null"" }

        ]");

        // Act
        string cleanedJson = json.RemoveDefaultNullProperties();
        String expectedJson = @"[
                { ""displayname"": ""Tim"", ""email"": null }
        ]";
        // Assert
        Assert.Equal(NormalizeJson(expectedJson), NormalizeJson(cleanedJson));

    }
    [Fact]
    public void ReplaceAndRemoveSlashes_Should_Preserve_Json_Property_Values()
    {
        // Arrange
        JObject inputJson = JObject.Parse(@"{
            ""RedirectUris"": [""http://localhost/.auth/login/aad/callback""],
            ""DirectoryPath"": ""/this/is/a/directory/and/should/not/be/removed""
        }");

        string expectedJson = @"{
            ""RedirectUris"": [""http://localhost/.auth/login/aad/callback""],
            ""DirectoryPath"": ""/this/is/a/directory/and/should/not/be/removed""
        }";

        // Act
        string result = inputJson.RemoveDefaultNullProperties();

        // Assert
        Assert.Equal(NormalizeJson(result), NormalizeJson(expectedJson));
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
    public void RemoveDefaultNullProperties_ShouldRemoveConvertNullStringValuesIntoNullInJsonObjectWithBothDeeplyNestedObjectsAndArrays()
    {
        // Arrange
        JObject json = JObject.Parse(@"{
            ""body"":{
                ""users"": [
                    { ""displayname"": ""Tim"", ""email"": ""null"", ""metadata"": { ""phone"": ""254714390915"" } }
                ]
            },
            ""users"": [
                { ""displayname"": ""Tim"", ""email"": ""null"", ""metadata"": { ""phone"": ""254714390915"" } }]}");

        // Act
        string cleanedJson = json.RemoveDefaultNullProperties();
        JObject result = JObject.Parse(cleanedJson);

        // Assert
        Assert.True(result["users"][0]?["metadata"]?.ToObject<JObject>().ContainsKey("phone"));
        Assert.True(result["body"]?["users"][0]?["metadata"]?.ToObject<JObject>().ContainsKey("phone"));
    }

    [Fact]
    public void RemoveDefaultNullProperties_ShouldNotDoAutomaticInferrencing()
    {
        // Arrange
        JObject json = JObject.Parse(@"{
            ""fields"": {
                ""BasicTag"": ""v2.31.0"",
                ""BuildID"": ""3599"",
                ""MWSCommitID"": ""a5c7998252f2366c8cbbb03ba46e9b"",
                ""MWSTag"": ""v2.21.0"",
                ""BasicCommitID"": ""9c3d0f36362dd25caa0da2ecab06a1859ce2"",
                ""CustomerCommitID"": ""c40241be9fd2f1cd2f2f2fc961c37f720c""
            }
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
        string cleanedJson = json.RemoveDefaultNullProperties();

        // Assert
        Assert.Equal(NormalizeJson(expectedJson), NormalizeJson(cleanedJson));
    }



}

