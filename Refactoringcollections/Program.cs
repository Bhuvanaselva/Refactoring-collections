// See https://aka.ms/new-console-template for more information
using Refactoringcollections;

Console.WriteLine("Welcome to Ticket Booking!!\n");


TicketSalesManager salesManager = new TicketSalesManager();


Ticket ticket1 = new Ticket(24, Class1.PlacePreference.Standing);
Console.WriteLine("Ticket Details:\n");
Console.WriteLine("Ticket1:\n");
Console.WriteLine($"Age: {ticket1.Age}");
Console.WriteLine($"Place: {ticket1.Place}");
Console.WriteLine($"Ticket Price: {ticket1.Price()} SEK");
Console.WriteLine($"Tax: {ticket1.Tax()} SEK");
Console.WriteLine($"Ticket Number: {ticket1.TicketNumber}");

Ticket ticket2 = new Ticket(65, Class1.PlacePreference.Seated);
Console.WriteLine("\nTicket2:\n");
Console.WriteLine($"Age: {ticket2.Age}");
Console.WriteLine($"Place: {ticket2.Place}");
Console.WriteLine($"Ticket Price: {ticket2.Price()} SEK");
Console.WriteLine($"Tax: {ticket2.Tax()} SEK");
Console.WriteLine($"Ticket Number: {ticket2.TicketNumber}");

Ticket ticket3 = new Ticket(5, Class1.PlacePreference.Seated);
Console.WriteLine("\nTicket3:\n");
Console.WriteLine($"Age: {ticket3.Age}");
Console.WriteLine($"Place: {ticket3.Place}");
Console.WriteLine($"Ticket Price: {ticket3.Price()} SEK");
Console.WriteLine($"Tax: {ticket3.Tax()} SEK");
Console.WriteLine($"Ticket Number: {ticket3.TicketNumber}");

salesManager.AddTicket(ticket1);
salesManager.AddTicket(ticket2);
salesManager.AddTicket(ticket3);


Console.WriteLine("\nAdded Tickets:\n");
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
Console.WriteLine($"\nThank you for booking!");