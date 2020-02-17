using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIWeb_TareaMartin.Services;
using APIWeb_TareaMartin.Models;
using Microsoft.Extensions.Logging;

namespace APIWeb_TareaMartin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private PostService _postService;
        private readonly ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger, PostService postService)
        {
            _postService = postService;
            _logger = logger;
        }

        // GET: api/Post
        [HttpGet]
        public List<Post> Get()
        {
            return _postService.GetPosts();
        }

        // GET: api/Post/5
        [HttpGet("{id}", Name = "GetPosts")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Post
        [HttpPost]
        public string Post([FromBody] Post post)
        {
            //User user = new User { id = id, FirstName = FirstName, LastName = LastName, email = email, password = password };
            return _postService.AddPost(post);
        }

        // PUT: api/Post/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Post post)
        {
            return _postService.EditPost(id, post);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _postService.DeletePost(id);
        }
    }
}
