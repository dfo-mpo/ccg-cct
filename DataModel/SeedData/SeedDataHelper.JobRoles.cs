﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<JobRole> JobRoles = new List<JobRole>()
        {
            new JobRole() {JobGroupId = 1, SubJobGroupId = 25, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 2, SubJobGroupId = 25, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 2, SubJobGroupId = 25, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 3, SubJobGroupId = 25, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 2, SubJobGroupId = 25, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 3, SubJobGroupId = 25, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 2, SubJobGroupId = 25, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 2, SubJobGroupId = 25, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 2, SubJobGroupId = 25, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 2, SubJobGroupId = 25, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 2, SubJobGroupId = 25, JobGroupLevelId = 8},
            new JobRole() {JobGroupId = 2, SubJobGroupId = 22, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 2, SubJobGroupId = 22, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 2, SubJobGroupId = 22, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 2, SubJobGroupId = 22, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 1, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 1, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 2, JobGroupLevelId = 9},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 2, JobGroupLevelId = 10},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 3, JobGroupLevelId = 10},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 4, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 4, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 4, JobGroupLevelId = 8},
            new JobRole() {JobGroupId = 9, SubJobGroupId = 5, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 9, SubJobGroupId = 5, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 9, SubJobGroupId = 5, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 9, SubJobGroupId = 6, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 9, SubJobGroupId = 6, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 9, SubJobGroupId = 6, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 9, SubJobGroupId = 6, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 9, SubJobGroupId = 7, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 9, SubJobGroupId = 7, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 9, SubJobGroupId = 7, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 9, SubJobGroupId = 7, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 9, SubJobGroupId = 7, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 9, SubJobGroupId = 7, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 9, SubJobGroupId = 8, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 9, SubJobGroupId = 8, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 9, SubJobGroupId = 8, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 10, SubJobGroupId = 9, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 10, SubJobGroupId = 9, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 10, SubJobGroupId = 9, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 10, SubJobGroupId = 9, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 10, SubJobGroupId = 9, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 10, SubJobGroupId = 9, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 10, SubJobGroupId = 9, JobGroupLevelId = 8},
            new JobRole() {JobGroupId = 10, SubJobGroupId = 9, JobGroupLevelId = 9},
            new JobRole() {JobGroupId = 10, SubJobGroupId = 9, JobGroupLevelId = 10},
            new JobRole() {JobGroupId = 10, SubJobGroupId = 9, JobGroupLevelId = 11},
            new JobRole() {JobGroupId = 10, SubJobGroupId = 9, JobGroupLevelId = 12},
            new JobRole() {JobGroupId = 10, SubJobGroupId = 9, JobGroupLevelId = 13},
            new JobRole() {JobGroupId = 10, SubJobGroupId = 10, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 10, SubJobGroupId = 10, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 17, SubJobGroupId = 25, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 17, SubJobGroupId = 25, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 17, SubJobGroupId = 25, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 17, SubJobGroupId = 25, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 18, SubJobGroupId = 27, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 18, SubJobGroupId = 27, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 18, SubJobGroupId = 27, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 19, SubJobGroupId = 24, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 19, SubJobGroupId = 24, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 19, SubJobGroupId = 24, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 7, SubJobGroupId = 25, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 7, SubJobGroupId = 25, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 7, SubJobGroupId = 25, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 15, SubJobGroupId = 26, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 15, SubJobGroupId = 26, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 4, SubJobGroupId = 11, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 4, SubJobGroupId = 11, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 4, SubJobGroupId = 11, JobGroupLevelId = 9},
            new JobRole() {JobGroupId = 4, SubJobGroupId = 12, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 4, SubJobGroupId = 12, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 14, SubJobGroupId = 13, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 14, SubJobGroupId = 14, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 14, SubJobGroupId = 15, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 14, SubJobGroupId = 15, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 5, SubJobGroupId = 25, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 5, SubJobGroupId = 25, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 5, SubJobGroupId = 25, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 5, SubJobGroupId = 25, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 5, SubJobGroupId = 25, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 5, SubJobGroupId = 25, JobGroupLevelId = 8},
            new JobRole() {JobGroupId = 5, SubJobGroupId = 25, JobGroupLevelId = 9},
            new JobRole() {JobGroupId = 21, SubJobGroupId = 25, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 21, SubJobGroupId = 25, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 21, SubJobGroupId = 25, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 21, SubJobGroupId = 25, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 21, SubJobGroupId = 25, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 16, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 16, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 16, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 16, JobGroupLevelId = 8},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 16, JobGroupLevelId = 9},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 16, JobGroupLevelId = 10},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 17, JobGroupLevelId = 9},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 17, JobGroupLevelId = 10},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 17, JobGroupLevelId = 11},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 18, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 18, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 18, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 18, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 18, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 19, JobGroupLevelId = 8},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 19, JobGroupLevelId = 9},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 19, JobGroupLevelId = 10},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 19, JobGroupLevelId = 11},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 20, JobGroupLevelId = 10},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 20, JobGroupLevelId = 11},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 21, JobGroupLevelId = 9},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 21, JobGroupLevelId = 10},
            new JobRole() {JobGroupId = 8, SubJobGroupId = 21, JobGroupLevelId = 11},
            new JobRole() {JobGroupId = 13, SubJobGroupId = 25, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 13, SubJobGroupId = 25, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 13, SubJobGroupId = 25, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 13, SubJobGroupId = 25, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 13, SubJobGroupId = 25, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 13, SubJobGroupId = 25, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 13, SubJobGroupId = 25, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 22, SubJobGroupId = 25, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 22, SubJobGroupId = 25, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 20, SubJobGroupId = 25, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 20, SubJobGroupId = 25, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 20, SubJobGroupId = 25, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 20, SubJobGroupId = 25, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 6, SubJobGroupId = 25, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 6, SubJobGroupId = 25, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 6, SubJobGroupId = 25, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 6, SubJobGroupId = 25, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 6, SubJobGroupId = 25, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 1, SubJobGroupId = 25, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 1, SubJobGroupId = 25, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 1, SubJobGroupId = 25, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 1, SubJobGroupId = 25, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 1, SubJobGroupId = 25, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 1, SubJobGroupId = 25, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 1, SubJobGroupId = 25, JobGroupLevelId = 8},
            new JobRole() {JobGroupId = 11, SubJobGroupId = 25, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 11, SubJobGroupId = 25, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 11, SubJobGroupId = 25, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 11, SubJobGroupId = 25, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 11, SubJobGroupId = 25, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 3, SubJobGroupId = 25, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 3, SubJobGroupId = 25, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 23, SubJobGroupId = 25, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 23, SubJobGroupId = 25, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 23, SubJobGroupId = 25, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 23, SubJobGroupId = 25, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 23, SubJobGroupId = 25, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 23, SubJobGroupId = 25, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 23, SubJobGroupId = 25, JobGroupLevelId = 8},
            new JobRole() {JobGroupId = 23, SubJobGroupId = 25, JobGroupLevelId = 9},
            new JobRole() {JobGroupId = 16, SubJobGroupId = 25, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 16, SubJobGroupId = 25, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 16, SubJobGroupId = 25, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 16, SubJobGroupId = 25, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 16, SubJobGroupId = 23, JobGroupLevelId = 1}
        };
    }
}

