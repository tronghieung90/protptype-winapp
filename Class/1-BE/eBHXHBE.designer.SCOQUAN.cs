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
	/// Generated Class for Table : SCOQUAN.
	/// </summary>
	public partial class SCOQUAN : TableBase
	{
		public SCOQUAN() : base(){}

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
		private string m_CQ_MACQ;
		/// <summary>
		/// CQ_MACQ.
		/// </summary>
		public string CQ_MACQ
		{
			get
			{
				return m_CQ_MACQ;
			}
			set
			{
				if ((this.m_CQ_MACQ != value))
				{
					this.SendPropertyChanging("CQ_MACQ");
					this.m_CQ_MACQ = value;
					this.SendPropertyChanged("CQ_MACQ");
				}
			}
		}

		private string m_CQ_TENCQ;
		private bool m_CQ_TENCQUpdated = false;
		/// <summary>
		/// CQ_TENCQ.
		/// </summary>
		public string CQ_TENCQ
		{
			get
			{
				return m_CQ_TENCQ;
			}
			set
			{
				if ((this.m_CQ_TENCQ != value))
				{
					this.SendPropertyChanging("CQ_TENCQ");
					this.m_CQ_TENCQ = value;
					this.SendPropertyChanged("CQ_TENCQ");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CQ_TENCQUpdated = true;
				}
			}
		}

		private string m_CQ_MACQCAPTREN = "0";
		private bool m_CQ_MACQCAPTRENUpdated = false;
		/// <summary>
		/// CQ_MACQCAPTREN.
		/// </summary>
		public string CQ_MACQCAPTREN
		{
			get
			{
				return m_CQ_MACQCAPTREN;
			}
			set
			{
				if ((this.m_CQ_MACQCAPTREN != value))
				{
					this.SendPropertyChanging("CQ_MACQCAPTREN");
					this.m_CQ_MACQCAPTREN = value;
					this.SendPropertyChanged("CQ_MACQCAPTREN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CQ_MACQCAPTRENUpdated = true;
				}
			}
		}

		private string m_CQ_TENDIADANH;
		private bool m_CQ_TENDIADANHUpdated = false;
		/// <summary>
		/// CQ_TENDIADANH.
		/// </summary>
		public string CQ_TENDIADANH
		{
			get
			{
				return m_CQ_TENDIADANH;
			}
			set
			{
				if ((this.m_CQ_TENDIADANH != value))
				{
					this.SendPropertyChanging("CQ_TENDIADANH");
					this.m_CQ_TENDIADANH = value;
					this.SendPropertyChanged("CQ_TENDIADANH");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CQ_TENDIADANHUpdated = true;
				}
			}
		}

		private string m_CQ_NGUOIKY_TEN;
		private bool m_CQ_NGUOIKY_TENUpdated = false;
		/// <summary>
		/// CQ_NGUOIKY_TEN.
		/// </summary>
		public string CQ_NGUOIKY_TEN
		{
			get
			{
				return m_CQ_NGUOIKY_TEN;
			}
			set
			{
				if ((this.m_CQ_NGUOIKY_TEN != value))
				{
					this.SendPropertyChanging("CQ_NGUOIKY_TEN");
					this.m_CQ_NGUOIKY_TEN = value;
					this.SendPropertyChanged("CQ_NGUOIKY_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CQ_NGUOIKY_TENUpdated = true;
				}
			}
		}

		private string m_CQ_NGUOIKY_CHUCVU;
		private bool m_CQ_NGUOIKY_CHUCVUUpdated = false;
		/// <summary>
		/// CQ_NGUOIKY_CHUCVU.
		/// </summary>
		public string CQ_NGUOIKY_CHUCVU
		{
			get
			{
				return m_CQ_NGUOIKY_CHUCVU;
			}
			set
			{
				if ((this.m_CQ_NGUOIKY_CHUCVU != value))
				{
					this.SendPropertyChanging("CQ_NGUOIKY_CHUCVU");
					this.m_CQ_NGUOIKY_CHUCVU = value;
					this.SendPropertyChanged("CQ_NGUOIKY_CHUCVU");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CQ_NGUOIKY_CHUCVUUpdated = true;
				}
			}
		}

		private string m_CQ_NOIKY;
		private bool m_CQ_NOIKYUpdated = false;
		/// <summary>
		/// CQ_NOIKY.
		/// </summary>
		public string CQ_NOIKY
		{
			get
			{
				return m_CQ_NOIKY;
			}
			set
			{
				if ((this.m_CQ_NOIKY != value))
				{
					this.SendPropertyChanging("CQ_NOIKY");
					this.m_CQ_NOIKY = value;
					this.SendPropertyChanged("CQ_NOIKY");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CQ_NOIKYUpdated = true;
				}
			}
		}

		private bool m_CQ_HOATDONG = true;
		private bool m_CQ_HOATDONGUpdated = false;
		/// <summary>
		/// CQ_HOATDONG.
		/// </summary>
		public bool CQ_HOATDONG
		{
			get
			{
				return m_CQ_HOATDONG;
			}
			set
			{
				if ((this.m_CQ_HOATDONG != value))
				{
					this.SendPropertyChanging("CQ_HOATDONG");
					this.m_CQ_HOATDONG = value;
					this.SendPropertyChanged("CQ_HOATDONG");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CQ_HOATDONGUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM SCOQUAN " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("CQ_MACQ", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CQ_TENCQ", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CQ_MACQCAPTREN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CQ_TENDIADANH", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CQ_NGUOIKY_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CQ_NGUOIKY_CHUCVU", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CQ_NOIKY", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CQ_HOATDONG", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO SCOQUAN (CQ_MACQ, CQ_TENCQ, CQ_MACQCAPTREN, CQ_TENDIADANH, CQ_NGUOIKY_TEN, CQ_NGUOIKY_CHUCVU, CQ_NOIKY, CQ_HOATDONG) VALUES(").Append(clsDAL.IsDBNULL(CQ_MACQ, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(CQ_TENCQ, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(CQ_MACQCAPTREN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(CQ_TENDIADANH, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(CQ_NGUOIKY_TEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(CQ_NGUOIKY_CHUCVU, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(CQ_NOIKY, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(CQ_HOATDONG, ProType.BOOL, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE SCOQUAN SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_CQ_TENCQUpdated ? string.Format(",CQ_TENCQ = {0}", clsDAL.IsDBNULL(CQ_TENCQ, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_CQ_MACQCAPTRENUpdated ? string.Format(",CQ_MACQCAPTREN = {0}", clsDAL.IsDBNULL(CQ_MACQCAPTREN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_CQ_TENDIADANHUpdated ? string.Format(",CQ_TENDIADANH = {0}", clsDAL.IsDBNULL(CQ_TENDIADANH, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_CQ_NGUOIKY_TENUpdated ? string.Format(",CQ_NGUOIKY_TEN = {0}", clsDAL.IsDBNULL(CQ_NGUOIKY_TEN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_CQ_NGUOIKY_CHUCVUUpdated ? string.Format(",CQ_NGUOIKY_CHUCVU = {0}", clsDAL.IsDBNULL(CQ_NGUOIKY_CHUCVU, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_CQ_NOIKYUpdated ? string.Format(",CQ_NOIKY = {0}", clsDAL.IsDBNULL(CQ_NOIKY, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_CQ_HOATDONGUpdated ? string.Format(",CQ_HOATDONG = {0}", clsDAL.IsDBNULL(CQ_HOATDONG, ProType.BOOL, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("CQ_TENCQ = {0}", clsDAL.IsDBNULL(CQ_TENCQ, ProType.STRING, this.DataManagement)).AppendFormat(",CQ_MACQCAPTREN = {0}", clsDAL.IsDBNULL(CQ_MACQCAPTREN, ProType.STRING, this.DataManagement)).AppendFormat(",CQ_TENDIADANH = {0}", clsDAL.IsDBNULL(CQ_TENDIADANH, ProType.STRING, this.DataManagement)).AppendFormat(",CQ_NGUOIKY_TEN = {0}", clsDAL.IsDBNULL(CQ_NGUOIKY_TEN, ProType.STRING, this.DataManagement)).AppendFormat(",CQ_NGUOIKY_CHUCVU = {0}", clsDAL.IsDBNULL(CQ_NGUOIKY_CHUCVU, ProType.STRING, this.DataManagement)).AppendFormat(",CQ_NOIKY = {0}", clsDAL.IsDBNULL(CQ_NOIKY, ProType.STRING, this.DataManagement)).AppendFormat(",CQ_HOATDONG = {0}", clsDAL.IsDBNULL(CQ_HOATDONG, ProType.BOOL, this.DataManagement));
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
			return clsDAL.DeleteString("SCOQUAN", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("CQ_MACQ = {0}", clsDAL.IsDBNULL(CQ_MACQ, ProType.STRING, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}