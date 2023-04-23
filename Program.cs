// See https://aka.ms/new-console-template for more information

using DesignPatterns;
using DesignPatterns.BuilderPattern;
using DesignPatterns.BuilderPattern.Desktop;
using DesignPatterns.BuilderPattern.Laptop;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using TestConsole;

namespace Practice
{
    class Testing
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
            Car objectCar = new Car();
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
            Singleton objSingle = Singleton.getInstance();
            objSingle.book1Details();
            objSingle.book2Details();
            #endregion

            #region
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
        }
    }
}