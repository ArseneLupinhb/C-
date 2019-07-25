namespace Model
{
    using System;

    /// <summary>
    /// ContactGroup:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ContactGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactGroup"/> class.
        /// </summary>
        public ContactGroup()
        {
        }

        /// <summary>
        /// Defines the _id
        /// </summary>
        private int _id;

        /// <summary>
        /// Defines the _groupname
        /// </summary>
        private string _groupname;

        /// <summary>
        /// Defines the _memo
        /// </summary>
        private string _memo;

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
        /// Gets or sets the GroupName
        /// 分组名称
        /// </summary>
        public string GroupName
        {
            set { _groupname = value; }
            get { return _groupname; }
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
    }
}
