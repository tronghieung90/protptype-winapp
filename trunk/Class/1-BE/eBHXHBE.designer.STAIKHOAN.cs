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
	/// Generated Class for Table : STAIKHOAN.
	/// </summary>
	public partial class STAIKHOAN : TableBase
	{
		public STAIKHOAN() : base(){}

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
		private string m_TK_TAIKHOAN;
		/// <summary>
		/// TK_TAIKHOAN.
		/// </summary>
		public string TK_TAIKHOAN
		{
			get
			{
				return m_TK_TAIKHOAN;
			}
			set
			{
				if ((this.m_TK_TAIKHOAN != value))
				{
					this.SendPropertyChanging("TK_TAIKHOAN");
					this.m_TK_TAIKHOAN = value;
					this.SendPropertyChanged("TK_TAIKHOAN");
				}
			}
		}

		private string m_TK_MATKHAU;
		private bool m_TK_MATKHAUUpdated = false;
		/// <summary>
		/// TK_MATKHAU.
		/// </summary>
		public string TK_MATKHAU
		{
			get
			{
				return m_TK_MATKHAU;
			}
			set
			{
				if ((this.m_TK_MATKHAU != value))
				{
					this.SendPropertyChanging("TK_MATKHAU");
					this.m_TK_MATKHAU = value;
					this.SendPropertyChanged("TK_MATKHAU");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TK_MATKHAUUpdated = true;
				}
			}
		}

		private string m_TK_HOTEN;
		private bool m_TK_HOTENUpdated = false;
		/// <summary>
		/// TK_HOTEN.
		/// </summary>
		public string TK_HOTEN
		{
			get
			{
				return m_TK_HOTEN;
			}
			set
			{
				if ((this.m_TK_HOTEN != value))
				{
					this.SendPropertyChanging("TK_HOTEN");
					this.m_TK_HOTEN = value;
					this.SendPropertyChanged("TK_HOTEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TK_HOTENUpdated = true;
				}
			}
		}

		private string m_TK_NGAYSINH;
		private bool m_TK_NGAYSINHUpdated = false;
		/// <summary>
		/// TK_NGAYSINH.
		/// </summary>
		public string TK_NGAYSINH
		{
			get
			{
				return m_TK_NGAYSINH;
			}
			set
			{
				if ((this.m_TK_NGAYSINH != value))
				{
					this.SendPropertyChanging("TK_NGAYSINH");
					this.m_TK_NGAYSINH = value;
					this.SendPropertyChanged("TK_NGAYSINH");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TK_NGAYSINHUpdated = true;
				}
			}
		}

		private string m_TK_CHUCVU;
		private bool m_TK_CHUCVUUpdated = false;
		/// <summary>
		/// TK_CHUCVU.
		/// </summary>
		public string TK_CHUCVU
		{
			get
			{
				return m_TK_CHUCVU;
			}
			set
			{
				if ((this.m_TK_CHUCVU != value))
				{
					this.SendPropertyChanging("TK_CHUCVU");
					this.m_TK_CHUCVU = value;
					this.SendPropertyChanged("TK_CHUCVU");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TK_CHUCVUUpdated = true;
				}
			}
		}

		private string m_TK_EMAIL;
		private bool m_TK_EMAILUpdated = false;
		/// <summary>
		/// TK_EMAIL.
		/// </summary>
		public string TK_EMAIL
		{
			get
			{
				return m_TK_EMAIL;
			}
			set
			{
				if ((this.m_TK_EMAIL != value))
				{
					this.SendPropertyChanging("TK_EMAIL");
					this.m_TK_EMAIL = value;
					this.SendPropertyChanged("TK_EMAIL");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TK_EMAILUpdated = true;
				}
			}
		}

		private string m_TK_DIENTHOAI;
		private bool m_TK_DIENTHOAIUpdated = false;
		/// <summary>
		/// TK_DIENTHOAI.
		/// </summary>
		public string TK_DIENTHOAI
		{
			get
			{
				return m_TK_DIENTHOAI;
			}
			set
			{
				if ((this.m_TK_DIENTHOAI != value))
				{
					this.SendPropertyChanging("TK_DIENTHOAI");
					this.m_TK_DIENTHOAI = value;
					this.SendPropertyChanged("TK_DIENTHOAI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TK_DIENTHOAIUpdated = true;
				}
			}
		}

		private bool m_TK_GIOITINH;
		private bool m_TK_GIOITINHUpdated = false;
		/// <summary>
		/// TK_GIOITINH.
		/// </summary>
		public bool TK_GIOITINH
		{
			get
			{
				return m_TK_GIOITINH;
			}
			set
			{
				if ((this.m_TK_GIOITINH != value))
				{
					this.SendPropertyChanging("TK_GIOITINH");
					this.m_TK_GIOITINH = value;
					this.SendPropertyChanged("TK_GIOITINH");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TK_GIOITINHUpdated = true;
				}
			}
		}

		private bool m_TK_KICHHOAT = true;
		private bool m_TK_KICHHOATUpdated = false;
		/// <summary>
		/// TK_KICHHOAT.
		/// </summary>
		public bool TK_KICHHOAT
		{
			get
			{
				return m_TK_KICHHOAT;
			}
			set
			{
				if ((this.m_TK_KICHHOAT != value))
				{
					this.SendPropertyChanging("TK_KICHHOAT");
					this.m_TK_KICHHOAT = value;
					this.SendPropertyChanged("TK_KICHHOAT");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TK_KICHHOATUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM STAIKHOAN " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("TK_TAIKHOAN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TK_MATKHAU", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TK_HOTEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TK_NGAYSINH", ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TK_CHUCVU", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TK_EMAIL", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TK_DIENTHOAI", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TK_GIOITINH", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TK_KICHHOAT", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO STAIKHOAN (TK_TAIKHOAN, TK_MATKHAU, TK_HOTEN, TK_NGAYSINH, TK_CHUCVU, TK_EMAIL, TK_DIENTHOAI, TK_GIOITINH, TK_KICHHOAT) VALUES(").Append(clsDAL.IsDBNULL(TK_TAIKHOAN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TK_MATKHAU, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TK_HOTEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TK_NGAYSINH, ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TK_CHUCVU, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TK_EMAIL, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TK_DIENTHOAI, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TK_GIOITINH, ProType.BOOL, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TK_KICHHOAT, ProType.BOOL, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE STAIKHOAN SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_TK_MATKHAUUpdated ? string.Format(",TK_MATKHAU = {0}", clsDAL.IsDBNULL(TK_MATKHAU, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_TK_HOTENUpdated ? string.Format(",TK_HOTEN = {0}", clsDAL.IsDBNULL(TK_HOTEN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_TK_NGAYSINHUpdated ? string.Format(",TK_NGAYSINH = {0}", clsDAL.IsDBNULL(TK_NGAYSINH, ProType.VNDATESTRING, this.DataManagement)) : string.Empty).Append(m_TK_CHUCVUUpdated ? string.Format(",TK_CHUCVU = {0}", clsDAL.IsDBNULL(TK_CHUCVU, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_TK_EMAILUpdated ? string.Format(",TK_EMAIL = {0}", clsDAL.IsDBNULL(TK_EMAIL, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_TK_DIENTHOAIUpdated ? string.Format(",TK_DIENTHOAI = {0}", clsDAL.IsDBNULL(TK_DIENTHOAI, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_TK_GIOITINHUpdated ? string.Format(",TK_GIOITINH = {0}", clsDAL.IsDBNULL(TK_GIOITINH, ProType.BOOL, this.DataManagement)) : string.Empty).Append(m_TK_KICHHOATUpdated ? string.Format(",TK_KICHHOAT = {0}", clsDAL.IsDBNULL(TK_KICHHOAT, ProType.BOOL, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("TK_MATKHAU = {0}", clsDAL.IsDBNULL(TK_MATKHAU, ProType.STRING, this.DataManagement)).AppendFormat(",TK_HOTEN = {0}", clsDAL.IsDBNULL(TK_HOTEN, ProType.STRING, this.DataManagement)).AppendFormat(",TK_NGAYSINH = {0}", clsDAL.IsDBNULL(TK_NGAYSINH, ProType.VNDATESTRING, this.DataManagement)).AppendFormat(",TK_CHUCVU = {0}", clsDAL.IsDBNULL(TK_CHUCVU, ProType.STRING, this.DataManagement)).AppendFormat(",TK_EMAIL = {0}", clsDAL.IsDBNULL(TK_EMAIL, ProType.STRING, this.DataManagement)).AppendFormat(",TK_DIENTHOAI = {0}", clsDAL.IsDBNULL(TK_DIENTHOAI, ProType.STRING, this.DataManagement)).AppendFormat(",TK_GIOITINH = {0}", clsDAL.IsDBNULL(TK_GIOITINH, ProType.BOOL, this.DataManagement)).AppendFormat(",TK_KICHHOAT = {0}", clsDAL.IsDBNULL(TK_KICHHOAT, ProType.BOOL, this.DataManagement));
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
			return clsDAL.DeleteString("STAIKHOAN", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("TK_TAIKHOAN = {0}", clsDAL.IsDBNULL(TK_TAIKHOAN, ProType.STRING, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}