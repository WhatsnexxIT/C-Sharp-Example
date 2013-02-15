Send Events Using C#
===============

Describes how to send an event through the Whatsnexx.TicketBus from a C# project

Getting Started
------------------
The whatsnexx [ticketbus](https://github.com/whatsnexx/Whatsnexx/wiki/TicketBus) handles REST and SOAP Web Service request to send events. In this example, we will demonstrate how to connect with the Whatsnexx ticketbus using a WCF client. If you are not familiar with WCF, the MSDN documentation can be found [here](http://msdn.microsoft.com/en-us/library/dd456779.aspx). You will need following to send a request to the [ticketbus](https://github.com/whatsnexx/Whatsnexx/wiki/TicketBus) service.

1. <b>Account Id:</b> A unique identifier/GUID for your account
2. <b>Username:</b> Provided by Whatsnexx.
2. <b>Password:</b> Provided by Whatsnexx.
3. <b>TermName:</b> This is the name of the event that is to be triggered by the send event.
4. <b>SubjectCode:</b> The unique identifier for your [subject](). This usually represents <b>who</b> you would like to send the event to.
5. <b>SubjectTypeId:</b> A unique identitfier for the subject type. The subject type defines the context under which events are sent.
6. <b>ExecutionEnvironment:</b> Specifies the Whatsnexx environment you are sending the event request. A <b>Constellation</b> must exist in the chosen environment for the event to be triggered. The available Environments are: Test, Stage, and Production.
7. <b>Attributes:</b> A list of attributes that are used by the event.

Getting Help
-----------
[Whatsnexx Full Documentation](https://github.com/whatsnexx/Whatsnexx/wiki)  
[Ticketbus](https://github.com/whatsnexx/Whatsnexx/wiki/TicketBus)  

*****
[Top](https://github.com/paulsmelser/PHP-Send-Event/blob/master/README.md#send-events-using-php)

