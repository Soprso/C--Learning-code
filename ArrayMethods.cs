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


public abstract class Area
{
    public abstract int Areacalc(int len, int brd);

    public virtual int PerimeterRectangle(int len, int brd)
    {
        int perimeter = 2 * (len+brd);
        return perimeter;
    }

}

public class Rectanglefeatures : Area
{
    public override int Areacalc(int len, int brd)
    {
        int area= len * brd;

        return area;
    }

    public  override int PerimeterRectangle(int len, int brd)
    {
        string quad;
        Console.WriteLine("Perimeter for rect or square");
        quad= Console.ReadLine();
        //Console.WriteLine(quad);
        int perimeter=0;
        if(quad =="rect")
        {
                perimeter = 2 * (len+brd);
        }
        else if (quad == "square")
        {
             perimeter= 4 * len;
        }
        
        else
        {
        Console.WriteLine("Please give valid input");
        }
        return perimeter;

    }
}