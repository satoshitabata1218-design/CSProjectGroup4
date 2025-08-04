using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Patient // blueprint to define an object (a set of data with variables inside) 
{

    // ** Question1: Create 4 Private fields with their 4 public properties **
    // Fields (private), names in camelCase (start with lowercase)
    private string firstName;
    private string lastName;
    private double weight; // the value in kg
    private double height; // the value in cm

    // Properties (public), names in PascalCAse (start with uppercase), with getter and setter inside
    // getter: method to define how to return values for properties
    // setter: method to define how to assign values for properties
    public string FirstName
    {   get { return firstName; } set { firstName = value; } }
    public string LastName
        { get { return lastName; } set { lastName = value; } }
    public double Weight
        { get { return weight; } set { weight = value; } }
    public double Height
        { get { return height; } set { height = value; } }  

    // ** Question 2: Create a custom constructor (with 4 parameteres) **
    // Constructor: Initialize a new object automatically when it's called
    public Patient(string firstName, string lastName, double weight, double height)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.weight = weight;
        this.height = height;
    }

    // ** Question 3: Create first method (public) for the blood pressure of the patient **
    // Blood Pressure Method (public method)
    // takes two integers, returns a string message besed on blood pressure range
    public string BloodPressure(int systolic, int diastolic)
    {
        // systolic less than 120 AND diastolic less than 80
        if (systolic < 120 && diastolic < 80)
        {
            return "NORMAL";
        }
        // systolic between 120 and 129 AND diastolic less than 80
        else if (systolic >= 120 && systolic <= 129 && diastolic < 80)
        {
            return "ELEVATED";
        }
        // systolic between 130 and 139 OR diastolic between 80 and 89 
        else if ((systolic >= 130 && systolic <= 139) || (diastolic >= 80 && diastolic <= 89))
        {
            return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
        }
        // systolic between 140 and 180 OR diastolic 90 or higher
        else if ((systolic >= 140 && systolic <= 180) || (diastolic >= 90 && diastolic <= 120))
        {
            return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
        }
        // systolic higher than 180 OR diastolic higher than 120
        else if (systolic > 180 || diastolic > 120)
        {
            return "HYPERTENSION CRISIS (CONSULT YOUR DOCTOR IMMEDIATELY)";
        }
        else
        {
            return "WARNING:BLOOD PRESSURE OUT OF USUAL RANGE ";
        }

    }

    // ** Question 4: Create second method (private) to calculate the BMI of the patient **
    private double BMI () // private because BMI value is only used internally
    {
        double heightInMeters = height / 100.0; // needs to be converted in meters to calculate BMI
        double bmi = weight / (heightInMeters * heightInMeters); // BMI Formula: BMI = kg/m * m
        return bmi;
    }

    // ** Question 5: Create final method (public) to print the patint's info **
    public void PatientInfo(int systolic, int diastolic) // it doesn't return anything, accepts two parameters (systolic and diastolic)
    {
        // Fullname
        Console.WriteLine("Name: " + firstName + " " + lastName);
        
        // Height
        Console.WriteLine("Height: " + height + " cm");
        
        // Weight
        Console.WriteLine("Weight: " + weight + " kg");

        // Blood pressure: takes two parameters, call first method for the blood pressure
        string bloodPressureCondition = BloodPressure(systolic, diastolic);
        Console.WriteLine("Blood Pressure Condition: " + bloodPressureCondition);

        // BMI: call second method to calculate the BMI
        double bmiValue = BMI();
        string bmiValue2 = bmiValue.ToString("F1"); // round off the value to one decimal place
        Console.WriteLine("BMI: " + bmiValue2);

        // Print BMI status besed on BMI levels using if conditions

        if (bmiValue >= 25.0)
        {
            //25 or higher
            Console.WriteLine("BMI Status: Overweight");
        }

        else if (bmiValue >= 18.5 && bmiValue <= 24.9)
        {
            // between 18.5 and 24.9
            Console.WriteLine("BMI Status: Normal (In the healthy range)");
        }
        else
        {   
            // under 18.5
            Console.WriteLine("BMI Status: Underwight");
        }
    }

}
