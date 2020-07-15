using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Linq
{
    public class UserRepository: IUserRepository

    {
        public List<User> users = new List<User>();

        public UserRepository()
        {

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------WITHOUT USING LINQ-----------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            // Add users to the list.
            users.Add(new User() { Id = 101, Name = "Vishali", email = "vish@gmail.com", location = "Bangalore", address = "Street1", isActive = true });
            users.Add(new User() { Id = 102, Name = "Vish", email = "vish@gmail.com", location = "Hyderabad", address = "Street2", isActive = false });
            users.Add(new User() { Id = 103, Name = "Ashu", email = "assh@gmail.com", location = "Bangalore", address = "Street3", isActive = false });
            users.Add(new User() { Id = 104, Name = "Prachu", email = "pra@gmail.com", location = "Bangalore", address = "Street1", isActive = true });
            users.Add(new User() { Id = 105, Name = "rishi", email = "rish@gmail.com", location = "Hyderbad", address = "Street1", isActive = true });
            users.Add(new User() { Id = 106, Name = "Avi", email = "avi@gmail.com", location = "Bangalore", address = "Street5", isActive = false });
            users.Add(new User() { Id = 107, Name = "Gops", email = "gops@gmail.com", location = "Hyderabad", address = "Street2", isActive = true });
            users.Add(new User() { Id = 108, Name = "Yash", email = "yash@gmail.com", location = "Bangalore", address = "Street1", isActive = false });
            users.Add(new User() { Id = 109, Name = "Riya", email = "yash@gmail.com", location = "Hyderabad", address = "Street2", isActive = true });
            users.Add(new User() { Id = 110, Name = "Sai", email = "sai@gmail.com", location = "Bangalore", address = "Street1", isActive = false });

        }
        public List<User> Users()
        {
            return users;
        }
        User data = new User();
        public User GetUser(int Id)
        {
            foreach(var item in users)
            {
                if (item.Id == Id)
                {
                    data = item;
                    
                }
            }
            return data;
        }
        public List<User> DeleteUser(int Id)
        {
            foreach (User user in users)
            {
                if (user.Id == Id)
                {
                    users.Remove(user);
                    break;
                }

            }
            return users;
        }

        public List<User> ActiveUser = new List<User>();
        public List<User> ActiveUsers()
        {
            foreach (User person in users)
            {
                if (person.isActive)
                {
                    ActiveUser.Add(person);
                }

            }
            return ActiveUser;
        }


        public List<User> AddUser(User user)
        {
            users.Add(user);
            return users;
        }


    }
}
