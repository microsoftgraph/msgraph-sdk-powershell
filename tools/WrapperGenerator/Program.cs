using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;

namespace WrapperGenerator;

// Entry point: loads an OpenAPI document from a file, applies --include-path filtering, builds
// the run configuration, and calls PowerShellWrapperGenerationService.GenerateAsync.
internal static class Program
{
    private static readonly JsonSerializerOptions LockFileJsonOptions = new() { WriteIndented = true };

    private static async Task<int> Main(string[] args)
    {
        string? specPath = null;
        string? outputPath = null;
        string? clientNamespace = null;
        var apiVersion = "v1.0";
        var useCollisionData = true;
        var includePaths = new List<string>();

        for (var i = 0; i < args.Length; i++)
        {
            switch (args[i])
            {
                case "-d" or "--openapi":
                    specPath = ArgValue(args, ref i);
                    break;
                case "-o" or "--output":
                    outputPath = ArgValue(args, ref i);
                    break;
                case "-n" or "--namespace" or "--namespace-name":
                    clientNamespace = ArgValue(args, ref i);
                    break;
                case "--api-version":
                    apiVersion = ArgValue(args, ref i);
                    break;
                case "--no-collision-data":
                    // Derivation mode: tools/Derive-CollisionResolutions.ps1 needs the raw
                    // collision inventory, so the derived resolutions must not mask it.
                    useCollisionData = false;
                    break;
                case "--include-path":
                    includePaths.Add(ArgValue(args, ref i));
                    break;
                case "-c" or "--class-name":
                    // Accepted for parity with the kiota command line; the emitter hardcodes the
                    // client type name, so this tool does not use it.
                    ArgValue(args, ref i);
                    break;
                default:
                    Console.Error.WriteLine($"Unknown argument: {args[i]}");
                    return 2;
            }
        }

        if (specPath is null || outputPath is null || clientNamespace is null)
        {
            Console.Error.WriteLine(
                "Usage: WrapperGenerator -d <openapi> -o <output> -n <namespace> [--api-version v1.0|beta] [--no-collision-data] [--include-path '<glob>#GET,POST' ...]");
            return 2;
        }

        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();

        await using var stream = File.OpenRead(specPath);
        var readResult = await OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None).ConfigureAwait(false);
        var document = readResult.Document
            ?? throw new InvalidOperationException($"Failed to parse an OpenAPI document from '{specPath}'.");

        IncludePathFilter.Apply(document, includePaths);

        var config = new GeneratorConfig(ClientNamespaceName: clientNamespace, OutputPath: outputPath,
            ApiVersion: apiVersion, UseCollisionData: useCollisionData);
        var service = new PowerShellWrapperGenerationService(document, config, new StderrLogger());
        await service.GenerateAsync(CancellationToken.None).ConfigureAwait(false);

        // The generation service writes only *.g.cs. Also write a minimal kiota-lock.json recording
        // the source spec path, so downstream tooling that keys off it — notably
        // tools/Compare-WrapperCmdletNames.ps1, which reads the v1.0/beta segment out of it to scope
        // its oracle join — can determine the API version.
        var lockJson = JsonSerializer.Serialize(new { descriptionLocation = specPath }, LockFileJsonOptions);
        await File.WriteAllTextAsync(Path.Combine(outputPath, "kiota-lock.json"), lockJson, CancellationToken.None).ConfigureAwait(false);

        var count = Directory.GetFiles(outputPath, "*.g.cs").Length;
        Console.WriteLine($"Generated {count} .g.cs file(s) to {outputPath}");
        return 0;
    }

    private static string ArgValue(string[] args, ref int i)
    {
        if (i + 1 >= args.Length)
            throw new ArgumentException($"Missing value after '{args[i]}'.");
        return args[++i];
    }
}
