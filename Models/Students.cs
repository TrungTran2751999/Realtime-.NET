using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models;
public class Student{
    [Key]
    [Column("idSystem")]
    public long IdSystem{get;set;}
    [Column("name")]
    public string? Name{get;set;}
    [Column("age")]
    public int? Age{get;set;}
    [Column("email")]
    public string? Email{get;set;}
    [Column("phoneNumber")]
    public string? PhoneNumber{get;set;}
    [Column("studentCode")]
    public string? StudentCode{get;set;}
    [Column("studentGrade")]
    public string? StudentGrade{get;set;}
}
