using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> EducationCmdletConfigurations =
    [
        // Education.md suppresses collection-reference DELETE, not item-reference DELETE.
        // v1.0 collision data already covers these; curated entries also cover beta and data-off runs.
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/education/classes/{}/assignments/{}/categories/$ref", Match: PathMatch.Exact, Value: null,
            Reason: "Education.md shared remove-path-by-operation; Education_directiveMigrationMap.json bridges both profiles"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/education/classes/{}/members/$ref", Match: PathMatch.Exact, Value: null,
            Reason: "Education.md shared remove-path-by-operation; Education_directiveMigrationMap.json bridges both profiles"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/education/classes/{}/teachers/$ref", Match: PathMatch.Exact, Value: null,
            Reason: "Education.md shared remove-path-by-operation; Education_directiveMigrationMap.json bridges both profiles"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/education/me/assignments/{}/categories/$ref", Match: PathMatch.Exact, Value: null,
            Reason: "Education.md shared remove-path-by-operation; Education_directiveMigrationMap.json bridges both profiles"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/education/schools/{}/classes/$ref", Match: PathMatch.Exact, Value: null,
            Reason: "Education.md shared remove-path-by-operation; Education_directiveMigrationMap.json bridges both profiles"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/education/schools/{}/users/$ref", Match: PathMatch.Exact, Value: null,
            Reason: "Education.md shared remove-path-by-operation; Education_directiveMigrationMap.json bridges both profiles"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/education/users/{}/assignments/{}/categories/$ref", Match: PathMatch.Exact, Value: null,
            Reason: "Education.md shared remove-path-by-operation; Education_directiveMigrationMap.json bridges both profiles"),
        new(OverrideKind.SuppressOperation, Method: null, "/education/classes/{}/assignments/{}/categories", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: the plain path ships nothing; the shipped surface is the $ref route"),
        new(OverrideKind.SuppressOperation, Method: null, "/education/users/{}/user", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: the user self-nav node ships nothing; its children (mailboxSettings) ship"),
    ];
}
