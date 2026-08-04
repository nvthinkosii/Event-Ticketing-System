/*
* Name: Lindokuhle Nkosi
* Student Number: EDUV10933182
* Module Name: Basic C# Programming
* Module Code: ITECA0-22
* Date: 06/06/2026
* Purpose: Event Booking System
*/

// Stores booking transaction details
public class Transaction
{
    public string EventName { get; set; }
    public decimal TotalAmount { get; set; }
    public string MemberEmail { get; set; }
    public Transaction()
    {
    }

    public Transaction(string eventName, decimal totalAmount, string memberEmail)
    {
        EventName = eventName;
        TotalAmount = totalAmount;
        MemberEmail = memberEmail;
    }
}