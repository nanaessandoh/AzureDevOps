using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest
    {
        ValuesController controller = new ValuesController();

        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Something Else 1", returnValue.Value);
        }


    }
}
