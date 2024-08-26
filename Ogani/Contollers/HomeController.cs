using Microsoft.AspNetCore.Mvc;
using Ogani.Models.Contexts.Configurations;
using Ogani.Models.Entities;

namespace Ogani.Contollers
{
	public class HomeController : Controller
	{
		public DataContext Db { get; }

		public HomeController(DataContext Db)
		{
			this.Db = Db;
		}
		public IActionResult Index()
		{
			return View();
		}


		public IActionResult Contact()
		{
			return View();
		}
		[HttpPost]

		public IActionResult Contact(string FullName, string Email, string Message)
		{

			var post = new ContactPost
			{
				FullName = FullName,
				Email = Email,
				Message = Message,
				CreatedAt = DateTime.Now


			};

			Db.ContactPosts.Add(post);
			Db.SaveChanges();

			return Json(new
			{
				error = false,
				Message = "Müraciətiniz qəbul  olundu"
			}

				);
		}

        [HttpPost]
        public IActionResult Subscribe(string email)
        {
            var post = new SubscribePost
            {
                Email = email,
                CreatedAt = DateTime.Now
            };


            Db.SubscribePost.Add(post);
            Db.SaveChanges();

            return Json(new
            {
                error = false,
                message = "abone olundu!"
            });
        }
    }
}






