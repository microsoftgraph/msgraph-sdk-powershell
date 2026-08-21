#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Microsoft.Graph.Wrapper.Runtime
{
    // Converts a PowerShell value to the kiota UntypedNode a schema-less property expects.
    // Such a property has no type in the spec, so there is nothing to bind against; taking
    // object and converting here lets the caller write -Maximum 100 or
    // -ContentInfo @{ a = 1 } instead of constructing an UntypedNode subclass by hand.
    //
    // Null and empty objects yield null, meaning "omit this property", matching the published
    // SDK: its AddIf helper adds a value only when it is non-null and not an empty JSON object,
    // so a null was never sent on the wire and clearing a field this way was never possible.
    public static class UntypedValue
    {
        public static UntypedNode? From(object? value)
        {
            // PowerShell hands parameters over wrapped; the wrapper is not the value.
            if (value is PSObject psObject)
                value = psObject.BaseObject;

            switch (value)
            {
                case null:
                    return null;
                case string s:
                    return new UntypedString(s);
                case bool b:
                    return new UntypedBoolean(b);
                case int i:
                    return new UntypedInteger(i);
                case long l:
                    return new UntypedLong(l);
                case float f:
                    return new UntypedFloat(f);
                case double d:
                    return new UntypedDouble(d);
                case decimal m:
                    return new UntypedDecimal(m);
                case byte or sbyte or short or ushort or uint:
                    return new UntypedInteger(Convert.ToInt32(value));
                case ulong ul:
                    return new UntypedLong(checked((long)ul));
                case IDictionary dictionary:
                    {
                        var members = new Dictionary<string, UntypedNode>(StringComparer.Ordinal);
                        foreach (DictionaryEntry entry in dictionary)
                        {
                            var key = entry.Key?.ToString();
                            if (key is null)
                                continue;
                            // Dropped, not sent. The published SDK has no untyped bag to copy
                            // here, so this extends its top-level rule rather than inheriting it.
                            var member = From(entry.Value);
                            if (member is not null)
                                members[key] = member;
                        }
                        return members.Count == 0 ? null : new UntypedObject(members);
                    }
                case IEnumerable sequence:
                    {
                        var items = new List<UntypedNode>();
                        foreach (var item in sequence)
                        {
                            var node = From(item);
                            if (node is not null)
                                items.Add(node);
                        }
                        return items.Count == 0 ? null : new UntypedArray(items);
                    }
                default:
                    // Stringifying an unrecognised type would send a value the caller never
                    // wrote; failing names the type so the gap is fixable.
                    throw new ArgumentException(
                        $"Cannot convert a value of type '{value.GetType().FullName}' to an untyped Graph value. Supported: string, boolean, number, hashtable, array.");
            }
        }
    }
}
