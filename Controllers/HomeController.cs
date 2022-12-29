using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			List<Slide> slides= new List<Slide>();

            slides.Add(new Slide { Id = 1, Name = "Men Fashion", Image = "carousel-1.jpg", Description = "Drive eCommerce performance with a visual search experience that connects shoppers with products they’ll love." });
            slides.Add(new Slide { Id = 2, Name = "Women Fashion", Image = "carousel-2.jpg", Description = "There are so many terms for women’s clothing, they boggle the mind–dolmen sleeves, pencil skirt, choker, colorblock. The best conjure up colorful images that share with a few words a glorious picture that sticks in your mind as the character walks through the scene." });
            slides.Add(new Slide { Id = 3, Name = "Kids Fashion", Image = "carousel-3.jpg", Description = "Clothing (also known as clothes, apparel, and attire) are items worn on the body. Typically, clothing is made of fabrics or textiles, but over time it has included garments made from animal skin and other thin sheets of materials and natural products found in the environment, put together." });
			ViewBag.Slides = slides;

			List<Category> categories = new List<Category>();
			categories.Add(new Category { Id = 1, Name = "Clothes", Image = "cat-1.jpg"});
            categories.Add(new Category { Id = 2, Name = "Camera", Image = "cat-2.jpg" });
            categories.Add(new Category { Id = 3, Name = "Shoes", Image = "cat-3.jpg" });
            categories.Add(new Category { Id = 4, Name = "Cosmetics", Image = "cat-4.jpg" });
			ViewBag.Categories = categories;

            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id=1,
                    Name = "Camera",
                    Image= "product-1.jpg",
                    Price=130.00
                },

				 new Product
				{
					Id=2,
					Name = "SweatShirt",
					Image= "product-2.jpg",
					Price=50.00
				},


			 new Product
				{
					Id=3,
					Name = "Lamp",
					Image= "product-3.jpg",
					Price=80.00
				},
			  new Product
				{
					Id=4,
					Name = "Shoes",
					Image= "product-4.jpg",
					Price=40.00
				},
			   new Product
				{
					Id=5,
					Name = "drone",
					Image= "product-5.jpg",
					Price=200.00
				},
				new Product
				{
					Id=6,
					Name = "Watch",
					Image= "product-6.jpg",
					Price=300.00
				},
				 new Product
				{
					Id=7,
					Name = "Blouse",
					Image= "product-7.jpg",
					Price=20.00
				},

			 new Product
				{
					Id=8,
					Name = "Cosmetic",
					Image= "product-8.jpg",
					Price=65.00
				}};

            return View(products);
        }
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult ShopDetail()
        {
			List<Product> products1 = new List<Product>();
			
			products1.Add(new Product { Id = 1, Name = "Camera", Price = 120.00,Image= "product-1.jpg"});
			products1.Add(new Product { Id = 2, Name = "Sweatshirt", Price = 20.00, Image = "product-2.jpg"});
            products1.Add(new Product { Id = 3, Name = "Lamp", Price = 30.00, Image = "product-3.jpg" });
            products1.Add(new Product { Id = 4, Name = "Shoes", Price = 55.00, Image = "product-4.jpg" });
            products1.Add(new Product { Id = 5, Name = "Drone", Price = 69.00, Image = "product-5.jpg" });
            ViewBag.Products = products1;

			string description = "Eos no lorem eirmod diam diam, eos elitr et gubergren diam sea. Consetetur vero aliquyam invidunt duo dolores et duo sit. Vero diam ea vero et dolore rebum, dolor rebum eirmod consetetur invidunt sed sed et, lorem duo et eos elitr, sadipscing kasd ipsum rebum diam. Dolore diam stet rebum sed tempor kasd eirmod. Takimata kasd ipsum accusam sadipscing, eos dolores sit no ut diam consetetur duo justo est, sit sanctus diam tempor aliquyam eirmod nonumy rebum dolor accusam, ipsum kasd eos consetetur at sit rebum, diam kasd invidunt tempor lorem, ipsum lorem elitr sanctus eirmod takimata dolor ea invidunt.Dolore magna est eirmod sanctus dolor, amet diam et eirmod et ipsum. Amet dolore tempor consetetur sed lorem dolor sit lorem tempor. Gubergren amet amet labore sadipscing clita clita diam clita. Sea amet et sed ipsum lorem elitr et, amet et labore voluptua sit rebum. Ea erat sed et diam takimata sed justo. Magna takimata justo et amet magna et.";
			Product product = new Product();
			product.Id = 1;
			product.Name = "Camera";
			product.Image = "product-1.jpg";
			product.Price = 100.00;
			product.Description = description;

            return View(product);

        }
    }
}
