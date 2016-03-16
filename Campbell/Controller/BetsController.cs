using System.Linq; 
using System.Web.Mvc;
using SportBet.Models;
public class BetsController : Controller { 
    private ApplicationDbContext _dbContext; 
    public BetsController() { 
        _dbContext = new ApplicationDbContext(); 
    }
    // GET: Videos
    public ActionResult Index() {
        var bets = _dbContext.Bets.ToList(); 
        return View(bets); 
    }

    public ActionResult Create() {
        return View(); 
    }

}