using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class SimilarJobGroupSearch
    {
        public int Id { get; set; }
        public string JobGroup { get; set; }
        public string SubJobGroup { get; set; }
        public int Level { get; set; }
        public string HundredPercentResult { get; set; }
        public string NineteenPercentResult { get; set; }
        public string HeighteenPercentResult { get; set; }
        public string SeventeenPercentResult { get; set; }
    }
}