using aspnet_core_unit_1.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_core_test;

public class HomeControllerTest
{
    [Fact]
    public void CheckCountValue_ThrowsException_WhenValueIsOutOfRange()
    {
        // Arrange
        var controller = new HomeController();
        int inputValue = 500;

        // Act & Assert
        Assert.Throws<Exception>(() => controller.CheckCountValue(inputValue));
    }

    [Fact]
    public void CheckCountValue_ReturnsView_WhenValueIsWithinRange()
    {
        // Arrange
        var controller = new HomeController();
        int inputValue = 2;

        // Act
        var result = controller.CheckCountValue(inputValue) as ViewResult;

        // Assert
        Assert.NotNull(result);
    }
}