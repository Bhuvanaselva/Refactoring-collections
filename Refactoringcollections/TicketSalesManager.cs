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
            private List<Ticket> tickets = new List<Ticket>();


            public static int NextTicketNumber()
            {

                Random random = new Random();
                int ticketNumber = random.Next(1, 8000);
                return ticketNumber;
            }


            public Ticket AddTicket(Ticket ticket)
            {
                tickets.Add(ticket);

                return ticket;
            }
            public bool RemoveTicket(Ticket ticket)
            {

                return tickets.Remove(ticket);
            }

            public decimal SalesTotal()
            {
                decimal total = 0;
                foreach (var ticket in tickets)
                {
                    total += ticket.Price();
                }
                return total;
            }

            public int AmountOfTickets()
            {
                return tickets.Count;
            }

            public void DisplayTickets()
            {
                foreach (var ticket in tickets)
                {
                    Console.WriteLine($"Ticket Number:{ticket.TicketNumber}, Price:{ticket.Price()}SEK, Place Preference:{ticket.Place}");
                }

            }
        }
    }
















       