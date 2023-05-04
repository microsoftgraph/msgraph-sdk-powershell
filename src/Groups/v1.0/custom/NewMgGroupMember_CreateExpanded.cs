﻿namespace Microsoft.Graph.PowerShell.Cmdlets
{
    using static Microsoft.Graph.PowerShell.Runtime.Extensions;
    using System;

    /// <summary>Add a member to an Office 365 group or security group through the members navigation property.</summary>
    /// <remarks>
    /// </remarks>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"MgGroupMember_CreateExpanded", SupportsShouldProcess = true)]
    [System.Management.Automation.OutputType(typeof(Models.IMicrosoftGraphDirectoryObject))]
    [global::Microsoft.Graph.PowerShell.Description(@"Add a member to an Office 365 group or security group through the members navigation property.")]
    [global::Microsoft.Graph.PowerShell.Generated]
    public partial class NewMgGroupMember_CreateExpanded : System.Management.Automation.PSCmdlet,
        Runtime.IEventListener
    {

        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private System.Threading.CancellationTokenSource _cancellationTokenSource = new System.Threading.CancellationTokenSource();

        /// <summary>Dictionary of <any></summary>
        private Microsoft.Graph.PowerShell.Models.IReferenceCreate _bodyParameter = new Microsoft.Graph.PowerShell.Models.ReferenceCreate();

        /// <summary>Wait for .NET debugger to attach</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Groups Client => Module.Instance.ClientAPI;

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private string _groupId;

        /// <summary>key: group-id of group</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "key: group-id of group")]
        [Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"key: group-id of group",
        SerializedName = @"group-id",
        PossibleTypes = new[] { typeof(string) })]
        [Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Path)]
        public string GroupId { get => this._groupId; set => this._groupId = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [System.Management.Automation.ValidateNotNull]
        [Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [System.Management.Automation.ValidateNotNull]
        [Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Body)]
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"id of directoryObject",
        SerializedName = @"id",
        PossibleTypes = new[] { typeof(string) })]
        public string DirectoryObjectId { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation; set { __invocationInfo = value; } }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        System.Action Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        System.Threading.CancellationToken Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// The instance of the <see cref="Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [System.Management.Automation.ValidateNotNull]
        [Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>
        /// <c>overrideOnCreated</c> will be called before the regular onCreated has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Models.IMicrosoftGraphDirectoryObject"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onCreated method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnCreated(System.Net.Http.HttpResponseMessage responseMessage, System.Threading.Tasks.Task<Models.IMicrosoftGraphDirectoryObject> response, ref System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Models.IMicrosoftGraphODataErrorsOdataError" /> from the remote
        /// call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(System.Net.Http.HttpResponseMessage responseMessage, System.Threading.Tasks.Task<Models.IMicrosoftGraphODataErrorsOdataError> response, ref System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Graph.PowerShell.Runtime.AttachDebugger.Break();
            }
            ((Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletBeginProcessing).Wait(); if (((Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletEndProcessing).Wait(); if (((Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is canceled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
        async System.Threading.Tasks.Task Runtime.IEventListener.Signal(string id, System.Threading.CancellationToken token, System.Func<Runtime.EventData> messageData)
        {
            using (NoSynchronizationContext)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }

                switch (id)
                {
                    case Microsoft.Graph.PowerShell.Runtime.Events.Verbose:
                        {
                            WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                            return;
                        }
                    case Microsoft.Graph.PowerShell.Runtime.Events.Warning:
                        {
                            WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                            return;
                        }
                    case Microsoft.Graph.PowerShell.Runtime.Events.Information:
                        {
                            var data = messageData();
                            WriteInformation(data, new[] { data.Message });
                            return;
                        }
                    case Microsoft.Graph.PowerShell.Runtime.Events.Debug:
                        {
                            WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                            return;
                        }
                    case Microsoft.Graph.PowerShell.Runtime.Events.Error:
                        {
                            WriteError(new System.Management.Automation.ErrorRecord(new System.Exception(messageData().Message), string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null));
                            return;
                        }
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewMgGroupMember_CreateExpanded" /> cmdlet class.
        /// </summary>
        public NewMgGroupMember_CreateExpanded()
        {

        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletProcessRecordStart).Wait(); if (((Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }
            try
            {
                // work
                if (ShouldProcess($"Call remote 'CreateGroupMember' operation"))
                {
                    using (var asyncCommandRuntime = new Runtime.PowerShell.AsyncCommandRuntime(this, ((Runtime.IEventListener)this).Token))
                    {
                        asyncCommandRuntime.Wait(ProcessRecordAsync(), ((Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach (var innerException in aggregateException.Flatten().InnerExceptions)
                {
                    ((Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if (((Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }
                    // Write exception out to error channel.
                    WriteError(new System.Management.Automation.ErrorRecord(innerException, string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null));
                }
            }
            catch (System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException) == null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if (((Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }
                // Write exception out to error channel.
                WriteError(new System.Management.Automation.ErrorRecord(exception, string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null));
            }
            finally
            {
                ((Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using (NoSynchronizationContext)
            {
                await ((Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletProcessRecordAsyncStart); if (((Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }
                await ((Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletGetPipeline); if (((Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }
                Pipeline = Microsoft.Graph.PowerShell.Module.Instance.CreatePipeline(InvocationInformation);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletBeforeAPICall); if (((Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }
                    _bodyParameter.OdataId = $"https://graph.microsoft.com/v1.0/directoryObjects/{DirectoryObjectId}";
                    await this.Client.GroupCreateMemberGraphBPreRef(GroupId, _bodyParameter, onNoContent, onDefault, this, Pipeline);
                    await ((Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletAfterAPICall); if (((Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }
                }
                catch (Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new { GroupId = GroupId, body = _bodyParameter })
                    {
                        ErrorDetails = new System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Graph.PowerShell.Models.IMicrosoftGraphODataErrorsOdataError">Microsoft.Graph.PowerShell.Models.IMicrosoftGraphODataErrorsOdataError</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Graph.PowerShell.Models.IMicrosoftGraphODataErrorsOdataError> response)
        {
            using (NoSynchronizationContext)
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnDefault(responseMessage, response, ref _returnNow);
                // if overrideOnDefault has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return;
                }
                // Error Response : default
                var code = (await response)?.Error?.Code;
                var message = (await response)?.Error?.Message;
                if ((null == code || null == message))
                {
                    // Unrecognized Response. Create an error record based on what we have.
                    var ex = new Microsoft.Graph.PowerShell.Runtime.RestException<Microsoft.Graph.PowerShell.Models.IMicrosoftGraphODataErrorsOdataError>(responseMessage, await response);
                    WriteError(new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new { GroupId = GroupId, body = _bodyParameter })
                    {
                        ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                    });
                }
                else
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{code}] : {message}"), code?.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { GroupId = GroupId, body = _bodyParameter })
                    {
                        ErrorDetails = new global::System.Management.Automation.ErrorDetails(message) { RecommendedAction = global::System.String.Empty }
                    });
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 204 (NoContent).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onNoContent(global::System.Net.Http.HttpResponseMessage responseMessage)
        {
            using (NoSynchronizationContext)
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                // if overrideOnNoContent has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return;
                }
                // onNoContent - response for 204 /
                if (true == MyInvocation?.BoundParameters?.ContainsKey("PassThru"))
                {
                    WriteObject(true);
                }
            }
        }
    }
}