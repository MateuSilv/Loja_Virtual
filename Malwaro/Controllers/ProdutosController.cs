using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Malwaro.Data;
using Malwaro.Models;

namespace Malwaro.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly MalwaroContext _context;

        public ProdutosController(MalwaroContext context)
        {
            _context = context;
        }

        // GET: Produtos
        public async Task<IActionResult> Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                
                return RedirectToAction("Login", "Usuarios");
            }

            if (!User.IsInRole(MalwaroRoles.Admin))
            {
                return RedirectToAction("Catalog", "Produtos");
            }

            return View(await _context.Produto.ToListAsync());
        }



        public async Task<IActionResult> Catalog()
        {
            return View(await _context.Produto.ToListAsync());
        }

        public async Task<IActionResult> Filter(string searchString)
        {
            var produtos = await _context.Produto.ToListAsync();
            if (!String.IsNullOrEmpty(searchString))
            {
                produtos = produtos.Where(e => e.Nome.Contains(searchString, StringComparison.OrdinalIgnoreCase) 
                || e.Descricao.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            return View("Catalog", produtos);
        }

        // GET: Produtos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // GET: Produtos/Create
        public IActionResult Create()
        {
            if (!User.Identity.IsAuthenticated)
            {

                
                return RedirectToAction("Login", "Usuarios");
            }

            if (!User.IsInRole(MalwaroRoles.Admin))
            {
                return RedirectToAction("Catalog", "Produtos");
            }

            return View();
        }

        // POST: Produtos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao,Valor,ImageURL,ProdutoCategoria")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }

        // GET: Produtos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                
                return RedirectToAction("Login", "Usuarios");
            }

            if (!User.IsInRole(MalwaroRoles.Admin))
            {
                return RedirectToAction("Catalog", "Produtos");
            }

            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produto.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        // POST: Produtos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao,Valor,ImageURL,ProdutoCategoria")] Produto produto)
        {
            if (id != produto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoExists(produto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }

        // GET: Produtos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produto = await _context.Produto.FindAsync(id);
            _context.Produto.Remove(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoExists(int id)
        {
            return _context.Produto.Any(e => e.Id == id);
        }
    }
}
