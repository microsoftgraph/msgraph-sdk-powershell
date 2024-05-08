using System.Text.Json;
using Microsoft.OpenApi.Readers;

namespace openapiinfo;
internal class Program
{
    public static string openApiInfoFile = "openApiInfo.json";
    public static string openApiFileError = "openAPIErrors.csv";
    private const string openApiInfoMetadataUrl_v1 = "https://raw.githubusercontent.com/microsoftgraph/msgraph-sdk-powershell/metadata-changes-detection/docs/OpenApiInfo/v1.0/openApiInfo.json";
    private const string openApiInfoMetadataUrl_beta = "https://raw.githubusercontent.com/microsoftgraph/msgraph-sdk-powershell/metadata-changes-detection/docs/OpenApiInfo/beta/openApiInfo.json";
    private static IList<Model> openApiInfo_v1 = new OriginalMetadata(openApiInfoMetadataUrl_v1).GetOpenApiInfo();
    private static IList<Model> openApiInfo_beta = new OriginalMetadata(openApiInfoMetadataUrl_beta).GetOpenApiInfo();
    private static IDictionary<string, IList<Model>> openApiVersions = new Dictionary<string, IList<Model>>();
    private static void Main(string[] args)
    {
        openApiVersions.Add("v1.0", openApiInfo_v1);
        openApiVersions.Add("beta", openApiInfo_beta);

        foreach (var version in openApiVersions)
        {
            CompareOpenApiInfo(version.Key, version.Value);
        }

    }

    private static void CompareOpenApiInfo(string version, IList<Model> openApiInfoMetadata)
    {
        var models = new HashSet<Model>();
        var newPathsAdded = new HashSet<string>();
        var openApiErrors = new HashSet<string>();
        newPathsAdded.Add("Module,Path,Method");
        openApiErrors.Add("Module,ApiPath,Method,From,To");
        var openApiFilePath = FileHandler.GetOpenApiFolder();
        var docPath = FileHandler.GetDocFolder();
        var openApiPath = openApiFilePath != null ? Path.Combine(openApiFilePath, version) : null;

        var combinedDocPath = docPath != null ? Path.Combine(docPath, "OpenAPiInfo") : null;
        var openApiInfoPath = combinedDocPath != null ? Path.Combine(combinedDocPath, version) : null;

        var errorPath = openApiInfoPath != null ? Path.Combine(openApiInfoPath, openApiFileError) : null;
        if (errorPath != null && File.Exists(errorPath))
        {
            File.WriteAllText(errorPath, string.Empty);
        }
        if (openApiPath != null)
        {
            //Go through list of openapi files
            foreach (var file in Directory.GetFiles(openApiPath))
            {
                using (var sr = new StreamReader(file))
                {
                    var fileName = Path.GetFileNameWithoutExtension(file);
                    var openApiDoc = new OpenApiStreamReader().Read(sr.BaseStream, out var diagnostic);
                    if (diagnostic.Errors.Count > 0)
                    {
                        throw new Exception($"Error reading openapi file {file}");
                    }

                    //Go through each path in the openapi file
                    foreach (var path in openApiDoc.Paths)
                    {
                        //Go through each operation in the path
                        foreach (var operation in path.Value.Operations)
                        {
                            var model = new Model();

                            var pathInfo = new PathInfo();
                            //Get the path key
                            var apiPath = path.Key;
                            pathInfo.Path = apiPath;
                            pathInfo.Module = fileName;
                            model.PathInfo = pathInfo;
                            var methodInfo = new MethodInfo();
                            //Get the operationId
                            var operationId = operation.Value.OperationId;
                            methodInfo.OperationId = operationId.ToString();

                            //Get the method
                            var method = operation.Key.ToString();
                            methodInfo.Method = method.ToString();
                            //Console.WriteLine("here" + methodInfo.Method);
                            //Get the parameters
                            var parameters = new List<Parameters>();
                            foreach (var parameter in operation.Value.Parameters)
                            {
                                var param = new Parameters();
                                param.Name = parameter.Name.ToString() ?? "NA";
                                param.Location = parameter.In.ToString() ?? "NA";
                                parameters.Add(param);
                            }
                            methodInfo.Parameters = parameters;
                            model.MethodInfo = methodInfo;

                            var originalPathDetails = PathDetails(openApiInfoMetadata, operationId, apiPath, method, fileName);
                            if (originalPathDetails == null || originalPathDetails.PathInfo == null)
                            {
                                newPathsAdded.Add($"{fileName},{apiPath},{method}");
                                continue;
                            }
                            if (originalPathDetails.MethodInfo != null && originalPathDetails.MethodInfo.Parameters != null && originalPathDetails.MethodInfo.Parameters.Count > methodInfo.Parameters.Count)
                            {
                                openApiErrors.Add($"{fileName},{apiPath}, {method},Parameter Count: {originalPathDetails.MethodInfo.Parameters.Count},Parameter Count: {methodInfo.Parameters.Count}");
                            }

                            if (originalPathDetails.MethodInfo != null && originalPathDetails.MethodInfo.OperationId != methodInfo.OperationId)
                            {
                                openApiErrors.Add($"{fileName},{apiPath}, {method},OperationId changed from: {originalPathDetails.MethodInfo.OperationId}, OperationId changed to: {methodInfo.OperationId}");
                            }

                            models.Add(model);

                        }



                    }
                }
            }
        }
        //convert list to json and add it to file
        if (newPathsAdded.Count > 1)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(models, options);
            //Clear file first
            File.WriteAllText($"{openApiInfoPath}\\{openApiInfoFile}", string.Empty);
            //then write to it with new content.
            File.WriteAllText($"{openApiInfoPath}\\{openApiInfoFile}", json);
        }
        if (openApiErrors.Count > 1)
        {
            foreach (var error in openApiErrors)
            {
                var errList = error.Split(",");
                var report = $"{errList[0]},{errList[1]},{errList[2]},{errList[3]},{errList[4]}";
                File.AppendAllText($"{openApiInfoPath}\\{openApiFileError}", report + Environment.NewLine);
            }
        }

    }
    private static Model PathDetails(IList<Model> openApiInfo, string operationId, string apiPath, string method, string module)
    {
        if (openApiInfo == null || openApiInfo.Count == 0)
        {
            throw new Exception("OpenApiInfo is empty");
        }

        var matchedPaths = openApiInfo.Where(c => c.MethodInfo != null && c.MethodInfo.Method == method
            && c.PathInfo != null && c.PathInfo.Path == apiPath && c.PathInfo.Module == module).ToList();
        var pathDetails = matchedPaths.FirstOrDefault();

        return pathDetails ?? new Model();
    }
}