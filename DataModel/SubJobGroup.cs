using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace DataModel
{
    public class SubJobGroup
    {
        public int Id { get; set; }

        public string SubCode { get; set; } // ex: MOC, WOW, 

        public int Active { get; set; } // ex : 0 = SubCode deleted, 1 = SubCode active

    }
}