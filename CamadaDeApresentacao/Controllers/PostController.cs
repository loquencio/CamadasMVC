using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CamadaDeApresentacao.Models;

namespace CamadaDeApresentacao.Controllers
{
    public class PostController : Controller
    {
        public ActionResult Lista()
        {
            ICollection<Post> posts = new List<Post>();

            for (int i = 0; i < 10; i++)
            {
                posts.Add(new Models.Post
                {
                    Autor = "Autor do post " + i,
                    Categoria = "Categoria" + i,
                    Data = DateTime.Now.Subtract(TimeSpan.FromDays(i)),
                    Texto = " - Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    Titulo = "Título do post " + i
                }); 
            }

            return View(posts);
        }
    }
}