using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerfectBlog.Models;

namespace PerfectBlog.DAL.Repositories
{
    public interface IMainRepository
    {
        void SaveUser(User user);
        void SaveBlog(Blog blog);

        User GetUserByLogin(String login);
        IList<Blog> GetAllBlogs();
        Blog GetBlogById(Guid id);
    }
}
