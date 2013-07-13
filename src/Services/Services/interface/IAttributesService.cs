using System.Collections.Generic;
using Model;

namespace Services.interfaces
{
    public interface IAttributesService : IBaseService<Attribute>
    {
        List<Attribute> GetAllAttributes();
    }
}
