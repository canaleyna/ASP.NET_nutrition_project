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
   
        public class ChronicDiseaseManager : IChronicDiseaseService
        {
            IChronicDiseaseDal _chronicdiseaseDal;


        public ChronicDiseaseManager(IChronicDiseaseDal chronicdiseaseDal)
            {
                _chronicdiseaseDal = chronicdiseaseDal;
            }


        public void ChronicDiseaseAdd(ChronicDisease chronicDisease)
            {
                _chronicdiseaseDal.Insert(chronicDisease);
            }

            public void ChronicDiseaseDelete(ChronicDisease chronicDisease)
            {
                _chronicdiseaseDal.Delete(chronicDisease);
            }

            public void ChronicDiseaseUpdate(ChronicDisease chronicDisease)
            {
                _chronicdiseaseDal.Update(chronicDisease);
            }

            public ChronicDisease GetByID(int id)
            {
                return _chronicdiseaseDal.Get(x => x.ChronicDiseaseID == id);
            }

            public List<ChronicDisease> GetList()
            {
                return _chronicdiseaseDal.List();
            }
        }
    }

