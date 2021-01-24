using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Contracts
{
    public interface ILoggedInUserService
    {
        public string UserId { get; }
    }
}
