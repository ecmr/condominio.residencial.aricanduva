﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebCondominio.Residencial.Context;
using WebCondominio.Residencial.Models;

namespace WebCondominio.Residencial.Controllers
{
    public class MoradoresController : Controller
    {
        private readonly Contexto _context;

        public MoradoresController(Contexto context)
        {
            _context = context;
        }

        // GET: Moradores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contatos.ToListAsync());
        }

        // GET: Moradores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var morador = await _context.Contatos
                .FirstOrDefaultAsync(m => m.IdMorador == id);
            if (morador == null)
            {
                return NotFound();
            }

            return View(morador);
        }

        // GET: Moradores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Moradores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMorador,Bloco,Apartamento")] Morador morador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(morador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(morador);
        }

        // GET: Moradores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var morador = await _context.Contatos.FindAsync(id);
            if (morador == null)
            {
                return NotFound();
            }
            return View(morador);
        }

        // POST: Moradores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMorador,Bloco,Apartamento")] Morador morador)
        {
            if (id != morador.IdMorador)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(morador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoradorExists(morador.IdMorador))
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
            return View(morador);
        }

        // GET: Moradores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var morador = await _context.Contatos
                .FirstOrDefaultAsync(m => m.IdMorador == id);
            if (morador == null)
            {
                return NotFound();
            }

            return View(morador);
        }

        // POST: Moradores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var morador = await _context.Contatos.FindAsync(id);
            _context.Contatos.Remove(morador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoradorExists(int id)
        {
            return _context.Contatos.Any(e => e.IdMorador == id);
        }
    }
}
