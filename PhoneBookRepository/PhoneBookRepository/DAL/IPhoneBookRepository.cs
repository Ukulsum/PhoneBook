using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookRepository.DAL
{
    public interface IPhoneBookRepository
    {
        List<PhoneBook> Get();
        PhoneBook Get(int id);
        bool Add(PhoneBook model);
        bool Update(PhoneBook model);
        bool Delete(int id);
    }
}
