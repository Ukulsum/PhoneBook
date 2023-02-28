using PhoneBookRepository.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookRepository.DAL;

namespace PhoneBookRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBookBusiness phoneBookBusiness = new PhoneBookBusiness(new PhoneBookRepos());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type 'l' for List, 'a' for Add, 'u' for Update, 'd' for Delete, 's' for Search, 'c' for Clear, 'x' for Exit");
                    string command = Console.ReadLine();
                    if (command == "l")
                    {
                        List<PhoneBook> _listPhoneBook = phoneBookBusiness.Get();
                        Console.WriteLine("List Of PhoneBook:");
                        Console.WriteLine("ID | Name | Address | Email");
                        foreach (PhoneBook _phoneBook in _listPhoneBook)
                        {
                            Console.WriteLine(_phoneBook.ID + " | " + _phoneBook.Name + " | " + _phoneBook.Address + " | " + _phoneBook.Email);
                        }
                    }
                    else if (command == "s")
                    {
                        Console.WriteLine("Input a id to find a phone book:");
                        string id = Console.ReadLine();
                        PhoneBook aphoneBook = phoneBookBusiness.Get(Convert.ToInt32(id));
                        Console.WriteLine(aphoneBook.ID + ". " + aphoneBook.Name + "__" + aphoneBook.Address + "__" + aphoneBook.Email);
                    }
                    else if (command == "a")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address");
                        string address = Console.ReadLine();
                        Console.WriteLine("Input a Email");
                        string email = Console.ReadLine();
                        PhoneBook aphoneBook = new PhoneBook();
                        aphoneBook.ID = Convert.ToInt32(id);
                        aphoneBook.Name = name;
                        aphoneBook.Address = address;
                        aphoneBook.Email = email;
                        bool isExecuted = phoneBookBusiness.Add(aphoneBook);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if( command == "u")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Console.WriteLine("Input a email:");
                        string email = Console.ReadLine();
                        PhoneBook aphonebook = new PhoneBook();
                        aphonebook.ID = Convert.ToInt32(id);
                        aphonebook.Name = name;
                        aphonebook.Address = address;
                        aphonebook.Email = email;
                        bool isExecuted = phoneBookBusiness.Update(aphonebook);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "d")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        bool isExecuted = phoneBookBusiness.Delete(Convert.ToInt32(id));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "c")
                    {
                        Console.Clear();
                    }
                    else if (command == "x")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
