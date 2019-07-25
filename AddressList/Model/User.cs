namespace Model
{
    using System;

    /// <summary>
    /// User:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
        }

        /// <summary>
        /// Defines the _username
        /// </summary>
        private string _username;

        /// <summary>
        /// Defines the _password
        /// </summary>
        private string _password;

        /// <summary>
        /// Gets or sets the UserName
        /// 用户名
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }

        /// <summary>
        /// Gets or sets the Password
        /// 密码
        /// </summary>
        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }
    }
}
