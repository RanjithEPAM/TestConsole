// See https://aka.ms/new-console-template for more information

using DesignPatterns.BuilderPattern;
using DesignPatterns.BuilderPattern.Desktop;
using DesignPatterns.BuilderPattern.Laptop;
using DesignPatterns.FactoryPattern;
using DesignPatterns.DecoratorPattern;
using DesignPatterns.Singleton;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using TestConsole;
using DesignPatterns.Learn;
using TestConsole.Examples;
using TestConsole.Delegates;
using OpenQA.Selenium;
using System.Configuration;
using TestConsole.Collections;
using TestConsole.Exercises;

namespace Practice
{
    public class Testing
    {
        public static void Main()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log =  log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            log.Info("Logging is started");

            #region Method hiding
            Console.WriteLine("\n ****************   Method Hiding   ****************");
            MethodDerived derived = new MethodDerived();
            MethodHiding mhiding = new MethodHiding();
            

            MethodHiding mhide1 = new MethodDerived();
            mhide1.TestMethod1();
            mhide1.TestMethod();


            MethodDerived derived2 = new MethodDerived();
            derived2.TestMethod();
            #endregion




            #region Compile Time Polymorphism
            Console.WriteLine("\n ****************   Compile Time Polymorphism   ****************");
            Overload Object1 = new Overload();
            Object1.addition(100, 200);
            Object1.addition(100.5, 200.5);
            #endregion
            log.Info("Compile time polymorphism");

            #region Run Time Polymorphism
            Console.WriteLine("\n ****************   Run Time Polymorphism   ****************");
            Object1.MethodPrint();
            #endregion

            #region Inheritance
            Console.WriteLine("\n ****************   Inheritance   ****************");
            DerivedClass DerivedObject = new DerivedClass();
            string userName = DerivedObject.ReturnUserName();
            Console.WriteLine(userName);
            DerivedObject.printUserSSN();
            DerivedObject.printUserAge();
            Console.WriteLine("Lastname is : " + DerivedObject.lastName);
            #endregion

            #region Multi-level Inheritance
            Console.WriteLine("\n ****************   Multi - Level Inheritance   ****************");
            DerivedClass2 DerivedObject2 = new DerivedClass2();
            DerivedObject2.printUserSSN();
            DerivedObject2.printUserAge();
            Console.WriteLine("Lastname is : " + DerivedObject2.lastName);
            DerivedObject2.PrintUserAddress();
            #endregion

            #region Mulitple Inheritance
            Console.WriteLine("\n ****************   Multiple Inheritance   ****************");
            Car1 objectCar = new Car1();
            objectCar.Method1();
            objectCar.Method2();
            #endregion

            #region Abstraction
            Console.WriteLine("\n ****************   Abstraction   ****************");
            School objectSchool = new School();
            objectSchool.printRollNo();
            objectSchool.printName();
            #endregion

            #region List
            Console.WriteLine("\n ****************   Lists   ****************");
            Lists objectList = new Lists();
            objectList.StudentsList();
            #endregion

            #region Array list
            Console.WriteLine("\n ****************   Array Lists   ****************");
            ArraList objArrList = new ArraList();
            objArrList.CheckArraList();
            #endregion

            #region Dictionary
            Console.WriteLine("\n ****************   Dictionary    ****************");
            Dictionary objDict= new Dictionary();
            objDict.dict();
            #endregion

            #region IEnumerable
            Console.WriteLine("\n ****************   IEnumerable    ****************");
            //sample sam = new sample();
            //sam.Method1();
            #endregion

            #region LINQ
            Console.WriteLine("\n ****************   LINQ    ****************");
            Linq query = new Linq();
            query.listValidation();
            query.LINQValidation();
            //query.StudentListValidation();
            
            #endregion

            #region Enum
            Console.WriteLine("\n" + priority.Medium);
            #endregion

            #region Static
            Console.WriteLine("\n ****************   Static    ****************");
            StaticClass.MethodStatic();
            Console.WriteLine("Department is - " + StaticClass.department);
            #endregion

            #region String Operations
            KeywordStringOperations sOperations = new KeywordStringOperations();
            sOperations.StringMethods();
            sOperations.BreakContinue();
            var typ = sOperations.GetType();
            Console.WriteLine(typ.IsInstanceOfType(sOperations));
            Console.WriteLine("\n ****************   String Builder   ****************");
            stringbuilders strBuilder = new stringbuilders();
            strBuilder.stringBuild();
            #endregion

            #region
            Testing test = new Testing();
            
            #endregion

            #region BrowserAutomation
            Automation auto = new Automation();
            //auto.Launchbrowser();
            #endregion

            //Creational Design pattern
            //It allows the class to create only one instance with global point of access to it
            //Useful where shared resources or data
            // it creates same object every time it is called.
            /*
            – In c# a static class cannot implement an interface. When a single instance class needs to implement an interface for some business reason or IoC purposes, you can use the Singleton pattern without a static class.
            – You can clone the object of Singleton but, you can not clone the static class object
            – Singleton object stores in Heap but, static object stores in stack
            – A singleton can be initialized lazily or asynchronously while a static class is generally initialized when it is first loaded
            */
            #region Singleton pattern


            Singleton objSingle = Singleton.getInstance();
            objSingle.book1Details();
            objSingle.book2Details();
            #endregion

            //Builder design - creational design pattern
            // Create, Initialize and Return objects
            //this separates the construction of complex objects from its represenatation
            //step by step process
            //Involves creation of objects and its initialization


            #region Builder Design Pattern
            /*
            DesktopBuilder objDeskBuilder = new DesktopBuilder();
            objDeskBuilder.CreateObject();
            objDeskBuilder.InitializeObject(" This is ");
            IProduct objPrd = objDeskBuilder.ReturnObject();
            objPrd.Shwodetails();
            */


            Director director = new Director();
            LaptopBuilder Lapbuilder = new LaptopBuilder();
            DesktopBuilder deskBuilder = new DesktopBuilder();

            IProduct prdLaptop = director.CreateProduct(Lapbuilder, "Laptop, 2tb, ssd, hdd");
            IProduct prdDesktop= director.CreateProduct(deskBuilder, "Desktop, 2tb, ssd, hdd");

            prdDesktop.Shwodetails();
            prdLaptop.Shwodetails();
            #endregion

            //Factory Pattern - Creational design pattern
            //It separates the instantiation logic
            //It uses common interface which is inherited by the class.
            //It maintains the centralized objects creation
            //DriverFactory - Switch - new object creation
            //DriverManager - quit and Createdriver methods

            #region Factory Pattern
            Console.WriteLine("Enter the Vehicle Type");
            string? type = Console.ReadLine();
            IVehicle Type = VehicleFactory.GetVehicleType(type);
            Console.WriteLine("Vehicle Type : " + Type.VehicleType());
            Console.WriteLine("Number of wheels : " + Type.NumberOfWheels());
            #endregion

            #region Decorator pattern

            /*
             The Decorator pattern is a design pattern in object-oriented programming that allows behavior to be added to an individual object, either statically or dynamically, without affecting the behavior of other objects from the same class. 
            
            It is a structural pattern that involves creating a decorator class that wraps the original class and provides additional functionality while maintaining the same interface as the original class. 
            
            This pattern is useful for situations where it is necessary to add functionality to an object in a flexible and modular way, without creating a large number of subclasses.
             */


            //Implements Open/Closed principle
            //Used for dynamically add an individual object without affecting the program correctness
            //It avoid creation of large number of subclasses.

            ICarDeco objCar = new LuxuryCar();
            //Wrap EconomyCar instance with BasicAccessories.   
            CarAccessoriesDecorator objAccessoriesDecorator = new BasicAccessories(objCar);
            Console.WriteLine("Car Details: " + objAccessoriesDecorator.GetDescription());
            Console.WriteLine("\n\n");
            Console.WriteLine("Total Price: " + objAccessoriesDecorator.GetCost());



            //Wrap EconomyCar instance with AdvancedAccessories instance.   
            objAccessoriesDecorator = new AdvancedAccessories(objAccessoriesDecorator);
            Console.WriteLine("Car Details: " + objAccessoriesDecorator.GetDescription());
            Console.WriteLine("\n\n");
            Console.WriteLine("Total Price: " + objAccessoriesDecorator.GetCost());
            #endregion


            #region LEarn
            Dog dog = new Dog();
            IAnimal11 dog1 = new Dog();
            IAnimal11 cat = new Cat();
            dog.animalSound();
            dog1.animalSound();
            cat.animalSound();

            #endregion

            #region Partial classes
            Employee emp = new Employee(1001, "Kumar");
            emp.displayInfo();
            #endregion

            #region Delegates main

            #region Delegates
            MyDelegate MyDel = ClassA.MethodA;
            MyDel("Test Message Delegate");
            MyDel.Invoke("Testing new invoke");
            #endregion

            #region Lambda Expression
            Console.WriteLine("\n ****************   Lambda Expression    ****************");
            Print print = (string mm) => Console.WriteLine("This is lambda" + mm);
            Print1 print1 = () => Console.WriteLine("This is lambda");
            print(" - *** Testing ");
            #endregion

            #region Function Delegate
            Console.WriteLine("\n ****************   Function Delegate   ****************");
            Func<int, int, int> add = sum;
            int result = add(10,10);
            Console.WriteLine("\n" + result);
            #endregion

            #region Action Delegate
            Console.WriteLine("\n ****************   Action Delegate   ****************");
            Action<int> actDel = Testing.consolePrint;
            actDel(100);
            #endregion

            #region Predicate Delegate
            Console.WriteLine("\n ****************   Predicate Delegate   ****************");
            Predicate<string> IsUpper = IsUpperCase;
            Console.WriteLine("Upper case validation : - " + IsUpper("HEllo"));
            #endregion
            #endregion

            #region Extension Method
            string sent = "This is beautiful day!";
            Console.WriteLine("Count is - " + sent.strCount());
            #endregion

            #region Collections
            Console.WriteLine("\n ****************   Collections  ****************");
            Sorted sorted = new Sorted();
            sorted.Method1();
            sorted.Method2();
            sorted.Method3();
            #endregion

        }
        public static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }


        public static void consolePrint(int num)
        {
            Console.WriteLine("Action Delegate - " + num);
        }
        

        static int sum(int x, int y)
        {
            return x + y;
        }

        //static Func<int, int, int> DelName;

        
        
    }
    


    delegate void Print(string m);
    delegate void Print1();
    delegate void MyDelegate(string msg);

    public class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("MethodA - " + message);
        }
    }
    public class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("MethodB - " + message);
        }
    }

    public static class StrOperations
    {
        public static int strCount(this string str)
        {
            char[] arr = { ',', ' ' };
            int num = str.Split(arr,StringSplitOptions.RemoveEmptyEntries).Length;
            return num;
        }
    }

    public class MethodDerived : MethodHiding
    {

        public new void TestMethod()
        {
            Console.WriteLine("This is a Test Derived Method");
        }

        public override void TestMethod1()
        {
            Console.WriteLine("This is a Override Method");
            MethodDerived m1 = new MethodDerived();
            m1.TestMethod();
        }
        
        
        

    }
}