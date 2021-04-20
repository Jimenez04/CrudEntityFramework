using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudEntityFramework.BD;
using CrudEntityFramework.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudEntityFramework.Controllers
{
    public class UsuariosController : Controller
    {

        private readonly ApplicationDBContext context;


        //para crear contructores  ctor

        public UsuariosController(ApplicationDBContext context)
        {
            this.context = context;
        }


        // GET: UsuariosController
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await context.Usuario.ToListAsync());
        }

        [HttpGet]
        public IActionResult Nuevo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Nuevo(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                context.Usuario.Add(usuario);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Editar(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            Usuario usuario = await context.Usuario.FindAsync(Id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                context.Usuario.Update(usuario);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        [HttpGet]
        public async Task<IActionResult> Detalle (int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            Usuario usuario = await context.Usuario.FindAsync(Id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        [HttpGet]
        public async Task<IActionResult> Eliminar(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            Usuario usuario = await context.Usuario.FindAsync(Id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }


        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Eliminaaaaaaar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                context.Usuario.Remove(usuario);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

    }
}
