using BookSmallShopServer.Common;
using BookSmallShopServer.DatabaseTable;
using System;

namespace BookSmallShopServer
{
    public class UserService
    {
        public static T_PersonalCenter_User GetById(int id)
        {
            T_PersonalCenter_User t_Personal = SqlDapperHelper.GetById<T_PersonalCenter_User>(id);
            return t_Personal;
        }
    }
}
