using DevopsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevopsDemo.Repository
{
     public  interface IPostRepository
    {
        List<PostViewModel> GetPosts();
    }
}
