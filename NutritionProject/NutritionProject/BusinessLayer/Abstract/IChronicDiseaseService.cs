using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IChronicDiseaseService
    {
        List<ChronicDisease> GetList();
        void ChronicDiseaseAdd(ChronicDisease chronicDisease);
        ChronicDisease GetByID(int id);
        void ChronicDiseaseDelete(ChronicDisease chronicDisease);
        void ChronicDiseaseUpdate(ChronicDisease chronicDisease);
    }
}
