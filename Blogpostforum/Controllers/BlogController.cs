using Blogpostforum.BussinessLayer.Interfaces;
using Blogpostforum.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Blogpostforum.Controllers
{
    public class BlogController : ApiController
    {
        /// <summary>
        /// Creating Referance variable of IBlogPostServices and injecting in BlogController constructor
        /// </summary>
        private readonly IBlogPostServices _postServices;

        public BlogController(IBlogPostServices blogPostServices)
        {
            _postServices = blogPostServices;
        }
        /// <summary>
        /// Get all post
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Post>> GetAllPost()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Create new post 
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Api/Blog/AddPost")]
        public async Task<IHttpActionResult> PostBlogPost([FromBody] Post post)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get post by id
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Api/Blog/Postbyid/{postId}")]
        public async Task<IHttpActionResult> GetBlogPostById(int postId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get list of comment on post
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Api/Blog/CommentById/{postId}")]
        public async Task<IHttpActionResult> GetBlogPostCommentById(int postId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Add/Create new comment on post
        /// </summary>
        /// <param name="postId"></param>
        /// <param name="comment"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Api/Blog/Newcomment/{postId}")]
        public async Task<IHttpActionResult> PostBlogPostComment(int postId, [FromBody] Comment comment)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
