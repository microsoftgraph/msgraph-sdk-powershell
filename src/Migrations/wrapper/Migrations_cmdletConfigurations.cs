using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> MigrationsCmdletConfigurations =
    [
        new(OverrideKind.StripNounPrefix, null, "/solutions/migrations/crosstenantmigrationjobs", PathMatch.Exact, "Migration",
            "Migrations.md directive 1: CrossTenantMigrationJob$2; the existing Solution strip runs first"),
        new(OverrideKind.StripNounPrefix, null, "/solutions/migrations/crosstenantmigrationjobs/", PathMatch.Prefix, "Migration",
            "Migrations.md directive 1: retain the job/user suffix after removing SolutionMigration"),

        new(OverrideKind.SuppressOperation, null, "/solutions/migrations", PathMatch.Exact, null,
            "Migrations.md directive 2: SolutionMigration root"),
        new(OverrideKind.SuppressOperation, null, "/solutions/migrations/crosstenantmigrationjobs(displayname='{}')", PathMatch.Exact, null,
            "Migrations.md directive 2: DisplayName alternate-key GET/PATCH/DELETE"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/solutions/migrations/crosstenantmigrationjobs(displayname='{}')/cancel", PathMatch.Exact, null,
            "Migrations.md directive 2: DisplayName alternate-key cancel"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/solutions/migrations/crosstenantmigrationjobs(displayname='{}')/migrate", PathMatch.Exact, null,
            "Migrations.md directive 2: DisplayName alternate-key migrate"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/solutions/migrations/crosstenantmigrationjobs(displayname='{}')/validate", PathMatch.Exact, null,
            "Migrations.md directive 2: DisplayName alternate-key validate"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/solutions/migrations/crosstenantmigrationjobs/$count", PathMatch.Exact, null,
            "Migrations.md directive 2: Count"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/solutions/migrations/crosstenantmigrationjobs/{}/users/$count", PathMatch.Exact, null,
            "Migrations.md directive 2: Count"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/solutions/migrations/crosstenantmigrationjobs/{}/users/{}", PathMatch.Exact, null,
            "Migrations.md directive 3: only jobs can be removed"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/solutions/migrations/crosstenantmigrationjobs/{}/users", PathMatch.Exact, null,
            "Migrations.md directive 4: New-CrossTenantMigrationJobUser is unsupported"),
        new(OverrideKind.SuppressOperation, HttpMethod.Patch, "/solutions/migrations/crosstenantmigrationjobs/{}/users/{}", PathMatch.Exact, null,
            "Migrations.md directive 4: Update-CrossTenantMigrationJobUser is unsupported"),

        // AutoRest supplies these semantic action names independently of the subject rename.
        // Pin the exact beta.Migrations oracle routes rather than duplicating structural CRUD names.
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/solutions/migrations/crosstenantmigrationjobs/{}/cancel", PathMatch.Exact, "CrossTenantMigrationJob",
            "oracle beta.Migrations: Stop-MgBetaCrossTenantMigrationJob"),
        new(OverrideKind.ReplaceVerb, HttpMethod.Post, "/solutions/migrations/crosstenantmigrationjobs/{}/cancel", PathMatch.Exact, "Stop",
            "oracle beta.Migrations: Stop-MgBetaCrossTenantMigrationJob"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/solutions/migrations/crosstenantmigrationjobs/{}/migrate", PathMatch.Exact, "CrossTenantMigrationJob",
            "oracle beta.Migrations: Move-MgBetaCrossTenantMigrationJob"),
        new(OverrideKind.ReplaceVerb, HttpMethod.Post, "/solutions/migrations/crosstenantmigrationjobs/{}/migrate", PathMatch.Exact, "Move",
            "oracle beta.Migrations: Move-MgBetaCrossTenantMigrationJob"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/solutions/migrations/crosstenantmigrationjobs/{}/validate", PathMatch.Exact, "CrossTenantMigrationJob",
            "oracle beta.Migrations: Test-MgBetaCrossTenantMigrationJob"),
        new(OverrideKind.ReplaceVerb, HttpMethod.Post, "/solutions/migrations/crosstenantmigrationjobs/{}/validate", PathMatch.Exact, "Test",
            "oracle beta.Migrations: Test-MgBetaCrossTenantMigrationJob"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/solutions/migrations/crosstenantmigrationjobs/{}/users/{}/cancel", PathMatch.Exact, "CrossTenantMigrationJobUser",
            "oracle beta.Migrations: Stop-MgBetaCrossTenantMigrationJobUser"),
        new(OverrideKind.ReplaceVerb, HttpMethod.Post, "/solutions/migrations/crosstenantmigrationjobs/{}/users/{}/cancel", PathMatch.Exact, "Stop",
            "oracle beta.Migrations: Stop-MgBetaCrossTenantMigrationJobUser"),
    ];
}
