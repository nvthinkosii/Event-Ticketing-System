/*
* Name: Lindokuhle Nkosi
* Student Number: EDUV10933182
* Module Name: Basic C# Programming
* Module Code: ITECA0-22
* Date: 06/06/2026
* Purpose: Event Booking System
*/

using System;
using System.Windows.Forms;

namespace EventHub
{
    internal static class Program
    {
        
        // The main entry point for the application.
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DataStore.Members.Add(
                new Member("Lindokuhle Nkosi", "lindo@gmail.com", 5000, "1234"));

            DataStore.Members.Add(
                new Member("Nkosinathi Thusi", "nvthi@gmail.com", 3000, "1234"));

            DataStore.Events.Add(
                new Event("S.O.S", 450, 1000));

            DataStore.Events.Add(
                new Event("Savanna Comedy Night", 250, 500));

            Application.Run(new LoginForm());
        }
    }
}
