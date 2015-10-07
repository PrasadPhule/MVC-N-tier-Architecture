using MVCApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.Data
{
  public class StudentRepository : IStudentRepository
  {
    private readonly scaffEntities _db;

    public StudentRepository()
    {
      _db = new scaffEntities();
    }

    public bool Save(StudentEntity studnetEntity)
    {
      Student student;

      if (studnetEntity.Id == 0)
      {
        student = new Student();
      }
      else
      {
        student = _db.Students.SingleOrDefault(x=>x.Id == studnetEntity.Id);//1 hit
      }
      //mapping
      //poco == studnetEntity
      _db.Students.Add(student);
      _db.SaveChanges();
      return true;
    }

    public bool Save()
    {
      throw new NotImplementedException();
    }
  }
}
