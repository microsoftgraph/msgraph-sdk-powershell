namespace Microsoft.Graph.PowerShell
{
    using Microsoft.Graph.PowerShell.Runtime.Json;
    using System.Collections.Generic;
    using static Microsoft.Graph.PowerShell.Runtime.Extensions;

    /// <summary>
    /// Custom Low-level API implementation for the Groups.DirectoryObject service.
    /// </summary>
    public partial class GroupsDirectoryObject
    {
        /// <summary>Create new navigation property to acceptedSenders for groups</summary>
        /// <param name="groupId">key: group-id of group</param>
        /// <param name="body">New navigation property</param>
        /// <param name="onCreated">a delegate that is called when the remote service returns 201 (Created).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Graph.PowerShell.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Graph.PowerShell.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task GroupsCreateGroupMember(string groupId, Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject>, global::System.Threading.Tasks.Task> onCreated, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Graph.PowerShell.Models.IOdataError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Graph.PowerShell.Runtime.IEventListener eventListener, Microsoft.Graph.PowerShell.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://graph.microsoft.com/stagingbeta/groups/"
                        + global::System.Uri.EscapeDataString(groupId)
                        + "/members/$ref"
                        , "\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(Runtime.Method.Post, _url);
                await eventListener.Signal(Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                Dictionary<string, string> requestBody = new Dictionary<string, string> { { "@odata.id", body.Id } };
                request.Content = new global::System.Net.Http.StringContent(null != body ? new JsonObject(requestBody): @"{}", global::System.Text.Encoding.UTF8); ;
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.GroupsCreateGroupMember_Call(request,onCreated,onDefault,eventListener,sender);
            }
        }

        /// <summary>Create new navigation property to acceptedSenders for groups</summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="body">New navigation property</param>
        /// <param name="onCreated">a delegate that is called when the remote service returns 201 (Created).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Graph.PowerShell.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Graph.PowerShell.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task GroupsCreateGroupMemberViaIdentity(global::System.String viaIdentity, Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject>, global::System.Threading.Tasks.Task> onCreated, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Graph.PowerShell.Models.IOdataError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Graph.PowerShell.Runtime.IEventListener eventListener, Microsoft.Graph.PowerShell.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/groups/(?<group-id>[^/]+)/members/$ref").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/groups/{group-id}/members/$ref'");
                }

                // replace URI parameters with values from identity
                var groupId = _match.Groups["group-id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://graph.microsoft.com/stagingbeta/groups/"
                        + groupId
                        + "/members/$ref"

                        , "\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(Runtime.Method.Post, _url);
                await eventListener.Signal(Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.GroupsCreateGroupMember_Call(request,onCreated,onDefault,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="GroupsCreateAcceptedSenders" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onCreated">a delegate that is called when the remote service returns 201 (Created).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Graph.PowerShell.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Graph.PowerShell.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task GroupsCreateGroupMember_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject>, global::System.Threading.Tasks.Task> onCreated, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Graph.PowerShell.Models.IOdataError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Graph.PowerShell.Runtime.IEventListener eventListener, Microsoft.Graph.PowerShell.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.Created:
                        {
                            await eventListener.Signal(Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onCreated(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Models.MicrosoftGraphDirectoryObject.FromJson(Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Models.OdataError.FromJson(Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="GroupsCreateAcceptedSenders" /> method. Call this like the actual call, but you will
        /// get validation events back.
        /// </summary>
        /// <param name="groupId">key: group-id of group</param>
        /// <param name="body">New navigation property</param>
        /// <param name="eventListener">an <see cref="Microsoft.Graph.PowerShell.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task GroupsCreateGroupMember_Validate(string groupId, Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject body, Microsoft.Graph.PowerShell.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(groupId),groupId);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }
    }
}