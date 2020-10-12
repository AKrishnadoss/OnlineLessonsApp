using ClassicalDanceWeb.Data;
using ClassicalDanceWeb.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicalDanceWeb.Models
{
    public class StudentModel :IStudentModel
    {
        private IDanceRepository _repository;
        public StudentModel(IDanceRepository repository)
        {
            _repository = repository;

        }

        public async Task<Student> GetStudent(int id)
        {
            return await _repository.GetStudent(id);
            
        }

        public async Task<List<Student>> GetStudents()
        {
            return await _repository.GetStudents();
        }
    }
}
