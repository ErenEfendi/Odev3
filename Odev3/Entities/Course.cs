using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.Entities;

public class Course
{


    public int Id { get; set; }
    public string CourseName { get; set; }
    public string Description { get; set; }
    public List<Instructor> Instructors { get; set;}
}
