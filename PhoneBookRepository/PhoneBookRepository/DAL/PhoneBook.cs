using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookRepository.DAL
{
    public class PhoneBook
    {
        public int ID;
        public string Name;
        public string Address;
        public string Email;

        public PhoneBook()
        {
        }
        public PhoneBook(int id, string name, string address, string email)
        {
            ID = id;
            Name = name;
            Address = address;
            Email = email;
        }
    }
}
