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

namespace Practice
{
    public class Testing
    {
        public static void Main()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log =  log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            log.Info("Logging is started");

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
            query.StudentListValidation();
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


            #region Singleton pattern
            //Creational Design pattern
            //It allows the class to create only one instance with global access to it
            //Useful where shared resources or data
            // it creates same oject evertyime it is called.


            Singleton objSingle = Singleton.getInstance();
            objSingle.book1Details();
            objSingle.book2Details();
            #endregion

            #region Builder Design Pattern
            /*
            DesktopBuilder objDeskBuilder = new DesktopBuilder();
            objDeskBuilder.CreateObject();
            objDeskBuilder.InitializeObject(" This is ");
            IProduct objPrd = objDeskBuilder.ReturnObject();
            objPrd.Shwodetails();
            */
            //creational design pattern
            //this separates the construction of complex objects from its represenatation
            //step by step process
            //Involves creation of objects and its initialization
            // Create, Initialize and Return objects
           
            Director director = new Director();
            LaptopBuilder Lapbuilder = new LaptopBuilder();
            DesktopBuilder deskBuilder = new DesktopBuilder();

            IProduct prdLaptop = director.CreateProduct(Lapbuilder, "Laptop, 2tb, ssd, hdd");
            IProduct prdDesktop= director.CreateProduct(deskBuilder, "Desktop, 2tb, ssd, hdd");

            prdDesktop.Shwodetails();
            prdLaptop.Shwodetails();
            #endregion

            //Creational design pattern
            //It separates the instantiation logic
            //It uses common interface which is inheriated by the class.
            //It maintains the centralized objects creation
            //DriverFactory - Switch - new object creation
            //DriverManager - quit and createdriver methods

            #region Factory Pattern
            Console.WriteLine("Enter the Vehicle Type");
            string? type = Console.ReadLine();
            IVehicle Type = VehicleFactory.GetVehicleType(type);
            Console.WriteLine("Vehicle Type : " + Type.VehicleType());
            Console.WriteLine("Number of wheels : " + Type.NumberOfWheels());
            #endregion

            #region Decorator pattern

            /*
             The Decorator pattern is a design pattern in object-oriented programming that allows behavior to be added to an individual object, either statically or dynamically, without affecting the behavior of other objects from the same class. It is a structural pattern that involves creating a decorator class that wraps the original class and provides additional functionality while maintaining the same interface as the original class. This pattern is useful for situations where it is necessary to add functionality to an object in a flexible and modular way, without creating a large number of subclasses.
             */


            //Implements Open/Closed principle
            //Used for dynamically add an individual object without affecting the program correctness
            //It avoid creation of large number of subclasses.

            ICarDeco objCar = new LuxuryCar();
            //Wrp EconomyCar instancw with BasicAccessories.   
            CarAccessoriesDecorator objAccessoriesDecorator = new BasicAccessories(objCar);
            //Wrap EconomyCar instance with AdvancedAccessories instance.   
            objAccessoriesDecorator = new AdvancedAccessories(objAccessoriesDecorator);
            Console.WriteLine("Car Details: " + objAccessoriesDecorator.GetDescription());
            Console.WriteLine("\n\n");
            Console.WriteLine("Total Price: " + objAccessoriesDecorator.GetCost());
            #endregion
        }
    }
}