using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCApp.Data;

namespace MVCApp.Bussiness
{
  public class StudentService : IStudentService
  {
    private readonly IStudentRepository _studentRepository;

    public StudentService()
    {
      _studentRepository = new StudentRepository();
    }


    public bool Save()
    {
      throw new NotImplementedException();
    }
  }
}
