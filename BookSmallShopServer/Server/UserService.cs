using BookSmallShopServer.Common;
using BookSmallShopServer.DatabaseTable;
using System;
using System.Threading.Tasks;

namespace BookSmallShopServer.Server
{
    public class UserService
    {
        public static async Task<T_PersonalCenter_User> GetById(int id)
        {
            T_PersonalCenter_User t_Personal = await SqlDapperHelper.GetByIdAsync<T_PersonalCenter_User>(id);
            return t_Personal;
        }
    }
}
