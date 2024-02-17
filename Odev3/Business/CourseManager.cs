using Odev3.DataAccess.Abstract;
using Odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.Business;

public class CourseManager
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {

        return _courseDal.GetAll();
    }
    public void Add(Course course)
    {
        _courseDal.Add(course);
    }
    public void Update(Course course)
    {
        _courseDal.Update(course);
    }
    public void Delete(int id)
    {
        _courseDal.Delete(id);
    }
}
