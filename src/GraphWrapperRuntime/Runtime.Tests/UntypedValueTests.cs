using System;
using System.Collections;
using System.Collections.Generic;

using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Kiota.Abstractions.Serialization;
using Xunit;

namespace Microsoft.Graph.Wrapper.Runtime.Tests;

// The conversion battery the per-module runtime gate has always exercised (19 cases), now
// pinned once against the shared implementation instead of re-proven per module by reflection.
public sealed class UntypedValueTests
{
    [Fact] public void NullYieldsNull() => Assert.Null(UntypedValue.From(null));
    [Fact] public void StringConverts() => Assert.Equal("x", Assert.IsType<UntypedString>(UntypedValue.From("x")).GetValue());
    [Fact] public void BoolConverts() => Assert.True(Assert.IsType<UntypedBoolean>(UntypedValue.From(true)).GetValue());
    [Fact] public void IntConverts() => Assert.Equal(7, Assert.IsType<UntypedInteger>(UntypedValue.From(7)).GetValue());
    [Fact] public void LongConverts() => Assert.Equal(7L, Assert.IsType<UntypedLong>(UntypedValue.From(7L)).GetValue());
    [Fact] public void FloatConverts() => Assert.Equal(1.5f, Assert.IsType<UntypedFloat>(UntypedValue.From(1.5f)).GetValue());
    [Fact] public void DoubleConverts() => Assert.Equal(1.5d, Assert.IsType<UntypedDouble>(UntypedValue.From(1.5d)).GetValue());
    [Fact] public void DecimalConverts() => Assert.Equal(1.5m, Assert.IsType<UntypedDecimal>(UntypedValue.From(1.5m)).GetValue());
    [Fact] public void SmallIntegerTypesWiden() => Assert.Equal(5, Assert.IsType<UntypedInteger>(UntypedValue.From((byte)5)).GetValue());
    [Fact] public void ULongConvertsChecked() => Assert.Equal(9L, Assert.IsType<UntypedLong>(UntypedValue.From(9UL)).GetValue());

    // PSObject unwrapping is host behavior and is pinned where the real host exists: the
    // per-module runtime gate (tools/Test-WrapperModule.ps1) runs the full 19-case untyped
    // battery, including PSObject unwrapping, through the compiled module inside real
    // PowerShell. The PowerShellStandard stub's PSObject.BaseObject returns null, so a unit
    // test here would pass vacuously against the wrong assembly.

    [Fact]
    public void DictionaryConvertsAndDropsNullMembers()
    {
        var node = UntypedValue.From(new Hashtable { ["a"] = 1, ["b"] = null });
        var members = Assert.IsType<UntypedObject>(node).GetValue();
        Assert.Single(members);
        Assert.Equal(1, Assert.IsType<UntypedInteger>(members["a"]).GetValue());
    }

    [Fact]
    public void EmptyDictionaryYieldsNullMeaningOmit()
        => Assert.Null(UntypedValue.From(new Hashtable()));

    [Fact]
    public void ArrayConvertsAndDropsNullElements()
    {
        var node = UntypedValue.From(new object?[] { 1, null, "x" });
        var items = Assert.IsType<UntypedArray>(node).GetValue();
        Assert.Equal(2, System.Linq.Enumerable.Count(items));
    }

    [Fact]
    public void EmptyArrayYieldsNullMeaningOmit()
        => Assert.Null(UntypedValue.From(Array.Empty<object>()));

    [Fact]
    public void NestedStructuresConvert()
    {
        var node = UntypedValue.From(new Hashtable { ["outer"] = new Hashtable { ["inner"] = "v" } });
        var outer = Assert.IsType<UntypedObject>(node).GetValue();
        var inner = Assert.IsType<UntypedObject>(outer["outer"]).GetValue();
        Assert.Equal("v", Assert.IsType<UntypedString>(inner["inner"]).GetValue());
    }

    [Fact]
    public void UnsupportedTypeThrowsNamingTheType()
    {
        var ex = Assert.Throws<ArgumentException>(() => UntypedValue.From(new Uri("https://example")));
        Assert.Contains("System.Uri", ex.Message);
    }
}
