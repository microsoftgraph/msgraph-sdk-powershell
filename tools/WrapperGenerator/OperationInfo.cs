using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

// What the OData metadata says an operation is. Actions and functions are not CRUD over a
// resource but calls on one, which changes the verb, the request shape and the kiota member
// the call goes through, so the distinction travels with the operation rather than being
// re-inferred from the path at each use.
public enum OperationKind
{
    // Create/read/update/delete on a resource path.
    Resource,
    // x-ms-docs-operation-type: action — always POST, parameters in an inline request body.
    Action,
    // x-ms-docs-operation-type: function — always GET, parameters inline in the path segment.
    Function,
}

// The slice of one OpenAPI operation that Naming.Resolve consumes — kept to exactly the
// values it reads. Per-operation response and query bookkeeping lives with the generation
// service (GetOperationRecord), not here.
public sealed record OperationInfo(
    HttpMethod HttpMethod,
    string Path,
    // Raw OpenAPI header parameter names, for example "If-Match". Graph sometimes requires
    // these even where the spec marks them optional (Planner's PATCH/DELETE), so they become
    // real cmdlet parameters instead of being dropped.
    IReadOnlyList<string>? HeaderParams = null,
    OperationKind Kind = OperationKind.Resource);
