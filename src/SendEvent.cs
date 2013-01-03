using System;
using System.Collections.Generic;
using Whatsnexx.SendEventLibrary;
using Whatsnexx.TicketBus.TicketBusClient.DataModel;
using Attribute = Whatsnexx.TicketBus.TicketBusClient.DataModel.Attribute;

namespace SendEventCSharpExample
{
    class SendEvent
    {
        public static void Main(string[] args)
        {
            var accountId = new Guid("00000000-0000-0000-0000-000000000001");
            const string ticketServiceUserName = "00000000-0000-0000-0000-000000000001";
            const string ticketServicePassword = "MDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDAwMDAwMDAx";
            const string term = "TestEvent";
            const string subjectCode = "psmelser@whatsnexx.com";
            var subjectTypeId = new Guid("00000000-0000-0000-0000-000000000001");

            var attributes = (IEnumerable<Attribute>) new Dictionary<string, string>
                                                                  {
                                                                      {"Language", "English"},
                                                                      {"Email", "emailValue"},
                                                                      {"FirstName", "firstNameValue"},
                                                                      {"LastName", "lastNameValue"}
                                                                  };
            const ExecutionEnvironments executionEnvironment = ExecutionEnvironments.Test;

            var sendEvent = new SendEventAction(attributes, executionEnvironment, accountId, subjectTypeId, subjectCode,
                                                term, ticketServicePassword, ticketServiceUserName, null);
            sendEvent.Execute();
        }
    }
}
