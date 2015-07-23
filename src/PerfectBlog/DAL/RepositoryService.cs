using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PerfectBlog.DAL.Repositories;
using PerfectBlog.Models;
using PerfectBlog.Models.Records;

namespace PerfectBlog.DAL
{
    public class RepositoryService
    {
        private static IMainRepository repository = new MainRepository();

        public static IMainRepository Repository
        {
            get { return repository; }
        }

        public static void Initialize()
        {
            User user = new User() { Login = "admin", Password = "admin" };
            Blog blog = new Blog() { Name = "Blog_1", Owner = user, Records = new List<BlogRecord>() };
            //blog.Records.Add(new BlogRecord() { Value = "Record_1", 
            System.Diagnostics.Debug.WriteLine("UserId = {0}", user.Id);
            repository.SaveUser(user);
            System.Diagnostics.Debug.WriteLine("UserId = {0}", user.Id);
            /*repository.SaveBlog(new Blog() { Name = "Blog_1", Owner = user });
            repository.SaveBlog(new Blog() { Name = "Blog_2", Owner = user });
            repository.SaveBlog(new Blog() { Name = "Blog_3", Owner = user });*/
            for (int i = 0; i < 3; i++)
                repository.SaveBlog(GetBlog(String.Format("Blog_{0}", i), user, 2));
        }

        private static Blog GetBlog(String name, User owner, int records)
        {
            var result = new Blog() { Name = name, Owner = owner, Records = new List<BlogRecord>() };

            for (int i = 0; i < records; i++)
                result.Records.Add(GetRecord(String.Format("Record_{0}", i), owner, result, 2, 2));

            return result;
        }

        private static BlogRecord GetRecord(String value, User owner, Blog blog, int ratings, int comments)
        {
            var result = new BlogRecord() { Comments = new List<Comment>(), Value = value, Blog = blog, Ratings = new List<Rating>() };

            for (int i = 0; i < ratings; i++)
            {
                result.Ratings.Add(new Rating()
                {
                    Value = i % 2 == 0,
                    Record = result,
                    Owner = new User() { Login = String.Format("user_{0}", i), Password = "admin" }
                });
            }

            for (int i = 0; i < comments; i++)
            {
                result.Comments.Add(new Comment()
                {
                    Value = String.Format("Comment_{0}", i),
                    Owner = owner,
                    Record = result
                });
            }

            return result;
        }
    }
}