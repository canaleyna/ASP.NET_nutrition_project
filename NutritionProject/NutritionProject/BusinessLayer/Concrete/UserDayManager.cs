using DataAccessLayer.Abstract;
using EntityLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserDayManager
    {
        IUserDayDal _userDayDal;
        public UserDayManager(IUserDayDal userDayDal)
        {
            _userDayDal = userDayDal;
        }
        public List<UserDayDetailDTO> GetUserDayDetails(int id)
        {
            return new List<UserDayDetailDTO>(_userDayDal.GetUserDayDetails(id));
        }
    }
}
