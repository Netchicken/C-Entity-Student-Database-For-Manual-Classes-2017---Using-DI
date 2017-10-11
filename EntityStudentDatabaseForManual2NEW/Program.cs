using System;
using System.Windows.Forms;

namespace CollegeDB
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>

        //THE CONTAINER
        private static SimpleInjector.Container container;

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new Form1());

            //new below for the Simple Injector
            Startup();
            Application.Run(container.GetInstance<Form1>());
        }

        private static void Startup()
        {
            //http://simpleinjector.readthedocs.io/en/latest/using.html
            //The goal of Simple Injector is to provide .NET application developers with an easy, flexible, and fast Inversion of Control library that promotes best practice to steer developers towards the pit of success.

            // Create the container as usual.Creating and configuring a Container is done by newing up an instance and calling the Register overloads to register each of your services:

            //http://simpleinjector.readthedocs.io/en/latest/windowsformsintegration.html
            container = new SimpleInjector.Container();

            // Register your types, for instance:
            container.Register<IStudents, Students>();
            container.Register<ICourses, Courses>();
            container.Register<IMarksData, MarksData>();
            container.Register<Form1>();
            // Registering a list of instances that will be created by the container.
            // Supplying a collection of types is the preferred way of registering collections.
            // container.RegisterCollection<IDiceRolls>(new[] { typeof(DiceRolls), typeof(DiceRoll3) });

            // Optionally verify the container.
            // container.Verify();


        }

    }
}