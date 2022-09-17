using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CategoryService
    {
        public CategoryDal categoryDal{ get; set; }
        public CategoryService()
        {
            categoryDal = new CategoryDal();
        }
        public Category GetById(int id)
        {
            return categoryDal.GetById(id);
        }
    }
}
