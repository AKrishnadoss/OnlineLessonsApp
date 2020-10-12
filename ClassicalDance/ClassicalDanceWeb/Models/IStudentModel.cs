using ClassicalDanceWeb.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicalDanceWeb.Models
{
    public interface IStudentModel
    {
        Task<List<Student>> GetStudents();
        Task<Student> GetStudent(int id);

    }
}
