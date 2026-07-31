using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class EmitterTests
{
    // A spec-derived noun or header name containing a double quote must be escaped where it is
    // interpolated into a generated C# string literal, or the generated source will not compile.
    [Fact]
    public void EscapesQuotesInSpecDerivedStringLiterals()
    {
        var naming = new CmdletNaming(
            VerbsClass: "VerbsCommon",
            VerbName: "Remove",
            Noun: "MgHe\"llo",                       // quote lands in the [Cmdlet(..., "...")] literal
            ClassName: "RemoveMgHelloCommand",        // class name is a separate, valid identifier
            PathParamNames: new[] { "UserId" },
            BuilderExpression: "Users[UserId]",
            HeaderParams: new[] { new HeaderParam("If\"Match", "IfMatch") }); // quote in a header name

        var source = CmdletEmitter.EmitRemove(naming, new EmitContext("Test.Client"));

        // Escaped forms present (valid literals).
        Assert.Contains("\"MgHe\\\"llo\"", source);   // "MgHe\"llo"
        Assert.Contains("\"If\\\"Match\"", source);   // "If\"Match"

        // Broken/unescaped forms absent.
        Assert.DoesNotContain("\"MgHe\"llo\"", source); // "MgHe"llo"
        Assert.DoesNotContain("\"If\"Match\"", source); // "If"Match"
    }
}
