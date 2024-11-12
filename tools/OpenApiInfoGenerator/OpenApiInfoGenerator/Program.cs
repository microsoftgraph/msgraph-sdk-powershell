using System.Text.Json;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

namespace openapiinfo;
internal class Program
{
    public static string openApiInfoFile = "openApiInfo.json";
    public static string openApiFileError = "openAPIErrors.csv";
    public static string duplicateOperationIdsFile = "duplicateOperationIds.csv";
    private const string openApiInfoMetadataUrl_v1 = "https://raw.githubusercontent.com/microsoftgraph/msgraph-sdk-powershell/dev/docs/OpenApiInfo/v1.0/openApiInfo.json";
    private const string openApiInfoMetadataUrl_beta = "https://raw.githubusercontent.com/microsoftgraph/msgraph-sdk-powershell/dev/docs/OpenApiInfo/beta/openApiInfo.json";
    private const string metadataJsonFile = "https://raw.githubusercontent.com/microsoftgraph/msgraph-sdk-powershell/refs/heads/dev/src/Authentication/Authentication/custom/common/MgCommandMetadata.json";
    private static IList<Model> openApiInfo_v1 = new OriginalMetadata(openApiInfoMetadataUrl_v1).GetOpenApiInfo();
    private static IList<Model> openApiInfo_beta = new OriginalMetadata(openApiInfoMetadataUrl_beta).GetOpenApiInfo();
    private static IList<CmdMetadata> cmdMetaData = new OriginalMetadata(metadataJsonFile, "cmdletmetadata").GetMetadataInfo();
    private static IDictionary<string, IList<Model>> openApiVersions = new Dictionary<string, IList<Model>>();
     public static Dictionary<string, string> operationIds =new ();
    public static HashSet<string> duplicateOperationIds = new();
    public static HashSet<string> opIdDetails = new();
    private static void Main(string[] args)
    {
        openApiVersions.Add("v1.0", openApiInfo_v1);
       // openApiVersions.Add("beta", openApiInfo_beta);

        foreach (var version in openApiVersions)
        {
            CompareOpenApiInfo(version.Key, version.Value);
        }
        
        // foreach (var v in operationIds)
        // {
        //     Console.WriteLine(v);
        // }

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
            File.Delete(errorPath);
        }
        if (openApiPath != null)
        {
            //Go through list of openapi files
            foreach (var file in Directory.GetFiles(openApiPath))
            {
                //Console.WriteLine($"Processing {file}");
                using (var sr = new StreamReader(file))
                {
                    var fileName = Path.GetFileNameWithoutExtension(file);
                    var openApiDoc = GetOpenApiStream(sr);

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
                            //Check if operationId already exists

                            if (operationIds.ContainsKey(operationId))
                            {
                                string duplicates = operationIds[operationId];
                                string[] dupList = duplicates.Split("**");
                                string duplicateOpId = operationId;
                                string dupModule = dupList[0];
                                string dupPath = dupList[1];
                                string dupMethod = dupList[2];
                                string dupFile = dupList[3];
                                var duplicate = duplicateOpId+"**"+dupModule+"**"+dupPath+"**"+dupMethod+"**"+dupFile+"**"+apiPath+"**"+method+"**"+fileName+"**"+file;
                                duplicateOperationIds.Add(duplicate);
                            }
                            else
                            {
                                var opIdDetails = fileName+"**"+apiPath+"**"+method+"**"+file;
                                operationIds.Add(operationId, opIdDetails);
                            }

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
        if (duplicateOperationIds.Count > 1)
        {
            foreach (var duplicate in duplicateOperationIds)
            {
                var dupList = duplicate.Split("**");
                //{duplicateOpId},{dupModule},{dupPath},{dupMethod},{dupFile},{apiPath},{method},{fileName},{file}");
                var report = $"{dupList[0]},{dupList[1]},{dupList[2]},{dupList[3]},{dupList[5]},{dupList[6]}";
                File.AppendAllText($"{openApiInfoPath}\\{duplicateOperationIdsFile}", report + Environment.NewLine);
                RemoveDuplicateOperationId(dupList[1],dupList[2],dupList[3],dupList[4],dupList[5],dupList[6], dupList[7], dupList[8]);

            }
        }

    }

    private static void RemoveDuplicateOperationId(string firstModule,string firstPath, string firstOperation, string firstFile, string secondPath, string secondOperation, string secondModule, string secondFile)
    {
        //Console.WriteLine($"First module: {firstModule}  FirstPath: {firstPath} First operation: {firstOperation} Second module: {secondModule} Second path: {secondPath} first file {firstFile} Second file: {secondFile}");
        try{
        bool firstModuleInfo = firstModuleInfoFound(firstModule, firstPath, firstOperation);
        //Check if the second path is available
        bool secondModuleInfo  = firstModuleInfoFound(secondModule, secondPath, secondOperation);
        string pathToRemove = secondPath;
        string fileToModify = secondFile;
        
        if(secondModuleInfo)
        {
            pathToRemove = firstPath;
            fileToModify = firstFile;
            //Console.WriteLine($"Removing path {pathToRemove} {firstModuleInfo} {file}");
        }
        // if(fileToModify.Equals("Get") || fileToModify.Equals("Post") || fileToModify.Equals("Patch") || fileToModify.Equals("Delete") || fileToModify.Equals("Put") || fileToModify.Equals("Invoke"))
        // {
        //     Console.WriteLine($"Removing path {pathToRemove} File to modify {fileToModify}");
        // }
        
            //The rest are new paths with duplicate operation ids and should be removed
            using (var sr = new StreamReader(fileToModify))
            {
                var openApiDoc = GetOpenApiStream(sr);
                if(openApiDoc.Paths.ContainsKey(pathToRemove))
                {
                    openApiDoc.Paths.Remove(pathToRemove);
                    var modified = openApiDoc.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
                    using (StreamWriter sw = new StreamWriter(fileToModify))
                    {
                        sw.Write(modified);
                    }   

                }
            }
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }   
        
    }

    private static bool firstModuleInfoFound(string module, string uri, string method){
        //Console.WriteLine($"Module: {module}, Path: {uri}, Method: {method}");
        var uriSegments = uri.Split('/');
        uriSegments[uriSegments.Length - 1] = uriSegments[uriSegments.Length - 1].Replace("microsoft.graph.", "").Replace("()", "");
        var newUri = string.Join("/", uriSegments);
        //Remove white spaces from beginning and end of uri
        newUri = newUri.Trim();
        module = module.Trim();
        method = method.Trim();

        //Console.WriteLine($"Module: {module}, Path: {newUri}, Method: {method}");
        var moduleInfo = cmdMetaData.Where(c => c.Module == module && c.Uri == newUri && c.Method == method.ToUpper()).ToList(); 
        if(moduleInfo.Count > 0){
            //Console.WriteLine($"Module: {module}, Path: {newUri}, Method: {method}");
            return true;
        }   
        return false;
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

    private static OpenApiDocument GetOpenApiStream(StreamReader sr)
    {
        var openApiDoc = new OpenApiStreamReader().Read(sr.BaseStream, out var diagnostic);
        if (diagnostic.Errors.Count > 0)
        {
            return null;
        }
        return openApiDoc;
    }
}