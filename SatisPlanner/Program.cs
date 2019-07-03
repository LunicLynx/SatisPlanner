using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace SatisPlanner
{
    class Program
    {
        static void Main(string[] args)
        {


            var toProduce = new MaterialRate()
            {
                Material = Data.Computer,
                RatePerMinute = 2
            };

            var rates = new[] { toProduce };
            NewMethod(rates);

            Console.WriteLine("Hello World!");
        }

        private static void NewMethod(IEnumerable<MaterialRate> rates)
        {
            foreach (var rate in rates)
            {
                var ratesa = GetRates(rate).ToList();
                NewMethod(ratesa);
            }
        }

        private static IEnumerable<MaterialRate> GetRates(MaterialRate toProduce)
        {
            var requiredSpeed = toProduce.RatePerMinute / 60;
            var ratePerSecond = requiredSpeed;
            // find recipe 
            var recipe = Data.Recipes.FirstOrDefault(r => r.Out.Material == toProduce.Material);

            // how many buildings
            var buildingAmountFraction = requiredSpeed / recipe.ProductionBuilding.ProductionSpeed * recipe.CraftingTime;
            var buildingAmount = Math.Ceiling(buildingAmountFraction);
            var usage = 100 * buildingAmountFraction / buildingAmount;

            Console.WriteLine($"{toProduce.Material.Name} {toProduce.RatePerMinute}/min {buildingAmount} {recipe.ProductionBuilding.Name} ({usage}%)");

            // calculate inputs
            foreach (var ma in recipe.In)
            {
                var in1Rate = ratePerSecond * ma.Amount;
                yield return new MaterialRate { RatePerMinute = in1Rate * 60, Material = ma.Material };
            }
        }
    }



    class Building
    {
        public string Name { get; set; }
        public int ProductionSpeed { get; set; }
    }

    class Recipe
    {
        public Building ProductionBuilding { get; set; }

        public List<MaterialAmount> In { get; } = new List<MaterialAmount>();
        public MaterialAmount Out { get; set; }

        public bool Alternative { get; set; }

        public double CraftingTime { get; set; }
        public int Clicks { get; set; }
    }

    class Material
    {
        public string Name { get; set; }
    }

    class MaterialAmount
    {
        public Material Material { get; set; }
        public int Amount { get; set; }
    }

    class MaterialRate
    {
        public Material Material { get; set; }
        public double RatePerMinute { get; set; }
    }

    static class Data
    {
        public static readonly Material IronOre = new Material { Name = "Iron Ore" };
        public static readonly Material IronIngot = new Material { Name = "Iron Ingot" };
        public static readonly Material Computer = new Material { Name = "Computer" };
        public static readonly Material CircuitBoard = new Material { Name = "Circuit Board" };
        public static readonly Material Cable = new Material() { Name = "Cable" };
        public static readonly Material Plastic = new Material() { Name = "Plastic" };
        public static readonly Material Screw = new Material() { Name = "Screw" };
        public static readonly Material Wire = new Material() { Name = "Wire" };
        public static readonly Material CopperOre = new Material() { Name = "Copper Ore" };
        public static readonly Material CopperIngot = new Material() { Name = "Copper Ingot" };
        public static readonly Material CrudeOil = new Material() { Name = "Crude Oil" };
        public static readonly Material IronRod = new Material() { Name = "Iron Rod" };

        public static readonly Building OilPump = new Building { Name = "Oil Pump", ProductionSpeed = 1 };
        public static readonly Building OilPumpMk1 = new Building { Name = "Oil Pump MK1", ProductionSpeed = 1 };

        public static readonly Building Miner = new Building { Name = "Miner", ProductionSpeed = 1 };
        public static readonly Building MinerMk1 = new Building { Name = "Miner MK1", ProductionSpeed = 1 };
        public static readonly Building MinerMk2 = new Building { Name = "Miner MK2", ProductionSpeed = 2 };
        public static readonly Building MinerMk3 = new Building { Name = "Miner MK3", ProductionSpeed = 4 };

        public static readonly Building Smelter = new Building { Name = "Smelter", ProductionSpeed = 1 };
        public static readonly Building OilRefinery = new Building { Name = "Oil Refinery", ProductionSpeed = 1 };

        public static readonly Building Constructor = new Building { Name = "Constructor", ProductionSpeed = 1 };
        public static readonly Building Assembler = new Building { Name = "Assembler", ProductionSpeed = 1 };
        public static readonly Building Manufacturer = new Building { Name = "Manufacturer", ProductionSpeed = 1 };

        public static readonly List<Recipe> Recipes = new List<Recipe>
            {
                new Recipe()
                {
                    ProductionBuilding = MinerMk1,
                    Out = new MaterialAmount() {Material = IronOre, Amount = 1},
                    CraftingTime = 1
                },
                new Recipe()
                {
                    ProductionBuilding = Smelter,
                    In = {new MaterialAmount {Material = IronOre, Amount = 1}},
                    Out = new MaterialAmount {Material = IronIngot, Amount = 1},
                    CraftingTime = 2
                },
                new Recipe()
                {
                    ProductionBuilding = Manufacturer,
                    In =
                    {
                        new MaterialAmount()
                        {
                            Material = CircuitBoard,
                            Amount = 5
                        },
                        new MaterialAmount()
                        {
                            Material = Cable,
                            Amount = 12

                        },
                        new MaterialAmount()
                        {
                            Material = Plastic,
                            Amount = 18,
                        },
                        new MaterialAmount()
                        {
                            Material = Screw,
                            Amount = 60
                        }
                    },
                    Out = new MaterialAmount() {Material = Computer, Amount = 1},
                    CraftingTime = 32,
                },
                new Recipe()
                {
                    ProductionBuilding = Assembler,
                    In = { new MaterialAmount()
                    {
                        Material = Wire,
                        Amount = 12
                    }, new MaterialAmount()
                    {
                        Material = Plastic,
                        Amount = 6
                    }},
                    Out = new MaterialAmount()
                    {
                        Material = CircuitBoard,
                        Amount = 1
                    },
                    CraftingTime = 12
                },
                new Recipe()
                {
                    ProductionBuilding = Constructor,
                    In = { new MaterialAmount()
                    {
                        Material = CopperIngot,
                        Amount = 1
                    }},
                    Out = new MaterialAmount()
                    {
                        Material = Wire,
                        Amount = 3
                    },
                    CraftingTime = 4
                },
                new Recipe()
                {
                    ProductionBuilding = Smelter,
                    In =
                    {
                        new MaterialAmount()
                        {
                            Material = CopperOre,
                            Amount = 1
                        }
                    },
                    Out = new MaterialAmount()
                    {
                        Material = CopperIngot,
                        Amount = 1
                    },
                    CraftingTime = 2,
                    Clicks = 2
                },
                new Recipe()
                {
                    ProductionBuilding = Miner,
                    Out = new MaterialAmount()
                    {
                        Material = CopperOre,
                        Amount = 1
                    }
                },
                new Recipe()
                {
                    ProductionBuilding = OilRefinery,
                    In = { new MaterialAmount()
                    {
                        Material = CrudeOil,
                        Amount = 4
                    }},
                    Out = new MaterialAmount()
                    {
                        Material = Plastic,
                        Amount = 3
                    },
                    CraftingTime = 8,
                    Clicks = 2
                },
                new Recipe()
                {
                    ProductionBuilding = OilPump,
                    Out = new MaterialAmount()
                    {
                        Material = CrudeOil,
                        Amount = 1
                    },
                    CraftingTime = 0.5
                },
                new Recipe()
                {
                    ProductionBuilding = Constructor,
                    In =
                    {
                        new MaterialAmount()
                        {
                            Material = Wire,
                            Amount = 2
                        }
                    },
                    Out = new MaterialAmount()
                    {
                        Material = Cable,
                        Amount = 1
                    },
                    CraftingTime = 4,
                    Clicks = 1
                },
                new Recipe()
                {
                    ProductionBuilding = Constructor,
                    In = { new MaterialAmount()
                    {
                        Material = IronRod,
                        Amount = 1
                    }},
                    Out =  new MaterialAmount()
                    {
                        Material = Screw,
                        Amount = 6
                    },
                    CraftingTime = 4,
                    Clicks = 1
                },
                new Recipe()
                {
                    ProductionBuilding = Constructor,
                    In = { new MaterialAmount()
                    {
                        Material = IronIngot,
                        Amount = 1
                    }},
                    Out = new MaterialAmount()
                    {
                        Material = IronRod,
                        Amount = 1
                    },
                    CraftingTime = 4,
                    Clicks = 1
                }
            };
    }
}
