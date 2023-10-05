using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Refactoringcollections
{
    internal class TicketSalesManager
    {
        private List<Ticket> tickets;
        public TicketSalesManager()
        {
            tickets = new List<Ticket>();
        }


        public int NextTicketNumber()
        {
            Random random = new Random();
            int ticketNumber = random.Next(1000, 9999);

            while (tickets.Exists(t => t.TicketNumber == ticketNumber))
            {
                ticketNumber = random.Next(1000, 9999);
            }

            return ticketNumber;
        }
    

        public Ticket AddTicket(Ticket ticket)
        {
            ticket.TicketNumber= NextTicketNumber();
            tickets.Add(ticket);
         
            return ticket;
        }
        public bool RemoveTicket(Ticket ticket)
        {
      
                Ticket ticketToRemove = tickets.FirstOrDefault(t => t.TicketNumber == ticket.TicketNumber);
                if (ticketToRemove != null)
                {
                    tickets.Remove(ticketToRemove);
                    return true;
                }
                return false;
            }      

        public decimal SalesTotal()
        {
            return tickets.Sum(t => t.Price);
        }

        public int AmountOfTickets()
        {
            return tickets.Count;
        }

        public void DisplayTickets()
        {
            foreach (var ticket in tickets)
            {
                Console.WriteLine($"Ticket {ticket.TicketNumber}, Price:{ticket.Price}SEK, Place Preference:{ticket.PlacePreference}");
            }
        }
    }
}







       