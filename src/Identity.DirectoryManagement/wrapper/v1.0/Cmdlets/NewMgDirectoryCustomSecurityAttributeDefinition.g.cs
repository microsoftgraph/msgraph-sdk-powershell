#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("POST", "/directory/customSecurityAttributeDefinitions")]
    [Cmdlet(VerbsCommon.New, "MgDirectoryCustomSecurityAttributeDefinition", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.CustomSecurityAttributeDefinition))]
    public class NewMgDirectoryCustomSecurityAttributeDefinitionCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AttributeSet { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsCollection { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSearchable { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public string? Status { get; set; }

        [Parameter(Mandatory = false)]
        public string? Type { get; set; }

        [Parameter(Mandatory = false)]
        public bool? UsePreDefinedValuesOnly { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.CustomSecurityAttributeDefinition();

    if (this.IsParameterBound(nameof(AttributeSet)))
        body.AttributeSet = AttributeSet;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(IsCollection)))
        body.IsCollection = IsCollection;

    if (this.IsParameterBound(nameof(IsSearchable)))
        body.IsSearchable = IsSearchable;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;

    if (this.IsParameterBound(nameof(UsePreDefinedValuesOnly)))
        body.UsePreDefinedValuesOnly = UsePreDefinedValuesOnly;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.CustomSecurityAttributeDefinition? result;
            try
            {
                result = client.Directory.CustomSecurityAttributeDefinitions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
