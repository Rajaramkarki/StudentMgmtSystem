using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Student_Management_System.Data;
using Student_Management_System.Models;
using Student_Management_System.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Student_Management_System.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDBContext dbContext;

        public StudentsController(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            var student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                isSubscribed = viewModel.isSubscribed
            };

            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var students = await dbContext.Students.ToListAsync();

            return View(students);
            
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var student = await dbContext.Students.FindAsync(id);

            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Student viewModel)
        {
            var student = await dbContext.Students.FindAsync(viewModel.id);

            if(student is not null)
            {
                student.Name = viewModel.Name;
                student.Email = viewModel.Email;   
                student.Phone = viewModel.Phone;    
                student.isSubscribed = viewModel.isSubscribed;

                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Students");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Student viewModel)
        {
            var student = await dbContext.Students.AsNoTracking().FirstOrDefaultAsync(x => x.id == viewModel.id);

            if(student is not null)
            {
                dbContext.Students.Remove(viewModel);

                await dbContext.SaveChangesAsync(); 
            }

            return RedirectToAction("List", "Students");
        }
    }
}
