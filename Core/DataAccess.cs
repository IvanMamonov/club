using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Core
{
    public static class DataAccess
    {
        public static List<Pc> GetPcs()
        {
            List<Pc> pc = new List<Pc>(DBconnection.connection.Pc);
            List<Pc> pcc = new List<Pc>();
            foreach (var t in pc)
            {
                pcc.Add(
                    new Pc
                    {
                        idPc = t.idPc,
                        characteristic = t.characteristic,
                    });
            }
            return pcc;
        }

        public static List<Pc> GetPc(int idPc)
        {
            List<Pc> pc = GetPcs();
            return pc.Where(a => a.idPc == idPc).ToList();
        }

        public static Pc GetPc(string characteristic)
        {
            List<Pc> pcs = GetPcs();
            return pcs.Where(t => t.characteristic == characteristic).FirstOrDefault();
        }

        public static bool AddNewPc(Pc pc)
        {
            try
            {
                DBconnection.connection.Pc.Add(pc);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void DeletePc(int idPc)
        {
            List<Pc> pcs = GetPcs();
            var pc = pcs.Where(t => t.idPc == idPc).FirstOrDefault();

            DBconnection.connection.Pc.Remove(pc);
            DBconnection.connection.SaveChanges();
        }

        public static void UpdatePc(int idPc, Pc pc)
        {

            DBconnection.connection.Pc.SingleOrDefault(t => t.idPc == idPc);
            DBconnection.connection.SaveChanges();

        }

        public static void DeleteTattoo(Pc pc)
        {
            DBconnection.connection.Pc.Remove(pc);
            DBconnection.connection.SaveChanges();
        }

        /////////////////////////////////////////
        ///

        public static List<Users> GetUsers()
        {
            List<Users> users = new List<Users>(DBconnection.connection.Users);
            List<Users> userss = new List<Users>();
            foreach (var t in users)
            {
                userss.Add(
                    new Users
                    {
                        idUsers = t.idUsers,
                        Fullname = t.Fullname,
                        idType = t.idType,
                    });
            }
            return userss;
        }

        public static List<Users> GetUserss(int idUsers)
        {
            List<Users> users = GetUsers();
            return users.Where(a => a.idUsers == idUsers).ToList();
        }

        public static Users GetUserss(string Fullname)
        {
            List<Users> userss = GetUsers();
            return userss.Where(t => t.Fullname == Fullname).FirstOrDefault();
        }
        public static Users GetUsers(int idType)
        {
            List<Users> users = GetUsers();
            return users.Where(t => t.idType == idType).FirstOrDefault();
        }

        public static bool AddNewUsers(Users users)
        {
            try
            {
                DBconnection.connection.Users.Add(users);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void Deleteusers(int idUsers)
        {
            List<Users> users = GetUsers();
            var user = users.Where(t => t.idUsers == idUsers).FirstOrDefault();

            DBconnection.connection.Users.Remove(user);
            DBconnection.connection.SaveChanges();
        }

        public static void UpdateUser(int idUser, Users users)
        {

            DBconnection.connection.Users.SingleOrDefault(t => t.idUsers == idUser);
            DBconnection.connection.SaveChanges();

        }

        public static void DeleteUsers(Users users)
        {
            DBconnection.connection.Users.Remove(users);
            DBconnection.connection.SaveChanges();
        }

        ///////////////////////////
        ///

        public static List<Type> GetTypes()
        {
            List<Type> types = new List<Type>(DBconnection.connection.Type);
            List<Type> typess = new List<Type>();
            foreach (var t in types)
            {
                types.Add(
                    new Type
                    {
                        idType = t.idType,
                        title = t.title,
                    });
            }
            return types;
        }

        public static List<Type> GetTypess(int idType)
        {
            List<Type> types = GetTypes();
            return types.Where(a => a.idType == idType).ToList();
        } 

        public static bool AddNewTypes(Type type)
        {
            try
            {
                DBconnection.connection.Type.Add(type);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void DeleteTypes(int idTypes)
        {
            List<Type> types = GetTypes();
            var type = types.Where(t => t.idType == idTypes).FirstOrDefault();

            DBconnection.connection.Type.Remove(type);
            DBconnection.connection.SaveChanges();
        }

        public static void UpdateTypes(int idType, Type type)
        {

            DBconnection.connection.Type.SingleOrDefault(t => t.idType == idType);
            DBconnection.connection.SaveChanges();

        }

        public static void DeleteType(Type type)
        {
            DBconnection.connection.Type.Remove(type);
            DBconnection.connection.SaveChanges();
        }

        ///////////////////////////////////////
        ///

        public static List<BronPc> GetBronPcs()
        {
            List<BronPc> bronPcs = new List<BronPc>(DBconnection.connection.BronPc);
            List<BronPc> bronPcss = new List<BronPc>();
            foreach (var t in bronPcs)
            {
                bronPcss.Add(
                    new BronPc
                    {
                        idBronPc = t.idBronPc,
                        NumberTable = t.NumberTable,
                        idUsers = t.idUsers,
                        idPc = t.idPc,
                    });
            }
            return bronPcs;
        }

        public static List<BronPc> GetBronPc(int idBronPc)
        {
            List<BronPc> bronPcs = GetBronPcs();
            var b = from i in bronPcs
                    where i.idBronPc == idBronPc
                    select i;
            return b.ToList(); ;
        }

        public static bool AddNewBronPc(BronPc bronPc)
        {
            try
            {
                DBconnection.connection.BronPc.Add(bronPc);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void DeleteBronPc(int idBronPc)
        {
            List<BronPc> bronPcs = GetBronPcs();
            var type = bronPcs.Where(t => t.idBronPc == idBronPc).FirstOrDefault();

            DBconnection.connection.BronPc.Remove(type);
            DBconnection.connection.SaveChanges();
        }

        public static void DeleteBronPc(BronPc bronPc)
        {
            DBconnection.connection.BronPc.Remove(bronPc);
            DBconnection.connection.SaveChanges();
        }

        //////////////////////////////////////////////
        ///
        public static List<ZakazFood> GetZakazFoods()
        {
            List<ZakazFood> zakazFoods = new List<ZakazFood>(DBconnection.connection.ZakazFood);
            List<ZakazFood> zakazFoodss = new List<ZakazFood>();
            foreach (var t in zakazFoods)
            {
                zakazFoods.Add(
                    new ZakazFood
                    {
                        idZakazFood = t.idZakazFood,
                        idFood = t.idFood ,
                        idUsers = t.idUsers,
                    });
            }
            return zakazFoods;
        }

        public static List<ZakazFood> GetZakazFood(int idZakazFood)
        {
            List<ZakazFood> bronPcs = GetZakazFoods();
            return bronPcs.Where(a => a.idZakazFood == idZakazFood).ToList();
        }

        public static bool AddNewZakazFood(ZakazFood zakazFood)
        {
            try
            {
                DBconnection.connection.ZakazFood.Add(zakazFood);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void DeleteZakazFood(int idZakazFood)
        {
            List<ZakazFood> zakazFoods = GetZakazFoods();
            var zakazFood = zakazFoods.Where(t => t.idZakazFood == idZakazFood).FirstOrDefault();

            DBconnection.connection.ZakazFood.Remove(zakazFood);
            DBconnection.connection.SaveChanges();
        }

        public static void DeleteBronPc(ZakazFood zakaz)
        {
            DBconnection.connection.ZakazFood.Remove(zakaz);
            DBconnection.connection.SaveChanges();
        }

        ////////////////////////////////////////////////////
        ///
        public static List<Food> GetFoods()
        {
            List<Food> foods = new List<Food>(DBconnection.connection.Food);
            List<Food> foodss = new List<Food>();
            foreach (var t in foods)
            {
                foods.Add(
                    new Food
                    {
                        idFood = t.idFood,
                        NameFood = t.NameFood,
                        Calories = t.Calories,
                    });
            }
            return foodss;
        }

        public static List<Food> GetFoods(int idFood)
        {
            List<Food> foods = GetFoods();
            return foods.Where(a => a.idFood == idFood).ToList();
        }

        public static bool AddNewFood(Food food)
        {
            try
            {
                DBconnection.connection.Food.Add(food);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool AddNewFood(int newidFood,
        string newNameFood, int newCalories)
        {
            try
            {
                Food food = new Food()
                {
                    idFood = newidFood,
                    NameFood = newNameFood,
                    Calories = newCalories
                };
                DBconnection.connection.Food.Add(food);
                DBconnection.connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
