using ClassicalDanceWeb.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicalDanceWeb.Data
{
    public interface IDanceRepository
    {
        Task<List<Student>> GetStudents();
        Task<Student> GetStudent(int id);

    }
}
