using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien : DBConnect
    {
        //Đăng nhập
        public bool NhanVienDangNhap(DTO_NhanVien nhanVien)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DangNhap";
                cmd.Parameters.AddWithValue("Email", nhanVien.Email);
                cmd.Parameters.AddWithValue("Matkhau", nhanVien.MatKhau);

                if(Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }catch (Exception ex)
            {
                throw ex;
            }finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
