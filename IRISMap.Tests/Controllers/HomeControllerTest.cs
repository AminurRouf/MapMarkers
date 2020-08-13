using System.Web.Mvc;
using IRISMap.Controllers;
using IRISMap.Interfaces;
using IRISMap.ViewModels;
using Moq;
using Shouldly;
using Xunit;

namespace IRISMap.Tests.Controllers
{
    public class HomeControllerTest
    {

        [Fact]
        public void Map()
        {

            // Arrange
            var viewModel = new LocationMapViewModel();
            viewModel.MapMarkers = "[]";
            var mockTask = new Mock<ILocationMapTasks>();
            mockTask.Setup(x => x.GetMapMarkers()).Returns(viewModel);
            HomeController controller = new HomeController(mockTask.Object);

            // Act
            ViewResult result = controller.Map() as ViewResult;

            // Assert
            mockTask.Verify(x=>x.GetMapMarkers(), Times.Once);
            ((LocationMapViewModel)result.Model).MapMarkers.ShouldBe(viewModel.MapMarkers);
            result.ShouldNotBeNull();
            
        }
    }
}
