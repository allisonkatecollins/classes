using System;
using System.Collections.Generic;

namespace classes
{
public class Company
{

    //code block for the "get" accessor is executed when the propery is read
    //code block for "set" accessor is executed when the property is assigned a new value
    //so a property without a "set" accessor is considered read-only
    
    /* 
      properties are declared in the class block by specifying the access level of the field
      --> followed by type of property
      --> followed by name of property
      --> followed by a code block that declares a get and/or set accessor
    */

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; } //name of company
    public DateTime CreatedOn { get; }

    // Create a public property for holding a list of current employees
    public List<Employee> People { get; set; }

    //a constructor is a special method in a class that is called when a new instance of the class is created
    //its role is to make sure the new object is set up and ready for use immediately after it's created

    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */

    public Company(string name, DateTime date) {
      Name = name;
      CreatedOn = date;
    }

    //The Company class should also have a ListEmployees() method which outputs the name of each employee to the console.
    public void ListEmployees() {
      foreach(Employee EmployeeItem in People) {
        Console.WriteLine($"{EmployeeItem.FirstName} {EmployeeItem.LastName} has worked at {Name} as a {EmployeeItem.Title} since {EmployeeItem.StartDate}");
      }
    }
}

public class Employee
{
//properties
public string FirstName { get; set; }
public string LastName { get; set; }
public string Title { get; set; }

public DateTime StartDate { get; set; }

}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of a company. Name it whatever you like.
        Company business = new Company("Cool Products Inc", DateTime.Now);
        
        // Create three employees
        Employee Allison = new Employee()
        {
          FirstName = "Allison",
          LastName = "Collins",
          Title = "Manager",
          StartDate = DateTime.Now
        };

        Employee Brittany = new Employee()
        {
          FirstName = "Brittany",
          LastName = "Ramos-Janeway",
          Title = "Second Manager",
          StartDate = DateTime.Now
        };

         Employee Mary = new Employee()
        {
          FirstName = "Mary",
          LastName = "Remo",
          Title = "Third Manager",
          StartDate = DateTime.Now
        };


        // Assign the employees to the company
        business.People = new List<Employee> ();
        business.People.Add(Allison);
        business.People.Add(Brittany);
        business.People.Add(Mary);

        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */

      business.ListEmployees();
    }
}
}
