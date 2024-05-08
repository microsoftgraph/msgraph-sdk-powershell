namespace openapiinfo;

public static class FileHandler
{
    private const string OpenApiFolderName = "OpenApiDocs";
    private const string DocFolderName = "docs";
    private static string? AssemblyLocation = Path.GetDirectoryName(typeof(FileHandler).Assembly.Location);

    public static string? GetOpenApiFolder()
    {
        if (AssemblyLocation is null)
        {
            throw new InvalidOperationException("Assembly location is null.");
        }

        return Path.Combine(AssemblyLocation, $"../../../../../../{OpenApiFolderName}");
    }
    public static string? GetDocFolder()
    {
        if (AssemblyLocation is null)
        {
            throw new InvalidOperationException("Assembly location is null.");
        }

        return Path.Combine(AssemblyLocation, $"../../../../../../{DocFolderName}");
    }
}
