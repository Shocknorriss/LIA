﻿using AnnonsonMVC.ViewModels;
using Domain.Entites;

namespace AnnonsonMVC.Utilities
{
    internal class ModelToViewModelMapper
    {
        public ModelToViewModelMapper()
        {

        }

        public ArticleEditViewModel ArticleToArticleViewModel(Article article)
        {
            return new ArticleEditViewModel
            { 
                ArticleId = article.ArticleId,
                Name = article.Name,
                Description = article.Description,
                Price = article.Price,
                PriceText = article.PriceText,
                PriceUnit = article.PriceUnit,
                ImagePath = article.ImagePath,
                ImageFileFormat = article.ImageFileFormat,
                ImageFileName = article.ImageFileName,
                ImageWidths = article.ImageWidths,
                PublishBegin = article.PublishBegin,
                PublishEnd = article.PublishEnd,
                ArticleCategory = article.ArticleCategory,
                StoreArticle = article.StoreArticle,
                Company = article.Company,
                UserId = article.UserId,
                CompanyId = article.CompanyId,
                Slug = article.Slug,               
            };
        }

        public ArticleDetailViewModel ArticleDetailViewModel(Article article)
        {
            return new ArticleDetailViewModel
            {
                ArticleId = article.ArticleId,
                Name = article.Name,
                Description = article.Description,
                Price = article.Price,
                PriceText = article.PriceText,
                PriceUnit = article.PriceUnit,
                ImageFileFormat = article.ImageFileFormat,
                ImageFileName = article.ImageFileName,
                ImagePath = article.ImagePath,
                PublishBegin = article.PublishBegin,
                PublishEnd = article.PublishEnd,
                ArticleCategory = article.ArticleCategory,
                StoreArticle = article.StoreArticle,
                Company = article.Company,
                CompanyId = article.CompanyId,
            };
        }
    }
}