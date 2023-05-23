using System.Diagnostics;
using BlogApp.BusinessLayer.Concrete;
using BlogApp.DataAccessLayer.Abstract;
using BlogApp.DataAccessLayer.EntityFramework;
using BlogApp.DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using BlogApp.Models;

namespace BlogApp.Controllers;

public class CategoryController : Controller
{
    private CategoryManager cm = new CategoryManager(new EfCategoryRepository());

    public IActionResult Index()
    {
        var values = cm.List();
        return View(values);
    }
}