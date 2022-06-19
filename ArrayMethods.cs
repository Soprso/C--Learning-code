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

public class howmanydaysyouhavelived
{
    public int howmanydays(DateOnly dob)
    {
        DateOnly dateofbirth= dob;
        int days=0;
        int months=0;
        int leapyears=countleapyears(dateofbirth).Item1;
        int nonleapyears=countleapyears(dateofbirth).Item2;
        // years= DateTime.Now.Year- dateofbirth.Year;
        months= DateTime.Now.Month- dateofbirth.Month;
        days= DateTime.Now.Day- dateofbirth.Day;

        int totalDays= days+(30*months)+(366*leapyears)+(365*nonleapyears);
        return totalDays;
    }
public Tuple<int,int> countleapyears(DateOnly dateofbirth)
{
    int birthyear=dateofbirth.Year;
    int numberofleapyears=0;
    int nonleapyears=0;
    while(birthyear <= DateTime.Now.Year)
    {
        if(birthyear%4==0)
        {
            numberofleapyears++;
        }
        else{
            nonleapyears++;
        }

        birthyear++;
    }
    return new Tuple<int, int>(numberofleapyears, nonleapyears);
    
}

public Tuple<int,int> howmanyleapyearslived(DateOnly dateofbirth)
{
    // int leapyears = countleapyears(dateofbirth).Item1;
    // int nonleapyears = countleapyears(dateofbirth).Item2;
    return new Tuple<int,int>(countleapyears(dateofbirth).Item1,countleapyears(dateofbirth).Item2);

}
    
}