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
	/// Generated Class for Table : SPHANCONG.
	/// </summary>
	public partial class SPHANCONG : TableBase
	{
		public SPHANCONG() : base(){}

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
		private string m_PC_MACQ;
		/// <summary>
		/// PC_MACQ.
		/// </summary>
		public string PC_MACQ
		{
			get
			{
				return m_PC_MACQ;
			}
			set
			{
				if ((this.m_PC_MACQ != value))
				{
					this.SendPropertyChanging("PC_MACQ");
					this.m_PC_MACQ = value;
					this.SendPropertyChanged("PC_MACQ");
				}
			}
		}

		private string m_PC_MAPHONG;
		/// <summary>
		/// PC_MAPHONG.
		/// </summary>
		public string PC_MAPHONG
		{
			get
			{
				return m_PC_MAPHONG;
			}
			set
			{
				if ((this.m_PC_MAPHONG != value))
				{
					this.SendPropertyChanging("PC_MAPHONG");
					this.m_PC_MAPHONG = value;
					this.SendPropertyChanged("PC_MAPHONG");
				}
			}
		}

		private string m_PC_TAIKHOAN_LANHDAO;
		private bool m_PC_TAIKHOAN_LANHDAOUpdated = false;
		/// <summary>
		/// PC_TAIKHOAN_LANHDAO.
		/// </summary>
		public string PC_TAIKHOAN_LANHDAO
		{
			get
			{
				return m_PC_TAIKHOAN_LANHDAO;
			}
			set
			{
				if ((this.m_PC_TAIKHOAN_LANHDAO != value))
				{
					this.SendPropertyChanging("PC_TAIKHOAN_LANHDAO");
					this.m_PC_TAIKHOAN_LANHDAO = value;
					this.SendPropertyChanged("PC_TAIKHOAN_LANHDAO");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_PC_TAIKHOAN_LANHDAOUpdated = true;
				}
			}
		}

		private string m_PC_TAIKHOAN_NHANVIEN;
		/// <summary>
		/// PC_TAIKHOAN_NHANVIEN.
		/// </summary>
		public string PC_TAIKHOAN_NHANVIEN
		{
			get
			{
				return m_PC_TAIKHOAN_NHANVIEN;
			}
			set
			{
				if ((this.m_PC_TAIKHOAN_NHANVIEN != value))
				{
					this.SendPropertyChanging("PC_TAIKHOAN_NHANVIEN");
					this.m_PC_TAIKHOAN_NHANVIEN = value;
					this.SendPropertyChanged("PC_TAIKHOAN_NHANVIEN");
				}
			}
		}

		private string m_PC_DONVI_MST;
		/// <summary>
		/// PC_DONVI_MST.
		/// </summary>
		public string PC_DONVI_MST
		{
			get
			{
				return m_PC_DONVI_MST;
			}
			set
			{
				if ((this.m_PC_DONVI_MST != value))
				{
					this.SendPropertyChanging("PC_DONVI_MST");
					this.m_PC_DONVI_MST = value;
					this.SendPropertyChanged("PC_DONVI_MST");
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM SPHANCONG " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("PC_MACQ", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("PC_MAPHONG", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("PC_TAIKHOAN_LANHDAO", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("PC_TAIKHOAN_NHANVIEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("PC_DONVI_MST", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO SPHANCONG (PC_MACQ, PC_MAPHONG, PC_TAIKHOAN_LANHDAO, PC_TAIKHOAN_NHANVIEN, PC_DONVI_MST) VALUES(").Append(clsDAL.IsDBNULL(PC_MACQ, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(PC_MAPHONG, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(PC_TAIKHOAN_LANHDAO, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(PC_TAIKHOAN_NHANVIEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(PC_DONVI_MST, ProType.STRING, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE SPHANCONG SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_PC_TAIKHOAN_LANHDAOUpdated ? string.Format(",PC_TAIKHOAN_LANHDAO = {0}", clsDAL.IsDBNULL(PC_TAIKHOAN_LANHDAO, ProType.STRING, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("PC_TAIKHOAN_LANHDAO = {0}", clsDAL.IsDBNULL(PC_TAIKHOAN_LANHDAO, ProType.STRING, this.DataManagement));
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
			return clsDAL.DeleteString("SPHANCONG", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("PC_MACQ = {0}", clsDAL.IsDBNULL(PC_MACQ, ProType.STRING, this.DataManagement)).AppendFormat(" AND PC_MAPHONG = {0}", clsDAL.IsDBNULL(PC_MAPHONG, ProType.STRING, this.DataManagement)).AppendFormat(" AND PC_TAIKHOAN_NHANVIEN = {0}", clsDAL.IsDBNULL(PC_TAIKHOAN_NHANVIEN, ProType.STRING, this.DataManagement)).AppendFormat(" AND PC_DONVI_MST = {0}", clsDAL.IsDBNULL(PC_DONVI_MST, ProType.STRING, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}