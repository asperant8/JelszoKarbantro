using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Xml;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;


namespace JelszoKarbantarto
{

    public class User
    {
        public string username { get; set; }
        public string hash_password { get; set; }

        public User(string username, string hash_password)
        {
            this.username = username;
            this.hash_password = hash_password;

        }

        public User()
        {

        }
    }


    public static class Authentication
    {
        public static void JSON_read(List<User> felhasznalok)
        {

            string fileName = "Felhasznalok.json";
            string jsonString = File.ReadAllText(fileName);
            string[] felhasznalokString = jsonString.Split('/'); //altgr+e
            for (int i = 0; i < felhasznalokString.Length - 1; i++)
            {
                felhasznalok.Add(JsonSerializer.Deserialize<User>(felhasznalokString[i]));
            }
        }
        //XML fájlba írás
        public static void JSON_write(User felhasznalo)
        {
            string fileName = "Felhasznalok.json";
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(felhasznalo, options) + '/';
            if (!File.Exists(fileName))
            {
                File.WriteAllText(fileName, jsonString);
            }
            else
            {
                File.AppendAllText(fileName, jsonString);
            }
        }


    }


    public static class Hashing
    {
        public static string Generate_hash(string jelszo)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                return GetHash(sha256Hash, jelszo).ToString();

            }

        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public static bool Hash_compare(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            var hashOfInput = GetHash(hashAlgorithm, input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            return comparer.Compare(hashOfInput, hash) == 0;
        }
    }

    public static class ModifyData
    {
        public static void Modify_Login_credentials(User logged_in_user, string old_password, string new_password, ref string label_result, ref bool successfulChange)
        {
            List<User> all_users = new List<User>();
            Authentication.JSON_read(all_users);
            foreach (var user in all_users)
            {
                if (user.username == logged_in_user.username)
                {
                    if (Hashing.Generate_hash(old_password) == user.hash_password)
                    {
                        if (new_password.Length > 5)
                        {
                            user.hash_password = Hashing.Generate_hash(new_password.ToString());
                            File.Delete("Felhasznalok.json");
                            for (int i = 0; i < all_users.Count; i++)
                            {
                                Authentication.JSON_write(all_users[i]);
                            }
                            label_result = "Jelszó sikeresen megváltoztatva!";
                            successfulChange = true;
                        }
                        else
                        {
                            label_result = "Az új jelszó min. 5 karakter hosszú lehet!";
                        }

                    }
                    else
                    {
                        label_result = "Hibás jelenlegi jelszót adott meg.";
                    }


                }
            }

        }

        public static void Delete_Account(User logged_in_user)
        {
            List<User> all_users = new List<User>();
            Authentication.JSON_read(all_users);
            int indexToDelete;
            for (int i = 0; i < all_users.Count; i++)
            {
                if (all_users[i].username == logged_in_user.username)
                {
                    indexToDelete = i;
                    File.Delete("Felhasznalok.json");
                    for (int j = 0; j < all_users.Count; j++)
                    {
                        if (j != indexToDelete)
                        {
                            Authentication.JSON_write(all_users[j]);
                        }

                    }

                }
            }
        }
    }

    public delegate void delegatePassUser(User user);

}
