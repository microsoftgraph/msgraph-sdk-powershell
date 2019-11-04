namespace Microsoft.Graph.PowerShell.Cmdlets
{
    using static Microsoft.Graph.PowerShell.Runtime.Extensions;

    /// <summary>Add a member to an Office 365 group or security group through the members navigation property.</summary>
    /// <remarks>
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.New, @"GroupMember_CreateViaIdentity", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject))]
    [global::Microsoft.Graph.PowerShell.Description(@"Add a member to an Office 365 group or security group through the members navigation property.")]
    [global::Microsoft.Graph.PowerShell.Generated]
    public partial class NewGroupMember_CreateViaIdentity : global::System.Management.Automation.PSCmdlet,
        Microsoft.Graph.PowerShell.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Backing field for <see cref="BodyParameter" /> property.</summary>
        private Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject _bodyParameter;

        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING", ValueFromPipeline = true)]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"bodyParameter",
        PossibleTypes = new [] { typeof(Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject) })]
        public Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject BodyParameter { get => this._bodyParameter; set => this._bodyParameter = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Graph.PowerShell.GroupsDirectoryObject Client => Microsoft.Graph.PowerShell.Module.Instance.ClientAPI;

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public Microsoft.Graph.PowerShell.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public Microsoft.Graph.PowerShell.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Backing field for <see cref="InputObject" /> property.</summary>
        private Microsoft.Graph.PowerShell.Models.IGroupsDirectoryObjectIdentity _inputObject;

        /// <summary>Identity Parameter</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Identity Parameter", ValueFromPipeline = true)]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Path)]
        public Microsoft.Graph.PowerShell.Models.IGroupsDirectoryObjectIdentity InputObject { get => this._inputObject; set => this._inputObject = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Graph.PowerShell.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Graph.PowerShell.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// The instance of the <see cref="Microsoft.Graph.PowerShell.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Microsoft.Graph.PowerShell.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>
        /// <c>overrideOnCreated</c> will be called before the regular onCreated has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onCreated method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnCreated(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Graph.PowerShell.Models.IOdataError" /> from the remote
        /// call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Graph.PowerShell.Models.IOdataError> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

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
            ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletEndProcessing).Wait(); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Microsoft.Graph.PowerShell.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Graph.PowerShell.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Graph.PowerShell.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Graph.PowerShell.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Graph.PowerShell.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data, new[] { data.Message });
                        return ;
                    }
                    case Microsoft.Graph.PowerShell.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Graph.PowerShell.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="NewGroupMember_CreateViaIdentity" /> cmdlet class.
        /// </summary>
        public NewGroupMember_CreateViaIdentity()
        {

        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            try
            {
                // work
                if (ShouldProcess($"Call remote 'CreateGroupMember' operation"))
                {
                    using( var asyncCommandRuntime = new Microsoft.Graph.PowerShell.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                await ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletProcessRecordAsyncStart); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                await ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Graph.PowerShell.Module.Instance.CreatePipeline(InvocationInformation);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Graph.PowerShell.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Graph.PowerShell.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // try to call with PATH parameters from Input Object
                    if (null == InputObject.GroupId)
                    {
                        ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.GroupId"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                    }
                    await this.Client.GroupsCreateGroupMember(InputObject.GroupId ?? null, BodyParameter, onCreated, onDefault, this, Pipeline);
                    await ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Graph.PowerShell.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  body=BodyParameter})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Signal(Microsoft.Graph.PowerShell.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Graph.PowerShell.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>a delegate that is called when the remote service returns 201 (Created).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onCreated(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnCreated(responseMessage, response, ref _returnNow);
                // if overrideOnCreated has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onCreated - response for 201 / application/json
                // (await response) // should be Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject
                WriteObject((await response));
            }
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Graph.PowerShell.Models.IOdataError" /> from the remote
        /// call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Graph.PowerShell.Models.IOdataError> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnDefault(responseMessage, response, ref _returnNow);
                // if overrideOnDefault has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // Error Response : default
                var code = (await response)?.Code;
                var message = (await response)?.Message;
                if ((null == code || null == message))
                {
                    // Unrecognized Response. Create an error record based on what we have.
                    var ex = new Microsoft.Graph.PowerShell.Runtime.RestException<Microsoft.Graph.PowerShell.Models.IOdataError>(responseMessage, await response);
                    WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new { body=BodyParameter })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                    });
                }
                else
                {
                    WriteError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{code}] : {message}"), code?.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { body=BodyParameter })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(message) { RecommendedAction = global::System.String.Empty }
                    });
                }
            }
        }
    }
}