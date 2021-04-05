using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //// single lavel inheritance . 
    //class Vechicle // base class
    //{
    //    string number;
    //    string owner;
    //}
    //class car: Vechicle // Derived class.
    //{
    //    int numberofDoors;
    //}
    // Multi lavel Inheritance.
    //class vechicle // base class.
    //{
    //    string number;
    //    string owner;
    //}
    //class FourWheeler : vechicle // Derived Class
    //{
    //    string type;
    //}
    //class car: FourWheeler // Derived Class
    //{
    //    int NumberofDoors;
    //}
    // hierarchical  Inheritance
    class vechicle // base class.
    {
        string number;
        string owner;
    }
    class FourWheeler : vechicle // Derived Class
    {
        string type;
    }
    class car : FourWheeler // Derived Class
    {
        int NumberofDoors;
    }
    class Tractor : FourWheeler // Derived Class
    {
        int numberOfAxels;
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
