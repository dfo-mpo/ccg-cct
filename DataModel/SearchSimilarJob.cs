using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace DataModel
{
    public class SearchSimilarJob
    {
        public int Id { get; set; }
        public int Position { get; set; }
        public string HundredPercent { get; set; }
        public string NinetyPercent { get; set; }
        public string EightyPercent { get; set; }
        public string SeventyPercent { get; set; }
    }
}