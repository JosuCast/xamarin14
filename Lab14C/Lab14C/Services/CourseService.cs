using Lab14C.DataContext;
using Lab14C.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Lab14C.Services
{
    public class CourseService
    {
        private readonly AppDbContext _context;

        public CourseService() => _context = App.GetContext();

        public bool Create(Course course)
        {
            try
            {
                _context.Courses.Add(course);
                _context.SaveChanges();
                return true;

            }catch(Exception)
            {
                return false;
            }
        }

        public bool CreateRange(List<Course> courses)
        {
            try
            {
                _context.Courses.AddRange(courses);
                _context.SaveChanges();
                return true;

            }catch(Exception)
            {
                return false;
            }
        }

        public List<Course> Get()
        {
            return _context.Courses.ToList();
        }

        public List<Course> GetByText(string text)
        {
            return _context.Courses.Where(x => x.Name.Contains(text)).ToList();
        }
    }
}
