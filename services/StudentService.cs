using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using app.Models;
using app.Controllers;
using Microsoft.EntityFrameworkCore;

public class StudentService : IStudentService
{
    private readonly ApplicationDbContext dbContext;

    public StudentService(ApplicationDbContext dbContext){
        this.dbContext = dbContext;
    }

    public async Task<List<Student>?> GetAll()
    {
        var students = dbContext.Students.ToListAsync();
        return await students;
    }

    public async Task<Student?> GetById(long idSystem)
    {
        var students = dbContext.Students.FirstOrDefaultAsync(param=>param.IdSystem==idSystem);
        return await students;
    }
    [HttpPost]
    public async Task<bool?> Save(Student student)
    {
        var maxInt = dbContext.Students.Max(x=>x.IdSystem);
        student.IdSystem = maxInt+1;
        await dbContext.Students.AddAsync(student);
        dbContext.SaveChanges();
        return true;
    }
    [HttpPut]

    public async Task<bool?> Update(Student student)
    {
        Console.WriteLine(student.IdSystem);
        var result = await dbContext.Students.FirstOrDefaultAsync(param=>param.IdSystem==student.IdSystem);
        if(result==null){
            return false;
        }
        Console.WriteLine(result);
        result.Name = student.Name;
        result.Email = student.Email;
        result.PhoneNumber = student.PhoneNumber;
        result.StudentCode = student.StudentCode;
        result.StudentGrade = student.StudentGrade;
        dbContext.SaveChanges();
        return true;
    }
}