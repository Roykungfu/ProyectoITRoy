using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor;


namespace ProyectoIT.Controllers
{
    public class LoginController : Controller
    {

		public ActionResult CrearCuenta()
		{
		return View();
		}

		public ActionResult Login()
        {
        return View();
        }

        public ActionResult LoginGoogle()
        {
            return RedirectToAction("Index", "Home");
		}


		public ActionResult OlvidoClave()
		{
			return View();
		}


		public ActionResult logout()
        {
        return RedirectToAction("Login", "Login");  // Redirige perdiendo todo, la seccion, las variables de la vista, el localstore, es como si fuera un refresh 
        }

        public ActionResult EnviarMail()
        {
            return RedirectToAction("RecuperarCuenta", "Login"); 

        }

        public ActionResult RecuperarCuenta() 
        { 
            return View();
        }
       
    }
}
    