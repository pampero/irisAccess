using System.Collections.Generic;
using System.Linq;
using Model.Repositories.interfaces;

namespace Model.Repositories.impl
{
    public class AttributesRepository : GenericUpdatableRepository<Attribute>, IAttributesRepository
    {
        public AttributesRepository(AppDbContext context) : base(context)
        {
        }
       
        public List<Attribute> GetAll()
        {
            return context.Attributes.Where(x => !x.IsDeleted).OrderByDescending(x => x.Created).ToList();
        }
    }
}