using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace DataModel
{
    public class SubJobGroup
    {
        public int Id { get; set; }

        public string Code { get; set; } // ex: MOC, WOW, 

        public string NameEng { get; set; } // 

        public string NameFre { get; set; } // 

        public int JobGroupId { get; set; }
        public JobGroup JobGroup { get; set; }
    }
}

