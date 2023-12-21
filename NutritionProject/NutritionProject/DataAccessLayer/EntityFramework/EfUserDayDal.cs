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
    public class EfUserDayDal : GenericRepository<UserDay>, IUserDayDal
    {
        public List<UserDayDetailDTO> GetUserDayDetails(int id)
        {
            using (var context = new Context())
            {
                var result = from user in context.Users
                             join userDay in context.UserDays
                             on user.UserID equals userDay.UserID
                             join day in context.Days
                             on userDay.DayID equals day.DayID
                             join water in context.WaterAmounts
                             on userDay.WaterAmountID equals water.WaterAmountID
                             join sleep in context.Sleeps
                             on userDay.SleepID equals sleep.SleepID
                             join stress in context.Stresses
                             on userDay.StressID equals stress.StressID
                             where user.UserID == id

                             select new UserDayDetailDTO
                             {
                                 FirstName = user.Name,
                                 LastName = user.Surname,
                                 DayName = day.DayName,
                                 Water = water.Glass,
                                 Sleep = sleep.SleepHour,
                                 Stress = stress.StressName,
                                 Step = userDay.StepCount
                             };
                return result.ToList();

            }
        }
    }
}
