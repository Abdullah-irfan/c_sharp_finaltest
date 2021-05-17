using System;
using System.Collections.Generic;
using System.Text;

namespace Abdullah_Test
{
    class Encapsulation
    {

        private string Test_Given_Date { get; set; }
        public int Total_Questions { get; set; }
        public string Test_Type { get; set; }

        public string test_given_date
        {
            get
            {
                return Test_Given_Date;
            }
            set
            {
                Test_Given_Date = value;
            }

        }
    }
   

}
    

