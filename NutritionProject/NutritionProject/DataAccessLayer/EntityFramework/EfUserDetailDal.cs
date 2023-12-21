using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityLayer.DTO;

namespace DataAccessLayer.EntityFramework
{
    public class EfUserDetailDal : GenericRepository<UserDetail>, IUserDetailDal
    {
        public List<UserDetailDTO> GetUserDetails(int id)
        {

            using (var context = new Context())

            {
                var result = from user in context.Users
                             join userDetail in context.UserDetails
                             on user.UserID equals userDetail.UserID
                             join badHabbit in context.BadHabbits
                             on userDetail.BadHabbitID equals badHabbit.BadHabbitID
                             join chronicDisease in context.ChronicDiseases
                             on userDetail.ChronicDiseaseID equals chronicDisease.ChronicDiseaseID
                             where user.UserID == id
                             select new UserDetailDTO
                             {
                                 Id = user.UserID,
                                 FirstName = user.Name,
                                 LastName = user.Surname,
                                 Age = userDetail.Age,
                                 Sex = userDetail.Sex,
                                 Height = userDetail.Height,
                                 Weight = userDetail.Weight,
                                 BodyMassIndex = userDetail.Weight / (userDetail.Height * userDetail.Height),
                                 BadHabbitName = badHabbit.BadHabbitName,
                                 ChronicDiseaseName = chronicDisease.ChronicDiseaseName
                             };

                return result.ToList();


            }
        }
    }
}
