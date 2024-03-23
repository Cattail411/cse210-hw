using System;
using System.ComponentModel.Design;

partial class Activity
{
    public static void Read()
    {
        Console.WriteLine("Choose Your Activity:");
        MenuCommand();
        Console.WriteLine("Going to sleep for a second...");

Thread.Sleep(1000);

Console.WriteLine("I'm back!!");
class ListingActivity
{
    public static void List()
    {
        Console.WriteLine("Available Activities:");
        Console.WriteLine("1. Yoga");
        Console.WriteLine("2. Running");
        Console.WriteLine("3. Swimming");
    }
    
}
}