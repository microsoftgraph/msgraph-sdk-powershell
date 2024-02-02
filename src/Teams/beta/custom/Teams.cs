namespace Microsoft.Graph.Beta.PowerShell
{
    using Microsoft.Graph.Beta.PowerShell.Cmdlets;
    using Microsoft.Graph.Beta.PowerShell.TeamsInternal.Requests;
    using Microsoft.Graph.Beta.PowerShell.Runtime.Json;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using static Microsoft.Graph.Beta.PowerShell.Runtime.Extensions;
    using Microsoft.Graph.Beta.PowerShell.TeamsInternal;
    using Microsoft.Graph.Beta.PowerShell.Models.TeamsInternal;

    public partial class Teams
    {
        /// <summary>
        /// Get teams app with given id.
        /// </summary>
        /// <param name="teamsAppId">The teams app id.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <param name="sender">Http Request sender.</param>
        /// <returns>Teams app.</returns>
        public async System.Threading.Tasks.Task<Models.IMicrosoftGraphTeamsApp> GetTeamsApp(
            string teamsAppId,
            Runtime.IEventListener eventListener,
            Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                GetTeamsAppRequest getTeamsAppRequest = new GetTeamsAppRequest(teamsAppId);

                return await this.ExecuteHttpRequestAsync(
                    getTeamsAppRequest,
                    json => Models.MicrosoftGraphTeamsApp.FromJson(json),
                    eventListener,
                    sender);
            }
        }

        /// <summary>
        /// Get service principal for the given azure app Id.
        /// </summary>
        /// <param name="azureAdAppId">The azure AD app Id.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <param name="sender">The http request sender.</param>
        /// <returns>Service principal.</returns>
        public async System.Threading.Tasks.Task<Models.IMicrosoftGraphEntity> GetServicePrincipal(
            string azureAdAppId,
            Runtime.IEventListener eventListener,
            Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                GetServicePrincipalRequest getServicePrincipalRequest = new GetServicePrincipalRequest(azureAdAppId);

                return await this.ExecuteHttpRequestAsync(
                    getServicePrincipalRequest,
                    json => Models.MicrosoftGraphEntity.FromJson(json),
                    eventListener,
                    sender);
            }
        }

        /// <summary>
        /// Create service principal for the given azure AD app Id.
        /// </summary>
        /// <param name="azureAdAppId">Azure AD app Id.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <param name="sender">The http request sender.</param>
        /// <returns>Service Principal.</returns>
        internal async System.Threading.Tasks.Task<Models.IMicrosoftGraphEntity> CreateServicePrincipal(
            string azureAdAppId,
            Runtime.IEventListener eventListener,
            Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                CreateServicePrincipalRequest createServicePrincipalRequest = new CreateServicePrincipalRequest(azureAdAppId);

                return await this.ExecuteHttpRequestAsync(
                    createServicePrincipalRequest,
                    json => Models.MicrosoftGraphEntity.FromJson(json),
                    eventListener,
                    sender);
            }
        }

        /// <summary>
        /// Get permission grant policies associated with the given service principal.
        /// </summary>
        /// <param name="servicePrincipalId">The service principal Id.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <param name="sender">The http request sender.</param>
        /// <returns>Preapproval policy collection.</returns>
        internal async System.Threading.Tasks.Task<MGTeamsInternalPermissionGrantPreApprovalPolicyCollection> GetPermissionGrantPreApprovalPoliciesAssociatedWithServicePrincipal(
            string servicePrincipalId,
            Runtime.IEventListener eventListener,
            Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                GetPermissionGrantPreApprovalPoliciesAssociatedWithServicePrincipalRequest request =
                    new GetPermissionGrantPreApprovalPoliciesAssociatedWithServicePrincipalRequest(servicePrincipalId);

                return await this.ExecuteHttpRequestAsync(
                    request,
                    json => MGTeamsInternalPermissionGrantPreApprovalPolicyCollection.FromJson(json),
                    eventListener,
                    sender);
            }
        }

        /// <summary>
        /// Get permission grant policies in the tenant.
        /// </summary>
        /// <param name="selectQuery">The select query.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <param name="sender">The http request sender.</param>
        /// <returns>Preapproval policy collection.</returns>
        internal async System.Threading.Tasks.Task<MGTeamsInternalPermissionGrantPolicyCollection> GetPermissionGrantPolicies(
            string selectQuery,
            Runtime.IEventListener eventListener,
            Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                GetPermissionGrantPolicyCollectionRequest request =
                    new GetPermissionGrantPolicyCollectionRequest(selectQuery);

                return await this.ExecuteHttpRequestAsync(
                    request,
                    json => MGTeamsInternalPermissionGrantPolicyCollection.FromJson(json),
                    eventListener,
                    sender);
            }
        }

        /// <summary>
        /// Get resource specific permissions registered in Microsoft Graph.
        /// </summary>
        /// <param name="eventListener">The event listener.</param>
        /// <param name="sender">The http request sender.</param>
        /// <returns>RSC permission collection.</returns>
        internal async System.Threading.Tasks.Task<MGTeamsInternalResourceSpecificPermissionCollection> GetMicrosoftGraphResourceSpecificPermissionCollection(
            Runtime.IEventListener eventListener,
            Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                GetMicrosoftGraphResourceSpecificPermissionCollectionRequest request =
                    new GetMicrosoftGraphResourceSpecificPermissionCollectionRequest();

                return await this.ExecuteHttpRequestAsync(
                    request,
                    json => MGTeamsInternalResourceSpecificPermissionCollection.FromJson(json),
                    eventListener,
                    sender);
            }
        }

        /// <summary>
        /// Create permission grant preapproval policy.
        /// </summary>
        /// <param name="preApprovalPolicyToBeCreated">The preapproval policy to be created.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <param name="sender">The http request sender.</param>
        /// <returns>Preapproval policy.</returns>
        internal async System.Threading.Tasks.Task<MGTeamsInternalPermissionGrantPreApprovalPolicy> CreatePermissionGrantPreApprovalPolicy(
            MGTeamsInternalPermissionGrantPreApprovalPolicy preApprovalPolicyToBeCreated,
            Runtime.IEventListener eventListener,
            Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                CreatePermissionGrantPreApprovalPolicyRequest request =
                    new CreatePermissionGrantPreApprovalPolicyRequest(preApprovalPolicyToBeCreated);

                return await this.ExecuteHttpRequestAsync(
                    request,
                    json => MGTeamsInternalPermissionGrantPreApprovalPolicy.FromJson(json),
                    eventListener,
                    sender);
            }
        }

        /// <summary>
        /// Update permission grant policy.
        /// </summary>
        /// <param name="policyId">The policy Id.</param>
        /// <param name="preApprovalPolicyToBeUpdated">The updated policy.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <param name="sender">Http request sender.</param>
        /// <returns>Task tracking operation.</returns>
        internal async Task UpdatePermissionGrantPreApprovalPolicy(
            string policyId,
            MGTeamsInternalPermissionGrantPreApprovalPolicy preApprovalPolicyToBeUpdated,
            Runtime.IEventListener eventListener,
            Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                UpdatePermissionGrantPreApprovalPolicyRequest request =
                    new UpdatePermissionGrantPreApprovalPolicyRequest(policyId, preApprovalPolicyToBeUpdated);

                await this.ExecuteHttpRequestAsync<MGTeamsInternalGenericEmptyResponse>(
                    request,
                    null,
                    eventListener,
                    sender);
            }
        }

        /// <summary>
        /// Remove the given pemission grant policy.
        /// </summary>
        /// <param name="policyId">The policy Id.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <param name="sender">The http request sender.</param>
        /// <returns>Task tracking operation.</returns>
        internal async Task RemovePermissionGrantPreApprovalPolicy(
            string policyId,
            Runtime.IEventListener eventListener,
            Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                RemovePermissionGrantPreApprovalPolicyRequest request =
                    new RemovePermissionGrantPreApprovalPolicyRequest(policyId);

                await this.ExecuteHttpRequestAsync<MGTeamsInternalGenericEmptyResponse>(
                    request,
                    null,
                    eventListener,
                    sender);
            }
        }

        /// <summary>
        /// Associate SP with preapproval policy.
        /// </summary>
        /// <param name="servicePrincipalId">The service principal Id.</param>
        /// <param name="permissionGrantPreApprovalPolicyId">The preapproval policy Id.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <param name="sender">Http request sender.</param>
        /// <returns>Task tracking operation.</returns>
        internal async Task AssociateServicePrincipalWithPermissionGrantPreApprovalPolicy(
            string servicePrincipalId,
            string permissionGrantPreApprovalPolicyId,
            Runtime.IEventListener eventListener,
            Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                AssociateServicePrincipalWithPermissionGrantPreApprovalPolicyRequest request =
                    new AssociateServicePrincipalWithPermissionGrantPreApprovalPolicyRequest(
                        servicePrincipalId,
                        permissionGrantPreApprovalPolicyId);

                await this.ExecuteHttpRequestAsync<MGTeamsInternalGenericEmptyResponse>(
                    request,
                    outputConverter: null,
                    eventListener: eventListener,
                    sender: sender);
            }
        }

        /// <summary>
        /// Remove association between service principal and preapproval policy.
        /// </summary>
        /// <param name="servicePrincipalId">The service principal Id.</param>
        /// <param name="permissionGrantPreApprovalPolicyId">The pre approval policy Id.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <param name="sender">Http request sender.</param>
        /// <returns>Task tracking operation.</returns>
        internal async Task RemoveAssociationBetweenServicePrincipalAndPreapprovalPolicy(
            string servicePrincipalId,
            string permissionGrantPreApprovalPolicyId,
            Runtime.IEventListener eventListener,
            Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                RemoveAssociationBetweenServicePrincipalAndPreapprovalPolicyRequest request =
                    new RemoveAssociationBetweenServicePrincipalAndPreapprovalPolicyRequest(
                        servicePrincipalId,
                        permissionGrantPreApprovalPolicyId);

                await this.ExecuteHttpRequestAsync<MGTeamsInternalGenericEmptyResponse>(
                    request,
                    outputConverter: null,
                    eventListener: eventListener,
                    sender: sender);
            }
        }

        /// <summary>
        /// Get sensitivity labels visible to current caller.
        /// </summary>
        /// <param name="eventListener">The event listener.</param>
        /// <param name="sender">The http request sender.</param>
        /// <returns>Sensitivity label collection.</returns>
        internal async System.Threading.Tasks.Task<MGTeamsInternalSensitivityLabelCollection> GetSensitivityLabelCollection(
            Runtime.IEventListener eventListener,
            Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                GetSensitivityLabelCollectionRequest request =
                    new GetSensitivityLabelCollectionRequest();

                return await this.ExecuteHttpRequestAsync(
                    request,
                    json => MGTeamsInternalSensitivityLabelCollection.FromJson(json),
                    eventListener,
                    sender);
            }
        }

        /// <summary>
        /// Get teams app settings.
        /// </summary>
        /// <param name="teamsAppId">The teams app id.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <param name="sender">Http Request sender.</param>
        /// <returns>Teams app.</returns>
        public async System.Threading.Tasks.Task<Models.IMicrosoftGraphTeamsAppSettings> GetTeamsAppSettings(
            Runtime.IEventListener eventListener,
            Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                GetTeamsAppSettingsRequest request = new GetTeamsAppSettingsRequest();

                return await this.ExecuteHttpRequestAsync(
                    request,
                    json => Models.MicrosoftGraphTeamsAppSettings.FromJson(json),
                    eventListener,
                    sender);
            }
        }

        /// <summary>
        /// Update Teams App Settings.
        /// </summary>
        /// <param name="isChatResourceSpecificConsentEnabled">Is chat RSC enabled.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <param name="sender">The http request sender.</param>
        internal async System.Threading.Tasks.Task UpdateTeamsAppSettings(
            bool isChatResourceSpecificConsentEnabled,
            Runtime.IEventListener eventListener,
            Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                UpdateTeamsAppSettingsRequest request =
                    new UpdateTeamsAppSettingsRequest(isChatResourceSpecificConsentEnabled);

                await this.ExecuteHttpRequestAsync<MGTeamsInternalGenericEmptyResponse>(
                    request,
                    outputConverter: null,
                    eventListener: eventListener,
                    sender: sender);
            }
        }

        /// <summary>
        /// Get sensitivity labels visible to current caller.
        /// </summary>
        /// <param name="eventListener">The event listener.</param>
        /// <param name="sender">The http request sender.</param>
        /// <returns>Sensitivity label collection.</returns>
        internal async System.Threading.Tasks.Task<MGTeamsInternalAuthorizationPolicy> GetAuthorizationPolicy(
            Runtime.IEventListener eventListener,
            Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                GetAuthorizationPolicyRequest request =
                    new GetAuthorizationPolicyRequest();

                return await this.ExecuteHttpRequestAsync(
                    request,
                    json => MGTeamsInternalAuthorizationPolicy.FromJson(json),
                    eventListener,
                    sender);
            }
        }

        /// <summary>
        /// Get sensitivity labels visible to current caller.
        /// </summary>
        /// <param name="eventListener">The event listener.</param>
        /// <param name="sender">The http request sender.</param>
        /// <returns>Sensitivity label collection.</returns>
        internal async System.Threading.Tasks.Task UpdateDefaultUserRolePermissionGrantPoliciesAssigned(
            IEnumerable<string> permissionGrantPolicies,
            Runtime.IEventListener eventListener,
            Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using (NoSynchronizationContext)
            {
                UpdateDefaultUserRolePermissionGrantPoliciesAssignedRequest request =
                    new UpdateDefaultUserRolePermissionGrantPoliciesAssignedRequest(permissionGrantPolicies);

                await this.ExecuteHttpRequestAsync<MGTeamsInternalGenericEmptyResponse>(
                    request,
                    outputConverter: null,
                    eventListener: eventListener,
                    sender: sender);
            }
        }

        /// <summary>
        /// Execute HTTP request.
        /// </summary>
        /// <typeparam name="T">The type of the response object.</typeparam>
        /// <param name="teamsHttpRequest">The http request.</param>
        /// <param name="outputConverter">Converter from json to the output type.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <param name="sender">The HTTP request sender.</param>
        /// <returns>The result object.</returns>
        private async Task<T> ExecuteHttpRequestAsync<T>(
            TeamsHttpRequest teamsHttpRequest,
            System.Func<Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonNode, T> outputConverter,
            Runtime.IEventListener eventListener,
            Runtime.ISendAsync sender) where T : class
        {
            using (NoSynchronizationContext)
            {
                System.Net.Http.HttpRequestMessage request = null;
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {

                    request = teamsHttpRequest.GetHttpRequestMessage();

                    await eventListener.Signal(Runtime.Events.BeforeCall, request);
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Runtime.Events.ResponseCreated, _response);
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    this.LogResponseInformation(_response, eventListener);
                    await eventListener.Signal(Runtime.Events.BeforeResponseDispatch, _response);

                    string responseBody = await _response.Content.ReadAsStringAsync();
                    if (_response.IsSuccessStatusCode)
                    {
                        if (typeof(T) == typeof(MGTeamsInternalGenericEmptyResponse))
                        {
                            return MGTeamsInternalGenericEmptyResponse.LazyInstance.Value as T;
                        }

                        Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonNode responseAsJsonNode = Runtime.Json.JsonNode.Parse(responseBody);
                        return outputConverter(responseAsJsonNode);
                    }
                    else
                    {
                        throw new MGTeamsInternalServiceRequestException(
                            _response.StatusCode,
                            Models.MicrosoftGraphODataErrorsOdataError.FromJson(Runtime.Json.JsonNode.Parse(responseBody)));
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
        /// Log Response Information.
        /// </summary>
        /// <param name="response">The http response.</param>
        /// <param name="eventListener">The event listener.</param>
        private void LogResponseInformation(System.Net.Http.HttpResponseMessage response, Runtime.IEventListener eventListener)
        {
            string requestId = response.GetFirstHeader("request-id");
            string clientRequestId = response.GetFirstHeader("client-request-id");
            string date = response.GetFirstHeader("Date");

            if (string.IsNullOrEmpty(requestId) || string.IsNullOrEmpty(clientRequestId) || string.IsNullOrEmpty(date))
            {
                this.LogVerbose($"Invoked Http request with Url: '{response.RequestMessage.Method.Method} {response.RequestMessage.RequestUri}', ResponseCode: '{response.StatusCode}'.", eventListener);
                this.LogVerbose($"Response headers: '{response.Headers.ToString()}'.", eventListener);
            }
            else
            {
                this.LogVerbose($"Invoked Http request with Url: '{response.RequestMessage.Method.Method} {response.RequestMessage.RequestUri}', ResponseCode: '{response.StatusCode}', RequestId: '{requestId}', ClientRequestId: '{clientRequestId}', Date: '{date}'.", eventListener);
            }
        }

        /// <summary>
        /// Log verbose.
        /// </summary>
        /// <param name="message">The log message.</param>
        /// <param name="eventListener">The event listener.</param>
        private void LogVerbose(string message, Runtime.IEventListener eventListener)
        {
            eventListener.Signal(
                Microsoft.Graph.Beta.PowerShell.Runtime.Events.Verbose,
                () => new Microsoft.Graph.Beta.PowerShell.Runtime.EventData
                {
                    Message = message,
                });
        }
    }
}
