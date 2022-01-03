using System.Text.RegularExpressions;

namespace LGraebin.Extensions.Verification
{
    public static partial class VerificationExtensions
    {
        private static readonly Regex EmailRegex = new Regex(@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        /// <summary>
        /// Check if a given string is a valid e-mail address.
        /// </summary>
        /// <param name="email">String to check.</param>
        /// <returns>TRUE if the given string is a valid e-mail address; otherwise, FALSE.</returns>
        public static bool IsEmail(this string email)
        {
            return EmailRegex.IsMatch(email);
        }
    }
}
