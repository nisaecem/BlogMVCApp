using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        //blogcontext içinde değişim olursa silip tekrar oluşturur.
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){KategoriAdi="C#"},
                new Category(){KategoriAdi="ASP.NET MVC"},
                new Category(){KategoriAdi="ASP.NET WebForm"},
                new Category(){KategoriAdi="PHP"},
            };
            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog(){Baslik="C# Delegates Hakkında",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,Icerik="C# Delegates HakkındaC# Delegates Hakkında",Resim="1.jpg",CategoryId=1},
                new Blog(){Baslik="C# Döngüler Nelerdir ",Aciklama="C# Döngüler Nelerdir",EklenmeTarihi=DateTime.Now.AddDays(-2),Anasayfa=false,Onay=true,Icerik="C# Delegates HakkındaC# Delegates Hakkında",Resim="1.jpg",CategoryId=1},
                new Blog(){Baslik="C# Fonksiyonları Nelerdir ",Aciklama="C# Fonksiyonları Nelerdir",EklenmeTarihi=DateTime.Now.AddDays(-12),Anasayfa=false,Onay=true,Icerik="C# Delegates HakkındaC# Delegates Hakkında",Resim="2.jpg",CategoryId=2},
                new Blog(){Baslik="C# List Hakkında",Aciklama="C# List Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-3),Anasayfa=true,Onay=true,Icerik="C# Delegates HakkındaC# Delegates Hakkında",Resim="2.jpg",CategoryId=2},
                new Blog(){Baslik="C# Delegates Hakkında",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-7),Anasayfa=true,Onay=true,Icerik="C# Delegates HakkındaC# Delegates Hakkında",Resim="3.jpg",CategoryId=3},
                new Blog(){Baslik="C# Formlar Hakkında",Aciklama="C# Formlar Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-15),Anasayfa=true,Onay=false,Icerik="C# Delegates HakkındaC# Delegates Hakkında",Resim="3.jpg",CategoryId=3},
                new Blog(){Baslik="C# Sınıflar Hakkında",Aciklama="C# Sınıflar Hakkında",EklenmeTarihi=DateTime.Now.AddDays(12),Anasayfa=false,Onay=true,Icerik="C# Delegates HakkındaC# Delegates Hakkında",Resim="4.jpg",CategoryId=4},
                new Blog(){Baslik="C# MVC Hakkında",Aciklama="C# MVC Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-11),Anasayfa=true,Onay=true,Icerik="C# Delegates HakkındaC# Delegates Hakkında",Resim="5.jpg",CategoryId=4},
            };
            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}