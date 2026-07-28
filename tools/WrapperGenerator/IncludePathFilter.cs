using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.OpenApi;

namespace WrapperGenerator;

// Trims the OpenAPI document to the requested paths/methods before generation (the generation
// service just walks whatever paths remain).
//
// Each --include-path is "<glob>#METHOD1,METHOD2" (the "#..." method list is optional). A path
// is kept if it matches any pattern's glob; on a kept path, only operations whose HTTP method
// is in that pattern's method set survive (methods are unioned across every pattern that
// matches the path, and a pattern with no "#..." keeps all methods). With no --include-path
// supplied, the document is left untouched — i.e. a cmdlet is generated for every operation,
// which is the "feed an already-filtered document" mode.
//
// Glob semantics, matched against the templated path keys (e.g. "/users/{user-id}/messages"):
//   **  -> any characters, including "/"
//   *   -> any run of non-"/" characters (stays within one segment)
//   [s] -> a character class, passed through to the regex (so "message[s]" matches "messages")
//   everything else (including "{", "}", "-") is matched literally
// This is intentionally minimal: it covers the operators the current include patterns use, not
// a full glob surface.
internal static class IncludePathFilter
{
    private sealed record Pattern(Regex PathRegex, HashSet<string> Methods);

    public static void Apply(OpenApiDocument document, IReadOnlyList<string> includePaths)
    {
        if (includePaths.Count == 0 || document.Paths is null)
            return;

        var patterns = includePaths.Select(Parse).ToList();

        foreach (var pathKey in document.Paths.Keys.ToList())
        {
            var allowedMethods = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var allowAllMethods = false;
            var matchedAny = false;

            foreach (var pattern in patterns)
            {
                if (!pattern.PathRegex.IsMatch(pathKey))
                    continue;
                matchedAny = true;
                if (pattern.Methods.Count == 0)
                    allowAllMethods = true;
                else
                    allowedMethods.UnionWith(pattern.Methods);
            }

            if (!matchedAny)
            {
                document.Paths.Remove(pathKey);
                continue;
            }

            if (allowAllMethods)
                continue;

            var operations = document.Paths[pathKey].Operations;
            if (operations is null)
                continue;
            foreach (var method in operations.Keys.ToList())
            {
                if (!allowedMethods.Contains(method.Method))
                    operations.Remove(method);
            }
        }
    }

    private static Pattern Parse(string includePath)
    {
        var hashIndex = includePath.IndexOf('#');
        var glob = hashIndex >= 0 ? includePath[..hashIndex] : includePath;
        var methodsPart = hashIndex >= 0 ? includePath[(hashIndex + 1)..] : string.Empty;

        var methods = methodsPart
            .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .ToHashSet(StringComparer.OrdinalIgnoreCase);

        return new Pattern(new Regex(GlobToRegex(glob), RegexOptions.IgnoreCase), methods);
    }

    private static string GlobToRegex(string glob)
    {
        var sb = new StringBuilder("^");
        for (var i = 0; i < glob.Length; i++)
        {
            var c = glob[i];
            switch (c)
            {
                case '*' when i + 1 < glob.Length && glob[i + 1] == '*':
                    sb.Append(".*");
                    i++;
                    break;
                case '*':
                    sb.Append("[^/]*");
                    break;
                case '[':
                case ']':
                    sb.Append(c); // pass a glob character class straight through to the regex
                    break;
                default:
                    sb.Append(Regex.Escape(c.ToString()));
                    break;
            }
        }
        sb.Append('$');
        return sb.ToString();
    }
}
