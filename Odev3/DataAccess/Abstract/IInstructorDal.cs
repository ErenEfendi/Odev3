using Odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.DataAccess.Abstract;

public interface IInstructorDal
{
    void Add(Instructor instructor);
    void Read(Instructor instructor);
    void Update(Instructor ınstructor);
    void Delete(int id);

    List<Instructor> GetAll();
}
