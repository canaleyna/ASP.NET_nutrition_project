using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using EntityLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfUserDayTimeDal : GenericRepository<UserDayTime>, IUserDayTimeDal
    {
        public List<UserDayTimeDetailDTO> GetUserDayTimeDetails(int id)
        {
            using (var context = new Context())
            {
                var result = from user in context.Users
                             join userDayTime in context.UserDayTimes
                             on user.UserID equals userDayTime.UserID
                             join dayTime in context.DayTimes
                             on userDayTime.DayTimeID equals dayTime.DayTimeID
                             join day in context.Days
                             on userDayTime.DayID equals day.DayID
                             join food in context.Foods
                             on userDayTime.FoodID equals food.FoodID
                             join userDayTimeDigestion in context.UserDayTimeDigestions
                             on userDayTime.DayTimeID equals userDayTimeDigestion.UserDayTimeID
                             join digestion in context.Digestions
                             on userDayTimeDigestion.DigestionID equals digestion.DigestionID
                             where user.UserID == id

                             select new UserDayTimeDetailDTO
                             {
                                 FirstName = user.Name,
                                 LastName = user.Surname,
                                 DayName = day.DayName,
                                 DayTimeName = dayTime.DayTimeName,
                                 FoodName = food.FoodName,
                                 Calori = food.FoodCalorie,
                                 Digestion = digestion.DigestionName
                             };

                return result.ToList();

            }
        }
    }

}

