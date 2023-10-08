using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private ApplicationDbContext dbContext;
    public HomeController(ApplicationDbContext dbContext){
        this.dbContext = dbContext;
    }

    // public HomeController(ILogger<HomeController> logger)
    // {
    //     _logger = logger;
    // }

    public IActionResult Index()
    {
        // var student = from nv in dbContext.NhanVien join pb in dbContext.PhongBan on nv.MaPB equals pb.id
        //               select new {nv,pb};
        // Console.WriteLine(student);
        // ViewBag.result = student;
        return View();
    }
    // [Route("{id}")]
    public IActionResult Privacy(long id)
    {
        // var student = dbContext.NhanVien.FirstOrDefault(item=>item.id==id);
        // ViewBag.result = student;
        return View();
    }
    [Route("create")]
    public IActionResult Create()
    {
        // var student = dbContext.PhongBan.ToList();
        // ViewBag.result = student;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    // private ApplicationDbContext dbContext;
    // public StudentController(ApplicationDbContext dbContext){
    //     this.dbContext = dbContext;
    // }
    // [Authorize(Roles = "ADMIN,USER")]
    // public async Task<ActionResult> Index(){
    //     var student = dbContext.Students.ToList();
    //     ViewBag.result = student;
    //     return View();
    // }
}
