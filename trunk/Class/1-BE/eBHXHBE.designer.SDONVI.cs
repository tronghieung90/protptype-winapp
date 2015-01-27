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
	/// Generated Class for Table : SDONVI.
	/// </summary>
	public partial class SDONVI : TableBase
	{
		public SDONVI() : base(){}

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
		private string m_DV_DONVI_MST;
		/// <summary>
		/// DV_DONVI_MST.
		/// </summary>
		public string DV_DONVI_MST
		{
			get
			{
				return m_DV_DONVI_MST;
			}
			set
			{
				if ((this.m_DV_DONVI_MST != value))
				{
					this.SendPropertyChanging("DV_DONVI_MST");
					this.m_DV_DONVI_MST = value;
					this.SendPropertyChanged("DV_DONVI_MST");
				}
			}
		}

		private string m_DV_DONVI_MA;
		private bool m_DV_DONVI_MAUpdated = false;
		/// <summary>
		/// DV_DONVI_MA.
		/// </summary>
		public string DV_DONVI_MA
		{
			get
			{
				return m_DV_DONVI_MA;
			}
			set
			{
				if ((this.m_DV_DONVI_MA != value))
				{
					this.SendPropertyChanging("DV_DONVI_MA");
					this.m_DV_DONVI_MA = value;
					this.SendPropertyChanged("DV_DONVI_MA");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_DV_DONVI_MAUpdated = true;
				}
			}
		}

		private string m_DV_DONVI_TEN;
		private bool m_DV_DONVI_TENUpdated = false;
		/// <summary>
		/// DV_DONVI_TEN.
		/// </summary>
		public string DV_DONVI_TEN
		{
			get
			{
				return m_DV_DONVI_TEN;
			}
			set
			{
				if ((this.m_DV_DONVI_TEN != value))
				{
					this.SendPropertyChanging("DV_DONVI_TEN");
					this.m_DV_DONVI_TEN = value;
					this.SendPropertyChanged("DV_DONVI_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_DV_DONVI_TENUpdated = true;
				}
			}
		}

		private string m_DV_DONVI_DIENTHOAI;
		private bool m_DV_DONVI_DIENTHOAIUpdated = false;
		/// <summary>
		/// DV_DONVI_DIENTHOAI.
		/// </summary>
		public string DV_DONVI_DIENTHOAI
		{
			get
			{
				return m_DV_DONVI_DIENTHOAI;
			}
			set
			{
				if ((this.m_DV_DONVI_DIENTHOAI != value))
				{
					this.SendPropertyChanging("DV_DONVI_DIENTHOAI");
					this.m_DV_DONVI_DIENTHOAI = value;
					this.SendPropertyChanged("DV_DONVI_DIENTHOAI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_DV_DONVI_DIENTHOAIUpdated = true;
				}
			}
		}

		private string m_DV_DONVI_FAX;
		private bool m_DV_DONVI_FAXUpdated = false;
		/// <summary>
		/// DV_DONVI_FAX.
		/// </summary>
		public string DV_DONVI_FAX
		{
			get
			{
				return m_DV_DONVI_FAX;
			}
			set
			{
				if ((this.m_DV_DONVI_FAX != value))
				{
					this.SendPropertyChanging("DV_DONVI_FAX");
					this.m_DV_DONVI_FAX = value;
					this.SendPropertyChanged("DV_DONVI_FAX");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_DV_DONVI_FAXUpdated = true;
				}
			}
		}

		private string m_DV_DONVI_EMAIL;
		private bool m_DV_DONVI_EMAILUpdated = false;
		/// <summary>
		/// DV_DONVI_EMAIL.
		/// </summary>
		public string DV_DONVI_EMAIL
		{
			get
			{
				return m_DV_DONVI_EMAIL;
			}
			set
			{
				if ((this.m_DV_DONVI_EMAIL != value))
				{
					this.SendPropertyChanging("DV_DONVI_EMAIL");
					this.m_DV_DONVI_EMAIL = value;
					this.SendPropertyChanged("DV_DONVI_EMAIL");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_DV_DONVI_EMAILUpdated = true;
				}
			}
		}

		private string m_DV_DONVI_DIACHI;
		private bool m_DV_DONVI_DIACHIUpdated = false;
		/// <summary>
		/// DV_DONVI_DIACHI.
		/// </summary>
		public string DV_DONVI_DIACHI
		{
			get
			{
				return m_DV_DONVI_DIACHI;
			}
			set
			{
				if ((this.m_DV_DONVI_DIACHI != value))
				{
					this.SendPropertyChanging("DV_DONVI_DIACHI");
					this.m_DV_DONVI_DIACHI = value;
					this.SendPropertyChanged("DV_DONVI_DIACHI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_DV_DONVI_DIACHIUpdated = true;
				}
			}
		}

		private string m_DV_DONVI_NGAYTHAMGIA;
		private bool m_DV_DONVI_NGAYTHAMGIAUpdated = false;
		/// <summary>
		/// DV_DONVI_NGAYTHAMGIA.
		/// </summary>
		public string DV_DONVI_NGAYTHAMGIA
		{
			get
			{
				return m_DV_DONVI_NGAYTHAMGIA;
			}
			set
			{
				if ((this.m_DV_DONVI_NGAYTHAMGIA != value))
				{
					this.SendPropertyChanging("DV_DONVI_NGAYTHAMGIA");
					this.m_DV_DONVI_NGAYTHAMGIA = value;
					this.SendPropertyChanged("DV_DONVI_NGAYTHAMGIA");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_DV_DONVI_NGAYTHAMGIAUpdated = true;
				}
			}
		}

		private string m_DV_NGUOILIENHE_TEN;
		private bool m_DV_NGUOILIENHE_TENUpdated = false;
		/// <summary>
		/// DV_NGUOILIENHE_TEN.
		/// </summary>
		public string DV_NGUOILIENHE_TEN
		{
			get
			{
				return m_DV_NGUOILIENHE_TEN;
			}
			set
			{
				if ((this.m_DV_NGUOILIENHE_TEN != value))
				{
					this.SendPropertyChanging("DV_NGUOILIENHE_TEN");
					this.m_DV_NGUOILIENHE_TEN = value;
					this.SendPropertyChanged("DV_NGUOILIENHE_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_DV_NGUOILIENHE_TENUpdated = true;
				}
			}
		}

		private string m_DV_NGUOILIENHE_EMAIL;
		private bool m_DV_NGUOILIENHE_EMAILUpdated = false;
		/// <summary>
		/// DV_NGUOILIENHE_EMAIL.
		/// </summary>
		public string DV_NGUOILIENHE_EMAIL
		{
			get
			{
				return m_DV_NGUOILIENHE_EMAIL;
			}
			set
			{
				if ((this.m_DV_NGUOILIENHE_EMAIL != value))
				{
					this.SendPropertyChanging("DV_NGUOILIENHE_EMAIL");
					this.m_DV_NGUOILIENHE_EMAIL = value;
					this.SendPropertyChanged("DV_NGUOILIENHE_EMAIL");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_DV_NGUOILIENHE_EMAILUpdated = true;
				}
			}
		}

		private string m_DV_NGUOILIENHE_DIENTHOAI;
		private bool m_DV_NGUOILIENHE_DIENTHOAIUpdated = false;
		/// <summary>
		/// DV_NGUOILIENHE_DIENTHOAI.
		/// </summary>
		public string DV_NGUOILIENHE_DIENTHOAI
		{
			get
			{
				return m_DV_NGUOILIENHE_DIENTHOAI;
			}
			set
			{
				if ((this.m_DV_NGUOILIENHE_DIENTHOAI != value))
				{
					this.SendPropertyChanging("DV_NGUOILIENHE_DIENTHOAI");
					this.m_DV_NGUOILIENHE_DIENTHOAI = value;
					this.SendPropertyChanged("DV_NGUOILIENHE_DIENTHOAI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_DV_NGUOILIENHE_DIENTHOAIUpdated = true;
				}
			}
		}

		private bool m_DV_HOATDONG = true;
		private bool m_DV_HOATDONGUpdated = false;
		/// <summary>
		/// DV_HOATDONG.
		/// </summary>
		public bool DV_HOATDONG
		{
			get
			{
				return m_DV_HOATDONG;
			}
			set
			{
				if ((this.m_DV_HOATDONG != value))
				{
					this.SendPropertyChanging("DV_HOATDONG");
					this.m_DV_HOATDONG = value;
					this.SendPropertyChanged("DV_HOATDONG");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_DV_HOATDONGUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM SDONVI " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("DV_DONVI_MST", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("DV_DONVI_MA", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("DV_DONVI_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("DV_DONVI_DIENTHOAI", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("DV_DONVI_FAX", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("DV_DONVI_EMAIL", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("DV_DONVI_DIACHI", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("DV_DONVI_NGAYTHAMGIA", ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.SelectField("DV_NGUOILIENHE_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("DV_NGUOILIENHE_EMAIL", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("DV_NGUOILIENHE_DIENTHOAI", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("DV_HOATDONG", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO SDONVI (DV_DONVI_MST, DV_DONVI_MA, DV_DONVI_TEN, DV_DONVI_DIENTHOAI, DV_DONVI_FAX, DV_DONVI_EMAIL, DV_DONVI_DIACHI, DV_DONVI_NGAYTHAMGIA, DV_NGUOILIENHE_TEN, DV_NGUOILIENHE_EMAIL, DV_NGUOILIENHE_DIENTHOAI, DV_HOATDONG) VALUES(").Append(clsDAL.IsDBNULL(DV_DONVI_MST, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(DV_DONVI_MA, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(DV_DONVI_TEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(DV_DONVI_DIENTHOAI, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(DV_DONVI_FAX, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(DV_DONVI_EMAIL, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(DV_DONVI_DIACHI, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(DV_DONVI_NGAYTHAMGIA, ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(DV_NGUOILIENHE_TEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(DV_NGUOILIENHE_EMAIL, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(DV_NGUOILIENHE_DIENTHOAI, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(DV_HOATDONG, ProType.BOOL, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE SDONVI SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_DV_DONVI_MAUpdated ? string.Format(",DV_DONVI_MA = {0}", clsDAL.IsDBNULL(DV_DONVI_MA, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_DV_DONVI_TENUpdated ? string.Format(",DV_DONVI_TEN = {0}", clsDAL.IsDBNULL(DV_DONVI_TEN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_DV_DONVI_DIENTHOAIUpdated ? string.Format(",DV_DONVI_DIENTHOAI = {0}", clsDAL.IsDBNULL(DV_DONVI_DIENTHOAI, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_DV_DONVI_FAXUpdated ? string.Format(",DV_DONVI_FAX = {0}", clsDAL.IsDBNULL(DV_DONVI_FAX, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_DV_DONVI_EMAILUpdated ? string.Format(",DV_DONVI_EMAIL = {0}", clsDAL.IsDBNULL(DV_DONVI_EMAIL, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_DV_DONVI_DIACHIUpdated ? string.Format(",DV_DONVI_DIACHI = {0}", clsDAL.IsDBNULL(DV_DONVI_DIACHI, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_DV_DONVI_NGAYTHAMGIAUpdated ? string.Format(",DV_DONVI_NGAYTHAMGIA = {0}", clsDAL.IsDBNULL(DV_DONVI_NGAYTHAMGIA, ProType.VNDATESTRING, this.DataManagement)) : string.Empty).Append(m_DV_NGUOILIENHE_TENUpdated ? string.Format(",DV_NGUOILIENHE_TEN = {0}", clsDAL.IsDBNULL(DV_NGUOILIENHE_TEN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_DV_NGUOILIENHE_EMAILUpdated ? string.Format(",DV_NGUOILIENHE_EMAIL = {0}", clsDAL.IsDBNULL(DV_NGUOILIENHE_EMAIL, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_DV_NGUOILIENHE_DIENTHOAIUpdated ? string.Format(",DV_NGUOILIENHE_DIENTHOAI = {0}", clsDAL.IsDBNULL(DV_NGUOILIENHE_DIENTHOAI, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_DV_HOATDONGUpdated ? string.Format(",DV_HOATDONG = {0}", clsDAL.IsDBNULL(DV_HOATDONG, ProType.BOOL, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("DV_DONVI_MA = {0}", clsDAL.IsDBNULL(DV_DONVI_MA, ProType.STRING, this.DataManagement)).AppendFormat(",DV_DONVI_TEN = {0}", clsDAL.IsDBNULL(DV_DONVI_TEN, ProType.STRING, this.DataManagement)).AppendFormat(",DV_DONVI_DIENTHOAI = {0}", clsDAL.IsDBNULL(DV_DONVI_DIENTHOAI, ProType.STRING, this.DataManagement)).AppendFormat(",DV_DONVI_FAX = {0}", clsDAL.IsDBNULL(DV_DONVI_FAX, ProType.STRING, this.DataManagement)).AppendFormat(",DV_DONVI_EMAIL = {0}", clsDAL.IsDBNULL(DV_DONVI_EMAIL, ProType.STRING, this.DataManagement)).AppendFormat(",DV_DONVI_DIACHI = {0}", clsDAL.IsDBNULL(DV_DONVI_DIACHI, ProType.STRING, this.DataManagement)).AppendFormat(",DV_DONVI_NGAYTHAMGIA = {0}", clsDAL.IsDBNULL(DV_DONVI_NGAYTHAMGIA, ProType.VNDATESTRING, this.DataManagement)).AppendFormat(",DV_NGUOILIENHE_TEN = {0}", clsDAL.IsDBNULL(DV_NGUOILIENHE_TEN, ProType.STRING, this.DataManagement)).AppendFormat(",DV_NGUOILIENHE_EMAIL = {0}", clsDAL.IsDBNULL(DV_NGUOILIENHE_EMAIL, ProType.STRING, this.DataManagement)).AppendFormat(",DV_NGUOILIENHE_DIENTHOAI = {0}", clsDAL.IsDBNULL(DV_NGUOILIENHE_DIENTHOAI, ProType.STRING, this.DataManagement)).AppendFormat(",DV_HOATDONG = {0}", clsDAL.IsDBNULL(DV_HOATDONG, ProType.BOOL, this.DataManagement));
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
			return clsDAL.DeleteString("SDONVI", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("DV_DONVI_MST = {0}", clsDAL.IsDBNULL(DV_DONVI_MST, ProType.STRING, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}