// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Management.Automation.Language;
using Xunit;

namespace Microsoft.Graph.Authentication.Test.Utilities.Runtime.Cmdlets
{
    /// <summary>
    /// Tests to verify that path escaping works correctly for PowerShell commands.
    /// These tests validate the fix for CVE-like vulnerability where paths with single quotes
    /// could break PowerShell command syntax or potentially allow command injection.
    /// </summary>
    public class StringEscapingTests
    {
        public static IEnumerable<object[]> PathsWithSingleQuotes =>
            new List<object[]>
            {
                new object[] { "C:\\User's Documents\\Module.psd1", "C:\\User''s Documents\\Module.psd1" },
                new object[] { "C:\\Test's\\Path\\File.ps1", "C:\\Test''s\\Path\\File.ps1" },
                new object[] { "C:\\Users\\John's Folder\\Scripts", "C:\\Users\\John''s Folder\\Scripts" },
                new object[] { "C:\\It's\\Working\\Test.psm1", "C:\\It''s\\Working\\Test.psm1" },
                new object[] { "C:\\Multiple'Single'Quotes\\File.ps1", "C:\\Multiple''Single''Quotes\\File.ps1" }
            };

        public static IEnumerable<object[]> PathsWithoutSingleQuotes =>
            new List<object[]>
            {
                new object[] { "C:\\Users\\Documents\\Module.psd1" },
                new object[] { "C:\\Windows\\System32\\Test.ps1" },
                new object[] { "C:\\Program Files\\Application\\Script.psm1" }
            };

        public static IEnumerable<object[]> MaliciousPaths =>
            new List<object[]>
            {
                // Path that attempts command injection
                new object[] { "C:\\Test'; Write-Output 'INJECTED'; '\\Module.psd1", "C:\\Test''; Write-Output ''INJECTED''; ''\\Module.psd1" },
                // Path that attempts to close the string and run additional command
                new object[] { "C:\\Malicious' -and $true -eq $true #\\Test.ps1", "C:\\Malicious'' -and $true -eq $true #\\Test.ps1" }
            };

        [Theory]
        [MemberData(nameof(PathsWithSingleQuotes))]
        public void EscapeSingleQuotedStringContent_WithSingleQuote_ShouldDoubleTheQuote(string input, string expected)
        {
            // Act
            var result = CodeGeneration.EscapeSingleQuotedStringContent(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(PathsWithoutSingleQuotes))]
        public void EscapeSingleQuotedStringContent_WithoutSingleQuote_ShouldReturnUnchanged(string input)
        {
            // Act
            var result = CodeGeneration.EscapeSingleQuotedStringContent(input);

            // Assert
            Assert.Equal(input, result);
        }

        [Theory]
        [MemberData(nameof(MaliciousPaths))]
        public void EscapeSingleQuotedStringContent_WithMaliciousInput_ShouldEscapeAllQuotes(string input, string expected)
        {
            // Act
            var result = CodeGeneration.EscapeSingleQuotedStringContent(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void EscapeSingleQuotedStringContent_WithEmptyString_ShouldReturnEmpty()
        {
            // Arrange
            var input = string.Empty;

            // Act
            var result = CodeGeneration.EscapeSingleQuotedStringContent(input);

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void EscapedPath_WhenUsedInPowerShellCommand_ShouldNotBreakSyntax()
        {
            // Arrange
            var pathWithQuote = "C:\\User's Documents\\Module.psd1";
            var escapedPath = CodeGeneration.EscapeSingleQuotedStringContent(pathWithQuote);

            // Act - Simulate the command construction like in GetModuleCmdlet
            var command = $"(Get-Command -Module (Import-Module '{escapedPath}' -PassThru))";

            // Assert - Verify the command has properly escaped quotes
            Assert.Contains("User''s Documents", command);
            Assert.DoesNotContain("User's Documents", command);

            // Verify opening and closing quotes match
            var singleQuoteCount = command.Count(c => c == '\'');
            Assert.Equal(4, singleQuoteCount); // 2 pairs of quotes around the path
        }

        [Fact]
        public void EscapedScriptFolder_WhenUsedInPowerShellCommand_ShouldNotBreakSyntax()
        {
            // Arrange
            var folderWithQuote = "C:\\User's Scripts";
            var escapedFolder = CodeGeneration.EscapeSingleQuotedStringContent(folderWithQuote);

            // Act - Simulate the command construction like in GetScriptCmdlet
            var command = $"Get-ChildItem -Path '{escapedFolder}' -Recurse -Include '*.ps1' -File";

            // Assert - Verify the command has properly escaped quotes
            Assert.Contains("User''s Scripts", command);
            Assert.DoesNotContain("User's Scripts", command);
        }
    }
}
