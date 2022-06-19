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
int howmanydays = hwd.howmanydays();
Console.WriteLine(howmanydays);
// Rectanglefeatures rf= new Rectanglefeatures();
// Console.WriteLine(rf.Areacalc(12,13));
// Console.WriteLine(rf.PerimeterRectangle(12,13));
// Console.WriteLine (e1.FirstName+" is the spouse of "+ e.FirstName);
