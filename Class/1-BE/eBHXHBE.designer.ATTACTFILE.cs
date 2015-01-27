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
	/// Generated Class for Table : ATTACTFILE.
	/// </summary>
	public partial class ATTACTFILE : TableBase
	{
		public ATTACTFILE() : base(){}

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
		private string m_AT_ID;
		/// <summary>
		/// AT_ID.
		/// </summary>
		public string AT_ID
		{
			get
			{
				return m_AT_ID;
			}
			set
			{
				if ((this.m_AT_ID != value))
				{
					this.SendPropertyChanging("AT_ID");
					this.m_AT_ID = value;
					this.SendPropertyChanged("AT_ID");
				}
			}
		}

		private string m_AT_HS_SOHS;
		/// <summary>
		/// AT_HS_SOHS.
		/// </summary>
		public string AT_HS_SOHS
		{
			get
			{
				return m_AT_HS_SOHS;
			}
			set
			{
				if ((this.m_AT_HS_SOHS != value))
				{
					this.SendPropertyChanging("AT_HS_SOHS");
					this.m_AT_HS_SOHS = value;
					this.SendPropertyChanged("AT_HS_SOHS");
				}
			}
		}

		private string m_AT_HS_NAMDK;
		/// <summary>
		/// AT_HS_NAMDK.
		/// </summary>
		public string AT_HS_NAMDK
		{
			get
			{
				return m_AT_HS_NAMDK;
			}
			set
			{
				if ((this.m_AT_HS_NAMDK != value))
				{
					this.SendPropertyChanging("AT_HS_NAMDK");
					this.m_AT_HS_NAMDK = value;
					this.SendPropertyChanged("AT_HS_NAMDK");
				}
			}
		}

		private string m_AT_FileName;
		private bool m_AT_FileNameUpdated = false;
		/// <summary>
		/// AT_FileName.
		/// </summary>
		public string AT_FileName
		{
			get
			{
				return m_AT_FileName;
			}
			set
			{
				if ((this.m_AT_FileName != value))
				{
					this.SendPropertyChanging("AT_FileName");
					this.m_AT_FileName = value;
					this.SendPropertyChanged("AT_FileName");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_AT_FileNameUpdated = true;
				}
			}
		}

		private string m_AT_FileContent;
		private bool m_AT_FileContentUpdated = false;
		/// <summary>
		/// AT_FileContent.
		/// </summary>
		public string AT_FileContent
		{
			get
			{
				return m_AT_FileContent;
			}
			set
			{
				if ((this.m_AT_FileContent != value))
				{
					this.SendPropertyChanging("AT_FileContent");
					this.m_AT_FileContent = value;
					this.SendPropertyChanged("AT_FileContent");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_AT_FileContentUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM ATTACTFILE " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("AT_ID", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("AT_HS_SOHS", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("AT_HS_NAMDK", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("AT_FileName", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("AT_FileContent", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO ATTACTFILE (AT_HS_SOHS, AT_HS_NAMDK, AT_FileName, AT_FileContent) VALUES(").Append(clsDAL.IsDBNULL(AT_HS_SOHS, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(AT_HS_NAMDK, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(AT_FileName, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(AT_FileContent, ProType.STRING, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE ATTACTFILE SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_AT_FileNameUpdated ? string.Format(",AT_FileName = {0}", clsDAL.IsDBNULL(AT_FileName, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_AT_FileContentUpdated ? string.Format(",AT_FileContent = {0}", clsDAL.IsDBNULL(AT_FileContent, ProType.STRING, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("AT_FileName = {0}", clsDAL.IsDBNULL(AT_FileName, ProType.STRING, this.DataManagement)).AppendFormat(",AT_FileContent = {0}", clsDAL.IsDBNULL(AT_FileContent, ProType.STRING, this.DataManagement));
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
			return clsDAL.DeleteString("ATTACTFILE", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("AT_ID = {0}", clsDAL.IsDBNULL(AT_ID, ProType.OTHER, this.DataManagement)).AppendFormat(" AND AT_HS_SOHS = {0}", clsDAL.IsDBNULL(AT_HS_SOHS, ProType.OTHER, this.DataManagement)).AppendFormat(" AND AT_HS_NAMDK = {0}", clsDAL.IsDBNULL(AT_HS_NAMDK, ProType.OTHER, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}