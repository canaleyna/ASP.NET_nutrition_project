using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DayManager : IDayService
    {
        IDayDal _dayDal;

        public DayManager(IDayDal dayDal)
        {
            _dayDal = dayDal;
        }

        public void DayAdd(Day day)
        {
            throw new NotImplementedException();
        }

        public void DayDelete(Day day)
        {
            throw new NotImplementedException();
        }

        public void DayUpdate(Day day)
        {
            throw new NotImplementedException();
        }

        public Day GetByID(int id)
        {
            return _dayDal.Get(x => x.DayID == id);
        }

        public List<Day> GetList()
        {
            return _dayDal.List();
        }
    }
}
