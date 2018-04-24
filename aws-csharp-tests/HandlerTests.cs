using System;
using Xunit;
using AwsDotnetCsharp;

namespace aws_csharp_tests
{
    public class UnitTest1
    {
        [Fact]
        public void ResponseMessage_ShouldBe_HelloWorld()
        {
			var handler = new Handler();

			Assert.Equal("Hello World", handler.GetResponseMessage());
        }
    }
}
