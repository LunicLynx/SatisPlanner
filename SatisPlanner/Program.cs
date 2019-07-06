using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace SatisPlanner
{
    enum BuildingGroup
    {
        All,
        Miners
    }

    class Program
    {
        private static Building _miner;
        private static double _overclocking;
        private static BuildingGroup _overclockBuildings;

        static void Main(string[] args)
        {
            _miner = Data.MinerMk1;
            _overclocking = 1;
            _overclockBuildings = BuildingGroup.Miners;

            var toProduce = new MaterialRate
            {
                Material = Data.ModularFrame,
                RatePerMinute = 20
            };

            GetRates(toProduce);
        }

        private static void GetRates(MaterialRate toProduce, string indent = "")
        {
            var requiredRatePerSecond = toProduce.RatePerMinute / 60;
            var ratePerSecond = requiredRatePerSecond;

            // find sub assembly
            var sa = Data.SubAssemblies.FirstOrDefault(s => s.Out.Material == toProduce.Material);
            List<MaterialAmount> list;
            int outAmount;
            double productionSpeed;
            double craftingTime;
            string name;

            if (sa != null)
            {
                craftingTime = sa.CraftingTime;
                outAmount = sa.Out.Amount;
                productionSpeed = 1;
                list = sa.In;
                name = "SA " + sa.Out.Material.Name;
            }
            else
            {
                var recipe = Data.Recipes.FirstOrDefault(r => r.Out.Material == toProduce.Material);

                craftingTime = recipe.CraftingTime;

                var productionBuilding = recipe.ProductionBuilding;
                if (productionBuilding == Data.Miner)
                    productionBuilding = _miner;

                productionSpeed = productionBuilding.ProductionSpeed;
                outAmount = recipe.Out.Amount;
                list = recipe.In;
                name = productionBuilding.Name;

                if (recipe.ProductionBuilding == Data.Miner)
                    productionSpeed *= _overclocking;
            }

            var productionRatePerSecond = outAmount * productionSpeed / craftingTime;

            // how many buildings
            var buildingAmountFraction = requiredRatePerSecond / productionRatePerSecond;
            var buildingAmount = Math.Ceiling(buildingAmountFraction);
            var usage = 100 * buildingAmountFraction / buildingAmount;

            Console.WriteLine($"{indent}{toProduce.Material.Name} {toProduce.RatePerMinute}/min {buildingAmount} {name} ({usage}%)");

            ratePerSecond /= outAmount;

            // calculate inputs
            foreach (var ma in list)
            {
                var in1Rate = ratePerSecond * ma.Amount;
                var mp = new MaterialRate { RatePerMinute = in1Rate * 60, Material = ma.Material };
                GetRates(mp, indent + "    ");
            }
        }
    }
}
