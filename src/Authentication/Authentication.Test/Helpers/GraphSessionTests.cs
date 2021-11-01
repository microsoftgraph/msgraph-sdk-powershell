using Microsoft.Graph.PowerShell.Authentication.Common;
using Microsoft.Graph.PowerShell.Authentication.Models;

using Xunit.Abstractions;

namespace Microsoft.Graph.Authentication.Test.Helpers
{
    using Microsoft.Graph.PowerShell.Authentication;

    using System;

    using Xunit;
    public class GraphSessionTests
    {
        private readonly ITestOutputHelper _helper;

        public GraphSessionTests(ITestOutputHelper helper)
        {
            _helper = helper;
        }
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
        [Fact]
        public void ShouldThrowExceptionWhenOutputIsNotInitialized()
        {
            GraphSession.Initialize(() => new GraphSession());
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => GraphSession.Instance.OutputWriter.WriteObject("Output"));

            Assert.NotNull(GraphSession.Instance);
            Assert.Null(GraphSession.Instance.AuthContext);

            // reset static instance.
            GraphSession.Reset();
        }
        [Fact]
        public void ShouldInitializeOutputWriter()
        {
            GraphSessionInitializer.InitializeSession();
            GraphSessionInitializer.InitializeOutput(new PsGraphOutputWriter
            {
                WriteError = (exception1, s, arg3, arg4) => _helper.WriteLine(exception1.Message),
                WriteObject = _helper.WriteLine,
                WriteDebug = _helper.WriteLine,
                WriteInformation = (o, s) => _helper.WriteLine(s),
                WriteVerbose = _helper.WriteLine
            });
            GraphSession.Instance.OutputWriter.WriteObject("Output");

            Assert.NotNull(GraphSession.Instance.OutputWriter);
            Assert.NotNull(GraphSession.Instance.OutputWriter.WriteObject);

            // reset static instance.
            GraphSession.Reset();
        }
    }
}
