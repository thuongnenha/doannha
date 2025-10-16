using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public static class SessionUser
    {
        public static T ghiDuLieu<T>(SqlDataReader dr) where T : IUser, new()
        {
            T obj = new T
            {
                ID = dr["ID"].ToString(),
                Ho = dr["Ho"].ToString(),
                Ten = dr["Ten"].ToString(),
                Email = dr["Email"].ToString(),
                PhoneNumber = dr["PhoneNumber"].ToString(),
                Password = dr["Password"].ToString()
            };
            Session.userID = obj.ID;
            Session.chucVu = obj is NhanVienDTO ? "nhanvien" : "admin";
            // Nếu là nhân viên thì gán thêm Lương
            if (obj is NhanVienDTO nv && dr["Luong"] != DBNull.Value)
                nv.Luong = Convert.ToDecimal(dr["Luong"]);
            return obj;
        }
        public static void ganSession<T>(T obj) where T : IUser
        {
            if (obj is AdminDTO admin)
            {
                Session.admin = admin;
            }
            else if (obj is NhanVienDTO nv)
            {
                Session.nhanVien = nv;
            }
        }
    }
}
