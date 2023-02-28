using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookRepository.DAL
{
    public class PhoneBookRepos: IPhoneBookRepository
    {
        List<PhoneBook> listPhoneBook = new List<PhoneBook>()
        {
            new PhoneBook(1001, "Umme Kulsum", "Mirpur-10,Dhaka", "umme520@gmail"),
            new PhoneBook(2001, "Fatima Akter", "Rajshahi", "fatima255@gamil.com"),
            new PhoneBook(3001, "Raihan Akter", "Dhaka", "raihan145@gmail.com"),
            new PhoneBook(4001, "Shamima Akter", "Borisal", "shamima45@gmail.com"),
            new PhoneBook(5004, "Tamanna Akter", "USA", "tamanna450@gmail.com"),
            new PhoneBook(3003, "Dipa Khondokar", "Japan", "dipa47@gmail.com"),
            new PhoneBook(5002, "Jannatul Ferdaus", "MohammadPur,Dhaka", "jannatul65@gmail.com")
        };
        public List<PhoneBook> Get()
        {
            return listPhoneBook.OrderBy(x => x.Name).ToList();
        }
        public PhoneBook Get(int id)
        {
            PhoneBook oPhoneBook = listPhoneBook.Where(x => x.ID == id).FirstOrDefault();
            return oPhoneBook;
        }
        public bool Add(PhoneBook model)
        {
            listPhoneBook.Add(model);
            return true;
        }
        public bool Update(PhoneBook model)
        {
            bool isExecuted = false;
            PhoneBook oPhoneBook = listPhoneBook.Where(x => x.ID == model.ID).FirstOrDefault();
            if (oPhoneBook != null)
            {
                listPhoneBook.Remove(oPhoneBook);
                listPhoneBook.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }
        public bool Delete(int id)
        {
            bool isExecuted = false;
            PhoneBook oPhoneBook = listPhoneBook.Where(x => x.ID == id).FirstOrDefault();
            if(oPhoneBook != null)
            {
                listPhoneBook.Remove(oPhoneBook);
                isExecuted = true;
            }
            return isExecuted;
        }
    }
}
