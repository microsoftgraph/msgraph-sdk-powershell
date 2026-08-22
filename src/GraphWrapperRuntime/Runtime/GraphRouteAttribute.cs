#nullable enable

using System;

namespace Microsoft.Graph.Wrapper.Runtime
{
    // The Graph operation each cmdlet was generated from, carried into the compiled assembly so
    // verification tooling reads the operation's identity from the build output rather than
    // reconstructing it from the builder expression. That reconstruction is lossy for a function
    // (the builder member keeps the argument names but not the OData argument syntax) and wrong
    // for a namespace-qualified action (kiota keeps the qualifier, the route does not).
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class GraphRouteAttribute : Attribute
    {
        public GraphRouteAttribute(string method, string path)
        {
            Method = method;
            Path = path;
        }

        public string Method { get; }

        public string Path { get; }
    }
}
