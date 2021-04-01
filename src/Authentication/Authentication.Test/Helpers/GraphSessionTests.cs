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
            GraphSession.Initialize(() => new GraphSession());

            Assert.NotNull(GraphSession.Instance);
            Assert.Null(GraphSession.Instance.AuthContext);

            // reset static instance.
            GraphSession.Reset();
        }
        
        [Fact]
        public void ShouldOverwriteExistingGraphSession()
        {
            GraphSession.Initialize(() => new GraphSession());
            Guid originalSessionId = GraphSession.Instance._graphSessionId;

            GraphSession.Initialize(() => new GraphSession(), true);

            Assert.NotNull(GraphSession.Instance);
            Assert.NotEqual(originalSessionId, GraphSession.Instance._graphSessionId);

            // reset static instance.
            GraphSession.Reset();
        } 
        
        [Fact]
        public void ShouldNotOverwriteExistingGraphSession()
        {
            GraphSession.Initialize(() => new GraphSession());
            Guid originalSessionId = GraphSession.Instance._graphSessionId;

            GraphSession.Initialize(() => new GraphSession());

            Assert.NotNull(GraphSession.Instance);
            Assert.Equal(originalSessionId, GraphSession.Instance._graphSessionId);

            // reset static instance.
            GraphSession.Reset();
        }

        [Fact]
        public void ShouldThrowExceptionWhenSessionIsNotInitialized()
        {
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => GraphSession.Instance);

            Assert.Equal(PowerShell.Authentication.Core.ErrorConstants.Codes.SessionNotInitialized, exception.Message);

            // reset static instance.
            GraphSession.Reset();
        }
    }
}
