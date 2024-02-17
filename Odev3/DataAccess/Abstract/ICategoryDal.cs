using Odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.DataAccess.Abstract;

public interface ICategoryDal
{
    void Add(Category category);

    void Update(Category category);

    void Delete(int id);

    void Read(int id);

    List<Category> GetAll();
}
