namespace openapiinfo;

public static class FileHandler
{
    private const string OpenApiFolderName = "docs";
    private static string? AssemblyLocation = Path.GetDirectoryName(typeof(FileHandler).Assembly.Location);

    public static string? GetDocsFolder()
    {
        if (AssemblyLocation is null)
        {
            throw new InvalidOperationException("Assembly location is null.");
        }

        return Path.Combine(AssemblyLocation, $"../../../../../../{OpenApiFolderName}");
    }
}
