using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIWeb_TareaMartin.Models;
using APIWeb_TareaMartin.Repositories;

namespace APIWeb_TareaMartin.Services
{
    public class UserService
    {
        private BlogRepository _blogRepository;

        public UserService(BlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public List<User> GetUsers()
        {
            return _blogRepository.GetUsers();
        }

        //metodo agregar usuarios
        public string AddUser(User user)
        {
            return _blogRepository.AddUsers(user);
        }

        public string EditUser(int id, User user)
        {
            return _blogRepository.EditUser(id, user);
        }

        public string DeleteUser(int id)
        {
            return _blogRepository.DeleteUser(id);
        }
    }
}
