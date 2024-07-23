using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class PostController : ControllerBase
{
    private static List<Post> posts = new List<Post>();

    public void CreatePost([FromBody] Post post)
    {
        posts.Add(post);
    }
}

