using EntityLayer.Concrete;
using EntityLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserDetailsService
    {
        List<UserDetailDTO> GetUserDetails(int id);
        List<UserDetail> GetList();
        void UserDetailAdd(UserDetail userDetail);
        UserDetail GetByID(int id);
        void UserDetailDelete(UserDetail userDetail);
        void UserDetailUpdate(UserDetail userDetail);
    }
}
