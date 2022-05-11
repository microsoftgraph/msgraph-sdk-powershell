namespace Microsoft.Graph.PowerShell
{
    using Microsoft.Graph.PowerShell.Runtime.Json;
    using System.Collections.Generic;
    using static Microsoft.Graph.PowerShell.Runtime.Extensions;
    public partial class Groups
    {
        /// <summary>Create new navigation property to members for groups</summary>
        /// <param name="groupId">key: group-id of group</param>
        /// <param name="body">New navigation property</param>
        /// <param name="onCreated">a delegate that is called when the remote service returns 204 (No Content).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Graph.PowerShell.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task GroupsCreateGroupMember(string apiVersion, string groupId, Models.IMicrosoftGraphDirectoryObject body, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Models.IMicrosoftGraphDirectoryObject>, System.Threading.Tasks.Task> onCreated, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Models.IMicrosoftGraphODataErrorsOdataError>, System.Threading.Tasks.Task> onDefault, Runtime.IEventListener eventListener, Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                // construct URL
                string baseUrl = $"https://graph.microsoft.com/{apiVersion}";
                var _url = new System.Uri(
                    System.Text.RegularExpressions.Regex.Replace($"{baseUrl}/groups/{System.Uri.EscapeDataString(groupId)}/members/$ref",
                    "\\?&*$|&*$|(\\?)&+|(&)&+", "$1$2"));

                await eventListener.Signal(Runtime.Events.URLCreated, _url); if (eventListener.Token.IsCancellationRequested) { return; }

                // generate request object
                var request = new System.Net.Http.HttpRequestMessage(Runtime.Method.Post, _url);
                await eventListener.Signal(Runtime.Events.RequestCreated, _url); if (eventListener.Token.IsCancellationRequested) { return; }

                await eventListener.Signal(Runtime.Events.HeaderParametersAdded, _url); if (eventListener.Token.IsCancellationRequested) { return; }
                // set body content
                string requestContent = null != body ? new JsonObject(new Dictionary<string, string> { { "@odata.id", $"{baseUrl}/directoryObjects/{body.Id}" } }) : @"{}";
                request.Content = new System.Net.Http.StringContent(requestContent, System.Text.Encoding.UTF8); ;
                request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Runtime.Events.BodyContentSet, _url); if (eventListener.Token.IsCancellationRequested) { return; }
                // make the call
                await this.GroupsCreateGroupMember_Call(request, onCreated, onDefault, eventListener, sender);
            }
        }

        /// <summary>Actual wire call for <see cref="GroupsCreateGroupMember" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onCreated">a delegate that is called when the remote service returns 204 (No content).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Graph.PowerShell.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task GroupsCreateGroupMember_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Models.IMicrosoftGraphDirectoryObject>, System.Threading.Tasks.Task> onCreated, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Models.IMicrosoftGraphODataErrorsOdataError>, System.Threading.Tasks.Task> onDefault, Runtime.IEventListener eventListener, Runtime.ISendAsync sender)
        {
            using (NoSynchronizationContext)
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Runtime.Events.BeforeCall, request); if (eventListener.Token.IsCancellationRequested) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Runtime.Events.ResponseCreated, _response); if (eventListener.Token.IsCancellationRequested) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch (_response.StatusCode)
                    {
                        case System.Net.HttpStatusCode.NoContent:
                            {
                                await eventListener.Signal(Runtime.Events.BeforeResponseDispatch, _response); if (eventListener.Token.IsCancellationRequested) { return; }
                                await onCreated(_response, _response.Content.ReadAsStringAsync().ContinueWith(body => Models.MicrosoftGraphDirectoryObject.FromJson(Runtime.Json.JsonNode.Parse(body.Result))));
                                break;
                            }
                        default:
                            {
                                await eventListener.Signal(Runtime.Events.BeforeResponseDispatch, _response); if (eventListener.Token.IsCancellationRequested) { return; }
                                await onDefault(_response, _response.Content.ReadAsStringAsync().ContinueWith(body => Models.MicrosoftGraphODataErrorsOdataError.FromJson(Runtime.Json.JsonNode.Parse(body.Result))));
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
        /// Validation method for <see cref="GroupsCreateGroupMember" /> method. Call this like the actual call, but you will
        /// get validation events back.
        /// </summary>
        /// <param name="groupId">key: group-id of group</param>
        /// <param name="body">New navigation property</param>
        /// <param name="eventListener">an <see cref="Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task GroupsCreateGroupMember_Validate(string groupId, Models.IMicrosoftGraphDirectoryObject body, Runtime.IEventListener eventListener)
        {
            using (NoSynchronizationContext)
            {
                await eventListener.AssertNotNull(nameof(groupId), groupId);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }
    }
}
