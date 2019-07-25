namespace Model
{
    using System;

    /// <summary>
    /// Contact:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Contact
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        public Contact()
        {
        }

        /// <summary>
        /// Defines the _id
        /// </summary>
        private int _id;

        /// <summary>
        /// Defines the _name
        /// </summary>
        private string _name;

        /// <summary>
        /// Defines the _phone
        /// </summary>
        private string _phone;

        /// <summary>
        /// Defines the _email
        /// </summary>
        private string _email;

        /// <summary>
        /// Defines the _qq
        /// </summary>
        private string _qq;

        /// <summary>
        /// Defines the _workunit
        /// </summary>
        private string _workunit;

        /// <summary>
        /// Defines the _officephone
        /// </summary>
        private string _officephone;

        /// <summary>
        /// Defines the _homeaddress
        /// </summary>
        private string _homeaddress;

        /// <summary>
        /// Defines the _homephone
        /// </summary>
        private string _homephone;

        /// <summary>
        /// Defines the _memo
        /// </summary>
        private string _memo;

        /// <summary>
        /// Defines the _groupid
        /// </summary>
        private int _groupid;

        /// <summary>
        /// Gets or sets the Id
        /// 自动编号
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }

        /// <summary>
        /// Gets or sets the Name
        /// 联系人姓名
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets the Phone
        /// 手机
        /// </summary>
        public string Phone
        {
            set { _phone = value; }
            get { return _phone; }
        }

        /// <summary>
        /// Gets or sets the Email
        /// 电子邮件
        /// </summary>
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }

        /// <summary>
        /// Gets or sets the QQ
        /// QQ
        /// </summary>
        public string QQ
        {
            set { _qq = value; }
            get { return _qq; }
        }

        /// <summary>
        /// Gets or sets the WorkUnit
        /// 工作单位
        /// </summary>
        public string WorkUnit
        {
            set { _workunit = value; }
            get { return _workunit; }
        }

        /// <summary>
        /// Gets or sets the OfficePhone
        /// 办公电话
        /// </summary>
        public string OfficePhone
        {
            set { _officephone = value; }
            get { return _officephone; }
        }

        /// <summary>
        /// Gets or sets the HomeAddress
        /// 家庭住址
        /// </summary>
        public string HomeAddress
        {
            set { _homeaddress = value; }
            get { return _homeaddress; }
        }

        /// <summary>
        /// Gets or sets the HomePhone
        /// 家庭电话
        /// </summary>
        public string HomePhone
        {
            set { _homephone = value; }
            get { return _homephone; }
        }

        /// <summary>
        /// Gets or sets the Memo
        /// 备注
        /// </summary>
        public string Memo
        {
            set { _memo = value; }
            get { return _memo; }
        }

        /// <summary>
        /// Gets or sets the GroupId
        /// 分组编号
        /// </summary>
        public int GroupId
        {
            set { _groupid = value; }
            get { return _groupid; }
        }
    }
}
