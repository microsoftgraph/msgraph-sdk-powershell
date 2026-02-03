namespace Microsoft.Graph.Beta.PowerShell.Models.TeamsInternal
{
    /// <summary>
    /// Teams internal model for all scope sensitivity labels in preapproval policies.
    /// </summary>
    internal class MGTeamsInternalAllScopeSensitivityLabels : MGTeamsInternalScopeSensitivityLabels
    {
        /// <summary>
        /// Deserializes a <see cref="Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonNode"/> into an instance of MGTeamsInternalAllScopeSensitivityLabels.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of MGTeamsInternalAllScopeSensitivityLabels.</returns>
        internal static new MGTeamsInternalAllScopeSensitivityLabels FromJson(Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonObject json)
        {
            return new MGTeamsInternalAllScopeSensitivityLabels(json);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MGTeamsInternalAllScopeSensitivityLabels"/> class.
        /// </summary>
        internal MGTeamsInternalAllScopeSensitivityLabels(Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonObject json) :
            base(json)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MGTeamsInternalAllScopeSensitivityLabels"/> class.
        /// </summary>
        internal MGTeamsInternalAllScopeSensitivityLabels() :
            base(labelKind: "all", type: "#microsoft.graph.allScopeSensitivityLabels")
        {
        }

        /// <summary>
        /// Serializes this instance into a <see cref="Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonNode" />.
        /// </summary>
        internal override Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonNode ToJson()
        {
            Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonObject jsonObject =
                (Microsoft.Graph.Beta.PowerShell.Runtime.Json.JsonObject)base.ToJson();

            return jsonObject;
        }
    }
}