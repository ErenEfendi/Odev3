using Odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.DataAccess.Abstract;

public interface ICourseDal
{
    void Add(Course course);
    void Read(int id);
    void Update(Course course);
    void Delete(int id);

    List<Course> GetAll();

}
