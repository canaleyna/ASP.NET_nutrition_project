using DataAccessLayer.Abstract;
using EntityLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
     public class UserDayTimeManager
    {
        IUserDayTimeDal _userDayTimeDal;
        public UserDayTimeManager(IUserDayTimeDal userDayTimeDal)
        {
            _userDayTimeDal = userDayTimeDal;
        }
        public List<UserDayTimeDetailDTO> GetUserDayTimeDetails(int id)
        {
            return new List<UserDayTimeDetailDTO>(_userDayTimeDal.GetUserDayTimeDetails(id));
        }
    }
}
