using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IDayService
    {
        List<Day> GetList();
        void DayAdd(Day day);
        Day GetByID(int id);
        void DayDelete(Day day);
        void DayUpdate(Day day);
    }
}
