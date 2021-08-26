using System.Collections.Generic;
using EPlayersASPNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EPlayersMVC.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
        Jogador jogadorModel = new Jogador();


        [TempData]
        public string Mensagem {get; set;}

        public IActionResult Index()
        {
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
           List<string> jogadoresCSV = jogadorModel.LerTodasLinhasCSV("Database/jogador.csv");

            var logado = jogadoresCSV.Find(
                x =>
                x.Split(";")[3] == form["Email"] && 
                
                x.Split(";")[4] == form["Senha"]
            );

            if (logado != null)
            {
                HttpContext.Session.SetString("_UserName", logado.Split(";")[2]);
                return LocalRedirect ("~/");

            }

               Mensagem = "Dados incorretos, tente novamente...";
               return LocalRedirect("~/Login");

        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("_UserName");
            return LocalRedirect ("~/");
        }
    } 
}