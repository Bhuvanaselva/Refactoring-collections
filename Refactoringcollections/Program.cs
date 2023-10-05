// See https://aka.ms/new-console-template for more information
using Refactoringcollections;

Console.WriteLine("Ticket Sales Manager!!\n");

TicketSalesManager salesManager = new TicketSalesManager();


Ticket ticket1 = new Ticket(salesManager.NextTicketNumber(), 120, "Standard");
Ticket ticket2 = new Ticket(salesManager.NextTicketNumber(), 130, "Rad 3&8 ");
Ticket ticket3 = new Ticket(salesManager.NextTicketNumber(), 150, "Fåtölj");

salesManager.AddTicket(ticket1);
salesManager.AddTicket(ticket2);
salesManager.AddTicket(ticket3);


Console.WriteLine("Added Tickets:\n");
salesManager.DisplayTickets();


Console.WriteLine("\nRemoving Ticket 2...\n");

bool removed = salesManager.RemoveTicket(ticket2);
if (removed)
{
    Console.WriteLine("Ticket 2 removed successfully.");
}
else
{
    Console.WriteLine("Ticket 2 removal failed.");
}


Console.WriteLine("\nRemaining Tickets:\n");
salesManager.DisplayTickets();


decimal salesTotal = salesManager.SalesTotal();
int amountOfTickets = salesManager.AmountOfTickets();

Console.WriteLine($"\nTotal Sales: {salesTotal}SEK");
Console.WriteLine($"\nAmount of Tickets Sold: {amountOfTickets}");