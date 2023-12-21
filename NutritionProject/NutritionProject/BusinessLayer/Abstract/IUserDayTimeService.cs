﻿using EntityLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserDayTimeService
    {
        List<UserDayTimeDetailDTO> GetUserDayTimeDetails(int id);
    }
}
