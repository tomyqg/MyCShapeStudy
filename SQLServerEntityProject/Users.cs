//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System.Linq;

namespace SQLServerEntityProject
{
    using System;
    using System.Collections.Generic;

    public partial class Users
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public Nullable<int> pid { get; set; }

        public static Tuple<bool, string> Add(Users users)
        {
            MyDatabaseEntities entities = MyDatabaseEntities.Instance();
            try
            {
                entities.Users.Add(users);
                entities.SaveChanges();
                return new Tuple<bool, string>(true, string.Empty);
            }
            catch (Exception ex)
            {
                entities.Users.Remove(users);
                return new Tuple<bool, string>(false, ex.Message);
            }
        }

        public static Tuple<bool, string> Delete(Users users)
        {
            MyDatabaseEntities entities = MyDatabaseEntities.Instance();

            try
            {
                entities.Users.Remove(users);
                entities.SaveChanges();
                return new Tuple<bool, string>(true, string.Empty);
            }
            catch (Exception e)
            {
                return new Tuple<bool, string>(false, e.Message);
            }
        }

        public static Tuple<bool, string> Modify(Users users, List<Users> listuUserses)
        {
            MyDatabaseEntities entities = MyDatabaseEntities.Instance();

            try
            {
                var list = entities.Users.ToList();
                foreach (var item in list)
                {
                    entities.Users.Remove(item);
                }
                entities.SaveChanges();


                return new Tuple<bool, string>(true, string.Empty);
            }
            catch (Exception e)
            {
                return new Tuple<bool, string>(false, e.Message);
            }

        }
    }
}
