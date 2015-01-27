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
	/// Generated Class for Table : SQUYTRINH.
	/// </summary>
	public partial class SQUYTRINH : TableBase
	{
		public SQUYTRINH() : base(){}

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
		private string m_QT_MACQ;
		/// <summary>
		/// QT_MACQ.
		/// </summary>
		public string QT_MACQ
		{
			get
			{
				return m_QT_MACQ;
			}
			set
			{
				if ((this.m_QT_MACQ != value))
				{
					this.SendPropertyChanging("QT_MACQ");
					this.m_QT_MACQ = value;
					this.SendPropertyChanged("QT_MACQ");
				}
			}
		}

		private string m_QT_MAPHONG;
		/// <summary>
		/// QT_MAPHONG.
		/// </summary>
		public string QT_MAPHONG
		{
			get
			{
				return m_QT_MAPHONG;
			}
			set
			{
				if ((this.m_QT_MAPHONG != value))
				{
					this.SendPropertyChanging("QT_MAPHONG");
					this.m_QT_MAPHONG = value;
					this.SendPropertyChanged("QT_MAPHONG");
				}
			}
		}

		private string m_QT_THUTUC_MA;
		/// <summary>
		/// QT_THUTUC_MA.
		/// </summary>
		public string QT_THUTUC_MA
		{
			get
			{
				return m_QT_THUTUC_MA;
			}
			set
			{
				if ((this.m_QT_THUTUC_MA != value))
				{
					this.SendPropertyChanging("QT_THUTUC_MA");
					this.m_QT_THUTUC_MA = value;
					this.SendPropertyChanged("QT_THUTUC_MA");
				}
			}
		}

		private string m_QT_THUTUTHUCHIEN;
		/// <summary>
		/// QT_THUTUTHUCHIEN.
		/// </summary>
		public string QT_THUTUTHUCHIEN
		{
			get
			{
				return m_QT_THUTUTHUCHIEN;
			}
			set
			{
				if ((this.m_QT_THUTUTHUCHIEN != value))
				{
					this.SendPropertyChanging("QT_THUTUTHUCHIEN");
					this.m_QT_THUTUTHUCHIEN = value;
					this.SendPropertyChanged("QT_THUTUTHUCHIEN");
				}
			}
		}

		private string m_QT_SONGAYTHUCHIEN = "1";
		private bool m_QT_SONGAYTHUCHIENUpdated = false;
		/// <summary>
		/// QT_SONGAYTHUCHIEN.
		/// </summary>
		public string QT_SONGAYTHUCHIEN
		{
			get
			{
				return m_QT_SONGAYTHUCHIEN;
			}
			set
			{
				if ((this.m_QT_SONGAYTHUCHIEN != value))
				{
					this.SendPropertyChanging("QT_SONGAYTHUCHIEN");
					this.m_QT_SONGAYTHUCHIEN = value;
					this.SendPropertyChanged("QT_SONGAYTHUCHIEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_QT_SONGAYTHUCHIENUpdated = true;
				}
			}
		}

		private string m_QT_TYTRONG = "0";
		private bool m_QT_TYTRONGUpdated = false;
		/// <summary>
		/// QT_TYTRONG.
		/// </summary>
		public string QT_TYTRONG
		{
			get
			{
				return m_QT_TYTRONG;
			}
			set
			{
				if ((this.m_QT_TYTRONG != value))
				{
					this.SendPropertyChanging("QT_TYTRONG");
					this.m_QT_TYTRONG = value;
					this.SendPropertyChanged("QT_TYTRONG");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_QT_TYTRONGUpdated = true;
				}
			}
		}

		private string m_QT_GHICHU;
		private bool m_QT_GHICHUUpdated = false;
		/// <summary>
		/// QT_GHICHU.
		/// </summary>
		public string QT_GHICHU
		{
			get
			{
				return m_QT_GHICHU;
			}
			set
			{
				if ((this.m_QT_GHICHU != value))
				{
					this.SendPropertyChanging("QT_GHICHU");
					this.m_QT_GHICHU = value;
					this.SendPropertyChanged("QT_GHICHU");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_QT_GHICHUUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM SQUYTRINH " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("QT_MACQ", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("QT_MAPHONG", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("QT_THUTUC_MA", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("QT_THUTUTHUCHIEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("QT_SONGAYTHUCHIEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("QT_TYTRONG", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("QT_GHICHU", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO SQUYTRINH (QT_MACQ, QT_MAPHONG, QT_THUTUC_MA, QT_SONGAYTHUCHIEN, QT_TYTRONG, QT_GHICHU) VALUES(").Append(clsDAL.IsDBNULL(QT_MACQ, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(QT_MAPHONG, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(QT_THUTUC_MA, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(QT_SONGAYTHUCHIEN, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(QT_TYTRONG, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(QT_GHICHU, ProType.STRING, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE SQUYTRINH SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_QT_SONGAYTHUCHIENUpdated ? string.Format(",QT_SONGAYTHUCHIEN = {0}", clsDAL.IsDBNULL(QT_SONGAYTHUCHIEN, ProType.OTHER, this.DataManagement)) : string.Empty).Append(m_QT_TYTRONGUpdated ? string.Format(",QT_TYTRONG = {0}", clsDAL.IsDBNULL(QT_TYTRONG, ProType.OTHER, this.DataManagement)) : string.Empty).Append(m_QT_GHICHUUpdated ? string.Format(",QT_GHICHU = {0}", clsDAL.IsDBNULL(QT_GHICHU, ProType.STRING, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("QT_SONGAYTHUCHIEN = {0}", clsDAL.IsDBNULL(QT_SONGAYTHUCHIEN, ProType.OTHER, this.DataManagement)).AppendFormat(",QT_TYTRONG = {0}", clsDAL.IsDBNULL(QT_TYTRONG, ProType.OTHER, this.DataManagement)).AppendFormat(",QT_GHICHU = {0}", clsDAL.IsDBNULL(QT_GHICHU, ProType.STRING, this.DataManagement));
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
			return clsDAL.DeleteString("SQUYTRINH", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("QT_MACQ = {0}", clsDAL.IsDBNULL(QT_MACQ, ProType.STRING, this.DataManagement)).AppendFormat(" AND QT_MAPHONG = {0}", clsDAL.IsDBNULL(QT_MAPHONG, ProType.STRING, this.DataManagement)).AppendFormat(" AND QT_THUTUC_MA = {0}", clsDAL.IsDBNULL(QT_THUTUC_MA, ProType.STRING, this.DataManagement)).AppendFormat(" AND QT_THUTUTHUCHIEN = {0}", clsDAL.IsDBNULL(QT_THUTUTHUCHIEN, ProType.OTHER, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}