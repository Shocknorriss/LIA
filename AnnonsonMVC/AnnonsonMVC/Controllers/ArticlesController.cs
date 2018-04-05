﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using AnnonsonMVC.ViewModels;
using Domain.Interfaces;

namespace AnnonsonMVC.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly IArticleService _articelService;
        private readonly ICategoryService _categoryService;
        private readonly IStoreService _storeService;
        private readonly ICompanyService _companyService;

        public ArticlesController(IArticleService articleService, ICategoryService categoryService, IStoreService storeService, ICompanyService companyService)
        {
            _articelService = articleService;
            _categoryService = categoryService;
            _storeService = storeService;
            _companyService = companyService;
        }

        public IActionResult Index()
        {
            var articles = _articelService.GetAll().Where(t => t.UserId == 2);
            return View( articles.ToList());
        }

        public IActionResult Create()
        {
            ViewData["CompanyId"] = new SelectList(_companyService.GetAll(), "CompanyId", "Name");
            ViewData["CategoryId"] = new SelectList(_categoryService.GetAll(), "CategoryId", "Name");
            ViewData["StoreId"] = new SelectList(_storeService.GetAll(), "StoreId", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ArticelViewModel article)
        {
            if (ModelState.IsValid)
            {

                //var slug = article.Name.Replace(" ", "-").ToLower();
                //article.Slug = slug;

                //article.UserId = 2;

                //_context.Add(article);
                //await _context.SaveChangesAsync();

                //var imageName = "aid" + article.ArticleId + "-" + Guid.NewGuid();
                //article.ImageFileName = imageName;

                //_context.Update(article);
                //await _context.SaveChangesAsync();


                return RedirectToAction(nameof(Index));
            }
            //ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "Company");
            //ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "Category");
            return View();
        }
      }
    }

