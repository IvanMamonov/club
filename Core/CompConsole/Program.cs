using System;
using Core;

namespace CompConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var command = Console.ReadLine();
                if (command.Trim().ToLower() == "exit")
                    return;
               Execute(command);
            }
        }
        private static void Execute(string command)
        {
            var arguments = command.Trim().Split();
            switch (arguments[0])
            {
                case "add":
                    Add(arguments);
                    break;
                case "get":
                    Get(arguments);
                    break;
                case "update":
                    Update(arguments);
                    break;
                case "remove":
                    Remove(arguments);
                    break;
                default:
                    Console.WriteLine($"Unknown command");
                    break;
            }

        }
        private static void Add(string[] args)
        {
            switch (args[1])
            {
                case "bron":
                    DataAccess.AddNewBronPc
                    (
                        new BronPc()  
                            {
                                idBronPc = int.Parse(args[2]),
                                NumberTable = args[3],
                                idUsers = int.Parse(args[4]),
                                idPc = int.Parse(args[4])
                            }
                    );
                    break;
                case "users":
                    DataAccess.AddNewUsers(new Users() { idUsers = int.Parse(args[2]) });
                    break;
                case "food":
                    DataAccess.AddNewFood
                    (
                        new Food()
                        {
                            idFood = int.Parse(args[2]),
                            NameFood = args[3],
                            Calories = int.Parse(args[4])
                        }
                    );
                    break;
                case "pc":
                    DataAccess.AddNewPc
                        (
                        new Pc()
                        {
                            idPc = int.Parse(args[2]),
                            characteristic = args[3]
                        }
                        );
                    break;
                case "zakazFood":
                    DataAccess.AddNewZakazFood
                        (
                        new ZakazFood()
                        {
                            idZakazFood = (int.Parse(args[2])) 
                        }
                        );
                    break;
                default:
                    Console.WriteLine($"Unknown command");
                    break;
            }
        }
        private static void Get(string[] args)
        {
            switch (args[1])
            {
                case "bronPc":
                    foreach (var a in DataAccess.GetBronPcs())
                        Console.WriteLine($"{a.idBronPc} {a.NumberTable}");
                    break; 
                case "foods":
                    foreach (var a in DataAccess.GetFoods(int.Parse(args[2])))
                        Console.WriteLine($"{a.idFood} {a.NameFood}");
                    break;
                case "pc":
                    foreach (var f in DataAccess.GetPcs())
                        Console.WriteLine($"{f.idPc} {f.characteristic}");
                    break;
                case "users":
                    Console.WriteLine(DataAccess.GetUsers(int.Parse(args[2])).Fullname);
                    break;
                case "zakazFood":
                    foreach (var a in DataAccess.GetZakazFoods())
                        Console.WriteLine($"{a.idZakazFood} {a.idFood}");
                    break;
                case "type":
                    foreach (var d in DataAccess.GetTypes())
                        Console.WriteLine($"{d.idType} {d.title}");
                    break;
                default:
                    Console.WriteLine($"Unknown command");
                    break;
            }
        }
        private static void Remove(string[] args)
        {
            switch (args[1])
            {
                case "delBronPc":
                    DataAccess.DeleteBronPc(int.Parse(args[2]));
                    break;
                case "pc":
                    DataAccess.GetPc(int.Parse(args[2]));
                    break;
                case "bronPc":
                    DataAccess.GetBronPc(int.Parse(args[2]));
                    break;
                default:
                    Console.WriteLine("Unknown command");
                    break;
            }
        }
        private static void Update(string[] args)
        {
            switch (args[1])
            {
                case "uppc":
                    DataAccess.UpdatePc(int.Parse(args[2]), new Pc() { characteristic = args[3] });
                    break;
            }
        }
    }
}
