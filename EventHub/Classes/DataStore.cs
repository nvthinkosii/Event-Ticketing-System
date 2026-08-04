/*
* Name: Lindokuhle Nkosi
* Student Number: EDUV10933182
* Module Name: Basic C# Programming
* Module Code: ITECA0-22
* Date: 06/06/2026
* Purpose: Event Booking System
*/

using System.Collections.Generic;

// Stores application data using in memory lists

public static class DataStore
{
    public static List<Member> Members = new List<Member>();

    public static List<Event> Events = new List<Event>();

    public static List<Transaction> Transactions = new List<Transaction>();
}