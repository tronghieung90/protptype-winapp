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
	/// Generated Class for Table : SPHONGBOPHAN.
	/// </summary>
	public partial class SPHONGBOPHAN : TableBase
	{
		public SPHONGBOPHAN() : base(){}

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
		private string m_P_MACQ;
		/// <summary>
		/// P_MACQ.
		/// </summary>
		public string P_MACQ
		{
			get
			{
				return m_P_MACQ;
			}
			set
			{
				if ((this.m_P_MACQ != value))
				{
					this.SendPropertyChanging("P_MACQ");
					this.m_P_MACQ = value;
					this.SendPropertyChanged("P_MACQ");
				}
			}
		}

		private string m_P_MAPHONG;
		/// <summary>
		/// P_MAPHONG.
		/// </summary>
		public string P_MAPHONG
		{
			get
			{
				return m_P_MAPHONG;
			}
			set
			{
				if ((this.m_P_MAPHONG != value))
				{
					this.SendPropertyChanging("P_MAPHONG");
					this.m_P_MAPHONG = value;
					this.SendPropertyChanged("P_MAPHONG");
				}
			}
		}

		private string m_P_TENPHONG;
		private bool m_P_TENPHONGUpdated = false;
		/// <summary>
		/// P_TENPHONG.
		/// </summary>
		public string P_TENPHONG
		{
			get
			{
				return m_P_TENPHONG;
			}
			set
			{
				if ((this.m_P_TENPHONG != value))
				{
					this.SendPropertyChanging("P_TENPHONG");
					this.m_P_TENPHONG = value;
					this.SendPropertyChanged("P_TENPHONG");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_P_TENPHONGUpdated = true;
				}
			}
		}

		private string m_P_TENDIADANH;
		private bool m_P_TENDIADANHUpdated = false;
		/// <summary>
		/// P_TENDIADANH.
		/// </summary>
		public string P_TENDIADANH
		{
			get
			{
				return m_P_TENDIADANH;
			}
			set
			{
				if ((this.m_P_TENDIADANH != value))
				{
					this.SendPropertyChanging("P_TENDIADANH");
					this.m_P_TENDIADANH = value;
					this.SendPropertyChanged("P_TENDIADANH");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_P_TENDIADANHUpdated = true;
				}
			}
		}

		private string m_P_DIACHI;
		private bool m_P_DIACHIUpdated = false;
		/// <summary>
		/// P_DIACHI.
		/// </summary>
		public string P_DIACHI
		{
			get
			{
				return m_P_DIACHI;
			}
			set
			{
				if ((this.m_P_DIACHI != value))
				{
					this.SendPropertyChanging("P_DIACHI");
					this.m_P_DIACHI = value;
					this.SendPropertyChanged("P_DIACHI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_P_DIACHIUpdated = true;
				}
			}
		}

		private string m_P_DIENTHOAI;
		private bool m_P_DIENTHOAIUpdated = false;
		/// <summary>
		/// P_DIENTHOAI.
		/// </summary>
		public string P_DIENTHOAI
		{
			get
			{
				return m_P_DIENTHOAI;
			}
			set
			{
				if ((this.m_P_DIENTHOAI != value))
				{
					this.SendPropertyChanging("P_DIENTHOAI");
					this.m_P_DIENTHOAI = value;
					this.SendPropertyChanged("P_DIENTHOAI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_P_DIENTHOAIUpdated = true;
				}
			}
		}

		private string m_P_FAX;
		private bool m_P_FAXUpdated = false;
		/// <summary>
		/// P_FAX.
		/// </summary>
		public string P_FAX
		{
			get
			{
				return m_P_FAX;
			}
			set
			{
				if ((this.m_P_FAX != value))
				{
					this.SendPropertyChanging("P_FAX");
					this.m_P_FAX = value;
					this.SendPropertyChanged("P_FAX");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_P_FAXUpdated = true;
				}
			}
		}

		private string m_P_LANHDAO_TEN;
		private bool m_P_LANHDAO_TENUpdated = false;
		/// <summary>
		/// P_LANHDAO_TEN.
		/// </summary>
		public string P_LANHDAO_TEN
		{
			get
			{
				return m_P_LANHDAO_TEN;
			}
			set
			{
				if ((this.m_P_LANHDAO_TEN != value))
				{
					this.SendPropertyChanging("P_LANHDAO_TEN");
					this.m_P_LANHDAO_TEN = value;
					this.SendPropertyChanged("P_LANHDAO_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_P_LANHDAO_TENUpdated = true;
				}
			}
		}

		private bool m_P_PHANCONGTUDONG = true;
		private bool m_P_PHANCONGTUDONGUpdated = false;
		/// <summary>
		/// P_PHANCONGTUDONG.
		/// </summary>
		public bool P_PHANCONGTUDONG
		{
			get
			{
				return m_P_PHANCONGTUDONG;
			}
			set
			{
				if ((this.m_P_PHANCONGTUDONG != value))
				{
					this.SendPropertyChanging("P_PHANCONGTUDONG");
					this.m_P_PHANCONGTUDONG = value;
					this.SendPropertyChanged("P_PHANCONGTUDONG");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_P_PHANCONGTUDONGUpdated = true;
				}
			}
		}

		private bool m_P_HOATDONG = true;
		private bool m_P_HOATDONGUpdated = false;
		/// <summary>
		/// P_HOATDONG.
		/// </summary>
		public bool P_HOATDONG
		{
			get
			{
				return m_P_HOATDONG;
			}
			set
			{
				if ((this.m_P_HOATDONG != value))
				{
					this.SendPropertyChanging("P_HOATDONG");
					this.m_P_HOATDONG = value;
					this.SendPropertyChanged("P_HOATDONG");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_P_HOATDONGUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM SPHONGBOPHAN " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("P_MACQ", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("P_MAPHONG", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("P_TENPHONG", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("P_TENDIADANH", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("P_DIACHI", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("P_DIENTHOAI", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("P_FAX", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("P_LANHDAO_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("P_PHANCONGTUDONG", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("P_HOATDONG", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO SPHONGBOPHAN (P_MACQ, P_MAPHONG, P_TENPHONG, P_TENDIADANH, P_DIACHI, P_DIENTHOAI, P_FAX, P_LANHDAO_TEN, P_PHANCONGTUDONG, P_HOATDONG) VALUES(").Append(clsDAL.IsDBNULL(P_MACQ, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(P_MAPHONG, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(P_TENPHONG, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(P_TENDIADANH, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(P_DIACHI, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(P_DIENTHOAI, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(P_FAX, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(P_LANHDAO_TEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(P_PHANCONGTUDONG, ProType.BOOL, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(P_HOATDONG, ProType.BOOL, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE SPHONGBOPHAN SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_P_TENPHONGUpdated ? string.Format(",P_TENPHONG = {0}", clsDAL.IsDBNULL(P_TENPHONG, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_P_TENDIADANHUpdated ? string.Format(",P_TENDIADANH = {0}", clsDAL.IsDBNULL(P_TENDIADANH, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_P_DIACHIUpdated ? string.Format(",P_DIACHI = {0}", clsDAL.IsDBNULL(P_DIACHI, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_P_DIENTHOAIUpdated ? string.Format(",P_DIENTHOAI = {0}", clsDAL.IsDBNULL(P_DIENTHOAI, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_P_FAXUpdated ? string.Format(",P_FAX = {0}", clsDAL.IsDBNULL(P_FAX, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_P_LANHDAO_TENUpdated ? string.Format(",P_LANHDAO_TEN = {0}", clsDAL.IsDBNULL(P_LANHDAO_TEN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_P_PHANCONGTUDONGUpdated ? string.Format(",P_PHANCONGTUDONG = {0}", clsDAL.IsDBNULL(P_PHANCONGTUDONG, ProType.BOOL, this.DataManagement)) : string.Empty).Append(m_P_HOATDONGUpdated ? string.Format(",P_HOATDONG = {0}", clsDAL.IsDBNULL(P_HOATDONG, ProType.BOOL, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("P_TENPHONG = {0}", clsDAL.IsDBNULL(P_TENPHONG, ProType.STRING, this.DataManagement)).AppendFormat(",P_TENDIADANH = {0}", clsDAL.IsDBNULL(P_TENDIADANH, ProType.STRING, this.DataManagement)).AppendFormat(",P_DIACHI = {0}", clsDAL.IsDBNULL(P_DIACHI, ProType.STRING, this.DataManagement)).AppendFormat(",P_DIENTHOAI = {0}", clsDAL.IsDBNULL(P_DIENTHOAI, ProType.STRING, this.DataManagement)).AppendFormat(",P_FAX = {0}", clsDAL.IsDBNULL(P_FAX, ProType.STRING, this.DataManagement)).AppendFormat(",P_LANHDAO_TEN = {0}", clsDAL.IsDBNULL(P_LANHDAO_TEN, ProType.STRING, this.DataManagement)).AppendFormat(",P_PHANCONGTUDONG = {0}", clsDAL.IsDBNULL(P_PHANCONGTUDONG, ProType.BOOL, this.DataManagement)).AppendFormat(",P_HOATDONG = {0}", clsDAL.IsDBNULL(P_HOATDONG, ProType.BOOL, this.DataManagement));
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
			return clsDAL.DeleteString("SPHONGBOPHAN", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("P_MACQ = {0}", clsDAL.IsDBNULL(P_MACQ, ProType.STRING, this.DataManagement)).AppendFormat(" AND P_MAPHONG = {0}", clsDAL.IsDBNULL(P_MAPHONG, ProType.STRING, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}