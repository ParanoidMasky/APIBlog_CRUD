using APIWeb_TareaMartin.Models;
using APIWeb_TareaMartin.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace APIWeb_TareaMartin.Services
{
    public class PostService
    {
        private BlogRepository _blogRepository;

        public PostService(BlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public List<Post> GetPosts()
        {
            return _blogRepository.GetPosts();
        }

        public string AddPost(Post post)
        {
            return _blogRepository.AddPost(post);
        }

        public string EditPost(int id, Post post)
        {
            return _blogRepository.EditPost(id, post);
        }

        public string DeletePost(int id)
        {
            return _blogRepository.DeletePost(id);
        }
    }
}
