using System;
using System.Collections.Generic;
using System.Text;

namespace Abdullah_Test
{
   public class OL
    {
        public static void class1(string Reporing_Manager, string Locaion)
        {
            Console.WriteLine("Reporing_Manager:{0}{1}", Reporing_Manager, Locaion);
        }
        public static void class1(string Team_Name, string Locaion, int Batch)//overloade
        {
            Console.WriteLine("Team:{0}{1}{2}", Team_Name, Locaion, Batch);
        }
    }

    public class Leave
    {
        public virtual void paywow()
        {
            Console.WriteLine("leave...");
        }
    }
    public class apply : Leave
    {
        public override void paywow()
        {
            Console.WriteLine("Apply in PayWow for Leave..");
        }

        public static  apply operator ++( apply c)  
            {
          
        }
    

}
   
}
