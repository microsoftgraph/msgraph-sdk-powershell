// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Models
{
    public interface IGraphCommand
    {
        string Command { get; set; }
        string Module { get; set; }
        string APIVersion { get; set; }
        string Method { get; set; }
        string URL { get; set; }
        string OutputType { get; set; }
        string[] Variants { get; set; }
        GraphPermission[] Permissions { get; set; }
    }

    /// <summary>
    /// Represents a Microsoft Graph powershell command metainfo.
    /// </summary>
    public class GraphCommand : IGraphCommand
    {
        /// <summary>
        /// Name of the command.
        /// </summary>
        public string Command { get; set; }
        /// <summary>
        /// The module in which the command is found.
        /// </summary>
        public string Module { get; set; }
        /// <summary>
        /// The service API version the command uses.
        /// </summary>
        public string APIVersion { get; set; }
        /// <summary>
        /// HTTP method the command makes.
        /// </summary>
        public string Method { get; set; }
        /// <summary>
        /// The API path the command calls.
        /// </summary>
        public string URL { get; set; }
        /// <summary>
        /// The response type of the command.
        /// </summary>
        public string OutputType { get; set; }
        /// <summary>
        /// The parameter sets of the command.
        /// </summary>
        public string[] Variants { get; set; }
        public GraphPermission[] Permissions { get; set; }
    }

    /// <summary>
    /// Represents a Microsoft Graph permission.
    /// </summary>
    public class GraphPermission
    {
        /// <summary>
        /// Permission name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Indicates whether the permission requires an admin consent.
        /// </summary>
        public bool IsAdmin { get; set; }
        /// <summary>
        /// Short description of the permission.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Full deescription of the permission.
        /// </summary>
        public string FullDescription { get; set; }
    }
}
