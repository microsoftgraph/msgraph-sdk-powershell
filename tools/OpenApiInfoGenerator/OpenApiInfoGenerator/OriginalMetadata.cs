using System.Text.Json;
using openapiinfo;
public class OriginalMetadata
{
    private string url;
    private Lazy<IList<Model>> OpenApiInfo;
    private Lazy<IList<CmdMetadata>> MetadataInfo;
    public OriginalMetadata(string endpoint)
    {
        url = endpoint;
        Lazy<IList<Model>> OpenApiInfo = new(
            () =>
            {
                using var httpClient = new HttpClient();
                Uri uri = new Uri(url);
                using var stream = httpClient.GetStreamAsync(uri).GetAwaiter().GetResult();
                var result = JsonSerializer.Deserialize<IList<Model>>(stream);
                return result ?? new List<Model>(); // Add null check and return an empty list if result is null
            },
            LazyThreadSafetyMode.PublicationOnly
        );
        this.OpenApiInfo = OpenApiInfo;
    }
    public OriginalMetadata(string endpoint, string cmdletmetadata)
    {
        url = endpoint;
        Lazy<IList<CmdMetadata>> MetadataInfo = new(
            () =>
            {
                using var httpClient = new HttpClient();
                Uri uri = new Uri(url);
                using var stream = httpClient.GetStreamAsync(uri).GetAwaiter().GetResult();
                var result = JsonSerializer.Deserialize<IList<CmdMetadata>>(stream);
                return result ?? new List<CmdMetadata>(); // Add null check and return an empty list if result is null
            },
            LazyThreadSafetyMode.PublicationOnly
        );
        this.MetadataInfo = MetadataInfo;
    }
    public IList<Model> GetOpenApiInfo()
    {
        return OpenApiInfo.Value;
    }
    public IList<CmdMetadata> GetMetadataInfo()
    {
        return MetadataInfo.Value;
    }
}