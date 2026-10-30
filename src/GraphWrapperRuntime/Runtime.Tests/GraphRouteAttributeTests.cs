using System;
using System.Linq;
using System.Reflection;

using Microsoft.Graph.Wrapper.Runtime;
using Xunit;

namespace Microsoft.Graph.Wrapper.Runtime.Tests;

public sealed class GraphRouteAttributeTests
{
    [Fact]
    public void ExistingWorkerRetainsSingleRouteWithoutParameterSet()
    {
        var route = Assert.Single(typeof(Worker).GetCustomAttributes<GraphRouteAttribute>());
        Assert.Equal("GET", route.Method);
        Assert.Equal("/items/{item-id}", route.Path);
        Assert.Null(route.ParameterSetName);
    }

    [Fact]
    public void DispatcherExposesEveryRouteAndItsParameterSet()
    {
        var routes = typeof(Dispatcher).GetCustomAttributes<GraphRouteAttribute>().ToArray();
        Assert.Equal(2, routes.Length);
        Assert.Contains(routes, route => route.Method == "GET" && route.Path == "/items"
            && route.ParameterSetName == "List");
        Assert.Contains(routes, route => route.Method == "GET" && route.Path == "/parents/{parent-id}/items"
            && route.ParameterSetName == "ListViaParent");
    }

    [Fact]
    public void CustomAttributeDataRetainsConstructorArgumentsForEachRoute()
    {
        var routes = typeof(Dispatcher).GetCustomAttributesData()
            .Where(attribute => attribute.AttributeType == typeof(GraphRouteAttribute)).ToArray();
        Assert.Equal(2, routes.Length);
        Assert.All(routes, route =>
        {
            Assert.Equal("GET", route.ConstructorArguments[0].Value);
            Assert.IsType<string>(route.ConstructorArguments[1].Value);
            Assert.Equal(nameof(GraphRouteAttribute.ParameterSetName), Assert.Single(route.NamedArguments).MemberName);
        });
    }

    [Fact]
    public void LegacyDispatcherCanHaveNoRouteMetadata()
        => Assert.Empty(typeof(LegacyDispatcher).GetCustomAttributes<GraphRouteAttribute>());

    [GraphRoute("GET", "/items/{item-id}")]
    private sealed class Worker { }

    [GraphRoute("GET", "/items", ParameterSetName = "List")]
    [GraphRoute("GET", "/parents/{parent-id}/items", ParameterSetName = "ListViaParent")]
    private sealed class Dispatcher { }

    private sealed class LegacyDispatcher { }
}
