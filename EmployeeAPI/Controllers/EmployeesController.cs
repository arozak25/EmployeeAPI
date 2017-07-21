using EmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        // GET api/values
        [HttpGet]
        public List<Employee> Get()
        {
            using (NorthwindDbContext db = new NorthwindDbContext())
            {
                return db.Employees.ToList();
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            using (NorthwindDbContext db = new NorthwindDbContext())
            {
                return db.Employees.Find(id);
            }
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Employee obj)
        {
            using (NorthwindDbContext db = new NorthwindDbContext())
            {
                db.Employees.Add(obj);
                db.SaveChanges();
                return new ObjectResult("Employee Added Successfully!");

            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Employee obj)
        {
            using (NorthwindDbContext db = new NorthwindDbContext())
            {
                db.Entry<Employee>(obj).State = EntityState.Modified;
                db.SaveChanges();
                return new ObjectResult("Employee Modified Successfully!");

            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using (NorthwindDbContext db = new NorthwindDbContext())
            {
                db.Employees.Remove(db.Employees.Find(id));
                db.SaveChanges();
                return new ObjectResult("Employee Deleted Successfully!");

            }
        }
    }
}
