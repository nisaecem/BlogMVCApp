using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class BlogContext:DbContext
    {
        //veritabanını yöneten sınıftır.Veri tabanının adı blogcontext olur.Base ile adını değiştirebilirsin.
        public BlogContext():base("BlogDB")
        {
            Database.SetInitializer(new BlogInitializer());
        }
        public DbSet<Blog> Bloglar{ get; set; }
        public DbSet<Category> Kategoriler{ get; set; }
    }
}