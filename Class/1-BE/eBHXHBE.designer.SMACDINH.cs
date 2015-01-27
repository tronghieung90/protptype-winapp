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
	/// Generated Class for Table : SMACDINH.
	/// </summary>
	public partial class SMACDINH : TableBase
	{
		public SMACDINH() : base(){}

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
		private string m_LOGIN_NAME;
		/// <summary>
		/// LOGIN_NAME.
		/// </summary>
		public string LOGIN_NAME
		{
			get
			{
				return m_LOGIN_NAME;
			}
			set
			{
				if ((this.m_LOGIN_NAME != value))
				{
					this.SendPropertyChanging("LOGIN_NAME");
					this.m_LOGIN_NAME = value;
					this.SendPropertyChanged("LOGIN_NAME");
				}
			}
		}

		private string m_MA_GT;
		private bool m_MA_GTUpdated = false;
		/// <summary>
		/// MA_GT.
		/// </summary>
		public string MA_GT
		{
			get
			{
				return m_MA_GT;
			}
			set
			{
				if ((this.m_MA_GT != value))
				{
					this.SendPropertyChanging("MA_GT");
					this.m_MA_GT = value;
					this.SendPropertyChanged("MA_GT");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_MA_GTUpdated = true;
				}
			}
		}

		private string m_GIA_TRI;
		private bool m_GIA_TRIUpdated = false;
		/// <summary>
		/// GIA_TRI.
		/// </summary>
		public string GIA_TRI
		{
			get
			{
				return m_GIA_TRI;
			}
			set
			{
				if ((this.m_GIA_TRI != value))
				{
					this.SendPropertyChanging("GIA_TRI");
					this.m_GIA_TRI = value;
					this.SendPropertyChanged("GIA_TRI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_GIA_TRIUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM SMACDINH " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("LOGIN_NAME", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("MA_GT", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("GIA_TRI", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO SMACDINH (LOGIN_NAME, MA_GT, GIA_TRI) VALUES(").Append(clsDAL.IsDBNULL(LOGIN_NAME, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(MA_GT, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(GIA_TRI, ProType.STRING, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE SMACDINH SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_MA_GTUpdated ? string.Format(",MA_GT = {0}", clsDAL.IsDBNULL(MA_GT, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_GIA_TRIUpdated ? string.Format(",GIA_TRI = {0}", clsDAL.IsDBNULL(GIA_TRI, ProType.STRING, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("MA_GT = {0}", clsDAL.IsDBNULL(MA_GT, ProType.STRING, this.DataManagement)).AppendFormat(",GIA_TRI = {0}", clsDAL.IsDBNULL(GIA_TRI, ProType.STRING, this.DataManagement));
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
			return clsDAL.DeleteString("SMACDINH", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("LOGIN_NAME = {0}", clsDAL.IsDBNULL(LOGIN_NAME, ProType.STRING, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}