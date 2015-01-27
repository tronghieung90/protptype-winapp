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
	/// Generated Class for Table : STHUTUCBANGKE.
	/// </summary>
	public partial class STHUTUCBANGKE : TableBase
	{
		public STHUTUCBANGKE() : base(){}

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
		private string m_TTBK_THUTUC_MA;
		/// <summary>
		/// TTBK_THUTUC_MA.
		/// </summary>
		public string TTBK_THUTUC_MA
		{
			get
			{
				return m_TTBK_THUTUC_MA;
			}
			set
			{
				if ((this.m_TTBK_THUTUC_MA != value))
				{
					this.SendPropertyChanging("TTBK_THUTUC_MA");
					this.m_TTBK_THUTUC_MA = value;
					this.SendPropertyChanged("TTBK_THUTUC_MA");
				}
			}
		}

		private string m_TTBK_MABK;
		/// <summary>
		/// TTBK_MABK.
		/// </summary>
		public string TTBK_MABK
		{
			get
			{
				return m_TTBK_MABK;
			}
			set
			{
				if ((this.m_TTBK_MABK != value))
				{
					this.SendPropertyChanging("TTBK_MABK");
					this.m_TTBK_MABK = value;
					this.SendPropertyChanged("TTBK_MABK");
				}
			}
		}

		private string m_TTBK_SOLUONG = "1";
		private bool m_TTBK_SOLUONGUpdated = false;
		/// <summary>
		/// TTBK_SOLUONG.
		/// </summary>
		public string TTBK_SOLUONG
		{
			get
			{
				return m_TTBK_SOLUONG;
			}
			set
			{
				if ((this.m_TTBK_SOLUONG != value))
				{
					this.SendPropertyChanging("TTBK_SOLUONG");
					this.m_TTBK_SOLUONG = value;
					this.SendPropertyChanged("TTBK_SOLUONG");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TTBK_SOLUONGUpdated = true;
				}
			}
		}

		private bool m_TTBK_BATBUOC = false;
		private bool m_TTBK_BATBUOCUpdated = false;
		/// <summary>
		/// TTBK_BATBUOC.
		/// </summary>
		public bool TTBK_BATBUOC
		{
			get
			{
				return m_TTBK_BATBUOC;
			}
			set
			{
				if ((this.m_TTBK_BATBUOC != value))
				{
					this.SendPropertyChanging("TTBK_BATBUOC");
					this.m_TTBK_BATBUOC = value;
					this.SendPropertyChanged("TTBK_BATBUOC");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TTBK_BATBUOCUpdated = true;
				}
			}
		}

		private bool m_TTBK_YEUCAUTOICANHAN = false;
		private bool m_TTBK_YEUCAUTOICANHANUpdated = false;
		/// <summary>
		/// TTBK_YEUCAUTOICANHAN.
		/// </summary>
		public bool TTBK_YEUCAUTOICANHAN
		{
			get
			{
				return m_TTBK_YEUCAUTOICANHAN;
			}
			set
			{
				if ((this.m_TTBK_YEUCAUTOICANHAN != value))
				{
					this.SendPropertyChanging("TTBK_YEUCAUTOICANHAN");
					this.m_TTBK_YEUCAUTOICANHAN = value;
					this.SendPropertyChanged("TTBK_YEUCAUTOICANHAN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TTBK_YEUCAUTOICANHANUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM STHUTUCBANGKE " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("TTBK_THUTUC_MA", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TTBK_MABK", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TTBK_SOLUONG", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TTBK_BATBUOC", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TTBK_YEUCAUTOICANHAN", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO STHUTUCBANGKE (TTBK_THUTUC_MA, TTBK_MABK, TTBK_SOLUONG, TTBK_BATBUOC, TTBK_YEUCAUTOICANHAN) VALUES(").Append(clsDAL.IsDBNULL(TTBK_THUTUC_MA, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TTBK_MABK, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TTBK_SOLUONG, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TTBK_BATBUOC, ProType.BOOL, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TTBK_YEUCAUTOICANHAN, ProType.BOOL, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE STHUTUCBANGKE SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_TTBK_SOLUONGUpdated ? string.Format(",TTBK_SOLUONG = {0}", clsDAL.IsDBNULL(TTBK_SOLUONG, ProType.OTHER, this.DataManagement)) : string.Empty).Append(m_TTBK_BATBUOCUpdated ? string.Format(",TTBK_BATBUOC = {0}", clsDAL.IsDBNULL(TTBK_BATBUOC, ProType.BOOL, this.DataManagement)) : string.Empty).Append(m_TTBK_YEUCAUTOICANHANUpdated ? string.Format(",TTBK_YEUCAUTOICANHAN = {0}", clsDAL.IsDBNULL(TTBK_YEUCAUTOICANHAN, ProType.BOOL, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("TTBK_SOLUONG = {0}", clsDAL.IsDBNULL(TTBK_SOLUONG, ProType.OTHER, this.DataManagement)).AppendFormat(",TTBK_BATBUOC = {0}", clsDAL.IsDBNULL(TTBK_BATBUOC, ProType.BOOL, this.DataManagement)).AppendFormat(",TTBK_YEUCAUTOICANHAN = {0}", clsDAL.IsDBNULL(TTBK_YEUCAUTOICANHAN, ProType.BOOL, this.DataManagement));
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
			return clsDAL.DeleteString("STHUTUCBANGKE", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("TTBK_THUTUC_MA = {0}", clsDAL.IsDBNULL(TTBK_THUTUC_MA, ProType.STRING, this.DataManagement)).AppendFormat(" AND TTBK_MABK = {0}", clsDAL.IsDBNULL(TTBK_MABK, ProType.STRING, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}