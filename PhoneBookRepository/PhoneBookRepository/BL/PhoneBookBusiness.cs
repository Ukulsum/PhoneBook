using PhoneBookRepository.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookRepository.BL
{
    public class PhoneBookBusiness
    {
        IPhoneBookRepository _repository;
        public PhoneBookBusiness (IPhoneBookRepository repository)
        {
            _repository = repository;
        }
        public List<PhoneBook> Get()
        {
            return _repository.Get();
        }
        public PhoneBook Get(int id)
        {
            return _repository.Get(id);
        }
        public bool Add(PhoneBook model)
        {
            return _repository.Add(model);
        }
        public bool Update(PhoneBook model)
        {
            return _repository.Update(model);
        }
        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}
