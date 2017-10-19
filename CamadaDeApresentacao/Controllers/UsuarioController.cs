using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CamadaDeApresentacao.Models;

namespace CamadaDeApresentacao.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Editar()
        {
            Usuario u = new Usuario
            {
                UsuarioID = 1,
                Nome = "Felipe",
                Email = "teste@teste.com",
                Cadastro = DateTime.Now,
                Descricao = "É um rapaz.",
                Senha = "teste"
            };

            return View(u);
        }
    }
}