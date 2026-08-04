/*
* Name: Lindokuhle Nkosi
* Student Number: EDUV10933182
* Module Name: Basic C# Programming
* Module Code: ITECA0-22
* Date: 06/06/2026
* Purpose: Event Booking System
*/

// Member class inherits from Person and stores account balance
public class Member : Person
{
    // Available balance used for purchasing tickets
    public decimal Balance { get; set; }
    public string Password { get; set; }

    // Constructor used to create a new member
    public Member(string name, string email, decimal balance, string password)
        : base(name, email)
    {
        Name = name;
        Email = email;
        Balance = balance;
        Password = password;
    }
}
