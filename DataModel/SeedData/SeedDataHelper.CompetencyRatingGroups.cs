using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<CompetencyRatingGroup> CompetencyRatingGroups = new List<CompetencyRatingGroup>()
        {
            new CompetencyRatingGroup
                {CompetencyId = 1, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 1},
            new CompetencyRatingGroup
                {CompetencyId = 1, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 2},
            new CompetencyRatingGroup
                {CompetencyId = 1, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 3},
            new CompetencyRatingGroup
                {CompetencyId = 1, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 4},
            new CompetencyRatingGroup
                {CompetencyId = 1, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 5},
            new CompetencyRatingGroup
                {CompetencyId = 2, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 6},
            new CompetencyRatingGroup
                {CompetencyId = 2, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 7},
            new CompetencyRatingGroup
                {CompetencyId = 2, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 8},
            new CompetencyRatingGroup
                {CompetencyId = 2, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 9},
            new CompetencyRatingGroup
                {CompetencyId = 2, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 10},
            new CompetencyRatingGroup
                {CompetencyId = 3, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 12},
            new CompetencyRatingGroup
                {CompetencyId = 3, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 13},
            new CompetencyRatingGroup
                {CompetencyId = 3, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 14},
            new CompetencyRatingGroup
                {CompetencyId = 3, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 15},
            new CompetencyRatingGroup
                {CompetencyId = 3, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 16},
            new CompetencyRatingGroup
                {CompetencyId = 4, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 17},
            new CompetencyRatingGroup
                {CompetencyId = 4, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 18},
            new CompetencyRatingGroup
                {CompetencyId = 4, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 19},
            new CompetencyRatingGroup
                {CompetencyId = 4, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 20},
            new CompetencyRatingGroup
                {CompetencyId = 4, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 21},
            new CompetencyRatingGroup
                {CompetencyId = 5, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 22},
            new CompetencyRatingGroup
                {CompetencyId = 5, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 23},
            new CompetencyRatingGroup
                {CompetencyId = 5, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 24},
            new CompetencyRatingGroup
                {CompetencyId = 5, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 25},
            new CompetencyRatingGroup
                {CompetencyId = 5, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 26},
            new CompetencyRatingGroup
                {CompetencyId = 6, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 27},
            new CompetencyRatingGroup
                {CompetencyId = 6, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 28},
            new CompetencyRatingGroup
                {CompetencyId = 6, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 29},
            new CompetencyRatingGroup
                {CompetencyId = 6, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 30},
            new CompetencyRatingGroup
                {CompetencyId = 6, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 31},
            new CompetencyRatingGroup
                {CompetencyId = 7, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 32},
            new CompetencyRatingGroup
                {CompetencyId = 7, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 33},
            new CompetencyRatingGroup
                {CompetencyId = 7, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 34},
            new CompetencyRatingGroup
                {CompetencyId = 7, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 35},
            new CompetencyRatingGroup
                {CompetencyId = 7, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 36},
            new CompetencyRatingGroup
                {CompetencyId = 8, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 37},
            new CompetencyRatingGroup
                {CompetencyId = 8, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 38},
            new CompetencyRatingGroup
                {CompetencyId = 8, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 39},
            new CompetencyRatingGroup
                {CompetencyId = 8, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 40},
            new CompetencyRatingGroup
                {CompetencyId = 8, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 41},
            new CompetencyRatingGroup
                {CompetencyId = 9, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 42},
            new CompetencyRatingGroup
                {CompetencyId = 9, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 43},
            new CompetencyRatingGroup
                {CompetencyId = 9, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 44},
            new CompetencyRatingGroup
                {CompetencyId = 9, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 45},
            new CompetencyRatingGroup
                {CompetencyId = 9, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 46},
            new CompetencyRatingGroup
                {CompetencyId = 10, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 47},
            new CompetencyRatingGroup
                {CompetencyId = 10, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 48},
            new CompetencyRatingGroup
                {CompetencyId = 10, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 49},
            new CompetencyRatingGroup
                {CompetencyId = 10, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 50},
            new CompetencyRatingGroup
                {CompetencyId = 10, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 51},
            new CompetencyRatingGroup
                {CompetencyId = 11, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 52},
            new CompetencyRatingGroup
                {CompetencyId = 11, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 53},
            new CompetencyRatingGroup
                {CompetencyId = 11, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 54},
            new CompetencyRatingGroup
                {CompetencyId = 11, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 55},
            new CompetencyRatingGroup
                {CompetencyId = 11, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 56},
            new CompetencyRatingGroup
                {CompetencyId = 12, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 57},
            new CompetencyRatingGroup
                {CompetencyId = 12, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 58},
            new CompetencyRatingGroup
                {CompetencyId = 12, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 59},
            new CompetencyRatingGroup
                {CompetencyId = 12, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 60},
            new CompetencyRatingGroup
                {CompetencyId = 12, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 61},
            new CompetencyRatingGroup
                {CompetencyId = 13, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 62},
            new CompetencyRatingGroup
                {CompetencyId = 13, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 63},
            new CompetencyRatingGroup
                {CompetencyId = 13, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 64},
            new CompetencyRatingGroup
                {CompetencyId = 13, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 65},
            new CompetencyRatingGroup
                {CompetencyId = 13, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 66},
            new CompetencyRatingGroup
                {CompetencyId = 14, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 67},
            new CompetencyRatingGroup
                {CompetencyId = 14, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 68},
            new CompetencyRatingGroup
                {CompetencyId = 14, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 69},
            new CompetencyRatingGroup
                {CompetencyId = 14, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 70},
            new CompetencyRatingGroup
                {CompetencyId = 14, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 71},
            new CompetencyRatingGroup
                {CompetencyId = 15, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 72},
            new CompetencyRatingGroup
                {CompetencyId = 15, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 73},
            new CompetencyRatingGroup
                {CompetencyId = 15, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 74},
            new CompetencyRatingGroup
                {CompetencyId = 15, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 75},
            new CompetencyRatingGroup
                {CompetencyId = 15, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 76},
            new CompetencyRatingGroup
                {CompetencyId = 16, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 77},
            new CompetencyRatingGroup
                {CompetencyId = 16, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 78},
            new CompetencyRatingGroup
                {CompetencyId = 16, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 79},
            new CompetencyRatingGroup
                {CompetencyId = 16, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 80},
            new CompetencyRatingGroup
                {CompetencyId = 16, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 81},
            new CompetencyRatingGroup
                {CompetencyId = 17, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 82},
            new CompetencyRatingGroup
                {CompetencyId = 17, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 83},
            new CompetencyRatingGroup
                {CompetencyId = 17, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 84},
            new CompetencyRatingGroup
                {CompetencyId = 17, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 85},
            new CompetencyRatingGroup
                {CompetencyId = 17, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 86},
            new CompetencyRatingGroup
                {CompetencyId = 18, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 87},
            new CompetencyRatingGroup
                {CompetencyId = 18, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 88},
            new CompetencyRatingGroup
                {CompetencyId = 18, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 89},
            new CompetencyRatingGroup
                {CompetencyId = 18, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 90},
            new CompetencyRatingGroup
                {CompetencyId = 18, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 91},
            new CompetencyRatingGroup
                {CompetencyId = 19, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 92},
            new CompetencyRatingGroup
                {CompetencyId = 19, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 93},
            new CompetencyRatingGroup
                {CompetencyId = 19, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 94},
            new CompetencyRatingGroup
                {CompetencyId = 19, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 95},
            new CompetencyRatingGroup
                {CompetencyId = 19, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 96},
            new CompetencyRatingGroup
                {CompetencyId = 20, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 97},
            new CompetencyRatingGroup
                {CompetencyId = 20, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 98},
            new CompetencyRatingGroup
                {CompetencyId = 20, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 99},
            new CompetencyRatingGroup
                {CompetencyId = 20, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 100},
            new CompetencyRatingGroup
                {CompetencyId = 20, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 101},
            new CompetencyRatingGroup
                {CompetencyId = 21, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 102},
            new CompetencyRatingGroup
                {CompetencyId = 21, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 103},
            new CompetencyRatingGroup
                {CompetencyId = 21, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 104},
            new CompetencyRatingGroup
                {CompetencyId = 21, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 105},
            new CompetencyRatingGroup
                {CompetencyId = 21, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 106},
            new CompetencyRatingGroup
                {CompetencyId = 22, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 107},
            new CompetencyRatingGroup
                {CompetencyId = 22, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 108},
            new CompetencyRatingGroup
                {CompetencyId = 22, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 109},
            new CompetencyRatingGroup
                {CompetencyId = 22, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 110},
            new CompetencyRatingGroup
                {CompetencyId = 22, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 111},
            new CompetencyRatingGroup
                {CompetencyId = 23, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 112},
            new CompetencyRatingGroup
                {CompetencyId = 23, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 113},
            new CompetencyRatingGroup
                {CompetencyId = 23, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 114},
            new CompetencyRatingGroup
                {CompetencyId = 23, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 115},

            new CompetencyRatingGroup
                {CompetencyId = 23, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 116},
            new CompetencyRatingGroup
                {CompetencyId = 24, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 117},
            new CompetencyRatingGroup
                {CompetencyId = 24, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 118},
            new CompetencyRatingGroup
                {CompetencyId = 24, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 119},
            new CompetencyRatingGroup
                {CompetencyId = 24, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 120},
            new CompetencyRatingGroup
                {CompetencyId = 24, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 121},
            new CompetencyRatingGroup
                {CompetencyId = 25, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 122},
            new CompetencyRatingGroup
                {CompetencyId = 25, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 123},
            new CompetencyRatingGroup
                {CompetencyId = 25, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 124},
            new CompetencyRatingGroup
                {CompetencyId = 25, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 125},
            new CompetencyRatingGroup
                {CompetencyId = 25, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 126},
            new CompetencyRatingGroup
                {CompetencyId = 26, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 127},
            new CompetencyRatingGroup
                {CompetencyId = 26, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 128},
            new CompetencyRatingGroup
                {CompetencyId = 26, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 129},
            new CompetencyRatingGroup
                {CompetencyId = 26, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 130},
            new CompetencyRatingGroup
                {CompetencyId = 26, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 131},
            new CompetencyRatingGroup
                {CompetencyId = 27, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 132},
            new CompetencyRatingGroup
                {CompetencyId = 27, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 133},
            new CompetencyRatingGroup
                {CompetencyId = 27, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 134},
            new CompetencyRatingGroup
                {CompetencyId = 27, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 135},
            new CompetencyRatingGroup
                {CompetencyId = 27, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 136},
            new CompetencyRatingGroup
                {CompetencyId = 28, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 137},
            new CompetencyRatingGroup
                {CompetencyId = 28, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 138},
            new CompetencyRatingGroup
                {CompetencyId = 28, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 139},
            new CompetencyRatingGroup
                {CompetencyId = 28, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 140},
            new CompetencyRatingGroup
                {CompetencyId = 28, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 141},
            new CompetencyRatingGroup
                {CompetencyId = 33, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 142},
            new CompetencyRatingGroup
                {CompetencyId = 33, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 143},
            new CompetencyRatingGroup
                {CompetencyId = 33, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 144},
            new CompetencyRatingGroup
                {CompetencyId = 33, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 145},
            new CompetencyRatingGroup
                {CompetencyId = 33, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 146},
            new CompetencyRatingGroup
                {CompetencyId = 34, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 147},
            new CompetencyRatingGroup
                {CompetencyId = 34, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 148},
            new CompetencyRatingGroup
                {CompetencyId = 34, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 149},
            new CompetencyRatingGroup
                {CompetencyId = 34, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 150},
            new CompetencyRatingGroup
                {CompetencyId = 34, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 151},
            new CompetencyRatingGroup
                {CompetencyId = 36, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 152},
            new CompetencyRatingGroup
                {CompetencyId = 36, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 153},
            new CompetencyRatingGroup
                {CompetencyId = 36, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 154},
            new CompetencyRatingGroup
                {CompetencyId = 36, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 155},
            new CompetencyRatingGroup
                {CompetencyId = 36, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 156},
            new CompetencyRatingGroup
                {CompetencyId = 37, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 157},
            new CompetencyRatingGroup
                {CompetencyId = 37, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 158},
            new CompetencyRatingGroup
                {CompetencyId = 37, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 159},
            new CompetencyRatingGroup
                {CompetencyId = 37, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 160},
            new CompetencyRatingGroup
                {CompetencyId = 37, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 161},
            new CompetencyRatingGroup
                {CompetencyId = 38, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 162},
            new CompetencyRatingGroup
                {CompetencyId = 38, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 163},
            new CompetencyRatingGroup
                {CompetencyId = 38, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 164},
            new CompetencyRatingGroup
                {CompetencyId = 38, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 165},
            new CompetencyRatingGroup
                {CompetencyId = 38, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 166},
            new CompetencyRatingGroup
                {CompetencyId = 39, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 167},
            new CompetencyRatingGroup
                {CompetencyId = 39, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 168},
            new CompetencyRatingGroup
                {CompetencyId = 39, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 169},
            new CompetencyRatingGroup
                {CompetencyId = 39, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 170},
            new CompetencyRatingGroup
                {CompetencyId = 39, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 171},
            new CompetencyRatingGroup
                {CompetencyId = 40, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 172},
            new CompetencyRatingGroup
                {CompetencyId = 40, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 173},
            new CompetencyRatingGroup
                {CompetencyId = 40, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 174},
            new CompetencyRatingGroup
                {CompetencyId = 40, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 175},
            new CompetencyRatingGroup
                {CompetencyId = 40, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 176},
            new CompetencyRatingGroup
                {CompetencyId = 41, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 177},
            new CompetencyRatingGroup
                {CompetencyId = 41, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 178},
            new CompetencyRatingGroup
                {CompetencyId = 41, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 179},
            new CompetencyRatingGroup
                {CompetencyId = 41, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 180},
            new CompetencyRatingGroup
                {CompetencyId = 41, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 181},
            new CompetencyRatingGroup
                {CompetencyId = 42, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 182},
            new CompetencyRatingGroup
                {CompetencyId = 42, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 183},
            new CompetencyRatingGroup
                {CompetencyId = 42, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 184},
            new CompetencyRatingGroup
                {CompetencyId = 42, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 185},
            new CompetencyRatingGroup
                {CompetencyId = 42, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 186},
            new CompetencyRatingGroup
                {CompetencyId = 43, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 187},
            new CompetencyRatingGroup
                {CompetencyId = 43, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 188},
            new CompetencyRatingGroup
                {CompetencyId = 43, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 189},
            new CompetencyRatingGroup
                {CompetencyId = 43, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 190},
            new CompetencyRatingGroup
                {CompetencyId = 43, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 191},
            new CompetencyRatingGroup
                {CompetencyId = 44, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 192},
            new CompetencyRatingGroup
                {CompetencyId = 44, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 193},
            new CompetencyRatingGroup
                {CompetencyId = 44, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 194},
            new CompetencyRatingGroup
                {CompetencyId = 44, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 195},
            new CompetencyRatingGroup
                {CompetencyId = 44, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 196},
            new CompetencyRatingGroup
                {CompetencyId = 45, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 197},
            new CompetencyRatingGroup
                {CompetencyId = 45, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 198},
            new CompetencyRatingGroup
                {CompetencyId = 45, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 199},
            new CompetencyRatingGroup
                {CompetencyId = 45, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 200},
            new CompetencyRatingGroup
                {CompetencyId = 45, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 201},
            new CompetencyRatingGroup
                {CompetencyId = 46, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 202},
            new CompetencyRatingGroup
                {CompetencyId = 46, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 203},
            new CompetencyRatingGroup
                {CompetencyId = 46, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 204},
            new CompetencyRatingGroup
                {CompetencyId = 46, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 205},
            new CompetencyRatingGroup
                {CompetencyId = 46, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 206},
            new CompetencyRatingGroup
                {CompetencyId = 47, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 207},
            new CompetencyRatingGroup
                {CompetencyId = 47, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 208},
            new CompetencyRatingGroup
                {CompetencyId = 47, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 209},
            new CompetencyRatingGroup
                {CompetencyId = 47, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 210},
            new CompetencyRatingGroup
                {CompetencyId = 47, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 211},
            new CompetencyRatingGroup
                {CompetencyId = 48, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 212},
            new CompetencyRatingGroup
                {CompetencyId = 48, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 213},
            new CompetencyRatingGroup
                {CompetencyId = 48, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 214},
            new CompetencyRatingGroup
                {CompetencyId = 48, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 215},
            new CompetencyRatingGroup
                {CompetencyId = 48, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 216},
            new CompetencyRatingGroup
                {CompetencyId = 49, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 217},
            new CompetencyRatingGroup
                {CompetencyId = 49, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 218},
            new CompetencyRatingGroup
                {CompetencyId = 49, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 219},
            new CompetencyRatingGroup
                {CompetencyId = 49, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 220},
            new CompetencyRatingGroup
                {CompetencyId = 49, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 221},
            new CompetencyRatingGroup
                {CompetencyId = 50, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 222},
            new CompetencyRatingGroup
                {CompetencyId = 50, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 223},
            new CompetencyRatingGroup
                {CompetencyId = 50, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 224},
            new CompetencyRatingGroup
                {CompetencyId = 50, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 225},
            new CompetencyRatingGroup
                {CompetencyId = 50, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 226},
            new CompetencyRatingGroup
                {CompetencyId = 51, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 227},
            new CompetencyRatingGroup
                {CompetencyId = 51, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 228},
            new CompetencyRatingGroup
                {CompetencyId = 51, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 229},
            new CompetencyRatingGroup
                {CompetencyId = 51, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 230},
            new CompetencyRatingGroup
                {CompetencyId = 51, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 231},
            new CompetencyRatingGroup
                {CompetencyId = 52, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 232},
            new CompetencyRatingGroup
                {CompetencyId = 52, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 233},
            new CompetencyRatingGroup
                {CompetencyId = 52, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 234},
            new CompetencyRatingGroup
                {CompetencyId = 52, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 235},
            new CompetencyRatingGroup
                {CompetencyId = 52, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 236},
            new CompetencyRatingGroup
                {CompetencyId = 53, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 237},
            new CompetencyRatingGroup
                {CompetencyId = 53, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 238},
            new CompetencyRatingGroup
                {CompetencyId = 53, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 239},
            new CompetencyRatingGroup
                {CompetencyId = 53, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 240},
            new CompetencyRatingGroup
                {CompetencyId = 53, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 241},
            new CompetencyRatingGroup
                {CompetencyId = 54, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 242},
            new CompetencyRatingGroup
                {CompetencyId = 54, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 243},
            new CompetencyRatingGroup
                {CompetencyId = 54, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 244},
            new CompetencyRatingGroup
                {CompetencyId = 54, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 245},
            new CompetencyRatingGroup
                {CompetencyId = 54, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 246},
            new CompetencyRatingGroup
                {CompetencyId = 55, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 247},
            new CompetencyRatingGroup
                {CompetencyId = 55, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 248},
            new CompetencyRatingGroup
                {CompetencyId = 55, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 249},
            new CompetencyRatingGroup
                {CompetencyId = 55, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 250},
            new CompetencyRatingGroup
                {CompetencyId = 55, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 251},
            new CompetencyRatingGroup
                {CompetencyId = 56, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 252},
            new CompetencyRatingGroup
                {CompetencyId = 56, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 253},
            new CompetencyRatingGroup
                {CompetencyId = 56, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 254},
            new CompetencyRatingGroup
                {CompetencyId = 56, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 255},
            new CompetencyRatingGroup
                {CompetencyId = 56, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 256},
            new CompetencyRatingGroup
                {CompetencyId = 57, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 257},
            new CompetencyRatingGroup
                {CompetencyId = 57, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 258},
            new CompetencyRatingGroup
                {CompetencyId = 57, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 259},
            new CompetencyRatingGroup
                {CompetencyId = 57, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 260},
            new CompetencyRatingGroup
                {CompetencyId = 57, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 261},
            new CompetencyRatingGroup
                {CompetencyId = 58, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 262},
            new CompetencyRatingGroup
                {CompetencyId = 58, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 263},
            new CompetencyRatingGroup
                {CompetencyId = 58, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 264},
            new CompetencyRatingGroup
                {CompetencyId = 58, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 265},
            new CompetencyRatingGroup
                {CompetencyId = 58, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 266},
            new CompetencyRatingGroup
                {CompetencyId = 59, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 267},
            new CompetencyRatingGroup
                {CompetencyId = 59, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 268},
            new CompetencyRatingGroup
                {CompetencyId = 59, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 269},
            new CompetencyRatingGroup
                {CompetencyId = 59, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 270},
            new CompetencyRatingGroup
                {CompetencyId = 59, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 271},
            new CompetencyRatingGroup
                {CompetencyId = 60, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 272},
            new CompetencyRatingGroup
                {CompetencyId = 60, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 273},
            new CompetencyRatingGroup
                {CompetencyId = 60, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 274},
            new CompetencyRatingGroup
                {CompetencyId = 60, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 275},
            new CompetencyRatingGroup
                {CompetencyId = 60, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 276},
            new CompetencyRatingGroup
                {CompetencyId = 61, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 277},
            new CompetencyRatingGroup
                {CompetencyId = 61, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 278},
            new CompetencyRatingGroup
                {CompetencyId = 61, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 279},
            new CompetencyRatingGroup
                {CompetencyId = 61, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 280},
            new CompetencyRatingGroup
                {CompetencyId = 61, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 281},
            new CompetencyRatingGroup
                {CompetencyId = 62, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 282},
            new CompetencyRatingGroup
                {CompetencyId = 62, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 283},
            new CompetencyRatingGroup
                {CompetencyId = 62, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 284},
            new CompetencyRatingGroup
                {CompetencyId = 62, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 285},
            new CompetencyRatingGroup
                {CompetencyId = 62, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 286},
            new CompetencyRatingGroup
                {CompetencyId = 63, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 287},
            new CompetencyRatingGroup
                {CompetencyId = 63, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 288},
            new CompetencyRatingGroup
                {CompetencyId = 63, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 289},
            new CompetencyRatingGroup
                {CompetencyId = 63, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 290},
            new CompetencyRatingGroup
                {CompetencyId = 63, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 291},
            new CompetencyRatingGroup
                {CompetencyId = 64, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 292},
            new CompetencyRatingGroup
                {CompetencyId = 64, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 293},
            new CompetencyRatingGroup
                {CompetencyId = 64, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 294},
            new CompetencyRatingGroup
                {CompetencyId = 64, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 295},
            new CompetencyRatingGroup
                {CompetencyId = 64, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 296},
            new CompetencyRatingGroup
                {CompetencyId = 65, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 297},
            new CompetencyRatingGroup
                {CompetencyId = 65, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 298},
            new CompetencyRatingGroup
                {CompetencyId = 65, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 299},
            new CompetencyRatingGroup
                {CompetencyId = 65, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 300},
            new CompetencyRatingGroup
                {CompetencyId = 65, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 301},
            new CompetencyRatingGroup
                {CompetencyId = 66, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 302},
            new CompetencyRatingGroup
                {CompetencyId = 66, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 303},
            new CompetencyRatingGroup
                {CompetencyId = 66, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 304},
            new CompetencyRatingGroup
                {CompetencyId = 66, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 305},
            new CompetencyRatingGroup
                {CompetencyId = 66, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 306},
            new CompetencyRatingGroup
                {CompetencyId = 67, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 307},
            new CompetencyRatingGroup
                {CompetencyId = 67, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 308},
            new CompetencyRatingGroup
                {CompetencyId = 67, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 309},
            new CompetencyRatingGroup
                {CompetencyId = 67, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 310},
            new CompetencyRatingGroup
                {CompetencyId = 67, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 311},
            new CompetencyRatingGroup
                {CompetencyId = 68, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 312},
            new CompetencyRatingGroup
                {CompetencyId = 68, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 313},
            new CompetencyRatingGroup
                {CompetencyId = 68, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 314},
            new CompetencyRatingGroup
                {CompetencyId = 68, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 315},
            new CompetencyRatingGroup
                {CompetencyId = 68, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 316},
            new CompetencyRatingGroup
                {CompetencyId = 69, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 317},
            new CompetencyRatingGroup
                {CompetencyId = 69, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 318},
            new CompetencyRatingGroup
                {CompetencyId = 69, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 319},
            new CompetencyRatingGroup
                {CompetencyId = 69, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 320},
            new CompetencyRatingGroup
                {CompetencyId = 69, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 321},
            new CompetencyRatingGroup
                {CompetencyId = 70, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 322},
            new CompetencyRatingGroup
                {CompetencyId = 70, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 323},
            new CompetencyRatingGroup
                {CompetencyId = 70, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 324},
            new CompetencyRatingGroup
                {CompetencyId = 70, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 325},
            new CompetencyRatingGroup
                {CompetencyId = 70, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 326},
            new CompetencyRatingGroup
                {CompetencyId = 71, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 327},
            new CompetencyRatingGroup
                {CompetencyId = 71, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 328},
            new CompetencyRatingGroup
                {CompetencyId = 71, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 329},
            new CompetencyRatingGroup
                {CompetencyId = 71, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 330},
            new CompetencyRatingGroup
                {CompetencyId = 71, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 331},
            new CompetencyRatingGroup
                {CompetencyId = 72, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 332},
            new CompetencyRatingGroup
                {CompetencyId = 72, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 333},
            new CompetencyRatingGroup
                {CompetencyId = 72, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 334},
            new CompetencyRatingGroup
                {CompetencyId = 72, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 335},
            new CompetencyRatingGroup
                {CompetencyId = 72, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 336},
            new CompetencyRatingGroup
                {CompetencyId = 73, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 337},
            new CompetencyRatingGroup
                {CompetencyId = 73, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 338},
            new CompetencyRatingGroup
                {CompetencyId = 73, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 339},
            new CompetencyRatingGroup
                {CompetencyId = 73, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 340},
            new CompetencyRatingGroup
                {CompetencyId = 73, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 341},
            new CompetencyRatingGroup
                {CompetencyId = 74, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 342},
            new CompetencyRatingGroup
                {CompetencyId = 74, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 343},
            new CompetencyRatingGroup
                {CompetencyId = 74, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 344},
            new CompetencyRatingGroup
                {CompetencyId = 74, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 345},
            new CompetencyRatingGroup
                {CompetencyId = 74, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 346},
            new CompetencyRatingGroup
                {CompetencyId = 75, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 347},
            new CompetencyRatingGroup
                {CompetencyId = 75, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 348},
            new CompetencyRatingGroup
                {CompetencyId = 75, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 349},
            new CompetencyRatingGroup
                {CompetencyId = 75, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 350},
            new CompetencyRatingGroup
                {CompetencyId = 75, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 351},
            new CompetencyRatingGroup
                {CompetencyId = 76, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 352},
            new CompetencyRatingGroup
                {CompetencyId = 76, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 353},
            new CompetencyRatingGroup
                {CompetencyId = 76, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 354},
            new CompetencyRatingGroup
                {CompetencyId = 76, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 355},
            new CompetencyRatingGroup
                {CompetencyId = 76, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 356},
            new CompetencyRatingGroup
                {CompetencyId = 77, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 357},
            new CompetencyRatingGroup
                {CompetencyId = 77, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 358},
            new CompetencyRatingGroup
                {CompetencyId = 77, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 359},
            new CompetencyRatingGroup
                {CompetencyId = 77, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 360},
            new CompetencyRatingGroup
                {CompetencyId = 77, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 361},
            new CompetencyRatingGroup
                {CompetencyId = 78, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 362},
            new CompetencyRatingGroup
                {CompetencyId = 78, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 363},
            new CompetencyRatingGroup
                {CompetencyId = 78, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 364},
            new CompetencyRatingGroup
                {CompetencyId = 78, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 365},
            new CompetencyRatingGroup
                {CompetencyId = 78, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 366},
            new CompetencyRatingGroup
                {CompetencyId = 79, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 367},
            new CompetencyRatingGroup
                {CompetencyId = 79, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 368},
            new CompetencyRatingGroup
                {CompetencyId = 79, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 369},
            new CompetencyRatingGroup
                {CompetencyId = 79, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 370},
            new CompetencyRatingGroup
                {CompetencyId = 79, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 371},
            new CompetencyRatingGroup
                {CompetencyId = 80, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 372},
            new CompetencyRatingGroup
                {CompetencyId = 80, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 373},
            new CompetencyRatingGroup
                {CompetencyId = 80, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 374},
            new CompetencyRatingGroup
                {CompetencyId = 80, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 375},
            new CompetencyRatingGroup
                {CompetencyId = 80, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 376},
            new CompetencyRatingGroup
                {CompetencyId = 81, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 377},
            new CompetencyRatingGroup
                {CompetencyId = 81, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 378},
            new CompetencyRatingGroup
                {CompetencyId = 81, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 379},
            new CompetencyRatingGroup
                {CompetencyId = 81, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 380},
            new CompetencyRatingGroup
                {CompetencyId = 81, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 381},
            new CompetencyRatingGroup
                {CompetencyId = 82, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 382},
            new CompetencyRatingGroup
                {CompetencyId = 82, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 383},
            new CompetencyRatingGroup
                {CompetencyId = 82, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 384},
            new CompetencyRatingGroup
                {CompetencyId = 82, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 385},
            new CompetencyRatingGroup
                {CompetencyId = 82, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 386},
            new CompetencyRatingGroup
                {CompetencyId = 83, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 387},
            new CompetencyRatingGroup
                {CompetencyId = 83, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 388},
            new CompetencyRatingGroup
                {CompetencyId = 83, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 389},
            new CompetencyRatingGroup
                {CompetencyId = 83, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 390},
            new CompetencyRatingGroup
                {CompetencyId = 83, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 391},
            new CompetencyRatingGroup
                {CompetencyId = 84, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 392},
            new CompetencyRatingGroup
                {CompetencyId = 84, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 393},
            new CompetencyRatingGroup
                {CompetencyId = 84, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 394},
            new CompetencyRatingGroup
                {CompetencyId = 84, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 395},
            new CompetencyRatingGroup
                {CompetencyId = 84, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 396},
            new CompetencyRatingGroup
                {CompetencyId = 85, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 397},
            new CompetencyRatingGroup
                {CompetencyId = 85, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 398},
            new CompetencyRatingGroup
                {CompetencyId = 85, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 399},
            new CompetencyRatingGroup
                {CompetencyId = 85, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 400},
            new CompetencyRatingGroup
                {CompetencyId = 85, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 401},
            new CompetencyRatingGroup
                {CompetencyId = 86, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 402},
            new CompetencyRatingGroup
                {CompetencyId = 86, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 403},
            new CompetencyRatingGroup
                {CompetencyId = 86, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 404},
            new CompetencyRatingGroup
                {CompetencyId = 86, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 405},
            new CompetencyRatingGroup
                {CompetencyId = 86, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 406},
            new CompetencyRatingGroup
                {CompetencyId = 87, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 407},
            new CompetencyRatingGroup
                {CompetencyId = 87, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 408},
            new CompetencyRatingGroup
                {CompetencyId = 87, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 409},
            new CompetencyRatingGroup
                {CompetencyId = 87, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 410},
            new CompetencyRatingGroup
                {CompetencyId = 87, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 411},
            new CompetencyRatingGroup
                {CompetencyId = 88, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 412},
            new CompetencyRatingGroup
                {CompetencyId = 88, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 413},
            new CompetencyRatingGroup
                {CompetencyId = 88, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 414},
            new CompetencyRatingGroup
                {CompetencyId = 88, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 415},
            new CompetencyRatingGroup
                {CompetencyId = 88, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 416},
            new CompetencyRatingGroup
                {CompetencyId = 89, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 417},
            new CompetencyRatingGroup
                {CompetencyId = 89, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 418},
            new CompetencyRatingGroup
                {CompetencyId = 89, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 419},
            new CompetencyRatingGroup
                {CompetencyId = 89, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 420},
            new CompetencyRatingGroup
                {CompetencyId = 89, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 421},
            new CompetencyRatingGroup
                {CompetencyId = 90, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 422},
            new CompetencyRatingGroup
                {CompetencyId = 90, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 423},
            new CompetencyRatingGroup
                {CompetencyId = 90, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 424},
            new CompetencyRatingGroup
                {CompetencyId = 90, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 425},
            new CompetencyRatingGroup
                {CompetencyId = 90, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 426},
            new CompetencyRatingGroup
                {CompetencyId = 93, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 437},
            new CompetencyRatingGroup
                {CompetencyId = 93, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 438},
            new CompetencyRatingGroup
                {CompetencyId = 93, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 439},
            new CompetencyRatingGroup
                {CompetencyId = 93, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 440},
            new CompetencyRatingGroup
                {CompetencyId = 93, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 441},
            new CompetencyRatingGroup
                {CompetencyId = 94, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 442},
            new CompetencyRatingGroup
                {CompetencyId = 94, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 443},
            new CompetencyRatingGroup
                {CompetencyId = 94, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 444},
            new CompetencyRatingGroup
                {CompetencyId = 94, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 445},
            new CompetencyRatingGroup
                {CompetencyId = 94, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 446},
            new CompetencyRatingGroup
                {CompetencyId = 95, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 447},
            new CompetencyRatingGroup
                {CompetencyId = 95, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 448},
            new CompetencyRatingGroup
                {CompetencyId = 95, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 449},
            new CompetencyRatingGroup
                {CompetencyId = 95, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 450},
            new CompetencyRatingGroup
                {CompetencyId = 95, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 451},
            new CompetencyRatingGroup
                {CompetencyId = 96, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 452},
            new CompetencyRatingGroup
                {CompetencyId = 96, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 453},
            new CompetencyRatingGroup
                {CompetencyId = 96, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 454},
            new CompetencyRatingGroup
                {CompetencyId = 96, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 455},
            new CompetencyRatingGroup
                {CompetencyId = 96, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 456},
            new CompetencyRatingGroup
                {CompetencyId = 97, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 457},
            new CompetencyRatingGroup
                {CompetencyId = 97, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 458},
            new CompetencyRatingGroup
                {CompetencyId = 97, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 459},
            new CompetencyRatingGroup
                {CompetencyId = 97, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 460},
            new CompetencyRatingGroup
                {CompetencyId = 97, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 461},
            new CompetencyRatingGroup
                {CompetencyId = 98, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 462},
            new CompetencyRatingGroup
                {CompetencyId = 98, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 463},
            new CompetencyRatingGroup
                {CompetencyId = 98, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 464},
            new CompetencyRatingGroup
                {CompetencyId = 98, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 465},
            new CompetencyRatingGroup
                {CompetencyId = 98, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 466},
            new CompetencyRatingGroup
                {CompetencyId = 99, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 467},
            new CompetencyRatingGroup
                {CompetencyId = 99, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 468},
            new CompetencyRatingGroup
                {CompetencyId = 99, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 469},
            new CompetencyRatingGroup
                {CompetencyId = 99, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 470},
            new CompetencyRatingGroup
                {CompetencyId = 99, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 471},
            new CompetencyRatingGroup
                {CompetencyId = 100, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 472},
            new CompetencyRatingGroup
                {CompetencyId = 100, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 473},
            new CompetencyRatingGroup
                {CompetencyId = 100, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 474},
            new CompetencyRatingGroup
                {CompetencyId = 100, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 475},
            new CompetencyRatingGroup
                {CompetencyId = 100, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 476},
            new CompetencyRatingGroup
                {CompetencyId = 101, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 477},
            new CompetencyRatingGroup
                {CompetencyId = 101, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 478},
            new CompetencyRatingGroup
                {CompetencyId = 101, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 479},
            new CompetencyRatingGroup
                {CompetencyId = 101, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 480},
            new CompetencyRatingGroup
                {CompetencyId = 101, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 481},
            new CompetencyRatingGroup
                {CompetencyId = 102, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 482},
            new CompetencyRatingGroup
                {CompetencyId = 102, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 483},
            new CompetencyRatingGroup
                {CompetencyId = 102, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 484},
            new CompetencyRatingGroup
                {CompetencyId = 102, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 485},
            new CompetencyRatingGroup
                {CompetencyId = 102, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 486},
            new CompetencyRatingGroup
                {CompetencyId = 103, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 487},
            new CompetencyRatingGroup
                {CompetencyId = 103, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 488},
            new CompetencyRatingGroup
                {CompetencyId = 103, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 489},
            new CompetencyRatingGroup
                {CompetencyId = 103, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 490},
            new CompetencyRatingGroup
                {CompetencyId = 103, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 491},
            new CompetencyRatingGroup
                {CompetencyId = 104, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 492},
            new CompetencyRatingGroup
                {CompetencyId = 104, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 493},
            new CompetencyRatingGroup
                {CompetencyId = 104, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 494},
            new CompetencyRatingGroup
                {CompetencyId = 104, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 495},
            new CompetencyRatingGroup
                {CompetencyId = 104, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 496},
            new CompetencyRatingGroup
                {CompetencyId = 105, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 497},
            new CompetencyRatingGroup
                {CompetencyId = 105, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 498},
            new CompetencyRatingGroup
                {CompetencyId = 105, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 499},
            new CompetencyRatingGroup
                {CompetencyId = 105, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 500},
            new CompetencyRatingGroup
                {CompetencyId = 105, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 501},
            new CompetencyRatingGroup
                {CompetencyId = 106, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 502},
            new CompetencyRatingGroup
                {CompetencyId = 106, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 503},
            new CompetencyRatingGroup
                {CompetencyId = 106, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 504},
            new CompetencyRatingGroup
                {CompetencyId = 106, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 505},
            new CompetencyRatingGroup
                {CompetencyId = 106, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 506},
            new CompetencyRatingGroup
                {CompetencyId = 107, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 507},
            new CompetencyRatingGroup
                {CompetencyId = 107, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 508},
            new CompetencyRatingGroup
                {CompetencyId = 107, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 509},
            new CompetencyRatingGroup
                {CompetencyId = 107, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 510},
            new CompetencyRatingGroup
                {CompetencyId = 107, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 511},
            new CompetencyRatingGroup
                {CompetencyId = 108, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 512},
            new CompetencyRatingGroup
                {CompetencyId = 108, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 513},
            new CompetencyRatingGroup
                {CompetencyId = 108, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 514},
            new CompetencyRatingGroup
                {CompetencyId = 108, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 515},
            new CompetencyRatingGroup
                {CompetencyId = 108, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 516},
            new CompetencyRatingGroup
                {CompetencyId = 109, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 517},
            new CompetencyRatingGroup
                {CompetencyId = 109, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 518},
            new CompetencyRatingGroup
                {CompetencyId = 109, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 519},
            new CompetencyRatingGroup
                {CompetencyId = 109, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 520},
            new CompetencyRatingGroup
                {CompetencyId = 109, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 521},
            new CompetencyRatingGroup
                {CompetencyId = 110, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 522},
            new CompetencyRatingGroup
                {CompetencyId = 110, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 523},
            new CompetencyRatingGroup
                {CompetencyId = 110, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 524},
            new CompetencyRatingGroup
                {CompetencyId = 110, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 525},
            new CompetencyRatingGroup
                {CompetencyId = 110, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 526},
            new CompetencyRatingGroup
                {CompetencyId = 111, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 527},
            new CompetencyRatingGroup
                {CompetencyId = 111, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 528},
            new CompetencyRatingGroup
                {CompetencyId = 111, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 529},
            new CompetencyRatingGroup
                {CompetencyId = 111, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 530},
            new CompetencyRatingGroup
                {CompetencyId = 111, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 531},
            new CompetencyRatingGroup
                {CompetencyId = 112, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 532},
            new CompetencyRatingGroup
                {CompetencyId = 112, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 533},
            new CompetencyRatingGroup
                {CompetencyId = 112, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 534},
            new CompetencyRatingGroup
                {CompetencyId = 112, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 535},
            new CompetencyRatingGroup
                {CompetencyId = 112, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 536},
            new CompetencyRatingGroup
                {CompetencyId = 113, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 537},
            new CompetencyRatingGroup
                {CompetencyId = 113, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 538},
            new CompetencyRatingGroup
                {CompetencyId = 113, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 539},
            new CompetencyRatingGroup
                {CompetencyId = 113, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 540},
            new CompetencyRatingGroup
                {CompetencyId = 113, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 541},
            new CompetencyRatingGroup
                {CompetencyId = 114, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 542},
            new CompetencyRatingGroup
                {CompetencyId = 114, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 543},
            new CompetencyRatingGroup
                {CompetencyId = 114, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 544},
            new CompetencyRatingGroup
                {CompetencyId = 114, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 545},
            new CompetencyRatingGroup
                {CompetencyId = 114, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 546},
            new CompetencyRatingGroup
                {CompetencyId = 115, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 547},
            new CompetencyRatingGroup
                {CompetencyId = 115, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 548},
            new CompetencyRatingGroup
                {CompetencyId = 115, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 549},
            new CompetencyRatingGroup
                {CompetencyId = 115, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 550},
            new CompetencyRatingGroup
                {CompetencyId = 115, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 551},
            new CompetencyRatingGroup
                {CompetencyId = 116, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 552},
            new CompetencyRatingGroup
                {CompetencyId = 116, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 553},
            new CompetencyRatingGroup
                {CompetencyId = 116, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 554},
            new CompetencyRatingGroup
                {CompetencyId = 116, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 555},
            new CompetencyRatingGroup
                {CompetencyId = 116, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 556},
            new CompetencyRatingGroup
                {CompetencyId = 117, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 557},
            new CompetencyRatingGroup
                {CompetencyId = 117, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 558},
            new CompetencyRatingGroup
                {CompetencyId = 117, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 559},
            new CompetencyRatingGroup
                {CompetencyId = 117, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 560},
            new CompetencyRatingGroup
                {CompetencyId = 117, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 561},
            new CompetencyRatingGroup
                {CompetencyId = 118, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 562},
            new CompetencyRatingGroup
                {CompetencyId = 118, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 563},
            new CompetencyRatingGroup
                {CompetencyId = 118, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 564},
            new CompetencyRatingGroup
                {CompetencyId = 118, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 565},
            new CompetencyRatingGroup
                {CompetencyId = 118, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 566},
            new CompetencyRatingGroup
                {CompetencyId = 119, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 567},
            new CompetencyRatingGroup
                {CompetencyId = 119, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 568},
            new CompetencyRatingGroup
                {CompetencyId = 119, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 569},
            new CompetencyRatingGroup
                {CompetencyId = 119, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 570},
            new CompetencyRatingGroup
                {CompetencyId = 119, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 571},
            new CompetencyRatingGroup
                {CompetencyId = 120, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 572},
            new CompetencyRatingGroup
                {CompetencyId = 120, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 573},
            new CompetencyRatingGroup
                {CompetencyId = 120, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 574},
            new CompetencyRatingGroup
                {CompetencyId = 120, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 575},
            new CompetencyRatingGroup
                {CompetencyId = 120, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 576},
            new CompetencyRatingGroup
                {CompetencyId = 121, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 577},
            new CompetencyRatingGroup
                {CompetencyId = 121, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 578},
            new CompetencyRatingGroup
                {CompetencyId = 121, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 579},
            new CompetencyRatingGroup
                {CompetencyId = 121, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 580},
            new CompetencyRatingGroup
                {CompetencyId = 121, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 581},
            new CompetencyRatingGroup
                {CompetencyId = 122, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 582},
            new CompetencyRatingGroup
                {CompetencyId = 122, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 583},
            new CompetencyRatingGroup
                {CompetencyId = 122, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 584},
            new CompetencyRatingGroup
                {CompetencyId = 122, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 585},
            new CompetencyRatingGroup
                {CompetencyId = 122, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 586},
            new CompetencyRatingGroup
                {CompetencyId = 123, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 587},
            new CompetencyRatingGroup
                {CompetencyId = 123, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 588},
            new CompetencyRatingGroup
                {CompetencyId = 123, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 589},
            new CompetencyRatingGroup
                {CompetencyId = 123, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 590},
            new CompetencyRatingGroup
                {CompetencyId = 123, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 591},
            new CompetencyRatingGroup
                {CompetencyId = 124, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 592},
            new CompetencyRatingGroup
                {CompetencyId = 124, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 593},
            new CompetencyRatingGroup
                {CompetencyId = 124, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 594},
            new CompetencyRatingGroup
                {CompetencyId = 124, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 595},
            new CompetencyRatingGroup
                {CompetencyId = 124, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 596},
            new CompetencyRatingGroup
                {CompetencyId = 125, CompetencyRatingLevelId = 1, CompetencyLevelRequirementId = 597},
            new CompetencyRatingGroup
                {CompetencyId = 125, CompetencyRatingLevelId = 2, CompetencyLevelRequirementId = 598},
            new CompetencyRatingGroup
                {CompetencyId = 125, CompetencyRatingLevelId = 3, CompetencyLevelRequirementId = 599},
            new CompetencyRatingGroup
                {CompetencyId = 125, CompetencyRatingLevelId = 4, CompetencyLevelRequirementId = 600},
            new CompetencyRatingGroup
                {CompetencyId = 125, CompetencyRatingLevelId = 5, CompetencyLevelRequirementId = 601},
            new CompetencyRatingGroup
            {
                CompetencyId = 126, CompetencyRatingLevelId = 6, CompetencyLevelRequirementId = 602
            },
            new CompetencyRatingGroup
                {CompetencyId = 126, CompetencyRatingLevelId = 7, CompetencyLevelRequirementId = 603},
            new CompetencyRatingGroup
                {CompetencyId = 126, CompetencyRatingLevelId = 8, CompetencyLevelRequirementId = 604},
            new CompetencyRatingGroup
                {CompetencyId = 126, CompetencyRatingLevelId = 9, CompetencyLevelRequirementId = 605},
            new CompetencyRatingGroup
                {CompetencyId = 126, CompetencyRatingLevelId = 10, CompetencyLevelRequirementId = 606},
            new CompetencyRatingGroup
                {CompetencyId = 127, CompetencyRatingLevelId = 6, CompetencyLevelRequirementId = 607},
            new CompetencyRatingGroup
                {CompetencyId = 127, CompetencyRatingLevelId = 7, CompetencyLevelRequirementId = 608},
            new CompetencyRatingGroup
                {CompetencyId = 127, CompetencyRatingLevelId = 8, CompetencyLevelRequirementId = 609},
            new CompetencyRatingGroup
                {CompetencyId = 127, CompetencyRatingLevelId = 9, CompetencyLevelRequirementId = 610},
            new CompetencyRatingGroup
                {CompetencyId = 127, CompetencyRatingLevelId = 10, CompetencyLevelRequirementId = 611},
            new CompetencyRatingGroup
                {CompetencyId = 128, CompetencyRatingLevelId = 6, CompetencyLevelRequirementId = 612},
            new CompetencyRatingGroup
                {CompetencyId = 128, CompetencyRatingLevelId = 7, CompetencyLevelRequirementId = 613},
            new CompetencyRatingGroup
                {CompetencyId = 128, CompetencyRatingLevelId = 8, CompetencyLevelRequirementId = 614},
            new CompetencyRatingGroup
                {CompetencyId = 128, CompetencyRatingLevelId = 9, CompetencyLevelRequirementId = 615},
            new CompetencyRatingGroup
                {CompetencyId = 128, CompetencyRatingLevelId = 10, CompetencyLevelRequirementId = 616},
            new CompetencyRatingGroup
                {CompetencyId = 129, CompetencyRatingLevelId = 6, CompetencyLevelRequirementId = 617},
            new CompetencyRatingGroup
                {CompetencyId = 129, CompetencyRatingLevelId = 7, CompetencyLevelRequirementId = 618},
            new CompetencyRatingGroup
                {CompetencyId = 129, CompetencyRatingLevelId = 8, CompetencyLevelRequirementId = 619},
            new CompetencyRatingGroup
                {CompetencyId = 129, CompetencyRatingLevelId = 9, CompetencyLevelRequirementId = 620},
            new CompetencyRatingGroup
                {CompetencyId = 129, CompetencyRatingLevelId = 10, CompetencyLevelRequirementId = 621},
            new CompetencyRatingGroup
                {CompetencyId = 130, CompetencyRatingLevelId = 6, CompetencyLevelRequirementId = 622},
            new CompetencyRatingGroup
                {CompetencyId = 130, CompetencyRatingLevelId = 7, CompetencyLevelRequirementId = 623},
            new CompetencyRatingGroup
                {CompetencyId = 130, CompetencyRatingLevelId = 8, CompetencyLevelRequirementId = 624},
            new CompetencyRatingGroup
                {CompetencyId = 130, CompetencyRatingLevelId = 9, CompetencyLevelRequirementId = 625},
            new CompetencyRatingGroup
                {CompetencyId = 130, CompetencyRatingLevelId = 10, CompetencyLevelRequirementId = 626},
            new CompetencyRatingGroup
                {CompetencyId = 131, CompetencyRatingLevelId = 6, CompetencyLevelRequirementId = 627},
            new CompetencyRatingGroup
                {CompetencyId = 131, CompetencyRatingLevelId = 7, CompetencyLevelRequirementId = 628},
            new CompetencyRatingGroup
                {CompetencyId = 131, CompetencyRatingLevelId = 8, CompetencyLevelRequirementId = 629},
            new CompetencyRatingGroup
                {CompetencyId = 131, CompetencyRatingLevelId = 9, CompetencyLevelRequirementId = 630},
            new CompetencyRatingGroup
                {CompetencyId = 131, CompetencyRatingLevelId = 10, CompetencyLevelRequirementId = 631}
        };
    }
}
