using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBadHabbitService
    {
        List<BadHabbit> GetList();
        void BadHabbitAdd(BadHabbit badHabbit);
        BadHabbit GetByID(int id);
        void BadHabbitDelete(BadHabbit badHabbit);
        void BadHabbitUpdate(BadHabbit badHabbit);
    }
}
