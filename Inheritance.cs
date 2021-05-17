using System;
using System.Collections.Generic;
using System.Text;

namespace Abdullah_Test
{
    class spantech
    {
        public void Start()
        {
            Console.WriteLine("clock In sharply at 10AM\n");
        }
        public void End()
        {
            Console.WriteLine("Before clock Out Make-Sure 8hr is Complited or Nots\n");
        }


    }
    class In_OFFICE : spantech
    {
        public void day()
        {
            Console.WriteLine("OFFC_Day Started\n");
        }
    }

    class WORK_FROM_HOME : spantech
    {
        public void day()
        {
            Console.WriteLine(" WFH_Day Started\n");
        }
    }
}


