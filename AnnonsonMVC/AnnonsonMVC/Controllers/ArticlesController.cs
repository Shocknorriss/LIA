﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using AnnonsonMVC.ViewModels;
using Data.DataContext;

namespace AnnonsonMVC.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly annonsappenContext _context;

        public ArticlesController(annonsappenContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var annonsappenContext = _context.Article.Where(t => t.UserId == 2).Include(t => t.Company);
            return View(await annonsappenContext.ToListAsync());
        }

        public IActionResult Create()
        {
            ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "Name");
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "Name");
            ViewData["StoreId"] = new SelectList(_context.Store, "StoreId", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ArticelViewModel article)
        {
            if (ModelState.IsValid)
            {
                         
                var slug = article.Name.Replace(" ", "-").ToLower();
                article.Slug = slug;

                article.UserId = 2;
                
                _context.Add(article);
                await _context.SaveChangesAsync();

                var imageName = "aid" + article.ArticleId + "-" + Guid.NewGuid();
                article.ImageFileName = imageName;

                _context.Update(article);
                await _context.SaveChangesAsync();

               
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "Company");
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "Category");
            return View();
        }
      }
    }

