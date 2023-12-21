using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FoodManager : IFoodService
    {
        IFoodDal _foodDal;

        public FoodManager(IFoodDal foodDal)
        {
            _foodDal = foodDal;
        }

        public void FoodAdd(Food food)
        {
            _foodDal.Insert(food);
        }

        public void FoodDelete(Food food)
        {
            
            _foodDal.Delete(food);
        }

        public void FoodUpdate(Food food)
        {
            _foodDal.Update(food);
        }

        public Food GetByID(int id)
        {
            return _foodDal.Get(x => x.FoodID == id);
        }

        public List<Food> GetList()
        {
            return _foodDal.List();
        }
    }
}
