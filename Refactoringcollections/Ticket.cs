using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoringcollections
{
    internal class Ticket
    {
        public int TicketNumber { get; set; }
        public decimal Price { get; set; }
        public string PlacePreference { get; set; }

        public Ticket(int ticketNumber, decimal price, string placePreference)
        {
            TicketNumber = ticketNumber;
            Price = price;
            PlacePreference = placePreference;
        }
    }
}