using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PerfectBlog.Models;

namespace PerfectBlog.DAL.Repositories
{
    public class MainRepository : IMainRepository
    {
        public void SaveUser(User user)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(user);
                    transaction.Commit();
                }
            }
        }

        public void SaveBlog(Blog blog)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(blog);
                    transaction.Commit();
                }
            }
        }

        public User GetUserByLogin(String login)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var list = session.QueryOver<User>().Where(x => x.Login == login).List();
                return list.Count != 0 ? list[0] : null;
            }
        }

        public IList<Blog> GetAllBlogs()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Blog>().List<Blog>();
            }
        }

        public Blog GetBlogById(Guid id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var list = session.QueryOver<Blog>().Where(x => x.Id == id).List();
                return list.Count != 0 ? list[0] : null;
            }
        }
    }
}