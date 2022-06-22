using System.Linq;
using Business.Dtos.JobPositions;
using System.Collections.Generic;

namespace Admin.Data.PartialModels
{
    public class SimilarDetailsPartialModel
    {

        public JobPositionDto[] JobPositions { get; set; }
        public int PercentMatch { get; set; }

        public int JobPositionId { get; set; }

    }
}