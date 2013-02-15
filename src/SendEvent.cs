using System;
using Attribute = CSharpExample.TicketBusService.Attribute;
using CSharpExample.TicketBusService;
namespace CSharpExample
{
    class SendEvent
    {
        static void Main(string[] args)
        {
            const string userName = "{Your Username}";
            const string password = "{Your Password}";
            const string accountId = "{Your Account Id}";
            const string subjectTypeId = "{Your Subject Id}";
            const string subject = "{Your Subject}";

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
