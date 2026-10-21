using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class ModuleContextCliTests
{
    [Theory]
    [InlineData("Compliance", false)]
    [InlineData("People", true)]
    public async Task ExplicitCliModuleReachesGenerationDespiteTheSameClientNamespace(string module, bool emitsDelete)
    {
        var root = Path.Combine(Path.GetTempPath(), "wrapper-module-context", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(root);
        try
        {
            var spec = Path.Combine(root, "input.yml");
            await File.WriteAllTextAsync(spec, """
                openapi: 3.0.0
                info:
                  title: Module context fixture
                  version: 1.0.0
                paths:
                  /compliance/ediscovery/cases/{case-id}/noncustodialDataSources/{source-id}/dataSource:
                    delete:
                      operationId: DeleteHistoricalDataSource
                      responses:
                        '204':
                          description: Deleted
                """, TestContext.Current.CancellationToken);
            var result = await Program.Main(["-d", spec, "-o", root, "-n", "Same.CollapsedNamespace.Client",
                "--module", module, "--api-version", "beta", "--no-collision-data"]);
            Assert.Equal(0, result);
            Assert.Equal(emitsDelete, File.Exists(Path.Combine(root, "RemoveMgComplianceEdiscoveryCaseNoncustodialDataSourceDataSource.g.cs")));
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    [Theory]
    [InlineData("DevicesServiceAnnouncement")]
    [InlineData("people")]
    [InlineData("")]
    public async Task InvalidCliModuleFailsBeforeReadingOrWritingFiles(string module)
    {
        Assert.Equal(2, await Program.Main(["-d", "does-not-exist.yml", "-o", "unused", "-n", "Test.Client", "--module", module]));
    }
}
