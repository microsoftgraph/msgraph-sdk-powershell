### Example 1: Add search with linked files and the latest cloud attachment version

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	search = @{
		id = "c17e91d6-6bc0-4ecb-b388-269ea3d4ffb7"
	}
	additionalDataOptions = "linkedFiles"
	cloudAttachmentVersion = "latest"
}

Add-MgBetaSecurityCaseEdiscoveryCaseReviewSetToReviewSet -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewSetId $ediscoveryReviewSetId -BodyParameter $params

```
This example will add search with linked files and the latest cloud attachment version

### Example 2: Add search with all data options and the latest cloud and document versions

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	search = @{
		id = "c17e91d6-6bc0-4ecb-b388-269ea3d4ffb7"
	}
	additionalDataOptions = "linkedFiles, allVersions, advancedIndexing, listAttachments, htmlTranscripts, messageConversationExpansion, locationsWithoutHits, allItemsInFolder"
	cloudAttachmentVersion = "latest"
	documentVersion = "recent10"
}

Add-MgBetaSecurityCaseEdiscoveryCaseReviewSetToReviewSet -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewSetId $ediscoveryReviewSetId -BodyParameter $params

```
This example will add search with all data options and the latest cloud and document versions

