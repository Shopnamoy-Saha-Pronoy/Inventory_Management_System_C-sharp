using InventoryMSystem.Data;
using InventoryMSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMSystem.Repository
{    
    public class UserDataRepository
    {
        private DataAccess Da { get; set; }

        public UserDataRepository()
        {
            this.Da = new DataAccess();
        }

        public List<UserEntity> GetAll(string key)
        {
            List<UserEntity> userList = new List<UserEntity>();
            string sql;
            try
            {
                if (key == null)
                    sql = "select * from UserData;";
                else
                    sql = "select * from UserData where UserName like'%" + key + "%';";
                var dt = this.Da.ExecuteQueryTable(sql);

                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    UserEntity u = ConvertToEntity(dt.Rows[ax]);
                    userList.Add(u);
                }

                return userList;
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        private UserEntity ConvertToEntity(DataRow row)
        {
            if(row == null)
               return null;

            //var dt = (DateTime)row["JoinDate"];
            var user = new UserEntity();

            user.Id = Convert.ToInt32(row["Id"].ToString());
            user.FullName = row["FullName"].ToString();
            user.UserName = row["UserName"].ToString();
            user.UserPassword = row["UserPassword"].ToString();
            user.UserPhone = row["UserPhone"].ToString();
            user.Role = row["Role"].ToString();
            return user;
        }

        public UserEntity SearchUser(UserEntity ud)
        {
            
            var sql = "select * from UserData where UserName = '" + ud.UserName + "' and UserPassword = '" + ud.UserPassword + "';";
            var dt = this.Da.ExecuteQueryTable(sql);
            if (dt.Rows.Count >0 && dt.Rows[0]["UserName"].ToString() == ud.UserName && dt.Rows[0]["UserPassword"].ToString() == ud.UserPassword)
            {
                UserEntity us = new UserEntity();
                us.UserName = dt.Rows[0]["UserPassword"].ToString();
                us.UserPassword = dt.Rows[0]["UserName"].ToString();
                us.Role = dt.Rows[0]["Role"].ToString();
                return us;
            }
            else
                return null;
        }
            


    
        public bool Save(UserEntity ud)
        {
            try
            {
                var sql = "insert into UserData values(" + ud.Id + ",'" + ud.FullName + "','" + ud.UserName + "','" + ud.UserPassword + "','" + ud.UserPhone + "','"+ ud.Role + "');";
                var rowCount = this.Da.ExecuteDML(sql);
                if (rowCount == 1)
                  return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Edit(UserEntity ud)
        {
            try
            {
                var sql = "update UserData set FullName = '" + ud.FullName + "', UserName = '" + ud.UserName + "', UserPassword= '" + ud.UserPassword + "',UserPhone='" + ud.UserPhone + "',Role='" + ud.Role + "' where Id = " + ud.Id + ";";
                var rowCount = this.Da.ExecuteDML(sql);
                if (rowCount == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(string id)
        {
            try
            {
                var sql = "delete from UserData where Id="+id+";";
                var rowCount = this.Da.ExecuteDML(sql);
                if (rowCount == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
