using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Repositories.interfaces;
using Moq;

namespace Services.Tests
{
    public class MockupsBusinessConfiguration
    {
        public static IBusinessRepository MockBusinessRepository()
        {
            var mockBusinessRepository = new Mock<IBusinessRepository>();

            var businesses = new List<Business>
                                 {
                                     new Business
                                         {
                                             Comments = "",
                                             Created = DateTime.Now,
                                             CreatedBy = "cvazquez",
                                             ID = 1,
                                             Name = "NOMBRE",
                                             IsDeleted = false
                                         },
                                     new Business
                                         {
                                             Comments = "",
                                             Created = DateTime.Now,
                                             CreatedBy = "cvazquez2",
                                             ID = 2,
                                             Name = "NOMBRE2",
                                             IsDeleted = false
                                         }
                                 };

            mockBusinessRepository.Setup(x=>x.GetByID(1)).Returns(businesses[0]);
            //TODO: Throw Exception
            //mockRoutesRepository.Setup(x=>x.GetByID(2)).Returns();
            mockBusinessRepository.Setup(x=>x.GetAll()).Returns(businesses);

            return mockBusinessRepository.Object;
        }

        public static IUnitOfWork MockUnitOfWork()
        {
            var mockUnitOfWork = new Mock<IUnitOfWork>();

            mockUnitOfWork.Setup(x => x.BusinessRepository).Returns(MockBusinessRepository);

            return mockUnitOfWork.Object;
        }
    }
}
