using BluePillApp.Models.Login;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePillApp.Helpers
{
    public class FirebaseHelper
    {
        //Connect app with firebase using API Url  
        public static FirebaseClient firebase = new FirebaseClient("https://bluepilllogindatabase.firebaseio.com/");

        //Read All    
        public static async Task<List<Users>> GetAllUsers()
        {
            try
            {
                var userlist = (await firebase.Child("Users").OnceAsync<Users>()).Select(item =>
                new Users
                {
                    Email = item.Object.Email,
                    Password = item.Object.Password
                }).ToList();
                return userlist;
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error:{e}");
                return null;
            }
        }

        //Read     
        public static async Task<Users> GetUser(string email, string password)
        {
            try
            {
                var allUsers = await GetAllUsers();
                await firebase.Child("Users").OnceAsync<Users>();
                return allUsers.Where(a => a.Email == email && a.Password == password).FirstOrDefault();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error:{e}");
                return null;
            }
        }

        //Add a new user    
        public static async Task<bool> AddUser(string firstname, string lastname, string email, string password)
        {
            try
            {
                await firebase.Child("Users").PostAsync(new Users() { FirstName = firstname, LastName = lastname, Email = email, Password = password });
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error:{e}");
                return false;
            }
        }
    }
}
