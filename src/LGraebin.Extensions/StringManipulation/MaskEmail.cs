using System.Text.RegularExpressions;

namespace LGraebin.Extensions.StringManipulation
{
    public static partial class StringManipulationExtensions
    {
        private static readonly Regex MaskRegex = new Regex(@"(?<=[^@]{1})[^@]*(?=[^@]{1}@)", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        /// <summary>
        /// Mask the local-part (the bit before the @-sign) of e-mail address by replacing all characters with *, except the first and last characters.
        /// </summary>
        /// <param name="email">E-mail to mask.</param>
        /// <returns>The e-mail address with the local-part masked.</returns>
        public static string MaskEmail(this string email)
        {
            return MaskRegex.Replace(email, x => new string('*', x.Length));
        }
    }
}
