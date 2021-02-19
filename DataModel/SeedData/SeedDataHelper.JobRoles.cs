﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<JobRole> JobRoles = new List<JobRole>()
        {
            new JobRole() {JobGroupId = 1, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 2, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 2, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 3, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 2, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 3, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 2, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 2, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 2, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 2, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 2, JobGroupLevelId = 8},
            new JobRole() {JobGroupId = 2, JobGroupLevelId = 80},
            new JobRole() {JobGroupId = 2, JobGroupLevelId = 81},
            new JobRole() {JobGroupId = 2, JobGroupLevelId = 82},
            new JobRole() {JobGroupId = 2, JobGroupLevelId = 83},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 10},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 11},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 12},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 13},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 14},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 15},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 16},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 17},
            new JobRole() {JobGroupId = 9, JobGroupLevelId = 18},
            new JobRole() {JobGroupId = 9, JobGroupLevelId = 19},
            new JobRole() {JobGroupId = 9, JobGroupLevelId = 20},
            new JobRole() {JobGroupId = 9, JobGroupLevelId = 21},
            new JobRole() {JobGroupId = 9, JobGroupLevelId = 22},
            new JobRole() {JobGroupId = 9, JobGroupLevelId = 23},
            new JobRole() {JobGroupId = 9, JobGroupLevelId = 24},
            new JobRole() {JobGroupId = 9, JobGroupLevelId = 25},
            new JobRole() {JobGroupId = 9, JobGroupLevelId = 26},
            new JobRole() {JobGroupId = 9, JobGroupLevelId = 27},
            new JobRole() {JobGroupId = 9, JobGroupLevelId = 28},
            new JobRole() {JobGroupId = 9, JobGroupLevelId = 29},
            new JobRole() {JobGroupId = 9, JobGroupLevelId = 30},
            new JobRole() {JobGroupId = 9, JobGroupLevelId = 31},
            new JobRole() {JobGroupId = 9, JobGroupLevelId = 32},
            new JobRole() {JobGroupId = 9, JobGroupLevelId = 33},
            new JobRole() {JobGroupId = 10, JobGroupLevelId = 34},
            new JobRole() {JobGroupId = 10, JobGroupLevelId = 35},
            new JobRole() {JobGroupId = 10, JobGroupLevelId = 36},
            new JobRole() {JobGroupId = 10, JobGroupLevelId = 37},
            new JobRole() {JobGroupId = 10, JobGroupLevelId = 38},
            new JobRole() {JobGroupId = 10, JobGroupLevelId = 39},
            new JobRole() {JobGroupId = 10, JobGroupLevelId = 40},
            new JobRole() {JobGroupId = 10, JobGroupLevelId = 41},
            new JobRole() {JobGroupId = 10, JobGroupLevelId = 42},
            new JobRole() {JobGroupId = 10, JobGroupLevelId = 43},
            new JobRole() {JobGroupId = 10, JobGroupLevelId = 44},
            new JobRole() {JobGroupId = 10, JobGroupLevelId = 45},
            new JobRole() {JobGroupId = 10, JobGroupLevelId = 46},
            new JobRole() {JobGroupId = 10, JobGroupLevelId = 47},
            new JobRole() {JobGroupId = 17, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 17, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 17, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 17, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 18, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 18, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 18, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 19, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 19, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 19, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 7, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 7, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 7, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 15, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 15, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 4, JobGroupLevelId = 48},
            new JobRole() {JobGroupId = 4, JobGroupLevelId = 49},
            new JobRole() {JobGroupId = 4, JobGroupLevelId = 50},
            new JobRole() {JobGroupId = 4, JobGroupLevelId = 51},
            new JobRole() {JobGroupId = 4, JobGroupLevelId = 52},
            new JobRole() {JobGroupId = 14, JobGroupLevelId = 53},
            new JobRole() {JobGroupId = 14, JobGroupLevelId = 54},
            new JobRole() {JobGroupId = 14, JobGroupLevelId = 55},
            new JobRole() {JobGroupId = 14, JobGroupLevelId = 56},
            new JobRole() {JobGroupId = 5, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 5, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 5, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 5, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 5, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 5, JobGroupLevelId = 8},
            new JobRole() {JobGroupId = 5, JobGroupLevelId = 9},
            new JobRole() {JobGroupId = 21, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 21, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 21, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 21, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 21, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 57},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 58},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 59},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 60},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 61},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 62},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 63},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 64},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 65},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 66},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 67},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 68},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 69},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 70},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 71},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 72},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 73},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 74},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 75},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 76},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 77},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 78},
            new JobRole() {JobGroupId = 8, JobGroupLevelId = 79},
            new JobRole() {JobGroupId = 13, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 13, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 13, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 13, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 13, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 13, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 13, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 22, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 22, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 20, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 20, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 20, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 20, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 6, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 6, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 6, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 6, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 6, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 1, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 1, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 1, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 1, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 1, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 1, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 1, JobGroupLevelId = 8},
            new JobRole() {JobGroupId = 11, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 11, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 11, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 11, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 11, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 3, JobGroupLevelId = 1},
            new JobRole() {JobGroupId = 3, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 23, JobGroupLevelId = 2},
            new JobRole() {JobGroupId = 23, JobGroupLevelId = 3},
            new JobRole() {JobGroupId = 23, JobGroupLevelId = 4},
            new JobRole() {JobGroupId = 23, JobGroupLevelId = 5},
            new JobRole() {JobGroupId = 23, JobGroupLevelId = 6},
            new JobRole() {JobGroupId = 23, JobGroupLevelId = 7},
            new JobRole() {JobGroupId = 23, JobGroupLevelId = 8},
            new JobRole() {JobGroupId = 23, JobGroupLevelId = 9}
        };
    }
}