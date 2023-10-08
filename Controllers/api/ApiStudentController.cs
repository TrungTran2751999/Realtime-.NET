using app.Controllers;
using app.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
[ApiController]
[Route("api/student")]
public class ApiStudentController:Controller{
    private IStudentService studentService;
    private ApplicationDbContext dbContext;
    public ApiStudentController(ApplicationDbContext dbContext, IStudentService studentService){
        this.dbContext=dbContext;
        this.studentService = studentService;
    }
    // [Authorize(Roles = "ADMIN,USER")]
    public async Task<IActionResult> GetAll(){
        var students = await studentService.GetAll();
        return Ok(students);
    }
    [Route("{id}")]
    public async Task<IActionResult> GetById(long id){
        var student = await studentService.GetById(id);
        return Ok(student);
    }
    // [Authorize(Roles = "ADMIN,USER")]
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Student student){
        var result = await studentService.Save(student);
        return Ok(result);
    }

    [HttpPut]
    // [Authorize(Roles = "ADMIN")]
    public async Task<IActionResult> Update([FromBody] Student student){
        var result = await studentService.Update(student);
        if(result==false){
            return BadRequest("NOT");
        }
        return Ok(result);
    }
}