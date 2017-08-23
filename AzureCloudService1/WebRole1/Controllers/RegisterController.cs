using System.Linq;
using System.Web.Mvc;
using WebRole1.Models;

namespace WebRole1.Controllers
{
	public class RegisterController : Controller
	{
		// GET: Register
		[HttpPost]
		public ActionResult Registration(Register model)
		{

			using (var db = new Lab9Context())
			{
				var s = db.Registers.Where(x => x.UserName == model.UserName).FirstOrDefault();
				if (s == null)
				{
					db.Registers.Add(model);
					db.SaveChanges();
					return RedirectToAction("Calculation", model);

				}

			};
			return RedirectToAction("Index", "Home");
		}

		[HttpPost]
		public ActionResult LoginUser(Login model)
		{
			using (var db = new Lab9Context())
			{
				var s = db.Registers.Where(x => x.UserName == model.UserName).FirstOrDefault();
				if (s != null)
				{
					if (s.Password == model.Password)
					{
						db.Logins.Add(model);
						db.SaveChanges();
						//return Redirect(Url.Action("Calculation","Home", new { id = model.UserName }));

						return RedirectToAction("Calculation", model);

					}
				}
			};
			return RedirectToAction("Index", "Home");
		}


		[HttpPost]
		public ActionResult Logout(string Username)
		{
			using (var db = new Lab9Context())
			{
				var s = db.Logins.Where(x => x.UserName == Username).FirstOrDefault();
				if (s != null)
				{
					db.Logins.Remove(s);
					db.SaveChanges();

					return RedirectToAction("Index", "Home");
				}
			};
			return RedirectToAction("Index", "Home");
		}

		public ActionResult Calculation(Login model)
		{
			if (model==null)
			{
				return RedirectToAction("Index", "Home");
			}
			return View(model);
		}
	}
}