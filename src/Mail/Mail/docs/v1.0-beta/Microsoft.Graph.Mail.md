---
Module Name: Microsoft.Graph.Mail
Module Guid: e71112ef-6a3a-4d15-9582-6a2fcbff607d
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.mail
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Mail Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Mail Cmdlets
### [Get-MgUserInferenceClassification](Get-MgUserInferenceClassification.md)
Relevance classification of the user's messages based on explicit designations which override inferred relevance or importance.

### [Get-MgUserInferenceClassificationOverride](Get-MgUserInferenceClassificationOverride.md)
A set of overrides for a user to always classify messages from specific senders in certain ways: focused, or other.
Read-only.
Nullable.

### [Get-MgUserMailFolder](Get-MgUserMailFolder.md)
The user's mail folders.
Read-only.
Nullable.

### [Get-MgUserMailFolderChildFolder](Get-MgUserMailFolderChildFolder.md)
The collection of child folders in the mailFolder.

### [Get-MgUserMailFolderMessage](Get-MgUserMailFolderMessage.md)
The collection of messages in the mailFolder.

### [Get-MgUserMailFolderMessageAttachment](Get-MgUserMailFolderMessageAttachment.md)
The fileAttachment and itemAttachment attachments for the message.

### [Get-MgUserMailFolderMessageContent](Get-MgUserMailFolderMessageContent.md)
Get media content for the navigation property messages from users

### [Get-MgUserMailFolderMessageExtension](Get-MgUserMailFolderMessageExtension.md)
The collection of open extensions defined for the message.
Nullable.

### [Get-MgUserMailFolderMessageMention](Get-MgUserMailFolderMessageMention.md)
A collection of mentions in the message, ordered by the createdDateTime from the newest to the oldest.
By default, a GET /messages does not return this property unless you apply $expand on the property.

### [Get-MgUserMailFolderMessageMultiValueExtendedProperty](Get-MgUserMailFolderMessageMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the message.
Nullable.

### [Get-MgUserMailFolderMessageRule](Get-MgUserMailFolderMessageRule.md)
The collection of rules that apply to the user's Inbox folder.

### [Get-MgUserMailFolderMessageSingleValueExtendedProperty](Get-MgUserMailFolderMessageSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the message.
Nullable.

### [Get-MgUserMailFolderMultiValueExtendedProperty](Get-MgUserMailFolderMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the mailFolder.
Read-only.
Nullable.

### [Get-MgUserMailFolderSingleValueExtendedProperty](Get-MgUserMailFolderSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the mailFolder.
Read-only.
Nullable.

### [Get-MgUserMailFolderUserConfiguration](Get-MgUserMailFolderUserConfiguration.md)
Get userConfigurations from users

### [Get-MgUserMessage](Get-MgUserMessage.md)
The messages in a mailbox or folder.
Read-only.
Nullable.

### [Get-MgUserMessageAttachment](Get-MgUserMessageAttachment.md)
The fileAttachment and itemAttachment attachments for the message.

### [Get-MgUserMessageContent](Get-MgUserMessageContent.md)
Get media content for the navigation property messages from users

### [Get-MgUserMessageExtension](Get-MgUserMessageExtension.md)
The collection of open extensions defined for the message.
Nullable.

### [Get-MgUserMessageMention](Get-MgUserMessageMention.md)
A collection of mentions in the message, ordered by the createdDateTime from the newest to the oldest.
By default, a GET /messages does not return this property unless you apply $expand on the property.

### [Get-MgUserMessageMultiValueExtendedProperty](Get-MgUserMessageMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the message.
Nullable.

### [Get-MgUserMessageSingleValueExtendedProperty](Get-MgUserMessageSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the message.
Nullable.

### [New-MgUserInferenceClassificationOverride](New-MgUserInferenceClassificationOverride.md)
A set of overrides for a user to always classify messages from specific senders in certain ways: focused, or other.
Read-only.
Nullable.

### [New-MgUserMailFolder](New-MgUserMailFolder.md)
The user's mail folders.
Read-only.
Nullable.

### [New-MgUserMailFolderChildFolder](New-MgUserMailFolderChildFolder.md)
The collection of child folders in the mailFolder.

### [New-MgUserMailFolderMessage](New-MgUserMailFolderMessage.md)
The collection of messages in the mailFolder.

### [New-MgUserMailFolderMessageAttachment](New-MgUserMailFolderMessageAttachment.md)
The fileAttachment and itemAttachment attachments for the message.

### [New-MgUserMailFolderMessageExtension](New-MgUserMailFolderMessageExtension.md)
The collection of open extensions defined for the message.
Nullable.

### [New-MgUserMailFolderMessageMention](New-MgUserMailFolderMessageMention.md)
A collection of mentions in the message, ordered by the createdDateTime from the newest to the oldest.
By default, a GET /messages does not return this property unless you apply $expand on the property.

### [New-MgUserMailFolderMessageMultiValueExtendedProperty](New-MgUserMailFolderMessageMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the message.
Nullable.

### [New-MgUserMailFolderMessageRule](New-MgUserMailFolderMessageRule.md)
The collection of rules that apply to the user's Inbox folder.

### [New-MgUserMailFolderMessageSingleValueExtendedProperty](New-MgUserMailFolderMessageSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the message.
Nullable.

### [New-MgUserMailFolderMultiValueExtendedProperty](New-MgUserMailFolderMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the mailFolder.
Read-only.
Nullable.

### [New-MgUserMailFolderSingleValueExtendedProperty](New-MgUserMailFolderSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the mailFolder.
Read-only.
Nullable.

### [New-MgUserMailFolderUserConfiguration](New-MgUserMailFolderUserConfiguration.md)
Create new navigation property to userConfigurations for users

### [New-MgUserMessage](New-MgUserMessage.md)
The messages in a mailbox or folder.
Read-only.
Nullable.

### [New-MgUserMessageAttachment](New-MgUserMessageAttachment.md)
The fileAttachment and itemAttachment attachments for the message.

### [New-MgUserMessageExtension](New-MgUserMessageExtension.md)
The collection of open extensions defined for the message.
Nullable.

### [New-MgUserMessageMention](New-MgUserMessageMention.md)
A collection of mentions in the message, ordered by the createdDateTime from the newest to the oldest.
By default, a GET /messages does not return this property unless you apply $expand on the property.

### [New-MgUserMessageMultiValueExtendedProperty](New-MgUserMessageMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the message.
Nullable.

### [New-MgUserMessageSingleValueExtendedProperty](New-MgUserMessageSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the message.
Nullable.

### [Remove-MgUserInferenceClassification](Remove-MgUserInferenceClassification.md)
Relevance classification of the user's messages based on explicit designations which override inferred relevance or importance.

### [Remove-MgUserInferenceClassificationOverride](Remove-MgUserInferenceClassificationOverride.md)
A set of overrides for a user to always classify messages from specific senders in certain ways: focused, or other.
Read-only.
Nullable.

### [Remove-MgUserMailFolder](Remove-MgUserMailFolder.md)
The user's mail folders.
Read-only.
Nullable.

### [Remove-MgUserMailFolderChildFolder](Remove-MgUserMailFolderChildFolder.md)
The collection of child folders in the mailFolder.

### [Remove-MgUserMailFolderMessage](Remove-MgUserMailFolderMessage.md)
The collection of messages in the mailFolder.

### [Remove-MgUserMailFolderMessageAttachment](Remove-MgUserMailFolderMessageAttachment.md)
The fileAttachment and itemAttachment attachments for the message.

### [Remove-MgUserMailFolderMessageExtension](Remove-MgUserMailFolderMessageExtension.md)
The collection of open extensions defined for the message.
Nullable.

### [Remove-MgUserMailFolderMessageMention](Remove-MgUserMailFolderMessageMention.md)
A collection of mentions in the message, ordered by the createdDateTime from the newest to the oldest.
By default, a GET /messages does not return this property unless you apply $expand on the property.

### [Remove-MgUserMailFolderMessageMultiValueExtendedProperty](Remove-MgUserMailFolderMessageMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the message.
Nullable.

### [Remove-MgUserMailFolderMessageRule](Remove-MgUserMailFolderMessageRule.md)
The collection of rules that apply to the user's Inbox folder.

### [Remove-MgUserMailFolderMessageSingleValueExtendedProperty](Remove-MgUserMailFolderMessageSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the message.
Nullable.

### [Remove-MgUserMailFolderMultiValueExtendedProperty](Remove-MgUserMailFolderMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the mailFolder.
Read-only.
Nullable.

### [Remove-MgUserMailFolderSingleValueExtendedProperty](Remove-MgUserMailFolderSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the mailFolder.
Read-only.
Nullable.

### [Remove-MgUserMailFolderUserConfiguration](Remove-MgUserMailFolderUserConfiguration.md)
Delete navigation property userConfigurations for users

### [Remove-MgUserMessage](Remove-MgUserMessage.md)
The messages in a mailbox or folder.
Read-only.
Nullable.

### [Remove-MgUserMessageAttachment](Remove-MgUserMessageAttachment.md)
The fileAttachment and itemAttachment attachments for the message.

### [Remove-MgUserMessageExtension](Remove-MgUserMessageExtension.md)
The collection of open extensions defined for the message.
Nullable.

### [Remove-MgUserMessageMention](Remove-MgUserMessageMention.md)
A collection of mentions in the message, ordered by the createdDateTime from the newest to the oldest.
By default, a GET /messages does not return this property unless you apply $expand on the property.

### [Remove-MgUserMessageMultiValueExtendedProperty](Remove-MgUserMessageMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the message.
Nullable.

### [Remove-MgUserMessageSingleValueExtendedProperty](Remove-MgUserMessageSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the message.
Nullable.

### [Set-MgUserMailFolderMessageContent](Set-MgUserMailFolderMessageContent.md)
Update media content for the navigation property messages in users

### [Set-MgUserMessageContent](Set-MgUserMessageContent.md)
Update media content for the navigation property messages in users

### [Update-MgUserInferenceClassification](Update-MgUserInferenceClassification.md)
Relevance classification of the user's messages based on explicit designations which override inferred relevance or importance.

### [Update-MgUserInferenceClassificationOverride](Update-MgUserInferenceClassificationOverride.md)
A set of overrides for a user to always classify messages from specific senders in certain ways: focused, or other.
Read-only.
Nullable.

### [Update-MgUserMailFolder](Update-MgUserMailFolder.md)
The user's mail folders.
Read-only.
Nullable.

### [Update-MgUserMailFolderChildFolder](Update-MgUserMailFolderChildFolder.md)
The collection of child folders in the mailFolder.

### [Update-MgUserMailFolderMessage](Update-MgUserMailFolderMessage.md)
The collection of messages in the mailFolder.

### [Update-MgUserMailFolderMessageAttachment](Update-MgUserMailFolderMessageAttachment.md)
The fileAttachment and itemAttachment attachments for the message.

### [Update-MgUserMailFolderMessageExtension](Update-MgUserMailFolderMessageExtension.md)
The collection of open extensions defined for the message.
Nullable.

### [Update-MgUserMailFolderMessageMention](Update-MgUserMailFolderMessageMention.md)
A collection of mentions in the message, ordered by the createdDateTime from the newest to the oldest.
By default, a GET /messages does not return this property unless you apply $expand on the property.

### [Update-MgUserMailFolderMessageMultiValueExtendedProperty](Update-MgUserMailFolderMessageMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the message.
Nullable.

### [Update-MgUserMailFolderMessageRule](Update-MgUserMailFolderMessageRule.md)
The collection of rules that apply to the user's Inbox folder.

### [Update-MgUserMailFolderMessageSingleValueExtendedProperty](Update-MgUserMailFolderMessageSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the message.
Nullable.

### [Update-MgUserMailFolderMultiValueExtendedProperty](Update-MgUserMailFolderMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the mailFolder.
Read-only.
Nullable.

### [Update-MgUserMailFolderSingleValueExtendedProperty](Update-MgUserMailFolderSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the mailFolder.
Read-only.
Nullable.

### [Update-MgUserMailFolderUserConfiguration](Update-MgUserMailFolderUserConfiguration.md)
Update the navigation property userConfigurations in users

### [Update-MgUserMessage](Update-MgUserMessage.md)
The messages in a mailbox or folder.
Read-only.
Nullable.

### [Update-MgUserMessageAttachment](Update-MgUserMessageAttachment.md)
The fileAttachment and itemAttachment attachments for the message.

### [Update-MgUserMessageExtension](Update-MgUserMessageExtension.md)
The collection of open extensions defined for the message.
Nullable.

### [Update-MgUserMessageMention](Update-MgUserMessageMention.md)
A collection of mentions in the message, ordered by the createdDateTime from the newest to the oldest.
By default, a GET /messages does not return this property unless you apply $expand on the property.

### [Update-MgUserMessageMultiValueExtendedProperty](Update-MgUserMessageMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the message.
Nullable.

### [Update-MgUserMessageSingleValueExtendedProperty](Update-MgUserMessageSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the message.
Nullable.

