using Odev3.DataAccess.Abstract;
using Odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.Business;

public class InstructorManager
{
    private readonly IInstructorDal _instractorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instractorDal = instructorDal;
    }

    public void Add(Instructor instructor)
    {
        _instractorDal.Add(instructor);
    }

    public void Delete(int id)
    {
        _instractorDal.Delete(id);
    }

    public List<Instructor> GetAll()
    {
        return _instractorDal.GetAll();
    }

    public void Update(Instructor instructor)
    {
        _instractorDal.Update(instructor);
    }

    public void Read(Instructor instructor)
    {
        _instractorDal.Read(instructor);
    }
}
