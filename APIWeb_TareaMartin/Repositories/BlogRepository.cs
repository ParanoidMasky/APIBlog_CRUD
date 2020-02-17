using APIWeb_TareaMartin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWeb_TareaMartin.Repositories
{
    public class BlogRepository
    {
        //lista de users
        private List<User> Users = new List<User>()
        {
            new User { id = 4, FirstName = "User 1", LastName = "Pootis1" , email = "pootis1chido@gmail.com", password = "121213"},
            new User { id = 3, FirstName = "User 2", LastName = "Pootis2" , email = "pootis2chido@gmail.com", password = "121214"},
            new User { id = 2, FirstName = "User 3", LastName = "Pootis3" , email = "pootis2chido@gmail.com", password = "121215"},
            new User { id = 1, FirstName = "User 4", LastName = "Pootis4" , email = "pootis2chido@gmail.com", password = "121216"}
        };

        public List<User> GetUsers()
        {
            return Users;
        }

        //funcion agregar usuarios
        public string AddUsers(User user)
        {
            Users.Add(user);
            return "Usuario Agregado!";
        }

        public string EditUser(int id, User user)
        {
            int contador = 0, comparador = 0;
            foreach (User userId in Users) 
            {

                if (userId.id.Equals(id))
                {
                    comparador = contador;
                }
                else
                {
                    contador++;
                }
            }
            Users[comparador] = user;
            return "Usuario modificado!";
      
        }

        public string DeleteUser(int id)
        {

            foreach (User user in Users)
            {
                if (user.id.Equals(id))
                {
                    Users.Remove(user);
                    return "Usuario Eliminado!";
                }
          
            }
            return "ID no encontrado!.";
        }

        //lista de posts
        private List<Post> Posts = new List<Post>()
        {
            new Post { id = 1, title = "Post 1", content = "Content 1" , publishedAt = "12/02/20", userID = 1},
            new Post { id = 2, title = "Post 1", content = "Content 2" , publishedAt = "13/02/20", userID = 1},
            new Post { id = 3, title = "Post 1", content = "Content 3" , publishedAt = "12/02/20", userID = 2},
            new Post { id = 4, title = "Post 1", content = "Content 4" , publishedAt = "08/01/20", userID = 3}
        };

        public List<Post> GetPosts()
        {
            return Posts;
        }

        public string AddPost(Post post)
        {
            Posts.Add(post);
            return "Post Agregado!";
        }

        public string EditPost(int id, Post post)
        {
            int contador = 0, comparador = 0;
            foreach (Post postId in Posts)
            {

                if (postId.id.Equals(id))
                {
                    comparador = contador;
                }
                else
                {
                    contador++;
                }
            }
            Posts[comparador] = post;
            return "Post modificado!";
        }

        public string DeletePost(int id)
        {
            foreach (Post post in Posts)
            {
                if (post.id.Equals(id))
                {
                    Posts.Remove(post);
                    return "Post Eliminado!";
                }

            }
            return "ID no encontrado!.";
        }
    }
}
