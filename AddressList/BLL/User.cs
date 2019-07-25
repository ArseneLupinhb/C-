namespace BLL
{
    /// <summary>
    /// Defines the <see cref="User" />
    /// </summary>
    public class User
    {
        /// <summary>
        /// Defines the user
        /// </summary>
        internal IDAL.IUser user = DALFactory.DataAccess.CreateUser();

        /// <summary>
        /// The Login
        /// </summary>
        /// <param name="userName">The userName<see cref="string"/></param>
        /// <param name="userPassword">The userPassword<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool Login(string userName, string userPassword)
        {
            return user.Login(userName, Common.MD5Provider.Hash(userPassword));
        }

        /// <summary>
        /// The Update
        /// </summary>
        /// <param name="model">The model<see cref="Model.User"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool Update(Model.User model)
        {
            model.Password = Common.MD5Provider.Hash(model.Password);
            return user.Update(model);
        }
    }
}
