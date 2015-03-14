using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMS.IDAL
{
    public interface IDbSession
    {

        //每个表对应的实体仓储对象

        IDAL.IRoleRepository RoleRepository { get; }

        IDAL.IUserInfoRepository UserInfoRepository { get; }

        //将当前应用程序跟数据库的会话内所有实体的变化更新会数据库

        int SaveChanges();

        //执行Sql语句的方法

        //EF5.0的写法

        int ExcuteSql(string strSql, DbParameter[] parameters);

    }
}
