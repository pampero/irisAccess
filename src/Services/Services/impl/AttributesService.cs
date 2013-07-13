using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Base;
using Model;
using Services.interfaces;
using Model.Repositories.interfaces;

namespace Services.impl
{
    public class AttributesService : BaseService, IAttributesService
    {
        private IUnitOfWork _unitOfWork { get; set; }


        public AttributesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        
        public List<Model.Attribute> GetAllAttributes()
        {
            return _unitOfWork.AttributesRepository.Query().Where(c => !c.IsDeleted).ToList();
        }


        public IList<Model.Attribute> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.Attribute> Query()
        {
            throw new NotImplementedException();
        }

        public Model.Attribute GetById(int objectId)
        {
            return _unitOfWork.AttributesRepository.GetByID(objectId);
        }

        public void Delete(Model.Attribute entity)
        {
            throw new NotImplementedException();
        }

        public void Add(Model.Attribute entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Model.Attribute entity)
        {
            throw new NotImplementedException();
        }
    }
}
