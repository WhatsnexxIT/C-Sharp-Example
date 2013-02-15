Send Events Using C#
===============

Describes how to send an event through the Whatsnexx.TicketBus from a Console application in Visual Studio.

Getting Started
------------------
The whatsnexx [ticketbus](https://github.com/whatsnexx/Whatsnexx/wiki/TicketBus) handles REST and SOAP Web Service request to send events. In this example, we will demonstrate how to connect with the Whatsnexx ticketbus using a WCF client. If you are not familiar with WCF, the MSDN documentation can be found [here](http://msdn.microsoft.com/en-us/library/dd456779.aspx). You will need following to send a request to the [ticketbus](https://github.com/whatsnexx/Whatsnexx/wiki/TicketBus) service.

1. <b>Account Id:</b> Provided by Whatsnexx.
2. <b>Username:</b> Provided by Whatsnexx.
2. <b>Password:</b> Provided by Whatsnexx.
3. <b>TermName:</b> This is the name of the event that is to be triggered by the send event.
4. <b>SubjectCode:</b> The unique identifier for your [subject](). This usually represents <b>who</b> you would like to send the event to.
5. <b>SubjectTypeId:</b> A unique identitfier for the subject type. The subject type defines the context under which events are sent.
6. <b>ExecutionEnvironment:</b> Specifies the Whatsnexx environment you are sending the event request. A <b>Constellation</b> must exist in the chosen environment for the event to be triggered. The available Environments are: Test, Stage, and Production.
7. <b>Attributes:</b> A list of attributes that are used by the event.

Process
----------------

<ol>
<li>Open Visual Studio and create a new Console Application.
  <ol type="a">
    <li>In the <b>File</b> menu of Visual Studio point to <b>New</b> and click <b>Protect</b>. A  <b>New Project</b> dialog box will appear.</li>
    <li>In the  <b>New Project</b> dialog box, select <b>Visual C#</b> from the <b>Installed Templates</b> box, and select <b>Console Application</b> from the list provided</li>
    <li>Enter the 'WhatsnexxTest' in the <b>Name</b> box and enter the location you would like to save the project in the <b>Location</b> box.</li>
    <li>Click OK</li>
  </ol>
</li>
<li>Add a <b>Service Reference</b> for the <b>Whatsnexx TicketBusService</b>
<ol type="a">
        <li></li>
</ol>
</li>
<li><li>
<li><li>
</ol>
Getting Help
-----------
[Whatsnexx Full Documentation](https://github.com/whatsnexx/Whatsnexx/wiki)  
[Ticketbus](https://github.com/whatsnexx/Whatsnexx/wiki/TicketBus)  

*****
[Top](https://github.com/paulsmelser/PHP-Send-Event/blob/master/README.md#send-events-using-php)

