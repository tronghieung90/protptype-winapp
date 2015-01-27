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
	/// Generated Class for Table : SLINHVUCTHUTUC.
	/// </summary>
	public partial class SLINHVUCTHUTUC : TableBase
	{
		public SLINHVUCTHUTUC() : base(){}

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
		private string m_LVTT_TENLINHVUC;
		/// <summary>
		/// LVTT_TENLINHVUC.
		/// </summary>
		public string LVTT_TENLINHVUC
		{
			get
			{
				return m_LVTT_TENLINHVUC;
			}
			set
			{
				if ((this.m_LVTT_TENLINHVUC != value))
				{
					this.SendPropertyChanging("LVTT_TENLINHVUC");
					this.m_LVTT_TENLINHVUC = value;
					this.SendPropertyChanged("LVTT_TENLINHVUC");
				}
			}
		}

		private string m_LVTT_THUTUC_MA;
		/// <summary>
		/// LVTT_THUTUC_MA.
		/// </summary>
		public string LVTT_THUTUC_MA
		{
			get
			{
				return m_LVTT_THUTUC_MA;
			}
			set
			{
				if ((this.m_LVTT_THUTUC_MA != value))
				{
					this.SendPropertyChanging("LVTT_THUTUC_MA");
					this.m_LVTT_THUTUC_MA = value;
					this.SendPropertyChanged("LVTT_THUTUC_MA");
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM SLINHVUCTHUTUC " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("LVTT_TENLINHVUC", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("LVTT_THUTUC_MA", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO SLINHVUCTHUTUC (LVTT_TENLINHVUC, LVTT_THUTUC_MA) VALUES(").Append(clsDAL.IsDBNULL(LVTT_TENLINHVUC, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(LVTT_THUTUC_MA, ProType.STRING, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE SLINHVUCTHUTUC SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL xóa dữ liêu.
		/// </summary>
		public override string DeleteStatement(string WhereClause)
		{
			return clsDAL.DeleteString("SLINHVUCTHUTUC", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("LVTT_TENLINHVUC = {0}", clsDAL.IsDBNULL(LVTT_TENLINHVUC, ProType.STRING, this.DataManagement)).AppendFormat(" AND LVTT_THUTUC_MA = {0}", clsDAL.IsDBNULL(LVTT_THUTUC_MA, ProType.STRING, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}