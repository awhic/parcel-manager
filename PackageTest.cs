// Grading ID: N8316
// Program 4
// April 23, 2019
// CIS 199-75

// This program uses two separate classes and uses properties to instantiate
// an array of objects in the form of packages in a logistics service.

using System;
using static System.Console;

public class PackageTest
{
    public static void Main()
    {
        //Creating 5 GroundPackage objects with hardcoded test data

        GroundPackage package1 = new GroundPackage(40220, 50111, 5.0, 4.0, 3.0, 2.5);
        GroundPackage package2 = new GroundPackage(00000, 99999, -5.0, 4.5, 3.1, 4.4);
        GroundPackage package3 = new GroundPackage(50123, 99776, 6.0, 7.8, 4.6, 3.8);
        GroundPackage package4 = new GroundPackage(53847, 32943, 9.0, -3.5, 0, 3.8);
        GroundPackage package5 = new GroundPackage(00000, 99999, -5.0, 4.5, 3.1, 4.4);

        WriteLine($"{package1}");
        WriteLine($"\n{package2}");
        WriteLine($"\n{package3}");
        WriteLine($"\n{package4}");
        WriteLine($"\n{package5}");
    }
}
