using LGraebin.Extensions.Verification;
using Xunit;

namespace LGraebin.Extensions.UnitTests.Verification
{
    public class IsEmailTests
    {
        [Theory]
        [InlineData("valid@example.com")]
        [InlineData("Valid@test.example.com")]
        [InlineData("valid+valid123@test.example.com")]
        [InlineData("valid_valid123@test.example.com")]
        [InlineData("valid-valid+123@test.example.co.uk")]
        [InlineData("valid-valid+1.23@test.example.com.au")]
        [InlineData("valid@example.co.uk")]
        [InlineData("v@example.com")]
        [InlineData("valid@example.ca")]
        [InlineData("valid_@example.com")]
        [InlineData("valid123.456@example.org")]
        [InlineData("valid123.456@example.travel")]
        [InlineData("valid123.456@example.museum")]
        [InlineData("valid@example.mobi")]
        [InlineData("valid@example.info")]
        [InlineData("valid-@example.com")]
        [InlineData("customer/department=shipping@example.com")] // From RFC 3696, page 6.
        [InlineData("$A12345@example.com")]
        [InlineData("!def!xyz%abc@example.com")]
        [InlineData("_somename@example.com")]
        [InlineData("test'test@example.com")] // Apostrophes.
        [InlineData("test`test@example.com")]
        public void ReturnsTrueValidEmail(string email)
        {
            var result = email.IsEmail();

            Assert.True(result);
        }

        [Theory]
        [InlineData("invalid@example-com")]
        [InlineData(".invalid@example.com")] // Period can not start local part.
        [InlineData("invalid.@example.com")] // Period can not end local part.
        [InlineData("invali..d@example.com")] // Period can not appear twice consecutively in local part.
        [InlineData("invalid@ex_mple.com")] // Should not allow underscores in domain names.
        [InlineData("invalid@example.com.")]
        [InlineData("invalid@example.com_")]
        [InlineData("invalid@example.com-")]
        [InlineData("invalid-example.com")]
        [InlineData("invalid@example.b#r.com")]
        [InlineData("invali d@example.com")]
        [InlineData("invalidexample.com")]
        [InlineData("invalid@example.")]
        [InlineData("test\"test@example.com")]
        [InlineData("test\\@test@example.com")]
        public void ReturnsFalseInvalidEmail(string email)
        {
            var result = email.IsEmail();

            Assert.False(result);
        }
    }
}
