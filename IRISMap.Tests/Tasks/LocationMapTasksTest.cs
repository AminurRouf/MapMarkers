using System.Collections.Generic;
using System.Linq;
using IRISMap.Interfaces;
using IRISMap.Models;
using IRISMap.Tasks;
using Moq;
using Shouldly;
using Xunit;

namespace IRISMap.Tests.Tasks
{
    public class LocationMapTasksTest
    {
        [Fact]
        public void ShouldGetMapMarkers()
        {
            //Arrange
            var expectedMarkers = "[{'title': 'Nowhere','lat': '1','lng': '2',},];";
            var entities = new  List<Location>{new Location{Latitude = "1", Longitude = "2", Name = "Nowhere" }}.AsQueryable();
            var mockRepo =  new Mock<IRepository<Location>>();
            mockRepo.Setup(x => x.Entities).Returns(entities);
            var sut = new LocationMapTasks(mockRepo.Object);

            //Act
             var result =sut.GetMapMarkers();

             //Arrange
            mockRepo.Verify(x=>x.Entities, Times.Once);
            result.ShouldNotBeNull();
            result.MapMarkers.ShouldBe(expectedMarkers);
        }
    }
}
