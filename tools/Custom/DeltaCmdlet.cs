// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace NamespacePrefixPlaceholder.PowerShell.Cmdlets.Custom
{
    using System.Management.Automation;
    public partial class DeltaCmdlet : ListCmdlet
    {
        /// <summary>Backing field for <see cref="DeltaLink" /> property.</summary>
        private string _deltaLink;

        /// <summary>The deltaLink URL, which will provide the changes that have occurred in the data set since the initial request was made.".</summary>
        [Parameter(Mandatory = false, HelpMessage = "The deltaLink URL, which will provide the changes that have occurred in the data set since the initial request was made.")]
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The deltaLink URL, which will provide the changes that have occurred in the data set since the initial request was made.",
        PossibleTypes = new[] { typeof(string) })]
        [Category(ParameterCategory.Runtime)]
        public string DeltaLink { get => this._deltaLink; set => this._deltaLink = value; }

        // <summary>Backing field for <see cref="CountVariable" /> property.</summary>
        private string _deltaLinkVariable = nameof(DeltaLinkVariable);

        /// <summary>A variable that's used to hold the deltaLink URL value from the last page.</summary>
        [Parameter(Mandatory = false, HelpMessage = "A variable that's used to hold the deltaLink URL value from the last page. By default, this variable will be set in the global scope.")]
        [Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A variable that's used to hold the deltaLink URL value from the last page. By default, this variable will be set in the global scope.",
        PossibleTypes = new[] { typeof(string) })]
        [Category(ParameterCategory.Runtime)]
        public string DeltaLinkVariable { get => this._deltaLinkVariable; set => this._deltaLinkVariable = value; }

        internal void SetDeltaLinkVariable(string deltaLink)
        {
            // Save the @odata.deltaLink to the PS environment in a global variable.
            // We need to store @odata.deltaLink in a global variable since these cmdlets are exported as functions. i.e. Functions can't modify parent scope.
            var psVI = SessionState.PSVariable;
            psVI.Set(new PSVariable(DeltaLinkVariable.Contains(":") ? DeltaLinkVariable : $"global:{DeltaLinkVariable}", deltaLink));
        }
    }
}
