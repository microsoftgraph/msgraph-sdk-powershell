namespace Microsoft.Graph.Beta.PowerShell.Models.TeamsInternal
{
    using static Microsoft.Graph.Beta.PowerShell.Runtime.Extensions;

    /// <summary>
    /// Teams internal model for all approved permissions on a specific resource in preapproval policies.
    /// </summary>
    internal class MGTeamsInternalAllPreApprovedPermissionsOnResourceApp : MGTeamsInternalPreApprovedPermissions
    {
        /// <summary>
        /// The resource application Id.
        /// </summary>
        internal string ResourceApplicationId { get; private set; }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonNode"/> into an instance of MGTeamsInternalAllPreApprovedPermissionsOnResourceApp.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of MGTeamsInternalAllPreApprovedPermissionsOnResourceApp.</returns>
        internal static new MGTeamsInternalAllPreApprovedPermissionsOnResourceApp FromJson(Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonObject json)
        {
            return new MGTeamsInternalAllPreApprovedPermissionsOnResourceApp(json);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MGTeamsInternalAllPreApprovedPermissionsOnResourceApp"/> class.
        /// </summary>
        internal MGTeamsInternalAllPreApprovedPermissionsOnResourceApp(Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonObject json)
            : base(json)
        {
            string resourceApplicationId = If(json.PropertyT<Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonString>("resourceApplicationId"), out var jsonResourceApplicationId)
                ? (string)ResourceApplicationId
                : string.Empty;

            this.SetProperties(resourceApplicationId);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MGTeamsInternalAllPreApprovedPermissionsOnResourceApp"/> class.
        /// </summary>
        internal MGTeamsInternalAllPreApprovedPermissionsOnResourceApp()
            : base(permissionKind: "allPermissionsOnResourceApp", odataType: "#microsoft.graph.allPreApprovedPermissionsOnResourceApp")
        {
            this.SetProperties(resourceApplicationId: "00000003-0000-0000-c000-000000000000");
        }

        /// <summary>
        /// Initialize properties of this object.
        /// </summary>
        private void SetProperties(string resourceApplicationId)
        {
            this.ResourceApplicationId = resourceApplicationId;
        }

        /// <summary>
        /// Serializes this instance into a <see cref="Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonNode" />.
        /// </summary>
        internal override Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonNode ToJson()
        {
            Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonObject jsonObject =
                (Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonObject)base.ToJson();

            if (this.ResourceApplicationId != null)
            {
                jsonObject.Add("resourceApplicationId", (Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonNode)new Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonString(this.ResourceApplicationId));
            }

            return jsonObject;
        }
    }
}