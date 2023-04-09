using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceDal
    {  
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Delete(Service t)
        {
           _serviceDal.Delete(t);
        }

        public Service GetByID(int id)
        {
            return _serviceDal.GetByID(id); 
        }

        public List<Service> GetList()
        {
            return _serviceDal.GetList();
        }

        public void Insert(Service t)
        {
            _serviceDal.Insert(t);
        }

        public void Update(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
