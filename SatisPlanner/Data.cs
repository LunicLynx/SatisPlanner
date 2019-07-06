using System.Collections.Generic;

namespace SatisPlanner
{
    static class Data
    {
        public static readonly Material IronOre = new Material { Name = "Iron Ore", StackSize = 100 };
        public static readonly Material IronIngot = new Material { Name = "Iron Ingot", StackSize = 100 };
        public static readonly Material Computer = new Material { Name = "Computer", StackSize = 50 };
        public static readonly Material CircuitBoard = new Material { Name = "Circuit Board", StackSize = 100 };
        public static readonly Material Cable = new Material { Name = "Cable", StackSize = 100 };
        public static readonly Material Plastic = new Material { Name = "Plastic", StackSize = 100 };
        public static readonly Material Screw = new Material { Name = "Screw", StackSize = 500 };
        public static readonly Material Wire = new Material { Name = "Wire", StackSize = 500 };
        public static readonly Material CopperOre = new Material { Name = "Copper Ore", StackSize = 100 };
        public static readonly Material CopperIngot = new Material { Name = "Copper Ingot", StackSize = 100 };
        public static readonly Material CrudeOil = new Material { Name = "Crude Oil", StackSize = 100 };
        public static readonly Material IronRod = new Material { Name = "Iron Rod", StackSize = 100 };
        public static readonly Material TurboMotor = new Material { Name = "Turbo Motor", StackSize = 50 };
        public static readonly Material HeatSink = new Material { Name = "Heat Sink", StackSize = 100 };
        public static readonly Material RadioControlUnit = new Material { Name = "Radio Control Unit", StackSize = 50 };
        public static readonly Material Motor = new Material { Name = "Motor" };
        public static readonly Material Rubber = new Material { Name = "Rubber" };
        public static readonly Material Stator = new Material { Name = "Stator" };
        public static readonly Material AiLimiter = new Material { Name = "A.I. Limiter" };
        public static readonly Material Bauxite = new Material { Name = "Bauxite" };
        public static readonly Material RawQuartz = new Material { Name = "Raw Quartz" };
        public static readonly Material Coal = new Material { Name = "Coal" };
        public static readonly Material SteelIngot = new Material { Name = "Steel Ingot" };
        public static readonly Material SteelPipe = new Material { Name = "Steel Pipe" };
        public static readonly Material HeavyModularFrame = new Material { Name = "Heavy Modular Frame" };
        public static readonly Material Uranium = new Material { Name = "Uranium" };
        public static readonly Material CateriumOre = new Material { Name = "Caterium Ore" };
        public static readonly Material SamOre = new Material { Name = "S.A.M. Ore" };
        public static readonly Material Sulfur = new Material { Name = "Sulfur" };
        public static readonly Material Limestone = new Material { Name = "Limestone" };
        public static readonly Material AlienCarapace = new Material { Name = "Alien Carapace" };
        public static readonly Material AlienOrgans = new Material { Name = "Alien Organs" };
        public static readonly Material Leaves = new Material { Name = "Leaves" };
        public static readonly Material Wood = new Material { Name = "Wood" };
        public static readonly Material Mycelia = new Material { Name = "Mycelia" };
        public static readonly Material FlowerPetals = new Material { Name = "Flower Petals" };
        public static readonly Material GreenPowerSlug = new Material { Name = "Green Power Slug" };
        public static readonly Material YellowPowerSlug = new Material { Name = "Yellow Power Slug" };
        public static readonly Material PurplePowerSlug = new Material { Name = "Purple Power Slug" };
        public static readonly Material BerylNut = new Material { Name = "Beryl Nut" };
        public static readonly Material Paleberry = new Material { Name = "Paleberry" };
        public static readonly Material BaconAgaric = new Material { Name = "Bacon Agaric" };
        public static readonly Material Somersloop = new Material { Name = "Somersloop" };
        public static readonly Material MercerSphere = new Material { Name = "Mercer Sphere" };
        public static readonly Material HardDrive = new Material { Name = "Hard Drive" };
        public static readonly Material IronPlate = new Material { Name = "Iron Plate" };
        public static readonly Material Biomass = new Material { Name = "Biomass" };
        public static readonly Material Concrete = new Material { Name = "Concrete" };
        public static readonly Material ReinforcedIronPlate = new Material { Name = "Reinforced Iron Plate" };
        public static readonly Material Biofuel = new Material { Name = "Biofuel" };
        public static readonly Material Rotor = new Material { Name = "Rotor" };
        public static readonly Material ModularFrame = new Material { Name = "Modular Frame" };
        public static readonly Material PowerShard = new Material { Name = "Power Shard" };
        public static readonly Material Fabric = new Material { Name = "Fabric" };
        public static readonly Material SteelBeam = new Material { Name = "Steel Beam" };
        public static readonly Material EncasedIndustrialBeam = new Material { Name = "Encased Industrial Beam" };
        public static readonly Material CateriumIngot = new Material { Name = "Caterium Ingot" };
        public static readonly Material Quickwire = new Material { Name = "Quickwire" };
        public static readonly Material QuartzCrystal = new Material { Name = "Quartz Crystal" };
        public static readonly Material CrystalOscillator = new Material { Name = "Crystal Oscillator" };
        public static readonly Material BlackPowder = new Material { Name = "Black Powder" };
        public static readonly Material Fuel = new Material { Name = "Fuel" };
        public static readonly Material Supercomputer = new Material { Name = "Supercomputer" };
        public static readonly Material HighSpeedConnector = new Material { Name = "High-Speed Connector" };
        public static readonly Material Silica = new Material { Name = "Silica" };
        public static readonly Material AluminumIngot = new Material { Name = "Aluminum Ingot", StackSize = 100 };
        public static readonly Material AlcladAluminumSheet = new Material { Name = "Alclad Aluminum Sheet", StackSize = 100 };

        public static readonly Building OilPump = new Building { Name = "Oil Pump", ProductionSpeed = 1 };
        public static readonly Building OilPumpMk1 = new Building { Name = "Oil Pump MK1", ProductionSpeed = 1 };

        public static readonly Building Miner = new Building { Name = "Miner", ProductionSpeed = 1 };
        public static readonly Building MinerMk1 = new Building { Name = "Miner MK1", ProductionSpeed = 1 };
        public static readonly Building MinerMk2 = new Building { Name = "Miner MK2", ProductionSpeed = 2 };
        public static readonly Building MinerMk3 = new Building { Name = "Miner MK3", ProductionSpeed = 4 };

        public static readonly Building Smelter = new Building { Name = "Smelter", ProductionSpeed = 1 };
        public static readonly Building Foundry = new Building { Name = "Foundry", ProductionSpeed = 1 };
        public static readonly Building OilRefinery = new Building { Name = "Oil Refinery", ProductionSpeed = 1 };

        public static readonly Building Constructor = new Building { Name = "Constructor", ProductionSpeed = 1 };
        public static readonly Building Assembler = new Building { Name = "Assembler", ProductionSpeed = 1 };
        public static readonly Building Manufacturer = new Building { Name = "Manufacturer", ProductionSpeed = 1 };

        public static readonly List<SubAssembly> SubAssemblies = new List<SubAssembly>
        {

            new SubAssembly()
            {
                In=
                {
                    new MaterialAmount()
                    {
                        Material = IronIngot,
                        Amount = 12,
                    }
                },
                Out = new MaterialAmount()
                {
                    Material = ReinforcedIronPlate,
                    Amount = 1
                },
                CraftingTime = 4
            },
            new SubAssembly()
            {
                In=
                {
                    new MaterialAmount()
                    {
                        Material = IronIngot,
                        Amount = 42,
                    }
                },
                Out = new MaterialAmount()
                {
                    Material = ModularFrame,
                    Amount = 1
                },
                CraftingTime = 3
            },
            new SubAssembly()
            {
                In = { new MaterialAmount()
                {
                    Material = SteelIngot,
                    Amount = 12,
                }, new MaterialAmount()
                {
                    Material = Concrete,
                    Amount = 5,
                }},
                Out = new MaterialAmount()
                {
                    Material = EncasedIndustrialBeam,
                    Amount = 1
                },
                CraftingTime = 3
            }
        };

        public static readonly List<Recipe> Recipes = new List<Recipe>
        {
            new Recipe
            {
                ProductionBuilding = Miner,
                Out = new MaterialAmount {Material = IronOre, Amount = 1},
                CraftingTime = 1
            },
            new Recipe
            {
                ProductionBuilding = Smelter,
                In = {new MaterialAmount {Material = IronOre, Amount = 1}},
                Out = new MaterialAmount {Material = IronIngot, Amount = 1},
                CraftingTime = 2
            },
            new Recipe
            {
                ProductionBuilding = Manufacturer,
                In =
                {
                    new MaterialAmount
                    {
                        Material = CircuitBoard,
                        Amount = 5
                    },
                    new MaterialAmount
                    {
                        Material = Cable,
                        Amount = 12

                    },
                    new MaterialAmount
                    {
                        Material = Plastic,
                        Amount = 18,
                    },
                    new MaterialAmount
                    {
                        Material = Screw,
                        Amount = 60
                    }
                },
                Out = new MaterialAmount {Material = Computer, Amount = 1},
                CraftingTime = 32,
            },
            new Recipe
            {
                ProductionBuilding = Assembler,
                In =
                {
                    new MaterialAmount
                    {
                        Material = Wire,
                        Amount = 12
                    },
                    new MaterialAmount
                    {
                        Material = Plastic,
                        Amount = 6
                    }
                },
                Out = new MaterialAmount
                {
                    Material = CircuitBoard,
                    Amount = 1
                },
                CraftingTime = 12
            },
            new Recipe
            {
                ProductionBuilding = Constructor,
                In =
                {
                    new MaterialAmount
                    {
                        Material = CopperIngot,
                        Amount = 1
                    }
                },
                Out = new MaterialAmount
                {
                    Material = Wire,
                    Amount = 3
                },
                CraftingTime = 4
            },
            new Recipe
            {
                ProductionBuilding = Smelter,
                In =
                {
                    new MaterialAmount
                    {
                        Material = CopperOre,
                        Amount = 1
                    }
                },
                Out = new MaterialAmount
                {
                    Material = CopperIngot,
                    Amount = 1
                },
                CraftingTime = 2,
                Clicks = 2
            },
            new Recipe
            {
                ProductionBuilding = Miner,
                Out = new MaterialAmount
                {
                    Material = CopperOre,
                    Amount = 1
                },
                CraftingTime = 1
            },
            new Recipe
            {
                ProductionBuilding = OilRefinery,
                In =
                {
                    new MaterialAmount
                    {
                        Material = CrudeOil,
                        Amount = 4
                    }
                },
                Out = new MaterialAmount
                {
                    Material = Plastic,
                    Amount = 3
                },
                CraftingTime = 8,
                Clicks = 2
            },
            new Recipe
            {
                ProductionBuilding = OilPump,
                Out = new MaterialAmount
                {
                    Material = CrudeOil,
                    Amount = 1
                },
                CraftingTime = 0.5
            },
            new Recipe
            {
                ProductionBuilding = Constructor,
                In =
                {
                    new MaterialAmount
                    {
                        Material = Wire,
                        Amount = 2
                    }
                },
                Out = new MaterialAmount
                {
                    Material = Cable,
                    Amount = 1
                },
                CraftingTime = 4,
                Clicks = 1
            },
            new Recipe
            {
                ProductionBuilding = Constructor,
                In =
                {
                    new MaterialAmount
                    {
                        Material = IronRod,
                        Amount = 1
                    }
                },
                Out = new MaterialAmount
                {
                    Material = Screw,
                    Amount = 6
                },
                CraftingTime = 4,
                Clicks = 1
            },
            new Recipe
            {
                ProductionBuilding = Constructor,
                In =
                {
                    new MaterialAmount
                    {
                        Material = IronIngot,
                        Amount = 1
                    }
                },
                Out = new MaterialAmount
                {
                    Material = IronRod,
                    Amount = 1
                },
                CraftingTime = 4,
                Clicks = 1
            },
            new Recipe
            {
                ProductionBuilding = Manufacturer,
                In =
                {
                    new MaterialAmount
                    {
                        Material = HeatSink,
                        Amount = 4
                    },
                    new MaterialAmount
                    {
                        Material = RadioControlUnit,
                        Amount = 2
                    },
                    new MaterialAmount
                    {
                        Material = Motor,
                        Amount = 4
                    },
                    new MaterialAmount
                    {
                        Material = Rubber,
                        Amount = 40
                    }
                },
                Out = new MaterialAmount
                {
                    Material = TurboMotor,
                    Amount = 1
                },
                CraftingTime = 32,
            },
            new Recipe
            {
                ProductionBuilding = Assembler,
                In =
                {
                    new MaterialAmount
                    {
                        Material = AlcladAluminumSheet,
                        Amount = 4
                    },
                    new MaterialAmount
                    {
                        Material = Rubber,
                        Amount = 10
                    }
                },
                Out = new MaterialAmount
                {
                    Material = HeatSink,
                    Amount = 1,
                },
                CraftingTime = 12,
            },
            new Recipe
            {
                ProductionBuilding = Assembler,
                In =
                {
                    new MaterialAmount
                    {
                        Material = AluminumIngot,
                        Amount = 3,
                    },
                    new MaterialAmount
                    {
                        Material = CopperIngot,
                        Amount = 2
                    }
                },
                Out = new MaterialAmount
                {
                    Material = AlcladAluminumSheet,
                    Amount = 3
                },
                CraftingTime = 12,
            },
            new Recipe
            {
                ProductionBuilding = Foundry,
                In =
                {
                    new MaterialAmount
                    {
                        Material = Bauxite,
                        Amount = 7
                    },
                    new MaterialAmount
                    {
                        Material = Silica,
                        Amount = 6
                    }
                },
                Out = new MaterialAmount
                {
                    Material = AluminumIngot,
                    Amount = 2
                },
                CraftingTime = 4
            },
            new Recipe
            {
                ProductionBuilding = Miner,
                Out = new MaterialAmount
                {
                    Material = Bauxite,
                    Amount = 1
                },
                CraftingTime = 1
            },
            new Recipe
            {
                ProductionBuilding = Constructor,
                In =
                {
                    new MaterialAmount
                    {
                        Material = RawQuartz,
                        Amount = 2
                    }
                },
                Out = new MaterialAmount
                {
                    Material = Silica,
                    Amount = 3
                },
                CraftingTime = 4,
                Clicks = 1
            },
            new Recipe
            {
                ProductionBuilding = Miner,
                Out = new MaterialAmount
                {
                    Material = RawQuartz,
                    Amount = 1
                },
                CraftingTime = 1,
            },
            new Recipe
            {
                ProductionBuilding = OilRefinery,
                In =
                {
                    new MaterialAmount
                    {
                        Material = CrudeOil,
                        Amount = 4
                    }
                },
                Out = new MaterialAmount
                {
                    Material = Rubber,
                    Amount = 4
                },
                CraftingTime = 8,
                Clicks = 2
            },
            new Recipe
            {
                ProductionBuilding = Manufacturer,
                In =
                {
                    new MaterialAmount
                    {
                        Material = HeatSink,
                        Amount = 4,
                    },
                    new MaterialAmount
                    {
                        Material = Rubber,
                        Amount = 24
                    },
                    new MaterialAmount
                    {
                        Material = CrystalOscillator,
                        Amount = 1
                    },
                    new MaterialAmount
                    {
                        Material = Computer,
                        Amount = 1
                    }
                },
                Out = new MaterialAmount
                {
                    Material = RadioControlUnit,
                    Amount = 1
                },
                CraftingTime = 24,
            },
            new Recipe
            {
                ProductionBuilding = Manufacturer,
                In =
                {
                    new MaterialAmount
                    {
                        Material = QuartzCrystal,
                        Amount = 10
                    },
                    new MaterialAmount
                    {
                        Material = Cable,
                        Amount = 14,
                    },
                    new MaterialAmount
                    {
                        Material = ReinforcedIronPlate,
                        Amount = 4
                    }
                },
                Out = new MaterialAmount
                {
                    Material = CrystalOscillator,
                    Amount = 1
                },
                CraftingTime = 32,
                Clicks = 8
            },
            new Recipe
            {
                ProductionBuilding = Constructor,
                In =
                {
                    new MaterialAmount
                    {
                        Material = RawQuartz,
                        Amount = 2,
                    }
                },
                Out = new MaterialAmount
                {
                    Material = QuartzCrystal,
                    Amount = 1
                },
                CraftingTime = 4,
                Clicks = 1
            },
            new Recipe
            {
                ProductionBuilding = Assembler,
                In =
                {
                    new MaterialAmount
                    {
                        Material = IronPlate,
                        Amount = 4,
                    },
                    new MaterialAmount
                    {
                        Material = Screw,
                        Amount = 24
                    }
                },
                Out = new MaterialAmount
                {
                    Material = ReinforcedIronPlate,
                    Amount = 1
                },
                CraftingTime = 12,
                Clicks = 3
            },
            new Recipe
            {
                ProductionBuilding = Constructor,
                In =
                {
                    new MaterialAmount
                    {
                        Material = IronIngot,
                        Amount = 2
                    },
                },
                Out = new MaterialAmount
                {
                    Material = IronPlate,
                    Amount = 1,
                },
                CraftingTime = 4,
                Clicks = 1
            },
            new Recipe
            {
                ProductionBuilding = Assembler,
                In =
                {
                    new MaterialAmount
                    {
                        Material = Rotor,
                        Amount = 2
                    },
                    new MaterialAmount
                    {
                        Material = Stator,
                        Amount = 2,
                    }
                },
                Out = new MaterialAmount
                {
                    Material = Motor,
                    Amount = 1
                },
                CraftingTime = 12,
                Clicks = 3
            },
            new Recipe
            {
                ProductionBuilding = Assembler,
                In =
                {
                    new MaterialAmount
                    {
                        Material = IronRod,
                        Amount = 3
                    },
                    new MaterialAmount
                    {
                        Material = Screw,
                        Amount = 22
                    }
                },
                Out = new MaterialAmount
                {
                    Material = Rotor,
                    Amount = 1
                },
                CraftingTime = 10,
                Clicks = 3
            },
            new Recipe
            {
                ProductionBuilding = Assembler,
                In =
                {
                    new MaterialAmount
                    {
                        Material = SteelPipe,
                        Amount = 3,
                    },
                    new MaterialAmount
                    {
                        Material = Wire,
                        Amount = 10
                    }
                },
                Out = new MaterialAmount
                {
                    Material = Stator,
                    Amount = 1
                },
                CraftingTime = 10,
                Clicks = 3
            },
            new Recipe
            {
                ProductionBuilding = Constructor,
                In =
                {
                    new MaterialAmount
                    {
                        Material = SteelIngot,
                        Amount = 1
                    }
                },
                Out = new MaterialAmount
                {
                    Material = SteelPipe,
                    Amount = 1
                },
                CraftingTime = 4,
                Clicks = 1
            },
            new Recipe
            {
                ProductionBuilding = Foundry,
                In =
                {
                    new MaterialAmount
                    {
                        Material = IronOre,
                        Amount = 3
                    },
                    new MaterialAmount
                    {
                        Material = Coal,
                        Amount = 3
                    }
                },
                Out = new MaterialAmount
                {
                    Material = SteelIngot,
                    Amount = 2
                },
                CraftingTime = 4,
                Clicks = 4,
            },
            new Recipe
            {
                ProductionBuilding = Miner,
                Out = new MaterialAmount
                {
                    Material = Coal,
                    Amount = 1
                },
                CraftingTime = 1
            },
            new Recipe()
            {
                ProductionBuilding = Assembler,
                In =
                {
                    new MaterialAmount()
                    {
                        Material = ReinforcedIronPlate,
                        Amount = 3
                    },
                    new MaterialAmount()
                    {
                        Material = IronRod,
                        Amount = 6
                    }
                },
                Out = new MaterialAmount()
                {
                    Material = ModularFrame,
                    Amount = 1
                },
                CraftingTime = 15,
                Clicks = 4
            },
            new Recipe()
            {
                ProductionBuilding = Manufacturer,
                In =
                {
                    new MaterialAmount()
                    {
                        Material = ModularFrame,
                        Amount = 5,
                    },
                    new MaterialAmount()
                    {
                        Material = SteelPipe,
                        Amount = 15
                    },
                    new MaterialAmount()
                    {
                        Material = EncasedIndustrialBeam,
                        Amount = 5
                    },
                    new MaterialAmount()
                    {
                        Material = Screw,
                        Amount = 90
                    }
                },
                Out = new MaterialAmount()
                {
                    Material = HeavyModularFrame,
                    Amount = 1
                },
                CraftingTime = 30,
                Clicks = 8,
            },
            new Recipe()
            {
                ProductionBuilding = Assembler,
                In =
                {
                    new MaterialAmount()
                    {
                        Material = SteelBeam,
                        Amount = 4
                    },
                    new MaterialAmount()
                    {
                        Material = Concrete,
                        Amount = 5
                    }
                },
                Out = new MaterialAmount()
                {
                    Material = EncasedIndustrialBeam,
                    Amount = 1
                },
                CraftingTime = 15,
                Clicks = 4
            },
            new Recipe()
            {
                ProductionBuilding = Constructor,
                In =
                {
                    new MaterialAmount()
                    {
                        Material = SteelIngot,
                        Amount = 3
                    }
                },
                Out = new MaterialAmount()
                {
                    Material = SteelBeam,
                    Amount = 1
                },
                CraftingTime = 6,
                Clicks = 2
            },
            new Recipe()
            {
                ProductionBuilding = Constructor,
                In =
                {
                    new MaterialAmount()
                    {
                        Material = Limestone,
                        Amount = 3,
                    }
                },
                Out = new MaterialAmount()
                {
                    Material = Concrete,
                    Amount = 1
                },
                CraftingTime = 4,
                Clicks = 1
            },
            new Recipe()
            {
                ProductionBuilding = Miner,
                Out = new MaterialAmount()
                {
                    Material = Limestone,
                    Amount = 1
                },
                CraftingTime = 1
            },
            new Recipe()
            {
                ProductionBuilding = Manufacturer,
                In =
                {
                    new MaterialAmount()
                    {
                        Material = Computer,
                        Amount = 2
                    },
                    new MaterialAmount()
                    {
                        Material = AiLimiter,
                        Amount = 2,
                    },
                    new MaterialAmount()
                    {
                        Material = HighSpeedConnector,
                        Amount = 3
                    },
                    new MaterialAmount()
                    {
                        Material = Plastic,
                        Amount = 21
                    }
                },
                Out = new MaterialAmount()
                {
                    Material = Supercomputer,
                    Amount = 1
                },
                CraftingTime = 32,
                Clicks = 8
            },
            new Recipe()
            {
                ProductionBuilding = Assembler,
                In =
                {
                    new MaterialAmount()
                    {
                        Material = CircuitBoard,
                        Amount = 2
                    },
                    new MaterialAmount()
                    {
                        Material = Quickwire,
                        Amount = 18
                    }
                },
                Out = new MaterialAmount()
                {
                    Material = AiLimiter,
                    Amount = 1
                },
                CraftingTime = 12,
                Clicks = 3
            },
            new Recipe()
            {
                ProductionBuilding = Constructor,
                In =
                {
                    new MaterialAmount()
                    {
                        Material = CateriumIngot
                    }
                },
                Out = new MaterialAmount()
                {
                    Material = Quickwire,
                    Amount = 4
                },
                CraftingTime = 4,
                Clicks = 1
            },
            new Recipe()
            {
                ProductionBuilding = Smelter,
                In =
                {
                    new MaterialAmount()
                    {
                        Material = CateriumOre,
                        Amount = 3
                    }
                },
                Out = new MaterialAmount()
                {
                    Material = CateriumIngot,
                    Amount = 1
                },
                CraftingTime = 4,
                Clicks = 4
            },
            new Recipe()
            {
                ProductionBuilding = Miner,
                Out = new MaterialAmount()
                {
                    Material = CateriumOre,
                    Amount = 1
                },
                CraftingTime = 1
            },
            new Recipe()
            {
                ProductionBuilding = Manufacturer,
                In =
                {
                    new MaterialAmount()
                    {
                        Material = Quickwire,
                        Amount = 40,
                    },
                    new MaterialAmount()
                    {
                        Material = Cable,
                        Amount = 10
                    },
                    new MaterialAmount()
                    {
                        Material = Plastic,
                        Amount = 6
                    }
                },
                Out = new MaterialAmount()
                {
                    Material = HighSpeedConnector,
                    Amount = 1
                },
                CraftingTime = 24,
                Clicks = 6
            }
        };
    }
}