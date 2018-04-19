using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TamaGotchi.Models;

namespace TamaGotchi.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/tamagotchies")]
    public ActionResult Index()
    {
      List<TamaPet> allTamagotchies = TamaPet.GetAll();
      return View(allTamagotchies);
    }

    [HttpGet("/")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/tamagotchies")]
    public ActionResult Create()
    {
      TamaPet newTamagotchi = new TamaPet(Request.Form["new-tamagotchi"]);

      List<TamaPet> allTamagotchies = TamaPet.GetAll();
      return View("Index", allTamagotchies);
    }

    [HttpGet("/feed/{id}")]
    public ActionResult Index1(int id)
    {
      TamaPet.Find(id).SetFeed();
      List<TamaPet> allTamagotchies = TamaPet.GetAll();
      return View("Index", allTamagotchies);
    }

    [HttpGet("/sleep/{id}")]
    public ActionResult Index2(int id)
    {
      TamaPet.Find(id).SetRest();
      List<TamaPet> allTamagotchies = TamaPet.GetAll();
      return View("Index", allTamagotchies);
    }

    [HttpGet("/happy/{id}")]
    public ActionResult Index3(int id)
    {
      TamaPet.Find(id).SetPlay();
      List<TamaPet> allTamagotchies = TamaPet.GetAll();
      return View("Index", allTamagotchies);
    }

    [HttpPost("/tamagotchies/decrease")]
        public ActionResult Decrease()
        {
            List<TamaPet> allTamagotchies = TamaPet.GetAll();
            foreach(TamaPet time in allTamagotchies )
            {
            time.Timepass();
            }
            return View("Index", allTamagotchies);
        }
        [HttpPost("/tamagotchies/clear")]
        public ActionResult DeleteAll()
        {
            TamaPet.ClearAll();
            return View();
        }
  }
}
