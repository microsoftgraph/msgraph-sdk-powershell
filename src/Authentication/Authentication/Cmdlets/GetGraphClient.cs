using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, "GraphClient", DefaultParameterSetName = Constants.UserParameterSet)]
    [OutputType(typeof(IAuthContext))]
    public class GetGraphClient : PSCmdlet
    {
        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            IAuthContext authConfig = GraphSession.Instance.AuthContext;
            HttpClient client = HttpHelpers.GetGraphHttpClient(authConfig);
            WriteObject(client);
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }
    }
}