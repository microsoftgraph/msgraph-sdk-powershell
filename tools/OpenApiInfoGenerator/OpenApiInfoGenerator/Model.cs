namespace openapiinfo;
public class Model
{
   public PathInfo? PathInfo { get; set; }
   public MethodInfo? MethodInfo { get; set; }

}
public class PathInfo
{
    public string? Path { get; set; }
    public string? Module { get; set; }
}
public class MethodInfo
{
    public string? OperationId { get; set; }
    public string? Method { get; set; }
    public List<Parameters>? Parameters { get; set; }
}