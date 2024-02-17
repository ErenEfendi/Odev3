using Odev3.DataAccess.Abstract;
using Odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.DataAccess.Concrete;

public class InstructorDal: IInstructorDal
{
    List<Instructor> instructors;

    public InstructorDal()
    {
        Instructor instructor1 = new Instructor() { Id = 1, FirstName = "Engin",LastName = "Demiroğ",Courses = new List<Course>().Where(c => c.CourseName =="Engin").ToList()};
        Instructor instructor2 = new Instructor() { Id = 2, FirstName = "Halit", LastName = "Kalaycı", Courses = new List<Course>().Where(c => c.CourseName == "Halit").ToList() };
        instructors = new List<Instructor>() { instructor1, instructor2 };
    }

    public void Add(Instructor instructor)
    {
        instructors.Add(instructor);
        Console.WriteLine(instructor.FirstName+" Added!");
    }

    //Method 2 used

    //public void Delete(int instructorId)
    //{
    //    if(InstructorById(instructorId) == null)
    //    {
    //        Console.WriteLine("There is no instructor with that id");
    //    }
    //    else
    //    {
    //        instructors.Remove(InstructorById(instructorId));
    //        Console.WriteLine("Instructor with ID: " + instructorId + " deleted!");
    //    }
    //}

    public void Delete(int instructorId)
    {
        foreach(Instructor instructor in instructors) 
        {
            if(instructor.Id == instructorId)
            {
                instructors.Remove(instructor);
                Console.WriteLine("Instructor Name: "+instructor.FirstName+" "+instructor.LastName+" deleted!");
                break;
            }
        }   
    }

    public List<Instructor> GetAll()
    {
        return instructors;
    }

    public void Read(Instructor instructor)
    {
        Console.WriteLine($"Name: {instructor.FirstName} {instructor.LastName}");

        if (instructor.Courses.Any())
        {
            Console.WriteLine("Courses:");
            foreach (var course in instructor.Courses)
            {
                Console.WriteLine($"- {course.CourseName}");
            }
        }
        else
        {
            Console.WriteLine("This instructor does not have any courses.");
        }
    }

    public void Update(Instructor updatedInstructor)
    {
        var existingInstructor = instructors.FirstOrDefault(c => c.Id == updatedInstructor.Id);
        if(existingInstructor != null)
        {
            
            existingInstructor.FirstName = updatedInstructor.FirstName;
            existingInstructor.LastName = updatedInstructor.LastName;
            existingInstructor.NationalIdentity = updatedInstructor.NationalIdentity;
            Console.WriteLine("Instructor updated!");

        }
        else
        {
            Console.WriteLine("Instructor not found!");
        }
    }

    //Method 2 for finding the wanted instructor. Can be applied on other Dal classes

    //public Instructor InstructorById(int instructorId)
    //{
    //    return instructors.Find(x => x.Id == instructorId);

    //}
}
