using System.Diagnostics;
using BlogApp.BusinessLayer.Concrete;
using BlogApp.DataAccessLayer.Abstract;
using BlogApp.DataAccessLayer.EntityRepository;
using BlogApp.DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using BlogApp.Models;

namespace BlogApp.Controllers;

public class DefaultController : Controller
{

    public PartialViewResult Header()
    {
        return PartialView();
    }
}