---
Module Name: Microsoft.Graph.Mail
Module Guid: dc619290-2848-4f9d-8cd8-bba8d361bfd9
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

### [Get-MgUserMailFolderChildFolderMessage](Get-MgUserMailFolderChildFolderMessage.md)
The collection of messages in the mailFolder.

### [Get-MgUserMailFolderChildFolderMessageAttachment](Get-MgUserMailFolderChildFolderMessageAttachment.md)
The fileAttachment and itemAttachment attachments for the message.

### [Get-MgUserMailFolderChildFolderMessageContent](Get-MgUserMailFolderChildFolderMessageContent.md)
Get media content for the navigation property messages from users

### [Get-MgUserMailFolderChildFolderMessageExtension](Get-MgUserMailFolderChildFolderMessageExtension.md)
The collection of open extensions defined for the message.
Nullable.

### [Get-MgUserMailFolderChildFolderMessageMention](Get-MgUserMailFolderChildFolderMessageMention.md)
A collection of mentions in the message, ordered by the createdDateTime from the newest to the oldest.
By default, a GET /messages does not return this property unless you apply $expand on the property.

### [Get-MgUserMailFolderChildFolderMessageMultiValueExtendedProperty](Get-MgUserMailFolderChildFolderMessageMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the message.
Nullable.

### [Get-MgUserMailFolderChildFolderMessageRule](Get-MgUserMailFolderChildFolderMessageRule.md)
The collection of rules that apply to the user's Inbox folder.

### [Get-MgUserMailFolderChildFolderMessageSingleValueExtendedProperty](Get-MgUserMailFolderChildFolderMessageSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the message.
Nullable.

### [Get-MgUserMailFolderChildFolderMultiValueExtendedProperty](Get-MgUserMailFolderChildFolderMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the mailFolder.
Read-only.
Nullable.

### [Get-MgUserMailFolderChildFolderSingleValueExtendedProperty](Get-MgUserMailFolderChildFolderSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the mailFolder.
Read-only.
Nullable.

### [Get-MgUserMailFolderChildFolderUserConfiguration](Get-MgUserMailFolderChildFolderUserConfiguration.md)
Get userConfigurations from users

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
Create a focused Inbox override for a sender identified by an SMTP address.
Future messages from that SMTP address will be consistently classified\nas specified in the override.

### [New-MgUserMailFolder](New-MgUserMailFolder.md)
Use this API to create a new mail folder in the root folder of the user's mailbox.
If you intend a new folder to be hidden, you must set the **isHidden** property to `true` on creation.

### [New-MgUserMailFolderChildFolder](New-MgUserMailFolderChildFolder.md)
Use this API to create a new child mailFolder.
If you intend a new folder to be hidden, you must set the **isHidden** property to `true` on creation.

### [New-MgUserMailFolderChildFolderMessage](New-MgUserMailFolderChildFolderMessage.md)
Use this API to create a new Message in a mailfolder.

### [New-MgUserMailFolderChildFolderMessageAttachment](New-MgUserMailFolderChildFolderMessageAttachment.md)
Use this API to add an attachment to a message.
An attachment can be one of the following types: All these types of attachment resources are derived from the attachment\nresource.
You can add an attachment to an existing message by posting to its attachments collection, or to a new \nmessage that is being drafted, or created and sent on the fly.

### [New-MgUserMailFolderChildFolderMessageExtension](New-MgUserMailFolderChildFolderMessageExtension.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
See known limitations of open extensions for more information.
The table in the Permissions section lists the resources that support open extensions.

### [New-MgUserMailFolderChildFolderMessageMention](New-MgUserMailFolderChildFolderMessageMention.md)
Create new navigation property to mentions for users

### [New-MgUserMailFolderChildFolderMessageMultiValueExtendedProperty](New-MgUserMailFolderChildFolderMessageMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgUserMailFolderChildFolderMessageRule](New-MgUserMailFolderChildFolderMessageRule.md)
Create new navigation property to messageRules for users

### [New-MgUserMailFolderChildFolderMessageSingleValueExtendedProperty](New-MgUserMailFolderChildFolderMessageSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgUserMailFolderChildFolderMultiValueExtendedProperty](New-MgUserMailFolderChildFolderMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgUserMailFolderChildFolderSingleValueExtendedProperty](New-MgUserMailFolderChildFolderSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgUserMailFolderMessage](New-MgUserMailFolderMessage.md)
Use this API to create a new Message in a mailfolder.

### [New-MgUserMailFolderMessageAttachment](New-MgUserMailFolderMessageAttachment.md)
Use this API to add an attachment to a message.
An attachment can be one of the following types: All these types of attachment resources are derived from the attachment\nresource.
You can add an attachment to an existing message by posting to its attachments collection, or to a new \nmessage that is being drafted, or created and sent on the fly.

### [New-MgUserMailFolderMessageExtension](New-MgUserMailFolderMessageExtension.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
See known limitations of open extensions for more information.
The table in the Permissions section lists the resources that support open extensions.

### [New-MgUserMailFolderMessageMention](New-MgUserMailFolderMessageMention.md)
Create new navigation property to mentions for users

### [New-MgUserMailFolderMessageMultiValueExtendedProperty](New-MgUserMailFolderMessageMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgUserMailFolderMessageRule](New-MgUserMailFolderMessageRule.md)
Create new navigation property to messageRules for users

### [New-MgUserMailFolderMessageSingleValueExtendedProperty](New-MgUserMailFolderMessageSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgUserMailFolderMultiValueExtendedProperty](New-MgUserMailFolderMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgUserMailFolderSingleValueExtendedProperty](New-MgUserMailFolderSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgUserMessage](New-MgUserMessage.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
See known limitations of open extensions for more information.
The table in the Permissions section lists the resources that support open extensions.

### [New-MgUserMessageAttachment](New-MgUserMessageAttachment.md)
Use this API to add an attachment to a message.
An attachment can be one of the following types: All these types of attachment resources are derived from the attachment\nresource.
You can add an attachment to an existing message by posting to its attachments collection, or to a new \nmessage that is being drafted, or created and sent on the fly.

### [New-MgUserMessageExtension](New-MgUserMessageExtension.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
See known limitations of open extensions for more information.
The table in the Permissions section lists the resources that support open extensions.

### [New-MgUserMessageMention](New-MgUserMessageMention.md)
Create new navigation property to mentions for users

### [New-MgUserMessageMultiValueExtendedProperty](New-MgUserMessageMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgUserMessageSingleValueExtendedProperty](New-MgUserMessageSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [Remove-MgUserInferenceClassificationOverride](Remove-MgUserInferenceClassificationOverride.md)
Delete navigation property overrides for users

### [Remove-MgUserMailFolder](Remove-MgUserMailFolder.md)
Delete navigation property mailFolders for users

### [Remove-MgUserMailFolderChildFolder](Remove-MgUserMailFolderChildFolder.md)
Delete navigation property childFolders for users

### [Remove-MgUserMailFolderChildFolderMessage](Remove-MgUserMailFolderChildFolderMessage.md)
Delete navigation property messages for users

### [Remove-MgUserMailFolderChildFolderMessageAttachment](Remove-MgUserMailFolderChildFolderMessageAttachment.md)
Delete navigation property attachments for users

### [Remove-MgUserMailFolderChildFolderMessageExtension](Remove-MgUserMailFolderChildFolderMessageExtension.md)
Delete navigation property extensions for users

### [Remove-MgUserMailFolderChildFolderMessageMention](Remove-MgUserMailFolderChildFolderMessageMention.md)
Delete navigation property mentions for users

### [Remove-MgUserMailFolderChildFolderMessageMultiValueExtendedProperty](Remove-MgUserMailFolderChildFolderMessageMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgUserMailFolderChildFolderMessageRule](Remove-MgUserMailFolderChildFolderMessageRule.md)
Delete navigation property messageRules for users

### [Remove-MgUserMailFolderChildFolderMessageSingleValueExtendedProperty](Remove-MgUserMailFolderChildFolderMessageSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgUserMailFolderChildFolderMultiValueExtendedProperty](Remove-MgUserMailFolderChildFolderMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgUserMailFolderChildFolderSingleValueExtendedProperty](Remove-MgUserMailFolderChildFolderSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgUserMailFolderMessage](Remove-MgUserMailFolderMessage.md)
Delete navigation property messages for users

### [Remove-MgUserMailFolderMessageAttachment](Remove-MgUserMailFolderMessageAttachment.md)
Delete navigation property attachments for users

### [Remove-MgUserMailFolderMessageExtension](Remove-MgUserMailFolderMessageExtension.md)
Delete navigation property extensions for users

### [Remove-MgUserMailFolderMessageMention](Remove-MgUserMailFolderMessageMention.md)
Delete navigation property mentions for users

### [Remove-MgUserMailFolderMessageMultiValueExtendedProperty](Remove-MgUserMailFolderMessageMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgUserMailFolderMessageRule](Remove-MgUserMailFolderMessageRule.md)
Delete navigation property messageRules for users

### [Remove-MgUserMailFolderMessageSingleValueExtendedProperty](Remove-MgUserMailFolderMessageSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgUserMailFolderMultiValueExtendedProperty](Remove-MgUserMailFolderMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgUserMailFolderSingleValueExtendedProperty](Remove-MgUserMailFolderSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgUserMessage](Remove-MgUserMessage.md)
Delete navigation property messages for users

### [Remove-MgUserMessageAttachment](Remove-MgUserMessageAttachment.md)
Delete navigation property attachments for users

### [Remove-MgUserMessageExtension](Remove-MgUserMessageExtension.md)
Delete navigation property extensions for users

### [Remove-MgUserMessageMention](Remove-MgUserMessageMention.md)
Delete navigation property mentions for users

### [Remove-MgUserMessageMultiValueExtendedProperty](Remove-MgUserMessageMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgUserMessageSingleValueExtendedProperty](Remove-MgUserMessageSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Set-MgUserMailFolderChildFolderMessageContent](Set-MgUserMailFolderChildFolderMessageContent.md)
Update media content for the navigation property messages in users

### [Set-MgUserMailFolderMessageContent](Set-MgUserMailFolderMessageContent.md)
Update media content for the navigation property messages in users

### [Set-MgUserMessageContent](Set-MgUserMessageContent.md)
Update media content for the navigation property messages in users

### [Update-MgUserInferenceClassification](Update-MgUserInferenceClassification.md)
Update the navigation property inferenceClassification in users

### [Update-MgUserInferenceClassificationOverride](Update-MgUserInferenceClassificationOverride.md)
Update the navigation property overrides in users

### [Update-MgUserMailFolder](Update-MgUserMailFolder.md)
Update the navigation property mailFolders in users

### [Update-MgUserMailFolderChildFolder](Update-MgUserMailFolderChildFolder.md)
Update the navigation property childFolders in users

### [Update-MgUserMailFolderChildFolderMessage](Update-MgUserMailFolderChildFolderMessage.md)
Update the navigation property messages in users

### [Update-MgUserMailFolderChildFolderMessageExtension](Update-MgUserMailFolderChildFolderMessageExtension.md)
Update the navigation property extensions in users

### [Update-MgUserMailFolderChildFolderMessageMultiValueExtendedProperty](Update-MgUserMailFolderChildFolderMessageMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgUserMailFolderChildFolderMessageRule](Update-MgUserMailFolderChildFolderMessageRule.md)
Update the navigation property messageRules in users

### [Update-MgUserMailFolderChildFolderMessageSingleValueExtendedProperty](Update-MgUserMailFolderChildFolderMessageSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgUserMailFolderChildFolderMultiValueExtendedProperty](Update-MgUserMailFolderChildFolderMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgUserMailFolderChildFolderSingleValueExtendedProperty](Update-MgUserMailFolderChildFolderSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgUserMailFolderMessage](Update-MgUserMailFolderMessage.md)
Update the navigation property messages in users

### [Update-MgUserMailFolderMessageExtension](Update-MgUserMailFolderMessageExtension.md)
Update the navigation property extensions in users

### [Update-MgUserMailFolderMessageMultiValueExtendedProperty](Update-MgUserMailFolderMessageMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgUserMailFolderMessageRule](Update-MgUserMailFolderMessageRule.md)
Update the navigation property messageRules in users

### [Update-MgUserMailFolderMessageSingleValueExtendedProperty](Update-MgUserMailFolderMessageSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgUserMailFolderMultiValueExtendedProperty](Update-MgUserMailFolderMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgUserMailFolderSingleValueExtendedProperty](Update-MgUserMailFolderSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgUserMessage](Update-MgUserMessage.md)
Update the navigation property messages in users

### [Update-MgUserMessageExtension](Update-MgUserMessageExtension.md)
Update the navigation property extensions in users

### [Update-MgUserMessageMultiValueExtendedProperty](Update-MgUserMessageMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgUserMessageSingleValueExtendedProperty](Update-MgUserMessageSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

