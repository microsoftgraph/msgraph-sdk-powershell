---
Module Name: Microsoft.Graph.Mail
Module Guid: 468aecb8-768b-4915-9e3e-e20bf18231f2
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.mail
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Mail Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Mail Cmdlets
### [Get-MgUserInferenceClassification](Get-MgUserInferenceClassification.md)
Relevance classification of the user's messages based on explicit designations that override inferred relevance or importance.

### [Get-MgUserInferenceClassificationOverride](Get-MgUserInferenceClassificationOverride.md)
A set of overrides for a user to always classify messages from specific senders in certain ways: focused, or other.
Read-only.
Nullable.

### [Get-MgUserInferenceClassificationOverrideCount](Get-MgUserInferenceClassificationOverrideCount.md)
Get the number of the resource

### [Get-MgUserMailFolder](Get-MgUserMailFolder.md)
The user's mail folders.
Read-only.
Nullable.

### [Get-MgUserMailFolderChildFolder](Get-MgUserMailFolderChildFolder.md)
The collection of child folders in the mailFolder.

### [Get-MgUserMailFolderChildFolderCount](Get-MgUserMailFolderChildFolderCount.md)
Get the number of the resource

### [Get-MgUserMailFolderChildFolderMessage](Get-MgUserMailFolderChildFolderMessage.md)
The collection of messages in the mailFolder.

### [Get-MgUserMailFolderChildFolderMessageAttachment](Get-MgUserMailFolderChildFolderMessageAttachment.md)
Read the properties, relationships, or raw contents of an attachment that is attached to a user event, message, or group post.
An attachment can be one of the following types: All these types of attachments are derived from the attachment resource.

### [Get-MgUserMailFolderChildFolderMessageAttachmentCount](Get-MgUserMailFolderChildFolderMessageAttachmentCount.md)
Get the number of the resource

### [Get-MgUserMailFolderChildFolderMessageContent](Get-MgUserMailFolderChildFolderMessageContent.md)
Get media content for the navigation property messages from users

### [Get-MgUserMailFolderChildFolderMessageCount](Get-MgUserMailFolderChildFolderMessageCount.md)
Get the number of the resource

### [Get-MgUserMailFolderChildFolderMessageExtension](Get-MgUserMailFolderChildFolderMessageExtension.md)
Get an open extension (openTypeExtension object) identified by name or fully qualified name.
The table in the Permissions section lists the resources that support open extensions.
The following table lists the three scenarios where you can get an open extension from a supported resource instance.

### [Get-MgUserMailFolderChildFolderMessageExtensionCount](Get-MgUserMailFolderChildFolderMessageExtensionCount.md)
Get the number of the resource

### [Get-MgUserMailFolderChildFolderMessageRule](Get-MgUserMailFolderChildFolderMessageRule.md)
Get the properties and relationships of a messageRule object.

### [Get-MgUserMailFolderChildFolderMessageRuleCount](Get-MgUserMailFolderChildFolderMessageRuleCount.md)
Get the number of the resource

### [Get-MgUserMailFolderCount](Get-MgUserMailFolderCount.md)
Get the number of the resource

### [Get-MgUserMailFolderMessage](Get-MgUserMailFolderMessage.md)
The collection of messages in the mailFolder.

### [Get-MgUserMailFolderMessageAttachment](Get-MgUserMailFolderMessageAttachment.md)
Read the properties, relationships, or raw contents of an attachment that is attached to a user event, message, or group post.
An attachment can be one of the following types: All these types of attachments are derived from the attachment resource.

### [Get-MgUserMailFolderMessageAttachmentCount](Get-MgUserMailFolderMessageAttachmentCount.md)
Get the number of the resource

### [Get-MgUserMailFolderMessageContent](Get-MgUserMailFolderMessageContent.md)
Get media content for the navigation property messages from users

### [Get-MgUserMailFolderMessageCount](Get-MgUserMailFolderMessageCount.md)
Get the number of the resource

### [Get-MgUserMailFolderMessageExtension](Get-MgUserMailFolderMessageExtension.md)
Get an open extension (openTypeExtension object) identified by name or fully qualified name.
The table in the Permissions section lists the resources that support open extensions.
The following table lists the three scenarios where you can get an open extension from a supported resource instance.

### [Get-MgUserMailFolderMessageExtensionCount](Get-MgUserMailFolderMessageExtensionCount.md)
Get the number of the resource

### [Get-MgUserMailFolderMessageRule](Get-MgUserMailFolderMessageRule.md)
Get the properties and relationships of a messageRule object.

### [Get-MgUserMailFolderMessageRuleCount](Get-MgUserMailFolderMessageRuleCount.md)
Get the number of the resource

### [Get-MgUserMessage](Get-MgUserMessage.md)
The messages in a mailbox or folder.
Read-only.
Nullable.

### [Get-MgUserMessageAttachment](Get-MgUserMessageAttachment.md)
Read the properties, relationships, or raw contents of an attachment that is attached to a user event, message, or group post.
An attachment can be one of the following types: All these types of attachments are derived from the attachment resource.

### [Get-MgUserMessageAttachmentCount](Get-MgUserMessageAttachmentCount.md)
Get the number of the resource

### [Get-MgUserMessageContent](Get-MgUserMessageContent.md)
Get media content for the navigation property messages from users

### [Get-MgUserMessageCount](Get-MgUserMessageCount.md)
Get the number of the resource

### [Get-MgUserMessageExtension](Get-MgUserMessageExtension.md)
Get an open extension (openTypeExtension object) identified by name or fully qualified name.
The table in the Permissions section lists the resources that support open extensions.
The following table lists the three scenarios where you can get an open extension from a supported resource instance.

### [Get-MgUserMessageExtensionCount](Get-MgUserMessageExtensionCount.md)
Get the number of the resource

### [New-MgUserInferenceClassificationOverride](New-MgUserInferenceClassificationOverride.md)
Create an override for a sender identified by an SMTP address.
Future messages from that SMTP address will be consistently classified\nas specified in the override.
Note

### [New-MgUserMailFolder](New-MgUserMailFolder.md)
Use this API to create a new mail folder in the root folder of the user's mailbox.
If you intend a new folder to be hidden, you must set the isHidden property to true on creation.

### [New-MgUserMailFolderChildFolder](New-MgUserMailFolderChildFolder.md)
Create a new mailSearchFolder in the specified user's mailbox.

### [New-MgUserMailFolderChildFolderMessage](New-MgUserMailFolderChildFolderMessage.md)
Use this API to create a new Message in a mailfolder.

### [New-MgUserMailFolderChildFolderMessageAttachment](New-MgUserMailFolderChildFolderMessageAttachment.md)
Use this API to add an attachment to a message.
An attachment can be one of the following types: All these types of attachment resources are derived from the attachment\nresource.
You can add an attachment to an existing message by posting to its attachments collection, or you can\nadd an attachment to a message that is being created and sent on the fly.
This operation limits the size of the attachment you can add to under 3 MB.

### [New-MgUserMailFolderChildFolderMessageExtension](New-MgUserMailFolderChildFolderMessageExtension.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
The table in the Permissions section lists the resources that support open extensions.

### [New-MgUserMailFolderChildFolderMessageRule](New-MgUserMailFolderChildFolderMessageRule.md)
Create a messageRule object by specifying a set of conditions and actions.
Outlook carries out those actions if an incoming message in the user's Inbox meets the specified conditions.

### [New-MgUserMailFolderMessage](New-MgUserMailFolderMessage.md)
Use this API to create a new Message in a mailfolder.

### [New-MgUserMailFolderMessageAttachment](New-MgUserMailFolderMessageAttachment.md)
Use this API to add an attachment to a message.
An attachment can be one of the following types: All these types of attachment resources are derived from the attachment\nresource.
You can add an attachment to an existing message by posting to its attachments collection, or you can\nadd an attachment to a message that is being created and sent on the fly.
This operation limits the size of the attachment you can add to under 3 MB.

### [New-MgUserMailFolderMessageExtension](New-MgUserMailFolderMessageExtension.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
The table in the Permissions section lists the resources that support open extensions.

### [New-MgUserMailFolderMessageRule](New-MgUserMailFolderMessageRule.md)
Create a messageRule object by specifying a set of conditions and actions.
Outlook carries out those actions if an incoming message in the user's Inbox meets the specified conditions.

### [New-MgUserMessage](New-MgUserMessage.md)
Create a draft of a new message in either JSON or MIME format.
When using JSON format, you can:\n- Include an attachment to the message.\n- Update the draft later to add content to the body or change other message properties.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in base64 format in the request body.\n- /* Add any attachments and S/MIME properties to the MIME content.
By default, this operation saves the draft in the Drafts folder.
Send the draft message in a subsequent operation.
Alternatively, send a new message in a single operation, or create a draft to forward, reply and reply-all to an existing message.

### [New-MgUserMessageAttachment](New-MgUserMessageAttachment.md)
Use this API to add an attachment to a message.
An attachment can be one of the following types: All these types of attachment resources are derived from the attachment\nresource.
You can add an attachment to an existing message by posting to its attachments collection, or you can\nadd an attachment to a message that is being created and sent on the fly.
This operation limits the size of the attachment you can add to under 3 MB.

### [New-MgUserMessageExtension](New-MgUserMessageExtension.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
The table in the Permissions section lists the resources that support open extensions.

### [Remove-MgUserInferenceClassificationOverride](Remove-MgUserInferenceClassificationOverride.md)
Delete an override specified by its ID.

### [Remove-MgUserMailFolder](Remove-MgUserMailFolder.md)
Delete the specified mailFolder.
The folder can be a mailSearchFolder.
You can specify a mail folder by its folder ID, or by its well-known folder name, if one exists.

### [Remove-MgUserMailFolderChildFolder](Remove-MgUserMailFolderChildFolder.md)
Delete navigation property childFolders for users

### [Remove-MgUserMailFolderChildFolderMessage](Remove-MgUserMailFolderChildFolderMessage.md)
Delete navigation property messages for users

### [Remove-MgUserMailFolderChildFolderMessageAttachment](Remove-MgUserMailFolderChildFolderMessageAttachment.md)
Delete navigation property attachments for users

### [Remove-MgUserMailFolderChildFolderMessageExtension](Remove-MgUserMailFolderChildFolderMessageExtension.md)
Delete an open extension (openTypeExtension object) from the specified instance of a resource.
For the list of resources that support open extensions, see the table in the Permissions section.

### [Remove-MgUserMailFolderChildFolderMessageRule](Remove-MgUserMailFolderChildFolderMessageRule.md)
Delete the specified messageRule object.

### [Remove-MgUserMailFolderMessage](Remove-MgUserMailFolderMessage.md)
Delete navigation property messages for users

### [Remove-MgUserMailFolderMessageAttachment](Remove-MgUserMailFolderMessageAttachment.md)
Delete navigation property attachments for users

### [Remove-MgUserMailFolderMessageExtension](Remove-MgUserMailFolderMessageExtension.md)
Delete an open extension (openTypeExtension object) from the specified instance of a resource.
For the list of resources that support open extensions, see the table in the Permissions section.

### [Remove-MgUserMailFolderMessageRule](Remove-MgUserMailFolderMessageRule.md)
Delete the specified messageRule object.

### [Remove-MgUserMessage](Remove-MgUserMessage.md)
Delete a message in the specified user's mailbox, or delete a relationship of the message.

### [Remove-MgUserMessageAttachment](Remove-MgUserMessageAttachment.md)
Delete navigation property attachments for users

### [Remove-MgUserMessageExtension](Remove-MgUserMessageExtension.md)
Delete an open extension (openTypeExtension object) from the specified instance of a resource.
For the list of resources that support open extensions, see the table in the Permissions section.

### [Set-MgUserMailFolderChildFolderMessageContent](Set-MgUserMailFolderChildFolderMessageContent.md)
Update media content for the navigation property messages in users

### [Set-MgUserMailFolderMessageContent](Set-MgUserMailFolderMessageContent.md)
Update media content for the navigation property messages in users

### [Set-MgUserMessageContent](Set-MgUserMessageContent.md)
Update media content for the navigation property messages in users

### [Update-MgUserInferenceClassification](Update-MgUserInferenceClassification.md)
Update the navigation property inferenceClassification in users

### [Update-MgUserInferenceClassificationOverride](Update-MgUserInferenceClassificationOverride.md)
Change the classifyAs field of an override as specified.
You cannot use PATCH to change any other fields in an inferenceClassificationOverride instance.
If an override exists for a sender and the sender changes his/her display name, you can use POST to force an update to the name field in the existing override.
If an override exists for a sender and the sender changes his/her SMTP address, deleting the existing override and creating a new one with\nthe new SMTP address is the only way to 'update' the override for this sender.

### [Update-MgUserMailFolder](Update-MgUserMailFolder.md)
Update the properties of mailfolder object.

### [Update-MgUserMailFolderChildFolder](Update-MgUserMailFolderChildFolder.md)
Update the navigation property childFolders in users

### [Update-MgUserMailFolderChildFolderMessage](Update-MgUserMailFolderChildFolderMessage.md)
Update the navigation property messages in users

### [Update-MgUserMailFolderChildFolderMessageExtension](Update-MgUserMailFolderChildFolderMessageExtension.md)
Update the navigation property extensions in users

### [Update-MgUserMailFolderChildFolderMessageRule](Update-MgUserMailFolderChildFolderMessageRule.md)
Change writable properties on a messageRule object and save the changes.

### [Update-MgUserMailFolderMessage](Update-MgUserMailFolderMessage.md)
Update the navigation property messages in users

### [Update-MgUserMailFolderMessageExtension](Update-MgUserMailFolderMessageExtension.md)
Update the navigation property extensions in users

### [Update-MgUserMailFolderMessageRule](Update-MgUserMailFolderMessageRule.md)
Change writable properties on a messageRule object and save the changes.

### [Update-MgUserMessage](Update-MgUserMessage.md)
Update the properties of an eventMessage object.

### [Update-MgUserMessageExtension](Update-MgUserMessageExtension.md)
Update the navigation property extensions in users

