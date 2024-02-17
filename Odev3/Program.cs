
using Odev3.Business;
using Odev3.DataAccess.Abstract;
using Odev3.DataAccess.Concrete;
using Odev3.Entities;

namespace Odev3
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            InstructorManager instructorManager = new InstructorManager(new InstructorDal());
            CourseManager courseManager = new CourseManager(new CourseDal());
            List<Instructor> instructors = instructorManager.GetAll();
            List<Course> courses = courseManager.GetAll();
            
            
            Course course10 = new Course() { Id = 10, CourseName = "Python Hazırlık", Description=" Python 3.12"};
            courseManager.Add(course10);
            courseManager.Delete(5);
            
            foreach (Course course in courses)
            {
                Console.WriteLine("Course ID: "+course.Id+" Course Name: " + course.CourseName + " | " + course.Description);
            }

            foreach (Instructor instructor in instructors)
            {
                Console.WriteLine("Instructor Name: "+instructor.FirstName+" "+instructor.LastName);
            }





        }
    }
}



