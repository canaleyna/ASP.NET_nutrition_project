﻿using EntityLayer.Concrete;
using EntityLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IUserDayTimeDal : IRepository<UserDayTime>
    {
        List<UserDayTimeDetailDTO> GetUserDayTimeDetails(int id);
    }
}
