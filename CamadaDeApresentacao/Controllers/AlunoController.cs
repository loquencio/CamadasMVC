using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CamadaDeApresentacao.Models;

namespace CamadaDeApresentacao.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Detalhes()
        {
            Aluno a = new Models.Aluno
            {
                AlunoID = 1,
                Nome = "Jonas Hirata",
                Email = "jojo@k19.com"
            };
            return View(a);
        }

        public ActionResult Lista()
        {
            ICollection<Aluno> alunos = new List<Aluno>();

            for (int i = 0; i < 5; i++)
            {
                Aluno a = new Aluno
                {
                    AlunoID = i,
                    Nome = "Aluno " + i,
                    Email = "Email " + i
                };

                alunos.Add(a);
            }

            return View(alunos);
        }

        public ActionResult Editar(Aluno n)
        {
            Aluno a = new Aluno
            {
                AlunoID = 1,
                Nome = n.Nome == null ? "Felipe" : n.Nome,
                Email = n.Email == null ? "teste@teste.com" : n.Email
            };

            return View(a);
        }
    }
}