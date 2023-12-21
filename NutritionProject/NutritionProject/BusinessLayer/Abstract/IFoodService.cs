using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IFoodService
    {
        List<Food> GetList();
        void FoodAdd(Food food);
        Food GetByID(int id);
        void FoodDelete(Food food);
        void FoodUpdate(Food food);
    }
}
