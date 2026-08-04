/*
* Name: Lindokuhle Nkosi
* Student Number: EDUV10933182
* Module Name: Basic C# Programming
* Module Code: ITECA0-22
* Date: 06/06/2026
* Purpose: Event Booking System
*/

// Stores event information and booking fuctionality

public class Event : IBookable
{
    public string EventName { get; set; }
    public decimal Price { get; set; }
    public int AvailableTickets { get; set; }
    public Event()
    {
    }
    public Event(string eventName, decimal price, int availableTickets)
    {
        EventName = eventName;
        Price = price;
        AvailableTickets = availableTickets;
    }
    public void BookTickets(int quantity)
    {
        AvailableTickets -= quantity;
    }
}