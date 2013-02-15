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
    <li>Enter the <b><i>'CSharpExample'</i></b> in the <b>Name</b> box and enter the location you would like to save the project in the <b>Location</b> box.</li>
    <li>Click <b>OK</b></li>
  </ol>
</li>
<li>Add a <b>Service Reference</b> for the <b>Whatsnexx TicketBusService</b>
<ol type="a">
        <li>In the <b>Solution Explorer</b> right click on <b>References</b> in the project <b>CSharpExample</b> and left click on <b>Add Service Reference</b>. The <b>Add Service Reference</b> dialog box will open.</li>
        <li>Enter<i>'https://ticketbusstage.whatsnexx.com/TicketBusService.svc'</i> in the <b>Address</b> box and click <b>Go. TicketBusService</b> will appear shortly.</li>
        <li>Enter <b><i>'TicketBusService'</i></b> in the <b>Namespace</b> box and click <b>OK</b>. The <b>Service Model</b> reference will be added to the the project <b>References</b> and the <b>Service References</b> will appear with <b>TicketBusService</b> added as a service.
        <ul><li>To view the service API, double click on <b>TicketBusService</b> under <b>Service References</b>. The <b>Object Browser</b> will appear.</li><li>Expand <b>CSharpExample.TicketBusService</b> and select objects in the explorer to view the methods available.</li></ul></li>
</ol>
</li>
<li>Modify <b>Program.cs</b> as follows and run the application. A console window will appear showing the service was called successfully.
</li>
</ol>

```java
using System;
using Attribute = CSharpExample.TicketBusService.Attribute;
using CSharpExample.TicketBusService;
namespace CSharpExample
{
    class SendEvent
    {
        static void Main(string[] args)
        {
            const string userName = "%YourUserName%";
            const string password = "%YourPassword%";
            //your account id
            const string accountId = "00000000-0000-0000-0000-000000000000";
            //the subject type id
            const string subjectTypeId = "00000000-0000-0000-0000-000000000000";
            const string subject = "%YourSubject%";

            //create out objects
            TicketBusResponse response;
            string transactionId;

            var ticketBusSendEvent = new TicketBusSendEvent
            {
                Attributes = new[] {
                    new Attribute {Name = "Test", Value = "Value1"}, 
                    new Attribute {Name = "Email", Value = "someone@somewhere.com"}},
                SubjectCode = "TestCode"
            };

            var client = new TicketBusServiceClient
            {
                ClientCredentials =
                {
                    UserName =
                    {
                        UserName = userName,
                        Password = password
                    }
                }
            };

            var success = client.SendEvent( accountId, ExecutionEnvironments.Stage,
                subjectTypeId, subject, ticketBusSendEvent, out response, out transactionId);

            Console.WriteLine("Worked: " + success + Environment.NewLine + "TransactionId: " + transactionId);
            Console.ReadKey();
        }
    }
}
```

Getting Help
-----------
[Whatsnexx Full Documentation](https://github.com/whatsnexx/Whatsnexx/wiki)  
[Ticketbus](https://github.com/whatsnexx/Whatsnexx/wiki/TicketBus)  

*****
[Top](https://github.com/paulsmelser/PHP-Send-Event/blob/master/README.md#send-events-using-php)

