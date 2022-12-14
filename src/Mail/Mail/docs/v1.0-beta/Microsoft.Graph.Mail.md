---
Module Name: Microsoft.Graph.Beta.Mail
Module Guid: 6dd54432-f738-4ddb-95a3-0b484a31ab73
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.Beta.mail
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Mail Module
## Description
Microsoft.Graph.Beta PowerShell Cmdlets

## Microsoft.Graph.Beta.Mail Cmdlets
### [Get-MgBetaUserInferenceClassification](Get-MgBetaUserInferenceClassification.md)
Relevance classification of the user's messages based on explicit designations which override inferred relevance or importance.

### [Get-MgBetaUserInferenceClassificationOverride](Get-MgBetaUserInferenceClassificationOverride.md)
A set of overrides for a user to always classify messages from specific senders in certain ways: focused, or other.
Read-only.
Nullable.

### [Get-MgBetaUserMailFolder](Get-MgBetaUserMailFolder.md)
The user's mail folders.
Read-only.
Nullable.

### [Get-MgBetaUserMailFolderChildFolder](Get-MgBetaUserMailFolderChildFolder.md)
The collection of child folders in the mailFolder.

### [Get-MgBetaUserMailFolderChildFolderMessage](Get-MgBetaUserMailFolderChildFolderMessage.md)
The collection of messages in the mailFolder.

### [Get-MgBetaUserMailFolderChildFolderMessageAttachment](Get-MgBetaUserMailFolderChildFolderMessageAttachment.md)
The fileAttachment and itemAttachment attachments for the message.

### [Get-MgBetaUserMailFolderChildFolderMessageContent](Get-MgBetaUserMailFolderChildFolderMessageContent.md)
Get media content for the navigation property messages from users

### [Get-MgBetaUserMailFolderChildFolderMessageExtension](Get-MgBetaUserMailFolderChildFolderMessageExtension.md)
The collection of open extensions defined for the message.
Nullable.

### [Get-MgBetaUserMailFolderChildFolderMessageMention](Get-MgBetaUserMailFolderChildFolderMessageMention.md)
A collection of mentions in the message, ordered by the createdDateTime from the newest to the oldest.
By default, a GET /messages does not return this property unless you apply $expand on the property.

### [Get-MgBetaUserMailFolderChildFolderMessageMultiValueExtendedProperty](Get-MgBetaUserMailFolderChildFolderMessageMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the message.
Nullable.

### [Get-MgBetaUserMailFolderChildFolderMessageRule](Get-MgBetaUserMailFolderChildFolderMessageRule.md)
The collection of rules that apply to the user's Inbox folder.

### [Get-MgBetaUserMailFolderChildFolderMessageSingleValueExtendedProperty](Get-MgBetaUserMailFolderChildFolderMessageSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the message.
Nullable.

### [Get-MgBetaUserMailFolderChildFolderMultiValueExtendedProperty](Get-MgBetaUserMailFolderChildFolderMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the mailFolder.
Read-only.
Nullable.

### [Get-MgBetaUserMailFolderChildFolderSingleValueExtendedProperty](Get-MgBetaUserMailFolderChildFolderSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the mailFolder.
Read-only.
Nullable.

### [Get-MgBetaUserMailFolderChildFolderUserConfiguration](Get-MgBetaUserMailFolderChildFolderUserConfiguration.md)
Get userConfigurations from users

### [Get-MgBetaUserMailFolderMessage](Get-MgBetaUserMailFolderMessage.md)
The collection of messages in the mailFolder.

### [Get-MgBetaUserMailFolderMessageAttachment](Get-MgBetaUserMailFolderMessageAttachment.md)
The fileAttachment and itemAttachment attachments for the message.

### [Get-MgBetaUserMailFolderMessageContent](Get-MgBetaUserMailFolderMessageContent.md)
Get media content for the navigation property messages from users

### [Get-MgBetaUserMailFolderMessageExtension](Get-MgBetaUserMailFolderMessageExtension.md)
The collection of open extensions defined for the message.
Nullable.

### [Get-MgBetaUserMailFolderMessageMention](Get-MgBetaUserMailFolderMessageMention.md)
A collection of mentions in the message, ordered by the createdDateTime from the newest to the oldest.
By default, a GET /messages does not return this property unless you apply $expand on the property.

### [Get-MgBetaUserMailFolderMessageMultiValueExtendedProperty](Get-MgBetaUserMailFolderMessageMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the message.
Nullable.

### [Get-MgBetaUserMailFolderMessageRule](Get-MgBetaUserMailFolderMessageRule.md)
The collection of rules that apply to the user's Inbox folder.

### [Get-MgBetaUserMailFolderMessageSingleValueExtendedProperty](Get-MgBetaUserMailFolderMessageSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the message.
Nullable.

### [Get-MgBetaUserMailFolderMultiValueExtendedProperty](Get-MgBetaUserMailFolderMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the mailFolder.
Read-only.
Nullable.

### [Get-MgBetaUserMailFolderSingleValueExtendedProperty](Get-MgBetaUserMailFolderSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the mailFolder.
Read-only.
Nullable.

### [Get-MgBetaUserMailFolderUserConfiguration](Get-MgBetaUserMailFolderUserConfiguration.md)
Get userConfigurations from users

### [Get-MgBetaUserMessage](Get-MgBetaUserMessage.md)
The messages in a mailbox or folder.
Read-only.
Nullable.

### [Get-MgBetaUserMessageAttachment](Get-MgBetaUserMessageAttachment.md)
The fileAttachment and itemAttachment attachments for the message.

### [Get-MgBetaUserMessageContent](Get-MgBetaUserMessageContent.md)
Get media content for the navigation property messages from users

### [Get-MgBetaUserMessageExtension](Get-MgBetaUserMessageExtension.md)
The collection of open extensions defined for the message.
Nullable.

### [Get-MgBetaUserMessageMention](Get-MgBetaUserMessageMention.md)
A collection of mentions in the message, ordered by the createdDateTime from the newest to the oldest.
By default, a GET /messages does not return this property unless you apply $expand on the property.

### [Get-MgBetaUserMessageMultiValueExtendedProperty](Get-MgBetaUserMessageMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the message.
Nullable.

### [Get-MgBetaUserMessageSingleValueExtendedProperty](Get-MgBetaUserMessageSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the message.
Nullable.

### [New-MgBetaUserInferenceClassificationOverride](New-MgBetaUserInferenceClassificationOverride.md)
Create a focused Inbox override for a sender identified by an SMTP address.
Future messages from that SMTP address will be consistently classified\nas specified in the override.

### [New-MgBetaUserMailFolder](New-MgBetaUserMailFolder.md)
Use this API to create a new mail folder in the root folder of the user's mailbox.
If you intend a new folder to be hidden, you must set the **isHidden** property to `true` on creation.

### [New-MgBetaUserMailFolderChildFolder](New-MgBetaUserMailFolderChildFolder.md)
Use this API to create a new child mailFolder.
If you intend a new folder to be hidden, you must set the **isHidden** property to `true` on creation.

### [New-MgBetaUserMailFolderChildFolderMessage](New-MgBetaUserMailFolderChildFolderMessage.md)
Use this API to create a new Message in a mailfolder.

### [New-MgBetaUserMailFolderChildFolderMessageAttachment](New-MgBetaUserMailFolderChildFolderMessageAttachment.md)
Use this API to add an attachment to a message.
An attachment can be one of the following types: All these types of attachment resources are derived from the attachment\nresource.
You can add an attachment to an existing message by posting to its attachments collection, or to a new \nmessage that is being drafted, or created and sent on the fly.

### [New-MgBetaUserMailFolderChildFolderMessageExtension](New-MgBetaUserMailFolderChildFolderMessageExtension.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
See known limitations of open extensions for more information.
The table in the Permissions section lists the resources that support open extensions.

### [New-MgBetaUserMailFolderChildFolderMessageMention](New-MgBetaUserMailFolderChildFolderMessageMention.md)
Create new navigation property to mentions for users

### [New-MgBetaUserMailFolderChildFolderMessageMultiValueExtendedProperty](New-MgBetaUserMailFolderChildFolderMessageMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgBetaUserMailFolderChildFolderMessageRule](New-MgBetaUserMailFolderChildFolderMessageRule.md)
Create new navigation property to messageRules for users

### [New-MgBetaUserMailFolderChildFolderMessageSingleValueExtendedProperty](New-MgBetaUserMailFolderChildFolderMessageSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgBetaUserMailFolderChildFolderMultiValueExtendedProperty](New-MgBetaUserMailFolderChildFolderMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgBetaUserMailFolderChildFolderSingleValueExtendedProperty](New-MgBetaUserMailFolderChildFolderSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgBetaUserMailFolderMessage](New-MgBetaUserMailFolderMessage.md)
Use this API to create a new Message in a mailfolder.

### [New-MgBetaUserMailFolderMessageAttachment](New-MgBetaUserMailFolderMessageAttachment.md)
Use this API to add an attachment to a message.
An attachment can be one of the following types: All these types of attachment resources are derived from the attachment\nresource.
You can add an attachment to an existing message by posting to its attachments collection, or to a new \nmessage that is being drafted, or created and sent on the fly.

### [New-MgBetaUserMailFolderMessageExtension](New-MgBetaUserMailFolderMessageExtension.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
See known limitations of open extensions for more information.
The table in the Permissions section lists the resources that support open extensions.

### [New-MgBetaUserMailFolderMessageMention](New-MgBetaUserMailFolderMessageMention.md)
Create new navigation property to mentions for users

### [New-MgBetaUserMailFolderMessageMultiValueExtendedProperty](New-MgBetaUserMailFolderMessageMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgBetaUserMailFolderMessageRule](New-MgBetaUserMailFolderMessageRule.md)
Create new navigation property to messageRules for users

### [New-MgBetaUserMailFolderMessageSingleValueExtendedProperty](New-MgBetaUserMailFolderMessageSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgBetaUserMailFolderMultiValueExtendedProperty](New-MgBetaUserMailFolderMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgBetaUserMailFolderSingleValueExtendedProperty](New-MgBetaUserMailFolderSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgBetaUserMessage](New-MgBetaUserMessage.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
See known limitations of open extensions for more information.
The table in the Permissions section lists the resources that support open extensions.

### [New-MgBetaUserMessageAttachment](New-MgBetaUserMessageAttachment.md)
Use this API to add an attachment to a message.
An attachment can be one of the following types: All these types of attachment resources are derived from the attachment\nresource.
You can add an attachment to an existing message by posting to its attachments collection, or to a new \nmessage that is being drafted, or created and sent on the fly.

### [New-MgBetaUserMessageExtension](New-MgBetaUserMessageExtension.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
See known limitations of open extensions for more information.
The table in the Permissions section lists the resources that support open extensions.

### [New-MgBetaUserMessageMention](New-MgBetaUserMessageMention.md)
Create new navigation property to mentions for users

### [New-MgBetaUserMessageMultiValueExtendedProperty](New-MgBetaUserMessageMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgBetaUserMessageSingleValueExtendedProperty](New-MgBetaUserMessageSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [Remove-MgBetaUserInferenceClassificationOverride](Remove-MgBetaUserInferenceClassificationOverride.md)
Delete navigation property overrides for users

### [Remove-MgBetaUserMailFolder](Remove-MgBetaUserMailFolder.md)
Delete navigation property mailFolders for users

### [Remove-MgBetaUserMailFolderChildFolder](Remove-MgBetaUserMailFolderChildFolder.md)
Delete navigation property childFolders for users

### [Remove-MgBetaUserMailFolderChildFolderMessage](Remove-MgBetaUserMailFolderChildFolderMessage.md)
Delete navigation property messages for users

### [Remove-MgBetaUserMailFolderChildFolderMessageAttachment](Remove-MgBetaUserMailFolderChildFolderMessageAttachment.md)
Delete navigation property attachments for users

### [Remove-MgBetaUserMailFolderChildFolderMessageExtension](Remove-MgBetaUserMailFolderChildFolderMessageExtension.md)
Delete navigation property extensions for users

### [Remove-MgBetaUserMailFolderChildFolderMessageMention](Remove-MgBetaUserMailFolderChildFolderMessageMention.md)
Delete navigation property mentions for users

### [Remove-MgBetaUserMailFolderChildFolderMessageMultiValueExtendedProperty](Remove-MgBetaUserMailFolderChildFolderMessageMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgBetaUserMailFolderChildFolderMessageRule](Remove-MgBetaUserMailFolderChildFolderMessageRule.md)
Delete navigation property messageRules for users

### [Remove-MgBetaUserMailFolderChildFolderMessageSingleValueExtendedProperty](Remove-MgBetaUserMailFolderChildFolderMessageSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgBetaUserMailFolderChildFolderMultiValueExtendedProperty](Remove-MgBetaUserMailFolderChildFolderMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgBetaUserMailFolderChildFolderSingleValueExtendedProperty](Remove-MgBetaUserMailFolderChildFolderSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgBetaUserMailFolderMessage](Remove-MgBetaUserMailFolderMessage.md)
Delete navigation property messages for users

### [Remove-MgBetaUserMailFolderMessageAttachment](Remove-MgBetaUserMailFolderMessageAttachment.md)
Delete navigation property attachments for users

### [Remove-MgBetaUserMailFolderMessageExtension](Remove-MgBetaUserMailFolderMessageExtension.md)
Delete navigation property extensions for users

### [Remove-MgBetaUserMailFolderMessageMention](Remove-MgBetaUserMailFolderMessageMention.md)
Delete navigation property mentions for users

### [Remove-MgBetaUserMailFolderMessageMultiValueExtendedProperty](Remove-MgBetaUserMailFolderMessageMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgBetaUserMailFolderMessageRule](Remove-MgBetaUserMailFolderMessageRule.md)
Delete navigation property messageRules for users

### [Remove-MgBetaUserMailFolderMessageSingleValueExtendedProperty](Remove-MgBetaUserMailFolderMessageSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgBetaUserMailFolderMultiValueExtendedProperty](Remove-MgBetaUserMailFolderMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgBetaUserMailFolderSingleValueExtendedProperty](Remove-MgBetaUserMailFolderSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgBetaUserMessage](Remove-MgBetaUserMessage.md)
Delete navigation property messages for users

### [Remove-MgBetaUserMessageAttachment](Remove-MgBetaUserMessageAttachment.md)
Delete navigation property attachments for users

### [Remove-MgBetaUserMessageExtension](Remove-MgBetaUserMessageExtension.md)
Delete navigation property extensions for users

### [Remove-MgBetaUserMessageMention](Remove-MgBetaUserMessageMention.md)
Delete navigation property mentions for users

### [Remove-MgBetaUserMessageMultiValueExtendedProperty](Remove-MgBetaUserMessageMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgBetaUserMessageSingleValueExtendedProperty](Remove-MgBetaUserMessageSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Set-MgBetaUserMailFolderChildFolderMessageContent](Set-MgBetaUserMailFolderChildFolderMessageContent.md)
Update media content for the navigation property messages in users

### [Set-MgBetaUserMailFolderMessageContent](Set-MgBetaUserMailFolderMessageContent.md)
Update media content for the navigation property messages in users

### [Set-MgBetaUserMessageContent](Set-MgBetaUserMessageContent.md)
Update media content for the navigation property messages in users

### [Update-MgBetaUserInferenceClassification](Update-MgBetaUserInferenceClassification.md)
Update the navigation property inferenceClassification in users

### [Update-MgBetaUserInferenceClassificationOverride](Update-MgBetaUserInferenceClassificationOverride.md)
Update the navigation property overrides in users

### [Update-MgBetaUserMailFolder](Update-MgBetaUserMailFolder.md)
Update the navigation property mailFolders in users

### [Update-MgBetaUserMailFolderChildFolder](Update-MgBetaUserMailFolderChildFolder.md)
Update the navigation property childFolders in users

### [Update-MgBetaUserMailFolderChildFolderMessage](Update-MgBetaUserMailFolderChildFolderMessage.md)
Update the navigation property messages in users

### [Update-MgBetaUserMailFolderChildFolderMessageExtension](Update-MgBetaUserMailFolderChildFolderMessageExtension.md)
Update the navigation property extensions in users

### [Update-MgBetaUserMailFolderChildFolderMessageMultiValueExtendedProperty](Update-MgBetaUserMailFolderChildFolderMessageMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgBetaUserMailFolderChildFolderMessageRule](Update-MgBetaUserMailFolderChildFolderMessageRule.md)
Update the navigation property messageRules in users

### [Update-MgBetaUserMailFolderChildFolderMessageSingleValueExtendedProperty](Update-MgBetaUserMailFolderChildFolderMessageSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgBetaUserMailFolderChildFolderMultiValueExtendedProperty](Update-MgBetaUserMailFolderChildFolderMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgBetaUserMailFolderChildFolderSingleValueExtendedProperty](Update-MgBetaUserMailFolderChildFolderSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgBetaUserMailFolderMessage](Update-MgBetaUserMailFolderMessage.md)
Update the navigation property messages in users

### [Update-MgBetaUserMailFolderMessageExtension](Update-MgBetaUserMailFolderMessageExtension.md)
Update the navigation property extensions in users

### [Update-MgBetaUserMailFolderMessageMultiValueExtendedProperty](Update-MgBetaUserMailFolderMessageMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgBetaUserMailFolderMessageRule](Update-MgBetaUserMailFolderMessageRule.md)
Update the navigation property messageRules in users

### [Update-MgBetaUserMailFolderMessageSingleValueExtendedProperty](Update-MgBetaUserMailFolderMessageSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgBetaUserMailFolderMultiValueExtendedProperty](Update-MgBetaUserMailFolderMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgBetaUserMailFolderSingleValueExtendedProperty](Update-MgBetaUserMailFolderSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgBetaUserMessage](Update-MgBetaUserMessage.md)
Update the navigation property messages in users

### [Update-MgBetaUserMessageExtension](Update-MgBetaUserMessageExtension.md)
Update the navigation property extensions in users

### [Update-MgBetaUserMessageMultiValueExtendedProperty](Update-MgBetaUserMessageMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgBetaUserMessageSingleValueExtendedProperty](Update-MgBetaUserMessageSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

