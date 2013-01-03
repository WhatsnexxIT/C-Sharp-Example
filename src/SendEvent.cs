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
            var accountId = new Guid("02040849-d23e-4ccc-9c8e-2bea340c8925");
            const string ticketServiceUserName = "E7F171A8-229C-4983-B605-BD55E97F0C5D";
            const string ticketServicePassword = "MDc0YmU5YTMtNGViMi00NjdmLTg4YzItOWM1MDU4Y2ZkZTA1";
            const string term = "12DaysXmasOrder";
            const string subjectCode = "psmelser@whatsnexx.com";
            var subjectTypeId = new Guid("ccbd8c87-8c93-40c0-bf28-2596a4739cd2");

            var attributes = (IEnumerable<Attribute>) new Dictionary<string, string>
                                                                  {
                                                                      {"Language", "English"},
                                                                      {"Email", "emailValue"},
                                                                      {"FirstName", "firstNameValue"},
                                                                      {"LastName", "lastNameValue"}
                                                                  };
            const ExecutionEnvironments executionEnvironment = ExecutionEnvironments.Test;

            var sendEvent = new SendEventAction(attributes, executionEnvironment, accountId, subjectTypeId, subjectCode,
                                                term, ticketServicePassword, ticketServiceUserName, "test");
            sendEvent.Execute();
        }
    }
}
