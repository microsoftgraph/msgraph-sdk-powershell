﻿namespace Microsoft.Graph.Beta.PowerShell.Cmdlets
{
    using Microsoft.Graph.Beta.PowerShell.Models.TeamsInternal;
    using Microsoft.Graph.Beta.PowerShell.TeamsInternal;
    using static Microsoft.Graph.Beta.PowerShell.Runtime.Extensions;

    /// <summary>
    /// Get Preapproval policy associated with a Teams App.
    /// </summary>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.Get, @"MgBetaTeamRscConfiguration_Get")]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRscConfiguration))]
    [global::Microsoft.Graph.Beta.PowerShell.Description(@"Get team RSC configuration for tenant.")]
    [global::Microsoft.Graph.Beta.PowerShell.Generated]
    public partial class GetMgBetaTeamRscConfiguration_Get : global::System.Management.Automation.PSCmdlet,
        Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Graph.Beta.PowerShell.Category(global::Microsoft.Graph.Beta.PowerShell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Graph.Beta.PowerShell.Teams Client => Microsoft.Graph.Beta.PowerShell.Module.Instance.ClientAPI;

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Graph.Beta.PowerShell.Category(global::Microsoft.Graph.Beta.PowerShell.ParameterCategory.Runtime)]
        public Microsoft.Graph.Beta.PowerShell.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Graph.Beta.PowerShell.Category(global::Microsoft.Graph.Beta.PowerShell.ParameterCategory.Runtime)]
        public Microsoft.Graph.Beta.PowerShell.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation; set { __invocationInfo = value; } }

        /// <summary>
        /// <see cref="Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// The instance of the <see cref="Microsoft.Graph.Beta.PowerShell.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Microsoft.Graph.Beta.PowerShell.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Graph.Beta.PowerShell.Category(global::Microsoft.Graph.Beta.PowerShell.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Graph.Beta.PowerShell.Category(global::Microsoft.Graph.Beta.PowerShell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Graph.Beta.PowerShell.Category(global::Microsoft.Graph.Beta.PowerShell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphODataErrorsOdataError">Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphODataErrorsOdataError</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphODataErrorsOdataError> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamworkDevice">Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamworkDevice</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamworkDevice> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Graph.Beta.PowerShell.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.Beta.PowerShell.Runtime.Events.CmdletBeginProcessing).Wait(); if (((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.Beta.PowerShell.Runtime.Events.CmdletEndProcessing).Wait(); if (((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="GetMgBetaChatRscConfiguration_Get" /> cmdlet class.
        /// </summary>
        public GetMgBetaTeamRscConfiguration_Get()
        {

        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
        async global::System.Threading.Tasks.Task Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Graph.Beta.PowerShell.Runtime.EventData> messageData)
        {
            using (NoSynchronizationContext)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }

                switch (id)
                {
                    case Microsoft.Graph.Beta.PowerShell.Runtime.Events.Verbose:
                        {
                            WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                            return;
                        }
                    case Microsoft.Graph.Beta.PowerShell.Runtime.Events.Warning:
                        {
                            WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                            return;
                        }
                    case Microsoft.Graph.Beta.PowerShell.Runtime.Events.Information:
                        {
                            var data = messageData();
                            WriteInformation(data.Message, new string[] { });
                            return;
                        }
                    case Microsoft.Graph.Beta.PowerShell.Runtime.Events.Debug:
                        {
                            WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                            return;
                        }
                    case Microsoft.Graph.Beta.PowerShell.Runtime.Events.Error:
                        {
                            WriteError(new global::System.Management.Automation.ErrorRecord(new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null));
                            return;
                        }
                }
                await Microsoft.Graph.Beta.PowerShell.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Graph.Beta.PowerShell.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Graph.Beta.PowerShell.Runtime.EventData), InvocationInformation, this.ParameterSetName, null);
                if (token.IsCancellationRequested)
                {
                    return;
                }

            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.Beta.PowerShell.Runtime.Events.CmdletProcessRecordStart).Wait(); if (((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }
            try
            {
                // work
                using (var asyncCommandRuntime = new Microsoft.Graph.Beta.PowerShell.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Token))
                {
                    asyncCommandRuntime.Wait(ProcessRecordAsync(), ((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Token);
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach (var innerException in aggregateException.Flatten().InnerExceptions)
                {
                    ((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.Beta.PowerShell.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if (((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }
                    // Write exception out to error channel.
                    WriteError(new global::System.Management.Automation.ErrorRecord(innerException, string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null));
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException) == null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.Beta.PowerShell.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if (((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }
                // Write exception out to error channel.
                WriteError(new global::System.Management.Automation.ErrorRecord(exception, string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null));
            }
            finally
            {
                ((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.Beta.PowerShell.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using (NoSynchronizationContext)
            {
                await ((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.Beta.PowerShell.Runtime.Events.CmdletProcessRecordAsyncStart); if (((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }
                await ((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.Beta.PowerShell.Runtime.Events.CmdletGetPipeline); if (((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }
                Pipeline = Microsoft.Graph.Beta.PowerShell.Module.Instance.CreatePipeline(InvocationInformation, this.ParameterSetName);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Graph.Beta.PowerShell.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Graph.Beta.PowerShell.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.Beta.PowerShell.Runtime.Events.CmdletBeforeAPICall); if (((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }

                    // Get Group consent settings
                    MGTeamsInternalTenantConsentSettingsCollection tenantConsentSettingCollection = await this.Client.GetTenantConsentSettings(this, Pipeline);

                    WriteVerbose($"Fetched Tenant App Settings for tenant.");

                    if (((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }

                    // Get authorization policy
                    MGTeamsInternalAuthorizationPolicy authorizationPolicy = await this.Client.GetAuthorizationPolicy(this, Pipeline);

                    WriteVerbose($"Fetched authorization policy for tenant.");

                    if (((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }

                    RscConfigurationSynthesizer rscConfigurationConverter = new RscConfigurationSynthesizer();
                    Models.IMicrosoftGraphRscConfiguration microsoftGraphRscConfiguration =
                        rscConfigurationConverter.ConvertToTeamRscConfiguration(tenantConsentSettingCollection, authorizationPolicy, this);

                    WriteObject(microsoftGraphRscConfiguration);

                    await ((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.Beta.PowerShell.Runtime.Events.CmdletAfterAPICall); if (((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }
                }
                catch (System.Exception ex)
                {
                    TeamsExceptionHandler.HandleException(
                        ex,
                        new
                        {
                        },
                        errorRecord => WriteError(errorRecord),
                        this);
                    ((Runtime.IEventListener)this).Signal(Runtime.Events.CmdletException, $"{ex.GetType().Name} - {ex.Message} : {ex.StackTrace}").Wait();
                    if (((Runtime.IEventListener)this).Token.IsCancellationRequested) { return; }
                }
                finally
                {
                    await ((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.Beta.PowerShell.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Graph.Beta.PowerShell.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }
    }
}