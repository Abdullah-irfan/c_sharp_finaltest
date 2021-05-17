using System;

namespace Abdullah_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // for class program
            Class1.classA();

            // for creating object
            Console.WriteLine();
            obj memory_Allocation= new obj();
            memory_Allocation.objectA();

            //for Encapsulation this type also called model
            Encapsulation capsul = new Encapsulation();
            Console.WriteLine();
            capsul.test_given_date = "14/5/2021";// private access modifies here used
            capsul.Total_Questions = 6;
            capsul.Test_Type = "c#";
            Console.WriteLine("Tast_Given_Date:"+ capsul.test_given_date);
            Console.WriteLine("Total_Questions:"+ capsul.Total_Questions);
            Console.WriteLine("Test_Type:"+ capsul.Test_Type);

            //for Abstract
            Console.WriteLine();
            Test_Model TM;
            TM = new RealTime_Example();
            TM.Answer_Model();

            //for In
            Console.WriteLine();
            In_OFFICE InOffc = new In_OFFICE();
            InOffc.day();
            InOffc.Start();
            InOffc.End();
            WORK_FROM_HOME wfh = new WORK_FROM_HOME();
            wfh.day();
            wfh.Start();
            wfh.End();
             
            //overload
            Console.WriteLine();
            OL.class1("Prasanth", "  Erode");
            OL.class1("FullSatack_Developer", " Erode ", 2021);
            //override
            Console.WriteLine();
            apply leave = new apply();
            leave.paywow();

            
            //------------------------------
            Console.ReadKey();

        }
    }
}
