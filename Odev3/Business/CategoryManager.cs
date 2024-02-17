using Odev3.DataAccess.Abstract;
using Odev3.DataAccess.Concrete;
using Odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.Business;

public class CategoryManager
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Delete(int id)
    {
        _categoryDal.Delete(id);
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public void Update(Category category)
    {
        _categoryDal.Update(category);
    }

    public void Read(int id)
    {
        _categoryDal.Read(id);
    }
}
