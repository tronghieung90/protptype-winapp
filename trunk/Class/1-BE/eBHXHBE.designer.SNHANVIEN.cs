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
	/// Generated Class for Table : SNHANVIEN.
	/// </summary>
	public partial class SNHANVIEN : TableBase
	{
		public SNHANVIEN() : base(){}

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
		private string m_NV_MACQ;
		/// <summary>
		/// NV_MACQ.
		/// </summary>
		public string NV_MACQ
		{
			get
			{
				return m_NV_MACQ;
			}
			set
			{
				if ((this.m_NV_MACQ != value))
				{
					this.SendPropertyChanging("NV_MACQ");
					this.m_NV_MACQ = value;
					this.SendPropertyChanged("NV_MACQ");
				}
			}
		}

		private string m_NV_MAPHONG;
		/// <summary>
		/// NV_MAPHONG.
		/// </summary>
		public string NV_MAPHONG
		{
			get
			{
				return m_NV_MAPHONG;
			}
			set
			{
				if ((this.m_NV_MAPHONG != value))
				{
					this.SendPropertyChanging("NV_MAPHONG");
					this.m_NV_MAPHONG = value;
					this.SendPropertyChanged("NV_MAPHONG");
				}
			}
		}

		private string m_NV_TAIKHOAN;
		/// <summary>
		/// NV_TAIKHOAN.
		/// </summary>
		public string NV_TAIKHOAN
		{
			get
			{
				return m_NV_TAIKHOAN;
			}
			set
			{
				if ((this.m_NV_TAIKHOAN != value))
				{
					this.SendPropertyChanging("NV_TAIKHOAN");
					this.m_NV_TAIKHOAN = value;
					this.SendPropertyChanged("NV_TAIKHOAN");
				}
			}
		}

		private bool m_NV_LANHDAO = false;
		private bool m_NV_LANHDAOUpdated = false;
		/// <summary>
		/// NV_LANHDAO.
		/// </summary>
		public bool NV_LANHDAO
		{
			get
			{
				return m_NV_LANHDAO;
			}
			set
			{
				if ((this.m_NV_LANHDAO != value))
				{
					this.SendPropertyChanging("NV_LANHDAO");
					this.m_NV_LANHDAO = value;
					this.SendPropertyChanged("NV_LANHDAO");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_NV_LANHDAOUpdated = true;
				}
			}
		}

		private bool m_NV_NHANVIEN = true;
		private bool m_NV_NHANVIENUpdated = false;
		/// <summary>
		/// NV_NHANVIEN.
		/// </summary>
		public bool NV_NHANVIEN
		{
			get
			{
				return m_NV_NHANVIEN;
			}
			set
			{
				if ((this.m_NV_NHANVIEN != value))
				{
					this.SendPropertyChanging("NV_NHANVIEN");
					this.m_NV_NHANVIEN = value;
					this.SendPropertyChanged("NV_NHANVIEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_NV_NHANVIENUpdated = true;
				}
			}
		}

		private bool m_NV_QUANTRI = false;
		private bool m_NV_QUANTRIUpdated = false;
		/// <summary>
		/// NV_QUANTRI.
		/// </summary>
		public bool NV_QUANTRI
		{
			get
			{
				return m_NV_QUANTRI;
			}
			set
			{
				if ((this.m_NV_QUANTRI != value))
				{
					this.SendPropertyChanging("NV_QUANTRI");
					this.m_NV_QUANTRI = value;
					this.SendPropertyChanged("NV_QUANTRI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_NV_QUANTRIUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM SNHANVIEN " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("NV_MACQ", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("NV_MAPHONG", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("NV_TAIKHOAN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("NV_LANHDAO", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("NV_NHANVIEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("NV_QUANTRI", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO SNHANVIEN (NV_MACQ, NV_MAPHONG, NV_TAIKHOAN, NV_LANHDAO, NV_NHANVIEN, NV_QUANTRI) VALUES(").Append(clsDAL.IsDBNULL(NV_MACQ, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(NV_MAPHONG, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(NV_TAIKHOAN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(NV_LANHDAO, ProType.BOOL, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(NV_NHANVIEN, ProType.BOOL, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(NV_QUANTRI, ProType.BOOL, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE SNHANVIEN SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_NV_LANHDAOUpdated ? string.Format(",NV_LANHDAO = {0}", clsDAL.IsDBNULL(NV_LANHDAO, ProType.BOOL, this.DataManagement)) : string.Empty).Append(m_NV_NHANVIENUpdated ? string.Format(",NV_NHANVIEN = {0}", clsDAL.IsDBNULL(NV_NHANVIEN, ProType.BOOL, this.DataManagement)) : string.Empty).Append(m_NV_QUANTRIUpdated ? string.Format(",NV_QUANTRI = {0}", clsDAL.IsDBNULL(NV_QUANTRI, ProType.BOOL, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("NV_LANHDAO = {0}", clsDAL.IsDBNULL(NV_LANHDAO, ProType.BOOL, this.DataManagement)).AppendFormat(",NV_NHANVIEN = {0}", clsDAL.IsDBNULL(NV_NHANVIEN, ProType.BOOL, this.DataManagement)).AppendFormat(",NV_QUANTRI = {0}", clsDAL.IsDBNULL(NV_QUANTRI, ProType.BOOL, this.DataManagement));
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
			return clsDAL.DeleteString("SNHANVIEN", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("NV_MACQ = {0}", clsDAL.IsDBNULL(NV_MACQ, ProType.STRING, this.DataManagement)).AppendFormat(" AND NV_MAPHONG = {0}", clsDAL.IsDBNULL(NV_MAPHONG, ProType.STRING, this.DataManagement)).AppendFormat(" AND NV_TAIKHOAN = {0}", clsDAL.IsDBNULL(NV_TAIKHOAN, ProType.STRING, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}