using System;
using System.IO;
using EPlayersASPNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EPlayersMVC.Controllers 
{
    [Route("Equipe")]
    public class EquipeController : Controller
    {
        Equipe equipeModel = new Equipe();

        [Route("Listar")]
        public IActionResult index()
        {

            ViewBag.Equipes = equipeModel.LerTodos();

            return View();

        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form){

            Equipe novaEquipe = new Equipe();
            novaEquipe.IdEquipe = Int32.Parse(form["idEquipe"]);
            novaEquipe.Nome = form["Nome"];
            // novaEquipe.Imagem = form["Imagem"];

            //Inicio Upload

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");
            
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                                    //localhost:5001 + wwwroot/img/ + Equipes + equipe.jpg
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
            }else
            {
                novaEquipe.Imagem = "padrao.png";                
            }

            //Término Upload

            equipeModel.Cadastrar(novaEquipe);
            ViewBag.Equipes = equipeModel.LerTodos();

            return LocalRedirect("~/Equipe/Listar");
        }


        [Route("{id}")]
        public IActionResult Excluir(int id)
        {
            equipeModel.Deletar(id);

            ViewBag.Equipes = equipeModel.LerTodos();

            return LocalRedirect("~/Equipe/Listar");
        }
    }

}