using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BadHabbitManager : IBadHabbitService
    {
        IBadHabbitDal _badhabbitDal;

        public BadHabbitManager(IBadHabbitDal badhabbitDal)
        {
            _badhabbitDal = badhabbitDal;
        }

        public void BadHabbitAdd(BadHabbit badHabbit)
        {
            _badhabbitDal.Insert(badHabbit);
        }

        public void BadHabbitDelete(BadHabbit badHabbit)
        {
            _badhabbitDal.Delete(badHabbit);
        }

        public void BadHabbitUpdate(BadHabbit badHabbit)
        {
            _badhabbitDal.Update(badHabbit);
        }

        public BadHabbit GetByID(int id)
        {
            return _badhabbitDal.Get(x => x.BadHabbitID == id);
        }

        public List<BadHabbit> GetList()
        {
            return _badhabbitDal.List();
        }

     
    }
}
