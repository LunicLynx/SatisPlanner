using System.Collections.Generic;

namespace SatisPlanner
{
    class Recipe
    {
        public Building ProductionBuilding { get; set; }

        public List<MaterialAmount> In { get; } = new List<MaterialAmount>();
        public MaterialAmount Out { get; set; }

        public bool Alternative { get; set; }

        public double CraftingTime { get; set; }
        public int Clicks { get; set; }
    }
}