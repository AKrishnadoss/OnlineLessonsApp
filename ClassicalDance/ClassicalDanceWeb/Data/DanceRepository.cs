using ClassicalDanceWeb.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicalDanceWeb.Data
{
    public class DanceRepository : IDanceRepository
    {
        DanceDBContext _danceDBContext;
        public DanceRepository(DanceDBContext danceDBContext)
        {
            _danceDBContext = danceDBContext;
        }

        public async Task<Student> GetStudent(int id)
        {
            return await _danceDBContext.Students.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Student>> GetStudents()
        {
            return await _danceDBContext.Students.OrderBy(x=>x.Id).ToListAsync();
        }
    }
}
