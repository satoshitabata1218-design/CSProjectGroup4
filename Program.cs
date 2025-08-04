using System;


class Program
{
    static void Main(string[] args) // Entry point to get user input and call methods from Patient.cs
    {
        // Get user input
        Console.Write("Enter patient's first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter patient's last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter weight (kg): ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter height (cm): ");
        double height = double.Parse(Console.ReadLine());

        Console.Write("Enter SYSTOLIC mm Hg (upper number): ");
        int systolic = int.Parse(Console.ReadLine());

        Console.Write("Enter DIASTOLIC mm Hg (lower number): ");
        int diastolic = int.Parse(Console.ReadLine());

        // Create a Patient object using the constructor
        Patient myPatient = new Patient(firstName, lastName, weight, height);

        // Call the public method to print info 
        myPatient.PatientInfo(systolic, diastolic);
    }

}
