namespace Microsoft.Graph.Beta.PowerShell.Models.TeamsInternal
{
    /// <summary>
    /// Teams internal model for all approved permissions in preapproval policies.
    /// </summary>
    internal class MGTeamsInternalAllPreApprovedPermissions : MGTeamsInternalPreApprovedPermissions
    {
        /// <summary>
        /// Deserializes a <see cref="Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonNode"/> into an instance of MGTeamsInternalAllPreApprovedPermissions.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of MGTeamsInternalAllPreApprovedPermissions.</returns>
        internal static new MGTeamsInternalAllPreApprovedPermissions FromJson(Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonObject json)
        {
            return new MGTeamsInternalAllPreApprovedPermissions(json);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MGTeamsInternalAllPreApprovedPermissions"/> class.
        /// </summary>
        internal MGTeamsInternalAllPreApprovedPermissions(Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonObject json)
            : base(json)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MGTeamsInternalAllPreApprovedPermissions"/> class.
        /// </summary>
        internal MGTeamsInternalAllPreApprovedPermissions()
            : base(permissionKind: "all", odataType: "#microsoft.graph.allPreApprovedPermissions")
        {
        }

        /// <summary>
        /// Serialize this instance to a JsonNode.
        /// </summary>
        /// <returns>Json Node.</returns>
        internal override Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonNode ToJson()
        {
            Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonObject jsonObject =
                (Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonObject)base.ToJson();

            return jsonObject;
        }
    }
}