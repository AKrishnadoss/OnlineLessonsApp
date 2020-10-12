using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ClassicalDanceWeb.Data.Entities;
using ClassicalDanceWeb.Models;
using ClassicalDanceWeb.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassicalDanceWeb.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private IMapper _mapper;

        private IStudentModel _studentModel;
        public StudentController(IMapper mapper, IStudentModel studentModel)
        {
            _mapper = mapper;
            _studentModel = studentModel;
        }

        [HttpGet]
        public async Task<ActionResult<List<StudentViewModel>>> GetStudents()
        {
            //List<Student> students = new List<Student>();
            //students.Add(new Student { Id=1,FirstName="Akila",LastName="Krishnadoss" });
            //students.Add(new Student { Id = 2, FirstName = "Aadhirai", LastName = "Niranjan" });

            List<Student> students = await _studentModel.GetStudents();

            return Ok(_mapper.Map<List<Student>, List<StudentViewModel>>(students));



        }


        //[HttpGet]
        //public async Task<ActionResult<StudentViewModel>> GetStudentById(int id)
        //{
        //    //List<Student> students = new List<Student>();
        //    //students.Add(new Student { Id=1,FirstName="Akila",LastName="Krishnadoss" });
        //    //students.Add(new Student { Id = 2, FirstName = "Aadhirai", LastName = "Niranjan" });

        //    Student student = await _studentModel.GetStudent(id);

        //    return Ok(_mapper.Map<Student, StudentViewModel>(student));



        //}
    }
}
