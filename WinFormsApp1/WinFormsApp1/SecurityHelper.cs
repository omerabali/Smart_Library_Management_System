namespace WinFormsApp1
{
    public static class SecurityHelper
    {
       
        public static string HashPassword(string password)
        {
            return password; 
        }

        public static bool VerifyPassword(string password, string dbPassword)
        {
            if (string.IsNullOrEmpty(dbPassword))
                return false;

            
            return password == dbPassword;
        }
    }
}
