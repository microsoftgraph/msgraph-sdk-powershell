using System.Text.Json;
using openapiinfo;
public class OriginalMetadata
{
    private string url;
    private Lazy<IList<Model>> OpenApiInfo;
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
    public IList<Model> GetOpenApiInfo()
    {
        return OpenApiInfo.Value;
    }
}