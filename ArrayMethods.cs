using System;
using System.Collections;



public interface IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }
    public int Age { get; set; }

}

public class Employee : IPerson
{
    public Employee()
    {
        
    }
    public Employee(string fName, string lName, int empId=0)
    {
        FirstName=fName;
        LastName=lName;
        Id= empId;
    }
     public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }
    public int Age { get; set; }

    //employee properties

    public int EmployeeId { get; set; }
    public DateOnly StartDate {get; set;}
    public TimeOnly ShiftStartTime { get; set; }

}

public class Manager: Employee, IPerson
{
    public Manager(string fName, string lName, int empId=0): base ( fName,  lName,  empId=0)
    {
        
    }
    public int NumberOfDirectReports { get; set; }
}


