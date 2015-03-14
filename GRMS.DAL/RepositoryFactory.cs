using GRMS.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMS.DAL
{
    //简单工厂方法
    public static class RepositoryFactory
    {
        public static IUserInfoRepository UserInfoRepository
        {
            get { return new UserInfoRepository(); }
        }
        public static IRoleRepository RoleRepository
        {
            get { return new RoleRepository(); }
        }
    }
}
