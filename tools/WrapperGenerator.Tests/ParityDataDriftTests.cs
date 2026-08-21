using System;
using System.Diagnostics;
using System.IO;
using Xunit;

namespace WrapperGenerator.Tests;

// The checked-in parity-resolution data (tools/WrapperGenerator/data/parity-*.json) is derived
// FROM the frozen input ledger (data/parity-input-ledger.v1.0.csv, captured from a
// --no-collision-data generation) and the oracle by tools/Derive-ParityResolutions.ps1. This
// test shells out to the script's -Validate mode so drift between ledger, oracle and data
// fails the suite instead of depending on someone remembering to re-derive. Validation reads
// the frozen ledger, never the live artifacts tree: once the data is embedded the live tree
// has the renames applied, and deriving from it would validate the data against itself.
public sealed class ParityDataDriftTests
{
    [Fact]
    public void DerivedParityDataMatchesAFreshDerivation()
    {
        var scriptPath = Path.Combine(FindRepoRoot(), "tools", "Derive-ParityResolutions.ps1");
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
            "Checked-in parity-suppressions/renames JSON no longer matches a fresh derivation from " +
            "parity-input-ledger.v1.0.csv and the oracle. Re-run tools/Derive-ParityResolutions.ps1 " +
            $"(without -Validate) and commit the result.\n--- stdout ---\n{stdout}\n--- stderr ---\n{stderr}");
    }

    private static string FindRepoRoot()
    {
        var dir = AppContext.BaseDirectory;
        while (dir is not null && !File.Exists(Path.Combine(dir, "tools", "Derive-ParityResolutions.ps1")))
            dir = Path.GetDirectoryName(dir);
        return dir ?? throw new InvalidOperationException("Repo root not found from test base directory.");
    }
}
