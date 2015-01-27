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
	/// Generated Class for Table : SBANGKE.
	/// </summary>
	public partial class SBANGKE : TableBase
	{
		public SBANGKE() : base(){}

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
		private string m_SBK_MABK;
		/// <summary>
		/// SBK_MABK.
		/// </summary>
		public string SBK_MABK
		{
			get
			{
				return m_SBK_MABK;
			}
			set
			{
				if ((this.m_SBK_MABK != value))
				{
					this.SendPropertyChanging("SBK_MABK");
					this.m_SBK_MABK = value;
					this.SendPropertyChanged("SBK_MABK");
				}
			}
		}

		private string m_SBK_TENBK;
		private bool m_SBK_TENBKUpdated = false;
		/// <summary>
		/// SBK_TENBK.
		/// </summary>
		public string SBK_TENBK
		{
			get
			{
				return m_SBK_TENBK;
			}
			set
			{
				if ((this.m_SBK_TENBK != value))
				{
					this.SendPropertyChanging("SBK_TENBK");
					this.m_SBK_TENBK = value;
					this.SendPropertyChanged("SBK_TENBK");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_SBK_TENBKUpdated = true;
				}
			}
		}

		private string m_SBK_GHICHU;
		private bool m_SBK_GHICHUUpdated = false;
		/// <summary>
		/// SBK_GHICHU.
		/// </summary>
		public string SBK_GHICHU
		{
			get
			{
				return m_SBK_GHICHU;
			}
			set
			{
				if ((this.m_SBK_GHICHU != value))
				{
					this.SendPropertyChanging("SBK_GHICHU");
					this.m_SBK_GHICHU = value;
					this.SendPropertyChanged("SBK_GHICHU");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_SBK_GHICHUUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM SBANGKE " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("SBK_MABK", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("SBK_TENBK", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("SBK_GHICHU", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO SBANGKE (SBK_MABK, SBK_TENBK, SBK_GHICHU) VALUES(").Append(clsDAL.IsDBNULL(SBK_MABK, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(SBK_TENBK, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(SBK_GHICHU, ProType.STRING, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE SBANGKE SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_SBK_TENBKUpdated ? string.Format(",SBK_TENBK = {0}", clsDAL.IsDBNULL(SBK_TENBK, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_SBK_GHICHUUpdated ? string.Format(",SBK_GHICHU = {0}", clsDAL.IsDBNULL(SBK_GHICHU, ProType.STRING, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("SBK_TENBK = {0}", clsDAL.IsDBNULL(SBK_TENBK, ProType.STRING, this.DataManagement)).AppendFormat(",SBK_GHICHU = {0}", clsDAL.IsDBNULL(SBK_GHICHU, ProType.STRING, this.DataManagement));
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
			return clsDAL.DeleteString("SBANGKE", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("SBK_MABK = {0}", clsDAL.IsDBNULL(SBK_MABK, ProType.STRING, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}