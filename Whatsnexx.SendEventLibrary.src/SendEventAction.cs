﻿using System;
using System.Collections.Generic;
using Whatsnexx.TicketBus.TicketBusClient;
using Whatsnexx.TicketBus.TicketBusClient.DataModel;
using Attribute = Whatsnexx.TicketBus.TicketBusClient.DataModel.Attribute;

namespace Whatsnexx.SendEventLibrary
{
    public class SendEventAction
    {
        private static string TicketServiceBaseUri { get; set; }
        private static string TicketServiceUserName { get; set; }
        private static string TicketServicePassword { get; set; }
        private static string SubjectCode { get; set; }
        private static string Term { get; set; }
        private static Guid SubjectTypeId { get; set; }
        private static Guid AccountId { get; set; }
        private static ExecutionEnvironments ExecutionEnvironment { get; set; }
        private static IEnumerable<Attribute> Attributes { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public SendEventAction(IEnumerable<Attribute> attributes, ExecutionEnvironments executionEnvironment,
            Guid accountId, Guid subjectTypeId, string subjectCode, string term, string ticketServicePassword, 
            string ticketServiceUserName, string ticketServiceBaseUri)
        {
            Attributes = attributes;
            ExecutionEnvironment = executionEnvironment;
            AccountId = accountId;
            SubjectTypeId = subjectTypeId;
            SubjectCode = subjectCode;
            Term = term;
            TicketServicePassword = ticketServicePassword;
            TicketServiceUserName = ticketServiceUserName;
            TicketServiceBaseUri = ticketServiceBaseUri;
        }
        /// <summary>
        /// Creates a GatewayStorageAccount with the credentials given in parameters.
        /// </summary>
        /// <returns></returns>
        private static GatewayStorageAccount GetAccount()
        {
            if (string.IsNullOrEmpty(TicketServiceBaseUri))
            {
                return new GatewayStorageAccount(TicketServiceUserName, TicketServicePassword, AccountId);
            }
            return new GatewayStorageAccount(TicketServiceUserName, TicketServicePassword, AccountId,
                                             TicketServiceBaseUri);
        }

        /// <summary>
        /// Creates a TicketBusClient and sends an event to the TicketBus.
        /// </summary>
        public void Execute()
        {
            var client = new TicketBusClient(GetAccount());


            client.SendEvent(SubjectTypeId, SubjectCode, Term, Attributes, ExecutionEnvironment);

        }
    }
}