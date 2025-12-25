using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public static class DbHelper
    {
        private const string ConnectionString =
            "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;";

        
        public static UserInfo ValidateLoginAndGetUser(string email, string password, int requiredRoleId)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            string sql = @"
                SELECT Ad, Soyad, Email, Sifre 
                FROM Kullanicilar 
                WHERE Email=@mail AND RolID=@roleId";

            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mail", email);
            cmd.Parameters.AddWithValue("@roleId", requiredRoleId);

            using SqlDataReader dr = cmd.ExecuteReader();

            if (!dr.Read())
                return null; 

            string dbPass = dr["Sifre"].ToString();

           
            if (!SecurityHelper.VerifyPassword(password, dbPass))
                return null;

            
            return new UserInfo
            {
                Name = dr["Ad"].ToString(),
                Surname = dr["Soyad"].ToString(),
                Email = dr["Email"].ToString()
            };
        }

        
        public static string GetUserName(string email)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            string sql = "SELECT Ad + ' ' + Soyad FROM Kullanicilar WHERE Email=@mail";

            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mail", email);

            return cmd.ExecuteScalar()?.ToString() ?? "";
        }
    }

   
    public class UserInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public string FullName => $"{Name} {Surname}";
    }
}
