namespace Microsoft.Graph.Authentication.Test.Helpers
{
    using Microsoft.Graph.PowerShell.Authentication;
    using System;
    using Xunit;
    public class GraphSessionTests
    {
        [Fact]
        public void GraphSessionShouldBeInitilizedAfterInitializerIsCalled()
        {
            GraphSessionInitializer.InitializeSession();

            Assert.NotNull(GraphSession.Instance);
            Assert.Null(GraphSession.Instance.AuthContext);
        }
        
        [Fact]
        public void ShoudlOverwriteExistingGraphSession()
        {
            GraphSessionInitializer.InitializeSession();
            Guid originalSessionId = GraphSession.Instance._graphSessionId;

            GraphSession.Initialize(() => new GraphSession(), true);

            Assert.NotNull(GraphSession.Instance);
            Assert.NotEqual(GraphSession.Instance._graphSessionId, originalSessionId);
        } 
        
        [Fact]
        public void ShoudlNotOverwriteExistingGraphSession()
        {
            GraphSessionInitializer.InitializeSession();
            Guid originalSessionId = GraphSession.Instance._graphSessionId;

            GraphSession.Initialize(() => new GraphSession());

            Assert.NotNull(GraphSession.Instance);
            Assert.Equal(GraphSession.Instance._graphSessionId, originalSessionId);
        }
    }
}
