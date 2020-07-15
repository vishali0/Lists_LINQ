using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List <User> values = new List <User>();
            //List<User> users = new List<User>();
            List<User> user = new List<User>();
            UserRepository obj = new UserRepository();
            values = obj.Users();
            Console.WriteLine(" ");
            Console.WriteLine("Get All User details");
            Console.WriteLine("Id\t" + "Name\t" + "Email\t\t\t" + "Address\t" + "Location\t" + "IsActive\t");
            foreach (var value in values)
            Console.WriteLine(value.Id+ "\t" + value.Name+ "\t" + value.email+ "\t\t" + value.address+ "\t" + value.location + "\t" + value.isActive);

            
            int Id = 101;
            User val = obj.GetUser(Id);
            Console.WriteLine(" ");
            Console.WriteLine("Get User details with id(101)");
            Console.WriteLine("Id\t" + "Name\t" + "Email\t\t\t" + "Address\t" + "Location\t" +"IsActive\t");
            Console.WriteLine(val.Id + "\t" + val.Name + "\t" + val.email + "\t\t" + val.address + "\t" + val.location + "\t" + val.isActive);


            //int user = (Id = 183, Name = "Neelansh", email = "sai@gmail.com", location = "Chennai", address = "Street1", isActive = true);

            int Delete = 105;
            Console.WriteLine(" ");
            Console.WriteLine("Delete User details with id(105)");
            List<User> afterDeletion = new List<User>();
            afterDeletion = obj.DeleteUser(Delete);
            //Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            Console.WriteLine("Id\t" + "Name\t" + "Email\t\t\t" + "Address\t" + "Location\t" + "IsActive\t");
            foreach (User users in afterDeletion)
            {
                Console.WriteLine(users.Id + "\t" + users.Name + "\t" + users.email + "\t\t" + users.address + "\t" + users.location + "\t" + users.isActive);
            }


            List<User> activeUser = new List<User>();
            activeUser = obj.ActiveUsers();
            Console.WriteLine();
            Console.WriteLine("List of Active Users");
            Console.WriteLine("Id\t" + "Name\t" + "Email\t\t\t" + "Address\t" + "Location\t" + "IsActive\t");
            foreach (User users in activeUser)
            {
                Console.WriteLine(users.Id + "\t" + users.Name + "\t" + users.email + "\t\t" + users.address + "\t " + users.location + "\t" + users.isActive);
            }


            User addUser = new User();
            addUser.Id = 111;
            addUser.Name = "Vysh";
            addUser.email = "vysh@gmail.com";
            addUser.location = "Hyderabad";
            addUser.address = "Street1";
            addUser.isActive = true;
            Console.WriteLine();

            Console.WriteLine("New user in List");
            obj.AddUser(addUser);
            var data = obj.Users();
            Console.WriteLine("Id\t" + "Name\t" + "Email\t\t" + "Address\t" + "Location\t" + "IsActive\t");
            foreach (User users in data)
            {
                Console.WriteLine(users.Id + "\t" + users.Name + "\t" + users.email + "\t" + users.address + "\t " + users.location + "\t" + users.isActive);
            }
            Console.WriteLine();


            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------- USING LINQ-----------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            

            Console.WriteLine();
            user = obj.Users();
            Console.WriteLine("Users Details:");
            Console.WriteLine("Id\t" + "Name\t" + "Email\t\t\t" + "Address\t" + "Location\t" + "IsActive\t");
            foreach (User users in user)
            {
                Console.WriteLine(users.Id + "\t" + users.Name + "\t" + users.email + "\t\t" + users.address + "\t " + users.location + "\t" +  users.isActive);
            }


            Console.WriteLine();
            Console.WriteLine("Getting User Details:");
            var getIdUser = user.Where(users => users.Id == 106);
            Console.WriteLine("Id\t" + "Name\t" + "Email\t\t\t" + "Address\t" + "Location\t" + "IsActive\t");
            foreach (User users in getIdUser)
            {
                Console.WriteLine(users.Id + "\t" + users.Name + "\t" + users.email + "\t\t" + users.address + "\t " + users.location + "\t"  + users.isActive);
            }

            
            Console.WriteLine();
            user.RemoveAll(x => x.Id == 107);
            Console.WriteLine("User details after deleting id(106) ");
            Console.WriteLine("Id\t" + "Name\t" + "Email\t\t\t" + "Address\t" + "Location\t" + "IsActive\t");
            foreach (User users in user)
            {
                Console.WriteLine(users.Id + "\t" + users.Name + "\t" + users.email + "\t\t" + users.address + "\t " + users.location + "\t" + users.isActive);
            }


            var ActiveUsers = user.Where(users => users.isActive == true);
            Console.WriteLine("");
            Console.WriteLine("Id\t" + "Name\t" + "Email\t\t\t" + "Address\t" + "Location\t" + "IsActive\t");
            foreach (User users in ActiveUsers)
            {
                Console.WriteLine(users.Id + "\t" + users.Name + "\t" + users.email + "\t\t" + users.address + "\t " + users.location + "\t" + users.isActive);
            }
            User newObject = new User();


        }


    }
}
