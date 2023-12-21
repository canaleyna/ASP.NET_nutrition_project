using EntityLayer.Concrete;
using EntityLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IUserDayDal : IRepository<UserDay>
    {
        List<UserDayDetailDTO> GetUserDayDetails(int id);
    }
}
