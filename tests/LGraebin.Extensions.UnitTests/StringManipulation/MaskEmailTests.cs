using LGraebin.Extensions.StringManipulation;
using Xunit;

namespace LGraebin.Extensions.UnitTests.StringManipulation
{
    public class MaskEmailTests
    {
        [Theory]
        [InlineData("valid@example.com", "v***d@example.com")]
        [InlineData("valid+valid123@test.example.com", "v************3@test.example.com")]
        [InlineData("valid_valid123@test.example.com", "v************3@test.example.com")]
        [InlineData("valid-valid+123@test.example.co.uk", "v*************3@test.example.co.uk")]
        [InlineData("valid-valid+1.23@test.example.com.au", "v**************3@test.example.com.au")]
        [InlineData("valid_@example.com", "v****_@example.com")]
        [InlineData("valid123.456@example.org", "v**********6@example.org")]
        [InlineData("valid-@example.com", "v****-@example.com")]
        [InlineData("customer/department=shipping@example.com", "c**************************g@example.com")]
        [InlineData("$A12345@example.com", "$*****5@example.com")]
        [InlineData("!def'`xyz%abc@example.com", "!***********c@example.com")]
        [InlineData("_somename@example.com", "_*******e@example.com")]
        public void ShouldMaskEmailAddress(string email, string expected)
        {
            var result = email.MaskEmail();

            Assert.Equal(expected, result);
        }
    }
}
