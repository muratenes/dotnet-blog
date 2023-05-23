using System.Diagnostics;
using BlogApp.BusinessLayer.Concrete;
using BlogApp.DataAccessLayer.Abstract;
using BlogApp.DataAccessLayer.EntityFramework;
using BlogApp.DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using BlogApp.Models;

namespace BlogApp.Controllers;

public class BlogController : Controller
{
    private BlogManager _blogManager = new BlogManager(new EfBlogRepository());

    public IActionResult Index()
    {
        var blogs = _blogManager.GetWithCategories();
        return View(blogs);
    }
}