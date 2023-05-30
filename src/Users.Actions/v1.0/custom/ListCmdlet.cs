// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Cmdlets.Custom
{
    using System;
    using System.Management.Automation;

    public partial class ListCmdlet : PSCmdlet
    {
        /// <summary>Backing field for <see cref="PageSize" /> property.</summary>
        private int _pageSize;
        
        /// <summary>Sets the page size of results.</summary>
        [Parameter(Mandatory = false, HelpMessage = "Sets the page size of results.")]
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The page size of results.",
        PossibleTypes = new[] { typeof(int) })]
        [Category(ParameterCategory.Runtime)]
        public int PageSize { get => this._pageSize; set => this._pageSize = value; }

        /// <summary>Backing field for <see cref="All" /> property.</summary>
        private global::System.Management.Automation.SwitchParameter _all;

        /// <summary>List All pages</summary>
        [Parameter(Mandatory = false, HelpMessage = "List all pages.")]
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List all pages.",
        PossibleTypes = new[] { typeof(global::System.Management.Automation.SwitchParameter) })]
        [Category(ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter All { get => this._all; set => this._all = value; }

        // <summary>Backing field for <see cref="CountVariable" /> property.</summary>
        private string _countVariable;

        /// <summary>Specifies a count of the total number of items in a collection. </summary>
        [Parameter(Mandatory = false, HelpMessage = "Specifies a count of the total number of items in a collection. By default, this variable will be set in the global scope.")]
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies a count of the total number of items in a collection. By default, this variable will be set in the global scope.",
        PossibleTypes = new[] { typeof(string) })]
        [Category(ParameterCategory.Runtime)]
        [global::System.Management.Automation.Alias("CV")]
        public string CountVariable { get => this._countVariable; set => this._countVariable = value; }

        /// <summary>
        /// Maximum number of items per page.
        /// </summary>
        internal const int MaxPageSize = 999;

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
        /// Total number of items to be fetched.
        /// </summary>
        internal int limit = default;

        /// <summary>
        /// Initializes paging values.
        /// </summary>
        /// <param name="invocationInfo">A reference to <see cref="System.Management.Automation.InvocationInfo"/> object.</param>
        /// <param name="top">A reference to top parameter.</param>
        public void InitializeCmdlet(ref global::System.Management.Automation.InvocationInfo invocationInfo, ref int top, ref global::System.Management.Automation.SwitchParameter count)
        {
            if (invocationInfo.BoundParameters.ContainsKey("PageSize") && (PageSize > MaxPageSize || PageSize == default))
            {
                ThrowTerminatingError(
                new ErrorRecord(
                    new ArgumentException($"Invalid page size specified `{PageSize}`. {nameof(PageSize)} must be between 1 and {MaxPageSize} inclusive."),
                    Guid.NewGuid().ToString(),
                    ErrorCategory.InvalidArgument,
                    null));
            }

            if (invocationInfo.BoundParameters.ContainsKey("Top"))
            {
                if ((top > MaxPageSize) || IsAllPresent(invocationInfo.BoundParameters) || invocationInfo.BoundParameters.ContainsKey("PageSize"))
                {
                    limit = top;
                }

                if (top > MaxPageSize)
                {
                    // Remove $top from query parameters, we will handle paging. 
                    top = default;
                    invocationInfo.BoundParameters.Remove("Top");
                }

                if (invocationInfo.BoundParameters.ContainsKey("PageSize"))
                {
                    invocationInfo.BoundParameters["Top"] = PageSize;
                    top = PageSize;
                }
            }
            else if (invocationInfo.BoundParameters.ContainsKey("PageSize"))
            {
                invocationInfo.BoundParameters["Top"] = PageSize;
                top = PageSize;
            }

            if ((!invocationInfo.BoundParameters.ContainsKey("Count")) && invocationInfo.BoundParameters.ContainsKey("CountVariable"))
            {
                // Set Count to true when CountVariable is set.
                invocationInfo.BoundParameters["Count"] = true;
                count = true;
            }
        }

        public void InitializePageCount(int initialPageSize)
        {
            if (limit != default && initialPageSize != default)
            {
                requiredPages = limit / initialPageSize;
                overflowItemsCount = limit % initialPageSize;
            }
        }

        /// <summary>
        /// Determines whether the cmdlet should follow the OData next link URL.
        /// Iteration will only occur when limit/top is not set, or if there a more items to fetch.
        /// </summary>
        /// <param name="boundParameters">The bound parameters of the cmdlet.</param>
        /// <param name="itemsCount">Current page items count.</param>
        /// <returns>True if it can iterate pages; otherwise False.</returns>
        public bool ShouldIteratePages(global::System.Collections.Generic.Dictionary<string, object> boundParameters, int itemsCount)
        {
            iteratedPages++;
            totalFetchedItems += itemsCount;

            return (IsAllPresent(boundParameters) && limit == default) || totalFetchedItems < limit;
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
                    nextLinkUri.Query += $"&$top={System.Uri.EscapeDataString(overflowItemsCount.ToString())}";
                }
            }
            return nextLinkUri.Uri;
        }

        /// <summary>
        /// Adds quotation mark around $search values if none exists.
        /// This is needed to support KQL e.g. "prop:value".
        /// </summary>
        /// <param name="boundParameters">The bound parameters of the calling cmdlet.</param>
        /// <param name="search">The $search value.</param>
        /// <returns>A formated search value.</returns>
        internal string FormatSearchValue(global::System.Collections.Generic.Dictionary<string, object> boundParameters, string search)
        {
            if (!boundParameters.ContainsKey("Search"))
            {
                return null;
            }
            else if (!string.IsNullOrWhiteSpace(search) && !search.StartsWith("\""))
            {
                search = $"\"{search}\"";
            }

            return search;
        }

        internal void OnBeforeWriteObject(global::System.Collections.Generic.Dictionary<string, object> boundParameters, global::System.Collections.Generic.IDictionary<string, object> additionalProperties)
        {
            // Get odata.count from the response.
            if (boundParameters.ContainsKey("CountVariable") &&
                additionalProperties != null &&
                additionalProperties.TryGetValue("@odata.count", out var odataCount))
            {
                // Save the Count back to the PS environment in a global variable.
                // We need to store count in a global variable since these cmdlets are exported as functions.
                // i.e. Functions can't modify parent scope.
                var psVI = SessionState.PSVariable;
                psVI.Set(new PSVariable(CountVariable.Contains(":") ? CountVariable : $"global:{CountVariable}", odataCount));
            }
        }

        private bool IsAllPresent(global::System.Collections.Generic.Dictionary<string, object> boundParameters)
        {
            return boundParameters.ContainsKey("All") && All.IsPresent;
        }
    }
}
