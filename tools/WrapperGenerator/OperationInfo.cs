using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

// The slice of one OpenAPI operation that Naming.Resolve consumes — kept to exactly the
// values it reads. Per-operation response and query bookkeeping lives with the generation
// service (GetOperationRecord), not here.
public sealed record OperationInfo(
    HttpMethod HttpMethod,
    string Path,
    // Raw OpenAPI header parameter names, for example "If-Match". Graph sometimes requires
    // these even where the spec marks them optional (Planner's PATCH/DELETE), so they become
    // real cmdlet parameters instead of being dropped.
    IReadOnlyList<string>? HeaderParams = null);
