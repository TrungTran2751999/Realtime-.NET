using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using app.Models;
using Microsoft.AspNetCore.Authorization;
using System.Text.Json;


namespace app.Controllers;
// [ApiController]
[Route("student")]
public class StudentController : Controller
{
    private ApplicationDbContext dbContext;
    public StudentController(ApplicationDbContext dbContext){
        this.dbContext = dbContext;
    }
    // [Authorize(Roles = "ADMIN,USER")]
    public ActionResult Index(){
        var student = dbContext.Students.ToList();
        ViewBag.result = student;
        return View();
    }
    [Route("create")]
    public ActionResult Create(){
        // var student = dbContext.Students.ToList();
        // ViewBag.result = student;
        return View();
    }
    [Route("detail")]
    public ActionResult Update(long id){
        var student = dbContext.Students.FirstOrDefault(x=>x.IdSystem==id);
        ViewBag.result = student;
        return View();
    }
    [Route("chat")]
    public ActionResult Chat(){
        return View();
    }
}
