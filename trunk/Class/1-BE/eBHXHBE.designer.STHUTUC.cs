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
	/// Generated Class for Table : STHUTUC.
	/// </summary>
	public partial class STHUTUC : TableBase
	{
		public STHUTUC() : base(){}

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
		private string m_TT_THUTUC_MA;
		/// <summary>
		/// TT_THUTUC_MA.
		/// </summary>
		public string TT_THUTUC_MA
		{
			get
			{
				return m_TT_THUTUC_MA;
			}
			set
			{
				if ((this.m_TT_THUTUC_MA != value))
				{
					this.SendPropertyChanging("TT_THUTUC_MA");
					this.m_TT_THUTUC_MA = value;
					this.SendPropertyChanged("TT_THUTUC_MA");
				}
			}
		}

		private string m_TT_THUTUC_TEN;
		private bool m_TT_THUTUC_TENUpdated = false;
		/// <summary>
		/// TT_THUTUC_TEN.
		/// </summary>
		public string TT_THUTUC_TEN
		{
			get
			{
				return m_TT_THUTUC_TEN;
			}
			set
			{
				if ((this.m_TT_THUTUC_TEN != value))
				{
					this.SendPropertyChanging("TT_THUTUC_TEN");
					this.m_TT_THUTUC_TEN = value;
					this.SendPropertyChanged("TT_THUTUC_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TT_THUTUC_TENUpdated = true;
				}
			}
		}

		private string m_TT_SONGAYTHUCHIEN = "10";
		private bool m_TT_SONGAYTHUCHIENUpdated = false;
		/// <summary>
		/// TT_SONGAYTHUCHIEN.
		/// </summary>
		public string TT_SONGAYTHUCHIEN
		{
			get
			{
				return m_TT_SONGAYTHUCHIEN;
			}
			set
			{
				if ((this.m_TT_SONGAYTHUCHIEN != value))
				{
					this.SendPropertyChanging("TT_SONGAYTHUCHIEN");
					this.m_TT_SONGAYTHUCHIEN = value;
					this.SendPropertyChanged("TT_SONGAYTHUCHIEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TT_SONGAYTHUCHIENUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM STHUTUC " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("TT_THUTUC_MA", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TT_THUTUC_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TT_SONGAYTHUCHIEN", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO STHUTUC (TT_THUTUC_MA, TT_THUTUC_TEN, TT_SONGAYTHUCHIEN) VALUES(").Append(clsDAL.IsDBNULL(TT_THUTUC_MA, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TT_THUTUC_TEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TT_SONGAYTHUCHIEN, ProType.OTHER, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE STHUTUC SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_TT_THUTUC_TENUpdated ? string.Format(",TT_THUTUC_TEN = {0}", clsDAL.IsDBNULL(TT_THUTUC_TEN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_TT_SONGAYTHUCHIENUpdated ? string.Format(",TT_SONGAYTHUCHIEN = {0}", clsDAL.IsDBNULL(TT_SONGAYTHUCHIEN, ProType.OTHER, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("TT_THUTUC_TEN = {0}", clsDAL.IsDBNULL(TT_THUTUC_TEN, ProType.STRING, this.DataManagement)).AppendFormat(",TT_SONGAYTHUCHIEN = {0}", clsDAL.IsDBNULL(TT_SONGAYTHUCHIEN, ProType.OTHER, this.DataManagement));
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
			return clsDAL.DeleteString("STHUTUC", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("TT_THUTUC_MA = {0}", clsDAL.IsDBNULL(TT_THUTUC_MA, ProType.STRING, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}