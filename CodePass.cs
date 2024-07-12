using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Security.Policy;

namespace RegistrationMark2
{

    internal partial class CodePass
    {
        #region -- Константы --
        public const int saltSize = 24; // размер соли
        public const int hashSize = 24; // размер хеша
        public const int itr = 100000; // число иттераций
        #endregion

        public static string CreateHash(string Login, string Password)
        {
            // Генерируем соль
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            byte[] salt = new byte[saltSize];
            provider.GetBytes(salt);
            //string readableSalt = BitConverter.ToString(salt).Replace("-", "").ToLower();

            // Генерируем хеш-пароль
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(Password, salt, itr);
            byte[] hash = pbkdf2.GetBytes(hashSize);
            string readableHash = BitConverter.ToString(hash).Replace("-", "").ToLower();

            //MessageBox.Show($"{readableHash}");
            //Передаём логин, хеш, соль в метод Add в классе ToDatabase
            ToDatabase transfer = new ToDatabase(Connection.ConnStr);
            transfer.Add(Login, hash, salt);

            return Login;
        }
        //Проверка хеша из БД и введённого пользователем хеша
        public static bool VerifyHash(string Password, byte[] hash, byte[] salt)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(Password, salt, itr);
            byte[] temphash = pbkdf2.GetBytes(hashSize);
            //string hasher = BitConverter.ToString(temphash).Replace("-", "").ToLower();
            //MessageBox.Show($"{hasher},{hash}");
            if (hash.SequenceEqual(temphash))
            {
                MessageBox.Show("Congratulations!, user login!");
            }
            else
            {
                MessageBox.Show("Meeeh, uncorrect user data");
            }
            return hash.SequenceEqual(temphash);
        }
    }
}
