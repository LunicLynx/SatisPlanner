using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace SatisPlanner
{
    class Program
    {
        private static Building _miner;
        private static double _overclocking;
        private static BuildingGroup _overclockBuildings;
        private static NodePurity _nodePurity;

        static void Main(string[] args)
        {
            _miner = Data.MinerMk3;
            _overclocking = 2.5;
            _overclockBuildings = BuildingGroup.Miners;
            _nodePurity = NodePurity.Impure;

            var toProduce = new MaterialRate
            {
                Material = Data.HeavyModularFrame,
                RatePerMinute = 4
            };

            GetRates(toProduce);
        }

        private static void GetRates(MaterialRate toProduce, string indent = "")
        {
            var requiredRatePerSecond = toProduce.RatePerMinute / 60;
            var ratePerSecond = requiredRatePerSecond;


            List<MaterialAmount> list;
            int outAmount;
            double productionSpeed;
            double craftingTime;
            string name;

            // find sub assembly
            var sa = Data.SubAssemblies.FirstOrDefault(s => s.Out.Material == toProduce.Material);
            if (sa != null)
            {
                craftingTime = sa.CraftingTime;
                outAmount = sa.Out.Amount;
                productionSpeed = 1;
                list = sa.In;
                name = "SA " + sa.Out.Material.Name;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                var recipe = Data.Recipes.First(r => r.Out.Material == toProduce.Material);

                craftingTime = recipe.CraftingTime;

                var productionBuilding = recipe.ProductionBuilding;
                if (productionBuilding == Data.Miner)
                    productionBuilding = _miner;

                productionSpeed = productionBuilding.ProductionSpeed;
                outAmount = recipe.Out.Amount;
                list = recipe.In;
                name = productionBuilding.Name;

                if (recipe.ProductionBuilding == Data.Miner)
                {
                    productionSpeed *= _overclocking;
                    switch (_nodePurity)
                    {
                        case NodePurity.Impure:
                            productionSpeed *= 0.5;
                            break;
                        case NodePurity.Pure:
                            productionSpeed *= 2;
                            break;
                        default:
                            break;
                    }
                }
            }

            // maximum production
            var productionRatePerSecond = outAmount * productionSpeed / craftingTime;

            // how many buildings
            var buildingAmountFraction = requiredRatePerSecond / productionRatePerSecond;
            var buildingAmount = Math.Ceiling(buildingAmountFraction);
            var usage = buildingAmountFraction / buildingAmount;

            Console.WriteLine($"{indent}{toProduce.Material.Name} {toProduce.RatePerMinute:F}/min {buildingAmount} {name} ({usage:P0})");
            Console.ResetColor();
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
