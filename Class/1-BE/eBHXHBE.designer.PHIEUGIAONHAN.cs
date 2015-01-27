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
	/// Generated Class for Table : PHIEUGIAONHAN.
	/// </summary>
	public partial class PHIEUGIAONHAN : TableBase
	{
		public PHIEUGIAONHAN() : base(){}

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
		private string m_PGN_HOSO_SOHS;
		/// <summary>
		/// PGN_HOSO_SOHS.
		/// </summary>
		public string PGN_HOSO_SOHS
		{
			get
			{
				return m_PGN_HOSO_SOHS;
			}
			set
			{
				if ((this.m_PGN_HOSO_SOHS != value))
				{
					this.SendPropertyChanging("PGN_HOSO_SOHS");
					this.m_PGN_HOSO_SOHS = value;
					this.SendPropertyChanged("PGN_HOSO_SOHS");
				}
			}
		}

		private string m_PGN_HOSO_NAMDK;
		/// <summary>
		/// PGN_HOSO_NAMDK.
		/// </summary>
		public string PGN_HOSO_NAMDK
		{
			get
			{
				return m_PGN_HOSO_NAMDK;
			}
			set
			{
				if ((this.m_PGN_HOSO_NAMDK != value))
				{
					this.SendPropertyChanging("PGN_HOSO_NAMDK");
					this.m_PGN_HOSO_NAMDK = value;
					this.SendPropertyChanged("PGN_HOSO_NAMDK");
				}
			}
		}

		private string m_PGN_BANGKE_MABK;
		/// <summary>
		/// PGN_BANGKE_MABK.
		/// </summary>
		public string PGN_BANGKE_MABK
		{
			get
			{
				return m_PGN_BANGKE_MABK;
			}
			set
			{
				if ((this.m_PGN_BANGKE_MABK != value))
				{
					this.SendPropertyChanging("PGN_BANGKE_MABK");
					this.m_PGN_BANGKE_MABK = value;
					this.SendPropertyChanged("PGN_BANGKE_MABK");
				}
			}
		}

		private string m_PGN_BANGKE_TEN;
		private bool m_PGN_BANGKE_TENUpdated = false;
		/// <summary>
		/// PGN_BANGKE_TEN.
		/// </summary>
		public string PGN_BANGKE_TEN
		{
			get
			{
				return m_PGN_BANGKE_TEN;
			}
			set
			{
				if ((this.m_PGN_BANGKE_TEN != value))
				{
					this.SendPropertyChanging("PGN_BANGKE_TEN");
					this.m_PGN_BANGKE_TEN = value;
					this.SendPropertyChanged("PGN_BANGKE_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_PGN_BANGKE_TENUpdated = true;
				}
			}
		}

		private string m_PGN_BANGKE_SOLUONG = "1";
		private bool m_PGN_BANGKE_SOLUONGUpdated = false;
		/// <summary>
		/// PGN_BANGKE_SOLUONG.
		/// </summary>
		public string PGN_BANGKE_SOLUONG
		{
			get
			{
				return m_PGN_BANGKE_SOLUONG;
			}
			set
			{
				if ((this.m_PGN_BANGKE_SOLUONG != value))
				{
					this.SendPropertyChanging("PGN_BANGKE_SOLUONG");
					this.m_PGN_BANGKE_SOLUONG = value;
					this.SendPropertyChanged("PGN_BANGKE_SOLUONG");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_PGN_BANGKE_SOLUONGUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM PHIEUGIAONHAN " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("PGN_HOSO_SOHS", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("PGN_HOSO_NAMDK", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("PGN_BANGKE_MABK", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("PGN_BANGKE_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("PGN_BANGKE_SOLUONG", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO PHIEUGIAONHAN (PGN_HOSO_SOHS, PGN_HOSO_NAMDK, PGN_BANGKE_MABK, PGN_BANGKE_TEN, PGN_BANGKE_SOLUONG) VALUES(").Append(clsDAL.IsDBNULL(PGN_HOSO_SOHS, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(PGN_HOSO_NAMDK, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(PGN_BANGKE_MABK, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(PGN_BANGKE_TEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(PGN_BANGKE_SOLUONG, ProType.OTHER, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE PHIEUGIAONHAN SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_PGN_BANGKE_TENUpdated ? string.Format(",PGN_BANGKE_TEN = {0}", clsDAL.IsDBNULL(PGN_BANGKE_TEN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_PGN_BANGKE_SOLUONGUpdated ? string.Format(",PGN_BANGKE_SOLUONG = {0}", clsDAL.IsDBNULL(PGN_BANGKE_SOLUONG, ProType.OTHER, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("PGN_BANGKE_TEN = {0}", clsDAL.IsDBNULL(PGN_BANGKE_TEN, ProType.STRING, this.DataManagement)).AppendFormat(",PGN_BANGKE_SOLUONG = {0}", clsDAL.IsDBNULL(PGN_BANGKE_SOLUONG, ProType.OTHER, this.DataManagement));
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
			return clsDAL.DeleteString("PHIEUGIAONHAN", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("PGN_HOSO_SOHS = {0}", clsDAL.IsDBNULL(PGN_HOSO_SOHS, ProType.OTHER, this.DataManagement)).AppendFormat(" AND PGN_HOSO_NAMDK = {0}", clsDAL.IsDBNULL(PGN_HOSO_NAMDK, ProType.OTHER, this.DataManagement)).AppendFormat(" AND PGN_BANGKE_MABK = {0}", clsDAL.IsDBNULL(PGN_BANGKE_MABK, ProType.STRING, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}