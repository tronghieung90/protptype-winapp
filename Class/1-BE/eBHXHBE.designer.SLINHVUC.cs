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
	/// Generated Class for Table : SLINHVUC.
	/// </summary>
	public partial class SLINHVUC : TableBase
	{
		public SLINHVUC() : base(){}

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
		private string m_LV_TENLINHVUC;
		/// <summary>
		/// LV_TENLINHVUC.
		/// </summary>
		public string LV_TENLINHVUC
		{
			get
			{
				return m_LV_TENLINHVUC;
			}
			set
			{
				if ((this.m_LV_TENLINHVUC != value))
				{
					this.SendPropertyChanging("LV_TENLINHVUC");
					this.m_LV_TENLINHVUC = value;
					this.SendPropertyChanged("LV_TENLINHVUC");
				}
			}
		}

		private string m_LV_GHICHU;
		private bool m_LV_GHICHUUpdated = false;
		/// <summary>
		/// LV_GHICHU.
		/// </summary>
		public string LV_GHICHU
		{
			get
			{
				return m_LV_GHICHU;
			}
			set
			{
				if ((this.m_LV_GHICHU != value))
				{
					this.SendPropertyChanging("LV_GHICHU");
					this.m_LV_GHICHU = value;
					this.SendPropertyChanged("LV_GHICHU");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_LV_GHICHUUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM SLINHVUC " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("LV_TENLINHVUC", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("LV_GHICHU", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO SLINHVUC (LV_TENLINHVUC, LV_GHICHU) VALUES(").Append(clsDAL.IsDBNULL(LV_TENLINHVUC, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(LV_GHICHU, ProType.STRING, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE SLINHVUC SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_LV_GHICHUUpdated ? string.Format(",LV_GHICHU = {0}", clsDAL.IsDBNULL(LV_GHICHU, ProType.STRING, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("LV_GHICHU = {0}", clsDAL.IsDBNULL(LV_GHICHU, ProType.STRING, this.DataManagement));
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
			return clsDAL.DeleteString("SLINHVUC", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("LV_TENLINHVUC = {0}", clsDAL.IsDBNULL(LV_TENLINHVUC, ProType.STRING, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}