using System.Collections.Generic;

namespace SatisPlanner
{
    class SubAssembly
    {
        public List<MaterialAmount> In { get; } = new List<MaterialAmount>();
        public MaterialAmount Out { get; set; }
        public double CraftingTime { get; set; }
    }
}