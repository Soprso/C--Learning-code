using System;

Employee e= new Employee{
    FirstName="Soumyadeep",
    LastName="Ghosh",
    Id=12
};
Employee e1= new Employee{
    FirstName="Madhumita",
    LastName="Ghosh",
    Id=13
};

howmanydaysyouhavelived hwd = new howmanydaysyouhavelived();
Console.WriteLine ("Please enter your date of birth");
DateOnly dob= DateOnly.Parse(Console.ReadLine());
int howmanydays = hwd.howmanydays(dob);
int howmanyleapyears = hwd.howmanyleapyearslived(dob).Item1;//hwd.howmanyleapyearslived(dob).Item1;
int howmanynonleapyears= hwd.howmanyleapyearslived(dob).Item2;
Console.WriteLine("How many days lived = {0}",howmanydays);
Console.WriteLine("How many leap years lived = {0}", howmanyleapyears);
Console.WriteLine("How many non leap years lived = {0}", howmanynonleapyears);
// Rectanglefeatures rf= new Rectanglefeatures();
// Console.WriteLine(rf.Areacalc(12,13));
// Console.WriteLine(rf.PerimeterRectangle(12,13));
// Console.WriteLine (e1.FirstName+" is the spouse of "+ e.FirstName);
