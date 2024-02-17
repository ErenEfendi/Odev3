using Odev3.DataAccess.Abstract;
using Odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.DataAccess.Concrete;

public class CourseDal : ICourseDal
{
    List<Course> courses;

    public CourseDal()
    {
        Course course1 = new Course() {Id = 1, CourseName = "Senior Yazılım Geliştirici Yetiştirme Kampı", Description = ".NET",Instructors = new List<Instructor>().Where(i => i.FirstName == "Engin" && i.LastName == "Demiroğ").ToList()};
        Course course2 = new Course() { Id = 2, CourseName = "Yazılım Geliştirici Yetiştirme Kampı", Description = "(C# + ANGULAR)", Instructors = new List<Instructor>().Where(i => i.FirstName == "Engin" && i.LastName == "Demiroğ").ToList() };
        Course course3 = new Course() { Id = 3, CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı", Description = "Python & Selenium", Instructors = new List<Instructor>().Where(i => i.FirstName == "Halit" && i.LastName == "Kalaycı").ToList() };
        Course course4 = new Course() { Id = 4, CourseName = "(2022) Yazılım Geliştirici Yetiştirme Kampı", Description = "JAVA", Instructors = new List<Instructor>().Where(i => i.FirstName == "Engin" && i.LastName == "Demiroğ").ToList() };
        Course course5 = new Course() { Id = 5, CourseName = "Yazılım Geliştirici Yetiştirme Kampı", Description = "JavaScript", Instructors = new List<Instructor>().Where(i => i.FirstName == "Engin" && i.LastName == "Demiroğ").ToList() };
        Course course6 = new Course() { Id = 6, CourseName = "Yazılım Geliştirici Yetiştirme Kampı", Description = "JAVA + REACT", Instructors = new List<Instructor>().Where(i => i.FirstName == "Engin" && i.LastName == "Demiroğ").ToList() };
        Course course7 = new Course() { Id = 7, CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı", Description = "C#", Instructors = new List<Instructor>().Where(i => i.FirstName == "Engin" && i.LastName == "Demiroğ").ToList() };
        Course course8 = new Course() { Id = 8, CourseName = "Programlamaya Giriş İçin Temel Kurs", Description = "PYTHON, JAVA, C#", Instructors = new List<Instructor>().Where(i => i.FirstName == "Engin" && i.LastName == "Demiroğ").ToList() };
        courses = new List<Course>() { course1, course2, course3, course4, course5, course6, course7, course8 };
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }

    public void Delete(int courseId)
    {
       foreach (Course course in courses)
        {
            if (course.Id == courseId)
            {
                courses.Remove(course);
                Console.WriteLine("Course Name: "+course.CourseName+" "+course.Description+" Deleted");
                break;
            }
        }
    }

    public List<Course> GetAll()
    {
        return courses;
    }

    public void Read(int courseId)
    {
        var course = courses.FirstOrDefault(c => c.Id == courseId);
        if (course != null)
        {
            Console.WriteLine($"Course Id: {course.Id}");
            Console.WriteLine($"Course Name: {course.CourseName}");
            Console.WriteLine($"Description: {course.Description}");

            if (course.Instructors.Any())
            {
                Console.WriteLine("Instructors:");
                foreach (var instructor in course.Instructors)
                {
                    Console.WriteLine($"- {instructor.FirstName} {instructor.LastName}");
                }
            }
            else
            {
                Console.WriteLine("This course does not have any instructors.");
            }
        }
        else
        {
            Console.WriteLine("Course not found!");
        }
    }

    public void Update(Course updatedCourse)
    {
        var existingCourse = courses.FirstOrDefault(c => c.Id == updatedCourse.Id);
        if (existingCourse != null)
        {
            existingCourse.CourseName = updatedCourse.CourseName;
            existingCourse.Description = updatedCourse.Description;

            Console.WriteLine("Course updated!");
        }
        else
        {
            Console.WriteLine("Course not found!");
        }
    }
}
