﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstApp.Models;

namespace FirstApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var list= new List<StudentVm>(){
            new StudentVm() {Id=1, Name="one",Address="Addr 1"},
             new StudentVm() {Id=2, Name="Two",Address="Addr 2"}


        };
        return View(list);
    }

    [HttpPost]
    //  public IActionResult New(TestVm)
    // {
    //     return Ok(vm);
    // }
     public IActionResult Privacy()
    {
        return View();
    }
     public IActionResult Test()
    {
        return View();
    }
    public IActionResult Test1(){
        return View();
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
