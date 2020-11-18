using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Queries.Dtos
{
    class JobCompetencyDto
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string NameEng { get; set; }

        public string NameFre { get; set; }

        public string DescEng { get; set; }

        public string DescFre { get; set; }
    }
}
