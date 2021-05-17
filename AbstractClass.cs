using System;
using System.Collections.Generic;
using System.Text;

namespace Abdullah_Test
{
    
        public abstract class Test_Model
        {
            public abstract void Answer_Model();
        }

        class RealTime_Example : Test_Model
        {
            public override void Answer_Model()
            {
            Console.WriteLine(@"Question's are:Class,Object,Encapsulation,Abstract,Inheritance,overload
overide and Operator Overload");            }
        }
}

