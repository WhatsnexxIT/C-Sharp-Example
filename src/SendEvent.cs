using System;
using Attribute = CSharpExample.TicketBusService.Attribute;
using CSharpExample.TicketBusService;
namespace CSharpExample
{
    class SendEvent
    {
        static void Main(string[] args)
        {
            const string userName = "00000000-0000-0000-0000-000000000001";
            const string password = "MDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDAwMDAwMDAx";
            const string accountId = "00000000-0000-0000-0000-000000000001";
            const string subjectTypeId = "00000000-0000-0000-0000-000000000001";
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
