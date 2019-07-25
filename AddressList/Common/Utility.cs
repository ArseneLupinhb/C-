namespace Common
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// Defines the <see cref="Utility" />
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// The CheckMobilePhone
        /// </summary>
        /// <param name="phone">The phone<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public static bool CheckMobilePhone(string phone)
        {
            bool check = true;
            if (phone != "")
            {
                if (phone.Length != 11 ||
                    !Regex.IsMatch(phone, @"13[012356789]\d{8}|15[012356789]\d{8}|18[012356789]\d{8}/"))
                {
                    check = false;
                }
            }
            return check;
        }

        /// <summary>
        /// The CheckEmail
        /// </summary>
        /// <param name="email">The email<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public static bool CheckEmail(string email)
        {
            bool check = true;
            if (email != "")
            {
                if (!Regex.IsMatch(email, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
                {
                    check = false;
                }
            }
            return check;
        }

        /// <summary>
        /// The CheckQQ
        /// </summary>
        /// <param name="qq">The qq<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public static bool CheckQQ(string qq)
        {
            bool check = true;
            if (qq != "")
            {
                if (!Regex.IsMatch(qq, @"^[1-9]*[1-9][0-9]*$"))
                {
                    check = false;
                }
            }
            return check;
        }

        /// <summary>
        /// The CheckPhone
        /// </summary>
        /// <param name="phone">The phone<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public static bool CheckPhone(string phone)
        {
            bool check = true;
            if (phone != "")
            {
                if (!Regex.IsMatch(phone, @"^(0[0-9]{2,3}\-)?([2-9][0-9]{6,7})+(\-[0-9]{1,4})?$"))
                {
                    check = false;
                }
            }
            return check;
        }
    }
}
