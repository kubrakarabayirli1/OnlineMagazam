using System.Collections.Generic;
using System.Data.Entity;

namespace OnlineMagazam.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() {Name="Elbise", Description="Giyim" },
                 new Category() {Name="Çizme", Description="Ayakkabı" }
            };
            foreach (var item in kategoriler)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product () {Name="Zara",Description="Giyim Ürünleri",Price=499,Stock=10,IsHome=true,CategoryId=1,Image="giyim1.jpg",IsApproved=true,IsFeatured=false },
                    new Product () {Name="Bot",Description="Ayakkabı Ürünleri",Price=499,Stock=10,IsHome=false,CategoryId=2,Image="ayakkabı1.jpg",IsApproved=true,IsFeatured=false },
                        new Product () {Name="Çizme",Description="Ayakkabı Ürünleri",Price=3999,Stock=10,IsHome=true,CategoryId=2,Image="ayakkabı2.jpg",IsApproved=true,IsFeatured=true }
            };
            foreach (var item in urunler)
            {
                context.Products.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}