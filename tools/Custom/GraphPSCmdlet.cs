
// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Cmdlets.Custom
{
    using static Microsoft.Graph.PowerShell.Runtime.Extensions;
    public partial class GraphPSCmdlet : global::System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="All" /> property.</summary>
        private global::System.Management.Automation.SwitchParameter _all;

        /// <summary>List All pages</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List all pages")]
        [Microsoft.Graph.PowerShell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List all pages",
        SerializedName = @"$all",
        PossibleTypes = new[] { typeof(global::System.Management.Automation.SwitchParameter) })]
        [global::Microsoft.Graph.PowerShell.Category(global::Microsoft.Graph.PowerShell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter All { get => this._all; set => this._all = value; }

        /// <summary>
        /// Default number of items per page.
        /// </summary>
        internal const int DefaultPageSize = 100;

        /// <summary>
        /// Maximum number of items per page.
        /// </summary>
        internal const int MaxPageSize = 999;

        /// <summary>
        /// Original page size/top/limit passed to Cmdlet via parameter.
        /// </summary>
        internal int originalPageSize = 0;

        /// <summary>
        /// Total number of pages required to iterate page collections excluding overflow items.
        /// </summary>
        internal int requiredPages = 0;

        /// <summary>
        /// A count of iterated pages thus far.
        /// </summary>
        internal int iteratedPages = 0;

        /// <summary>
        /// Total number of overflow items, less than the maximum number of items in a page.
        /// Modulus of original page size.
        /// </summary>
        internal int overflowItemsCount = 0;

        /// <summary>
        /// Total number of fetched items.
        /// </summary>
        internal int totalFetchedItems = 0;

        /// <summary>
        /// Initializes paging values.
        /// </summary>
        /// <param name="invocationInfo">A reference to <see cref="System.Management.Automation.InvocationInfo"/> object.</param>
        /// <param name="PageSize">A reference to page size parameter.</param>
        public void InitializePaging(ref global::System.Management.Automation.InvocationInfo invocationInfo, ref int PageSize)
        {
            if (PageSize > MaxPageSize)
            {
                invocationInfo.BoundParameters["All"] = true;
                originalPageSize = PageSize;
                requiredPages = PageSize / DefaultPageSize;
                overflowItemsCount = PageSize % DefaultPageSize;
                invocationInfo.BoundParameters["PageSize"] = DefaultPageSize;
                PageSize = DefaultPageSize;
            }
        }

        /// <summary>
        /// Determines whether the cmdlet should follow the OData next link url.
        /// </summary>
        /// <param name="boundParameters">The bound parameters of the cmdlet.</param>
        /// <param name="itemsCount">Current page items count.</param>
        /// <returns>True if it can iterate pages; False if it can't.</returns>
        public bool ShouldIteratePages(global::System.Collections.Generic.Dictionary<string, object> boundParameters, int itemsCount)
        {
            iteratedPages++;
            totalFetchedItems += itemsCount;
            if ((boundParameters.ContainsKey("All") && !boundParameters.ContainsKey("PageSize")) ||
                (boundParameters.ContainsKey("PageSize") && totalFetchedItems < originalPageSize))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Gets an OData next link for the overflow items.
        /// </summary>
        /// <param name="requestUri">The OData next link returned by the service.</param>
        /// <returns>An OData next link URI for the overflow items.</returns>
        public global::System.Uri GetOverflowItemsNextLinkUri(global::System.Uri requestUri)
        {
            var nextLinkUri = new global::System.UriBuilder(requestUri);
            if (requiredPages == iteratedPages && overflowItemsCount > 0)
            {
                if (nextLinkUri.Query.Contains("$top"))
                {
                    global::System.Collections.Specialized.NameValueCollection queryString = global::System.Web.HttpUtility.ParseQueryString(nextLinkUri.Query);
                    queryString["$top"] = global::System.Uri.EscapeDataString(overflowItemsCount.ToString());
                    nextLinkUri.Query = queryString.ToString();
                }
                else
                {
                    nextLinkUri.Query += $"$top=" + global::System.Uri.EscapeDataString(overflowItemsCount.ToString());
                }
            }
            return nextLinkUri.Uri;
        }
        
        public void OverrideCmdletOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Graph.PowerShell.Models.IOdataError> response, ref global::System.Threading.Tasks.Task<bool> returnNow)
        {
            if (responseMessage.IsSuccessStatusCode)
            {
                if (MyInvocation?.BoundParameters?.ContainsKey("PassThru") == true)
                {
                   WriteObject(true); 
                }
                returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(true);
            }
        }
    }
}