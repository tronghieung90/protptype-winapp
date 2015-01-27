using System;
using System.Data;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
namespace eBHXH
{
	/// <summary>
	/// Generated Class for Table : D02TS.
	/// </summary>
	public partial class D02TS : TableBase
	{
		public D02TS() : base(){}

		/// <summary>
		/// Là View hay là Table.
		/// </summary>
		public override bool IsView 
		{
			get
			{
				return false;
			}
		}
		private string m_D02TS_HS_SOHS;
		/// <summary>
		/// D02TS_HS_SOHS.
		/// </summary>
		public string D02TS_HS_SOHS
		{
			get
			{
				return m_D02TS_HS_SOHS;
			}
			set
			{
				if ((this.m_D02TS_HS_SOHS != value))
				{
					this.SendPropertyChanging("D02TS_HS_SOHS");
					this.m_D02TS_HS_SOHS = value;
					this.SendPropertyChanged("D02TS_HS_SOHS");
				}
			}
		}

		private string m_D02TS_HS_NAMDK;
		/// <summary>
		/// D02TS_HS_NAMDK.
		/// </summary>
		public string D02TS_HS_NAMDK
		{
			get
			{
				return m_D02TS_HS_NAMDK;
			}
			set
			{
				if ((this.m_D02TS_HS_NAMDK != value))
				{
					this.SendPropertyChanging("D02TS_HS_NAMDK");
					this.m_D02TS_HS_NAMDK = value;
					this.SendPropertyChanged("D02TS_HS_NAMDK");
				}
			}
		}

		private string m_D02TS_ITEM_ID;
		/// <summary>
		/// D02TS_ITEM_ID.
		/// </summary>
		public string D02TS_ITEM_ID
		{
			get
			{
				return m_D02TS_ITEM_ID;
			}
			set
			{
				if ((this.m_D02TS_ITEM_ID != value))
				{
					this.SendPropertyChanging("D02TS_ITEM_ID");
					this.m_D02TS_ITEM_ID = value;
					this.SendPropertyChanged("D02TS_ITEM_ID");
				}
			}
		}

		private string m_D02TS_Name;
		private bool m_D02TS_NameUpdated = false;
		/// <summary>
		/// D02TS_Name.
		/// </summary>
		public string D02TS_Name
		{
			get
			{
				return m_D02TS_Name;
			}
			set
			{
				if ((this.m_D02TS_Name != value))
				{
					this.SendPropertyChanging("D02TS_Name");
					this.m_D02TS_Name = value;
					this.SendPropertyChanged("D02TS_Name");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_NameUpdated = true;
				}
			}
		}

		private string m_D02TS_IssueCode;
		private bool m_D02TS_IssueCodeUpdated = false;
		/// <summary>
		/// D02TS_IssueCode.
		/// </summary>
		public string D02TS_IssueCode
		{
			get
			{
				return m_D02TS_IssueCode;
			}
			set
			{
				if ((this.m_D02TS_IssueCode != value))
				{
					this.SendPropertyChanging("D02TS_IssueCode");
					this.m_D02TS_IssueCode = value;
					this.SendPropertyChanged("D02TS_IssueCode");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_IssueCodeUpdated = true;
				}
			}
		}

		private string m_D02TS_BirthDay;
		private bool m_D02TS_BirthDayUpdated = false;
		/// <summary>
		/// D02TS_BirthDay.
		/// </summary>
		public string D02TS_BirthDay
		{
			get
			{
				return m_D02TS_BirthDay;
			}
			set
			{
				if ((this.m_D02TS_BirthDay != value))
				{
					this.SendPropertyChanging("D02TS_BirthDay");
					this.m_D02TS_BirthDay = value;
					this.SendPropertyChanged("D02TS_BirthDay");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_BirthDayUpdated = true;
				}
			}
		}

		private bool m_D02TS_Sex;
		private bool m_D02TS_SexUpdated = false;
		/// <summary>
		/// D02TS_Sex.
		/// </summary>
		public bool D02TS_Sex
		{
			get
			{
				return m_D02TS_Sex;
			}
			set
			{
				if ((this.m_D02TS_Sex != value))
				{
					this.SendPropertyChanging("D02TS_Sex");
					this.m_D02TS_Sex = value;
					this.SendPropertyChanged("D02TS_Sex");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_SexUpdated = true;
				}
			}
		}

		private string m_D02TS_Level;
		private bool m_D02TS_LevelUpdated = false;
		/// <summary>
		/// D02TS_Level.
		/// </summary>
		public string D02TS_Level
		{
			get
			{
				return m_D02TS_Level;
			}
			set
			{
				if ((this.m_D02TS_Level != value))
				{
					this.SendPropertyChanging("D02TS_Level");
					this.m_D02TS_Level = value;
					this.SendPropertyChanged("D02TS_Level");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_LevelUpdated = true;
				}
			}
		}

		private decimal? m_D02TS_OldSalary;
		private bool m_D02TS_OldSalaryUpdated = false;
		/// <summary>
		/// D02TS_OldSalary.
		/// </summary>
		public decimal? D02TS_OldSalary
		{
			get
			{
				return m_D02TS_OldSalary;
			}
			set
			{
				if ((this.m_D02TS_OldSalary != value))
				{
					this.SendPropertyChanging("D02TS_OldSalary");
					this.m_D02TS_OldSalary = value;
					this.SendPropertyChanged("D02TS_OldSalary");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_OldSalaryUpdated = true;
				}
			}
		}

		private string m_D02TS_OldLevel;
		private bool m_D02TS_OldLevelUpdated = false;
		/// <summary>
		/// D02TS_OldLevel.
		/// </summary>
		public string D02TS_OldLevel
		{
			get
			{
				return m_D02TS_OldLevel;
			}
			set
			{
				if ((this.m_D02TS_OldLevel != value))
				{
					this.SendPropertyChanging("D02TS_OldLevel");
					this.m_D02TS_OldLevel = value;
					this.SendPropertyChanged("D02TS_OldLevel");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_OldLevelUpdated = true;
				}
			}
		}

		private string m_D02TS_OldSeniorityExcessive;
		private bool m_D02TS_OldSeniorityExcessiveUpdated = false;
		/// <summary>
		/// D02TS_OldSeniorityExcessive.
		/// </summary>
		public string D02TS_OldSeniorityExcessive
		{
			get
			{
				return m_D02TS_OldSeniorityExcessive;
			}
			set
			{
				if ((this.m_D02TS_OldSeniorityExcessive != value))
				{
					this.SendPropertyChanging("D02TS_OldSeniorityExcessive");
					this.m_D02TS_OldSeniorityExcessive = value;
					this.SendPropertyChanged("D02TS_OldSeniorityExcessive");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_OldSeniorityExcessiveUpdated = true;
				}
			}
		}

		private string m_D02TS_OldSeniorityJob;
		private bool m_D02TS_OldSeniorityJobUpdated = false;
		/// <summary>
		/// D02TS_OldSeniorityJob.
		/// </summary>
		public string D02TS_OldSeniorityJob
		{
			get
			{
				return m_D02TS_OldSeniorityJob;
			}
			set
			{
				if ((this.m_D02TS_OldSeniorityJob != value))
				{
					this.SendPropertyChanging("D02TS_OldSeniorityJob");
					this.m_D02TS_OldSeniorityJob = value;
					this.SendPropertyChanged("D02TS_OldSeniorityJob");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_OldSeniorityJobUpdated = true;
				}
			}
		}

		private decimal? m_D02TS_NewSalary;
		private bool m_D02TS_NewSalaryUpdated = false;
		/// <summary>
		/// D02TS_NewSalary.
		/// </summary>
		public decimal? D02TS_NewSalary
		{
			get
			{
				return m_D02TS_NewSalary;
			}
			set
			{
				if ((this.m_D02TS_NewSalary != value))
				{
					this.SendPropertyChanging("D02TS_NewSalary");
					this.m_D02TS_NewSalary = value;
					this.SendPropertyChanged("D02TS_NewSalary");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_NewSalaryUpdated = true;
				}
			}
		}

		private string m_D02TS_NewLevel;
		private bool m_D02TS_NewLevelUpdated = false;
		/// <summary>
		/// D02TS_NewLevel.
		/// </summary>
		public string D02TS_NewLevel
		{
			get
			{
				return m_D02TS_NewLevel;
			}
			set
			{
				if ((this.m_D02TS_NewLevel != value))
				{
					this.SendPropertyChanging("D02TS_NewLevel");
					this.m_D02TS_NewLevel = value;
					this.SendPropertyChanged("D02TS_NewLevel");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_NewLevelUpdated = true;
				}
			}
		}

		private string m_D02TS_NewSeniorityExcessive;
		private bool m_D02TS_NewSeniorityExcessiveUpdated = false;
		/// <summary>
		/// D02TS_NewSeniorityExcessive.
		/// </summary>
		public string D02TS_NewSeniorityExcessive
		{
			get
			{
				return m_D02TS_NewSeniorityExcessive;
			}
			set
			{
				if ((this.m_D02TS_NewSeniorityExcessive != value))
				{
					this.SendPropertyChanging("D02TS_NewSeniorityExcessive");
					this.m_D02TS_NewSeniorityExcessive = value;
					this.SendPropertyChanged("D02TS_NewSeniorityExcessive");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_NewSeniorityExcessiveUpdated = true;
				}
			}
		}

		private string m_D02TS_NewSeniorityJob;
		private bool m_D02TS_NewSeniorityJobUpdated = false;
		/// <summary>
		/// D02TS_NewSeniorityJob.
		/// </summary>
		public string D02TS_NewSeniorityJob
		{
			get
			{
				return m_D02TS_NewSeniorityJob;
			}
			set
			{
				if ((this.m_D02TS_NewSeniorityJob != value))
				{
					this.SendPropertyChanging("D02TS_NewSeniorityJob");
					this.m_D02TS_NewSeniorityJob = value;
					this.SendPropertyChanged("D02TS_NewSeniorityJob");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_NewSeniorityJobUpdated = true;
				}
			}
		}

		private string m_D02TS_FromDate;
		private bool m_D02TS_FromDateUpdated = false;
		/// <summary>
		/// D02TS_FromDate.
		/// </summary>
		public string D02TS_FromDate
		{
			get
			{
				return m_D02TS_FromDate;
			}
			set
			{
				if ((this.m_D02TS_FromDate != value))
				{
					this.SendPropertyChanging("D02TS_FromDate");
					this.m_D02TS_FromDate = value;
					this.SendPropertyChanged("D02TS_FromDate");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_FromDateUpdated = true;
				}
			}
		}

		private string m_D02TS_ToDate;
		private bool m_D02TS_ToDateUpdated = false;
		/// <summary>
		/// D02TS_ToDate.
		/// </summary>
		public string D02TS_ToDate
		{
			get
			{
				return m_D02TS_ToDate;
			}
			set
			{
				if ((this.m_D02TS_ToDate != value))
				{
					this.SendPropertyChanging("D02TS_ToDate");
					this.m_D02TS_ToDate = value;
					this.SendPropertyChanged("D02TS_ToDate");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_ToDateUpdated = true;
				}
			}
		}

		private bool m_D02TS_IsPayCard;
		private bool m_D02TS_IsPayCardUpdated = false;
		/// <summary>
		/// D02TS_IsPayCard.
		/// </summary>
		public bool D02TS_IsPayCard
		{
			get
			{
				return m_D02TS_IsPayCard;
			}
			set
			{
				if ((this.m_D02TS_IsPayCard != value))
				{
					this.SendPropertyChanging("D02TS_IsPayCard");
					this.m_D02TS_IsPayCard = value;
					this.SendPropertyChanged("D02TS_IsPayCard");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_IsPayCardUpdated = true;
				}
			}
		}

		private bool m_D02TS_HaveIssue;
		private bool m_D02TS_HaveIssueUpdated = false;
		/// <summary>
		/// D02TS_HaveIssue.
		/// </summary>
		public bool D02TS_HaveIssue
		{
			get
			{
				return m_D02TS_HaveIssue;
			}
			set
			{
				if ((this.m_D02TS_HaveIssue != value))
				{
					this.SendPropertyChanging("D02TS_HaveIssue");
					this.m_D02TS_HaveIssue = value;
					this.SendPropertyChanged("D02TS_HaveIssue");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_HaveIssueUpdated = true;
				}
			}
		}

		private string m_D02TS_Comment;
		private bool m_D02TS_CommentUpdated = false;
		/// <summary>
		/// D02TS_Comment.
		/// </summary>
		public string D02TS_Comment
		{
			get
			{
				return m_D02TS_Comment;
			}
			set
			{
				if ((this.m_D02TS_Comment != value))
				{
					this.SendPropertyChanging("D02TS_Comment");
					this.m_D02TS_Comment = value;
					this.SendPropertyChanged("D02TS_Comment");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_CommentUpdated = true;
				}
			}
		}

		private bool m_D02TS_TangLaoDong = true;
		private bool m_D02TS_TangLaoDongUpdated = false;
		/// <summary>
		/// D02TS_TangLaoDong.
		/// </summary>
		public bool D02TS_TangLaoDong
		{
			get
			{
				return m_D02TS_TangLaoDong;
			}
			set
			{
				if ((this.m_D02TS_TangLaoDong != value))
				{
					this.SendPropertyChanging("D02TS_TangLaoDong");
					this.m_D02TS_TangLaoDong = value;
					this.SendPropertyChanged("D02TS_TangLaoDong");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_TangLaoDongUpdated = true;
				}
			}
		}

		private bool m_D02TS_TangMucDong = true;
		private bool m_D02TS_TangMucDongUpdated = false;
		/// <summary>
		/// D02TS_TangMucDong.
		/// </summary>
		public bool D02TS_TangMucDong
		{
			get
			{
				return m_D02TS_TangMucDong;
			}
			set
			{
				if ((this.m_D02TS_TangMucDong != value))
				{
					this.SendPropertyChanging("D02TS_TangMucDong");
					this.m_D02TS_TangMucDong = value;
					this.SendPropertyChanged("D02TS_TangMucDong");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_TangMucDongUpdated = true;
				}
			}
		}

		private bool m_D02TS_TangCong = true;
		private bool m_D02TS_TangCongUpdated = false;
		/// <summary>
		/// D02TS_TangCong.
		/// </summary>
		public bool D02TS_TangCong
		{
			get
			{
				return m_D02TS_TangCong;
			}
			set
			{
				if ((this.m_D02TS_TangCong != value))
				{
					this.SendPropertyChanging("D02TS_TangCong");
					this.m_D02TS_TangCong = value;
					this.SendPropertyChanged("D02TS_TangCong");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_D02TS_TangCongUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM D02TS " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("D02TS_HS_SOHS", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_HS_NAMDK", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_ITEM_ID", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_Name", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_IssueCode", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_BirthDay", ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_Sex", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_Level", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_OldSalary", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_OldLevel", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_OldSeniorityExcessive", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_OldSeniorityJob", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_NewSalary", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_NewLevel", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_NewSeniorityExcessive", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_NewSeniorityJob", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_FromDate", ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_ToDate", ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_IsPayCard", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_HaveIssue", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_Comment", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_TangLaoDong", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_TangMucDong", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("D02TS_TangCong", ProType.OTHER, this.DataManagement));
			return SelectStatement(sbSQL.ToString(), WhereClause, OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause)
		{
			return SelectStatement(WhereClause, string.Empty);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu theo khóa chính.
		/// </summary>
		public override string SelectStatement()
		{
			return SelectStatement(WhereById());
		}

		/// <summary>
		/// Tạo câu SQL thêm dữ liệu.
		/// </summary>
		public override string InsertStatement()
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append("INSERT INTO D02TS (D02TS_HS_SOHS, D02TS_HS_NAMDK, D02TS_Name, D02TS_IssueCode, D02TS_BirthDay, D02TS_Sex, D02TS_Level, D02TS_OldSalary, D02TS_OldLevel, D02TS_OldSeniorityExcessive, D02TS_OldSeniorityJob, D02TS_NewSalary, D02TS_NewLevel, D02TS_NewSeniorityExcessive, D02TS_NewSeniorityJob, D02TS_FromDate, D02TS_ToDate, D02TS_IsPayCard, D02TS_HaveIssue, D02TS_Comment, D02TS_TangLaoDong, D02TS_TangMucDong, D02TS_TangCong) VALUES(").Append(clsDAL.IsDBNULL(D02TS_HS_SOHS, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_HS_NAMDK, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_Name, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_IssueCode, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_BirthDay, ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_Sex, ProType.BOOL, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_Level, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_OldSalary, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_OldLevel, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_OldSeniorityExcessive, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_OldSeniorityJob, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_NewSalary, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_NewLevel, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_NewSeniorityExcessive, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_NewSeniorityJob, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_FromDate, ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_ToDate, ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_IsPayCard, ProType.BOOL, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_HaveIssue, ProType.BOOL, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_Comment, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_TangLaoDong, ProType.BOOL, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_TangMucDong, ProType.BOOL, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(D02TS_TangCong, ProType.BOOL, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE D02TS SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_D02TS_NameUpdated ? string.Format(",D02TS_Name = {0}", clsDAL.IsDBNULL(D02TS_Name, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_D02TS_IssueCodeUpdated ? string.Format(",D02TS_IssueCode = {0}", clsDAL.IsDBNULL(D02TS_IssueCode, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_D02TS_BirthDayUpdated ? string.Format(",D02TS_BirthDay = {0}", clsDAL.IsDBNULL(D02TS_BirthDay, ProType.VNDATESTRING, this.DataManagement)) : string.Empty).Append(m_D02TS_SexUpdated ? string.Format(",D02TS_Sex = {0}", clsDAL.IsDBNULL(D02TS_Sex, ProType.BOOL, this.DataManagement)) : string.Empty).Append(m_D02TS_LevelUpdated ? string.Format(",D02TS_Level = {0}", clsDAL.IsDBNULL(D02TS_Level, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_D02TS_OldSalaryUpdated ? string.Format(",D02TS_OldSalary = {0}", clsDAL.IsDBNULL(D02TS_OldSalary, ProType.OTHER, this.DataManagement)) : string.Empty).Append(m_D02TS_OldLevelUpdated ? string.Format(",D02TS_OldLevel = {0}", clsDAL.IsDBNULL(D02TS_OldLevel, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_D02TS_OldSeniorityExcessiveUpdated ? string.Format(",D02TS_OldSeniorityExcessive = {0}", clsDAL.IsDBNULL(D02TS_OldSeniorityExcessive, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_D02TS_OldSeniorityJobUpdated ? string.Format(",D02TS_OldSeniorityJob = {0}", clsDAL.IsDBNULL(D02TS_OldSeniorityJob, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_D02TS_NewSalaryUpdated ? string.Format(",D02TS_NewSalary = {0}", clsDAL.IsDBNULL(D02TS_NewSalary, ProType.OTHER, this.DataManagement)) : string.Empty).Append(m_D02TS_NewLevelUpdated ? string.Format(",D02TS_NewLevel = {0}", clsDAL.IsDBNULL(D02TS_NewLevel, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_D02TS_NewSeniorityExcessiveUpdated ? string.Format(",D02TS_NewSeniorityExcessive = {0}", clsDAL.IsDBNULL(D02TS_NewSeniorityExcessive, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_D02TS_NewSeniorityJobUpdated ? string.Format(",D02TS_NewSeniorityJob = {0}", clsDAL.IsDBNULL(D02TS_NewSeniorityJob, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_D02TS_FromDateUpdated ? string.Format(",D02TS_FromDate = {0}", clsDAL.IsDBNULL(D02TS_FromDate, ProType.VNDATESTRING, this.DataManagement)) : string.Empty).Append(m_D02TS_ToDateUpdated ? string.Format(",D02TS_ToDate = {0}", clsDAL.IsDBNULL(D02TS_ToDate, ProType.VNDATESTRING, this.DataManagement)) : string.Empty).Append(m_D02TS_IsPayCardUpdated ? string.Format(",D02TS_IsPayCard = {0}", clsDAL.IsDBNULL(D02TS_IsPayCard, ProType.BOOL, this.DataManagement)) : string.Empty).Append(m_D02TS_HaveIssueUpdated ? string.Format(",D02TS_HaveIssue = {0}", clsDAL.IsDBNULL(D02TS_HaveIssue, ProType.BOOL, this.DataManagement)) : string.Empty).Append(m_D02TS_CommentUpdated ? string.Format(",D02TS_Comment = {0}", clsDAL.IsDBNULL(D02TS_Comment, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_D02TS_TangLaoDongUpdated ? string.Format(",D02TS_TangLaoDong = {0}", clsDAL.IsDBNULL(D02TS_TangLaoDong, ProType.BOOL, this.DataManagement)) : string.Empty).Append(m_D02TS_TangMucDongUpdated ? string.Format(",D02TS_TangMucDong = {0}", clsDAL.IsDBNULL(D02TS_TangMucDong, ProType.BOOL, this.DataManagement)) : string.Empty).Append(m_D02TS_TangCongUpdated ? string.Format(",D02TS_TangCong = {0}", clsDAL.IsDBNULL(D02TS_TangCong, ProType.BOOL, this.DataManagement)) : string.Empty);
			if(sbSQL.Length > 0)
				return UpdateStatement(sbSQL.ToString().Substring(1), WhereClause);
			else
				return UpdateFullStatement(WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateFullStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.AppendFormat("D02TS_Name = {0}", clsDAL.IsDBNULL(D02TS_Name, ProType.STRING, this.DataManagement)).AppendFormat(",D02TS_IssueCode = {0}", clsDAL.IsDBNULL(D02TS_IssueCode, ProType.STRING, this.DataManagement)).AppendFormat(",D02TS_BirthDay = {0}", clsDAL.IsDBNULL(D02TS_BirthDay, ProType.VNDATESTRING, this.DataManagement)).AppendFormat(",D02TS_Sex = {0}", clsDAL.IsDBNULL(D02TS_Sex, ProType.BOOL, this.DataManagement)).AppendFormat(",D02TS_Level = {0}", clsDAL.IsDBNULL(D02TS_Level, ProType.STRING, this.DataManagement)).AppendFormat(",D02TS_OldSalary = {0}", clsDAL.IsDBNULL(D02TS_OldSalary, ProType.OTHER, this.DataManagement)).AppendFormat(",D02TS_OldLevel = {0}", clsDAL.IsDBNULL(D02TS_OldLevel, ProType.STRING, this.DataManagement)).AppendFormat(",D02TS_OldSeniorityExcessive = {0}", clsDAL.IsDBNULL(D02TS_OldSeniorityExcessive, ProType.STRING, this.DataManagement)).AppendFormat(",D02TS_OldSeniorityJob = {0}", clsDAL.IsDBNULL(D02TS_OldSeniorityJob, ProType.STRING, this.DataManagement)).AppendFormat(",D02TS_NewSalary = {0}", clsDAL.IsDBNULL(D02TS_NewSalary, ProType.OTHER, this.DataManagement)).AppendFormat(",D02TS_NewLevel = {0}", clsDAL.IsDBNULL(D02TS_NewLevel, ProType.STRING, this.DataManagement)).AppendFormat(",D02TS_NewSeniorityExcessive = {0}", clsDAL.IsDBNULL(D02TS_NewSeniorityExcessive, ProType.STRING, this.DataManagement)).AppendFormat(",D02TS_NewSeniorityJob = {0}", clsDAL.IsDBNULL(D02TS_NewSeniorityJob, ProType.STRING, this.DataManagement)).AppendFormat(",D02TS_FromDate = {0}", clsDAL.IsDBNULL(D02TS_FromDate, ProType.VNDATESTRING, this.DataManagement)).AppendFormat(",D02TS_ToDate = {0}", clsDAL.IsDBNULL(D02TS_ToDate, ProType.VNDATESTRING, this.DataManagement)).AppendFormat(",D02TS_IsPayCard = {0}", clsDAL.IsDBNULL(D02TS_IsPayCard, ProType.BOOL, this.DataManagement)).AppendFormat(",D02TS_HaveIssue = {0}", clsDAL.IsDBNULL(D02TS_HaveIssue, ProType.BOOL, this.DataManagement)).AppendFormat(",D02TS_Comment = {0}", clsDAL.IsDBNULL(D02TS_Comment, ProType.STRING, this.DataManagement)).AppendFormat(",D02TS_TangLaoDong = {0}", clsDAL.IsDBNULL(D02TS_TangLaoDong, ProType.BOOL, this.DataManagement)).AppendFormat(",D02TS_TangMucDong = {0}", clsDAL.IsDBNULL(D02TS_TangMucDong, ProType.BOOL, this.DataManagement)).AppendFormat(",D02TS_TangCong = {0}", clsDAL.IsDBNULL(D02TS_TangCong, ProType.BOOL, this.DataManagement));
			return UpdateStatement(sbSQL.ToString(), WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật liêu theo khóa chính.
		/// </summary>
		public override string UpdateStatement()
		{
			return UpdateStatement(WhereById());
		}

		/// <summary>
		/// Tạo câu SQL xóa dữ liêu.
		/// </summary>
		public override string DeleteStatement(string WhereClause)
		{
			return clsDAL.DeleteString("D02TS", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL xóa dữ liệu theo khóa chính.
		/// </summary>
		public override string DeleteStatement()
		{
			 return DeleteStatement(WhereById());
		}

		/// <summary>
		/// Tạo điều kiện tìm kiếm theo khóa chính.
		/// </summary>
		public override string WhereById()
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.AppendFormat("D02TS_HS_SOHS = {0}", clsDAL.IsDBNULL(D02TS_HS_SOHS, ProType.OTHER, this.DataManagement)).AppendFormat(" AND D02TS_HS_NAMDK = {0}", clsDAL.IsDBNULL(D02TS_HS_NAMDK, ProType.OTHER, this.DataManagement)).AppendFormat(" AND D02TS_ITEM_ID = {0}", clsDAL.IsDBNULL(D02TS_ITEM_ID, ProType.OTHER, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}