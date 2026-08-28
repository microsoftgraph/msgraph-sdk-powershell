using System;
using System.Diagnostics;
using System.IO;
using Xunit;

namespace WrapperGenerator.Tests;

// The checked-in collision-resolution data (tools/WrapperGenerator/data/collision-*.json) is
// derived FROM tools/WrapperGenerator/data/collision-inventory.v1.0.txt and the oracle
// (MgCommandMetadata.json) by tools/Derive-CollisionResolutions.ps1. Nothing else enforces
// that the checked-in files still match a fresh derivation — there is no CI pipeline for this
// project yet (tracked separately) — so this test is the drift gate: it shells out to the
// script's -Validate mode as part of the normal `dotnet test` run, the same command a human
// would run by hand, so staleness fails the suite instead of depending on someone remembering
// to run it.
public sealed class CollisionDataDriftTests
{
    [Fact]
    public void DerivedCollisionDataMatchesAFreshDerivation()
    {
        var scriptPath = Path.Combine(FindRepoRoot(), "tools", "Derive-CollisionResolutions.ps1");
        Assert.True(File.Exists(scriptPath), $"Derivation script not found at '{scriptPath}'.");

        var psi = new ProcessStartInfo("pwsh")
        {
            ArgumentList = { "-NoProfile", "-NonInteractive", "-File", scriptPath, "-Validate" },
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
        };
        using var process = Process.Start(psi) ?? throw new InvalidOperationException("Failed to start pwsh.");
        var stdout = process.StandardOutput.ReadToEnd();
        var stderr = process.StandardError.ReadToEnd();
        process.WaitForExit();

        Assert.True(process.ExitCode == 0,
            "Checked-in collision-suppressions/renames JSON no longer matches a fresh derivation from " +
            "collision-inventory.v1.0.txt and the oracle. Re-run tools/Derive-CollisionResolutions.ps1 " +
            $"(without -Validate) and commit the result.\n--- stdout ---\n{stdout}\n--- stderr ---\n{stderr}");
    }

    private static string FindRepoRoot()
    {
        // .git is a directory in a normal checkout and a FILE (a gitdir pointer) in a linked
        // worktree; accepting only the directory made this test fail in every worktree.
        var dir = new DirectoryInfo(AppContext.BaseDirectory);
        while (dir is not null
            && !Directory.Exists(Path.Combine(dir.FullName, ".git"))
            && !File.Exists(Path.Combine(dir.FullName, ".git")))
            dir = dir.Parent;
        return dir?.FullName ?? throw new InvalidOperationException("Could not locate repo root (.git) from " + AppContext.BaseDirectory);
    }
}
