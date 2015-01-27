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
	/// Generated Class for Table : INBOX.
	/// </summary>
	public partial class INBOX : TableBase
	{
		public INBOX() : base(){}

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
		private string m_IB_SODK;
		/// <summary>
		/// IB_SODK.
		/// </summary>
		public string IB_SODK
		{
			get
			{
				return m_IB_SODK;
			}
			set
			{
				if ((this.m_IB_SODK != value))
				{
					this.SendPropertyChanging("IB_SODK");
					this.m_IB_SODK = value;
					this.SendPropertyChanged("IB_SODK");
				}
			}
		}

		private string m_IB_NAMDK;
		/// <summary>
		/// IB_NAMDK.
		/// </summary>
		public string IB_NAMDK
		{
			get
			{
				return m_IB_NAMDK;
			}
			set
			{
				if ((this.m_IB_NAMDK != value))
				{
					this.SendPropertyChanging("IB_NAMDK");
					this.m_IB_NAMDK = value;
					this.SendPropertyChanged("IB_NAMDK");
				}
			}
		}

		private string m_IB_NGAYDK;
		private bool m_IB_NGAYDKUpdated = false;
		/// <summary>
		/// IB_NGAYDK.
		/// </summary>
		public string IB_NGAYDK
		{
			get
			{
				return m_IB_NGAYDK;
			}
			set
			{
				if ((this.m_IB_NGAYDK != value))
				{
					this.SendPropertyChanging("IB_NGAYDK");
					this.m_IB_NGAYDK = value;
					this.SendPropertyChanged("IB_NGAYDK");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_IB_NGAYDKUpdated = true;
				}
			}
		}

		private string m_IB_DONVI_MST;
		private bool m_IB_DONVI_MSTUpdated = false;
		/// <summary>
		/// IB_DONVI_MST.
		/// </summary>
		public string IB_DONVI_MST
		{
			get
			{
				return m_IB_DONVI_MST;
			}
			set
			{
				if ((this.m_IB_DONVI_MST != value))
				{
					this.SendPropertyChanging("IB_DONVI_MST");
					this.m_IB_DONVI_MST = value;
					this.SendPropertyChanged("IB_DONVI_MST");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_IB_DONVI_MSTUpdated = true;
				}
			}
		}

		private string m_IB_DONVI_MA;
		private bool m_IB_DONVI_MAUpdated = false;
		/// <summary>
		/// IB_DONVI_MA.
		/// </summary>
		public string IB_DONVI_MA
		{
			get
			{
				return m_IB_DONVI_MA;
			}
			set
			{
				if ((this.m_IB_DONVI_MA != value))
				{
					this.SendPropertyChanging("IB_DONVI_MA");
					this.m_IB_DONVI_MA = value;
					this.SendPropertyChanged("IB_DONVI_MA");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_IB_DONVI_MAUpdated = true;
				}
			}
		}

		private string m_IB_DONVI_TEN;
		private bool m_IB_DONVI_TENUpdated = false;
		/// <summary>
		/// IB_DONVI_TEN.
		/// </summary>
		public string IB_DONVI_TEN
		{
			get
			{
				return m_IB_DONVI_TEN;
			}
			set
			{
				if ((this.m_IB_DONVI_TEN != value))
				{
					this.SendPropertyChanging("IB_DONVI_TEN");
					this.m_IB_DONVI_TEN = value;
					this.SendPropertyChanged("IB_DONVI_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_IB_DONVI_TENUpdated = true;
				}
			}
		}

		private string m_IB_THUTUC_MA;
		private bool m_IB_THUTUC_MAUpdated = false;
		/// <summary>
		/// IB_THUTUC_MA.
		/// </summary>
		public string IB_THUTUC_MA
		{
			get
			{
				return m_IB_THUTUC_MA;
			}
			set
			{
				if ((this.m_IB_THUTUC_MA != value))
				{
					this.SendPropertyChanging("IB_THUTUC_MA");
					this.m_IB_THUTUC_MA = value;
					this.SendPropertyChanged("IB_THUTUC_MA");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_IB_THUTUC_MAUpdated = true;
				}
			}
		}

		private string m_IB_THUTUC_TEN;
		private bool m_IB_THUTUC_TENUpdated = false;
		/// <summary>
		/// IB_THUTUC_TEN.
		/// </summary>
		public string IB_THUTUC_TEN
		{
			get
			{
				return m_IB_THUTUC_TEN;
			}
			set
			{
				if ((this.m_IB_THUTUC_TEN != value))
				{
					this.SendPropertyChanging("IB_THUTUC_TEN");
					this.m_IB_THUTUC_TEN = value;
					this.SendPropertyChanged("IB_THUTUC_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_IB_THUTUC_TENUpdated = true;
				}
			}
		}

		private string m_IB_CQBHXH_MA;
		private bool m_IB_CQBHXH_MAUpdated = false;
		/// <summary>
		/// IB_CQBHXH_MA.
		/// </summary>
		public string IB_CQBHXH_MA
		{
			get
			{
				return m_IB_CQBHXH_MA;
			}
			set
			{
				if ((this.m_IB_CQBHXH_MA != value))
				{
					this.SendPropertyChanging("IB_CQBHXH_MA");
					this.m_IB_CQBHXH_MA = value;
					this.SendPropertyChanged("IB_CQBHXH_MA");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_IB_CQBHXH_MAUpdated = true;
				}
			}
		}

		private string m_IB_CQBHXH_TEN;
		private bool m_IB_CQBHXH_TENUpdated = false;
		/// <summary>
		/// IB_CQBHXH_TEN.
		/// </summary>
		public string IB_CQBHXH_TEN
		{
			get
			{
				return m_IB_CQBHXH_TEN;
			}
			set
			{
				if ((this.m_IB_CQBHXH_TEN != value))
				{
					this.SendPropertyChanging("IB_CQBHXH_TEN");
					this.m_IB_CQBHXH_TEN = value;
					this.SendPropertyChanged("IB_CQBHXH_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_IB_CQBHXH_TENUpdated = true;
				}
			}
		}

		private string m_IB_HOSO_NOIDUNG;
		private bool m_IB_HOSO_NOIDUNGUpdated = false;
		/// <summary>
		/// IB_HOSO_NOIDUNG.
		/// </summary>
		public string IB_HOSO_NOIDUNG
		{
			get
			{
				return m_IB_HOSO_NOIDUNG;
			}
			set
			{
				if ((this.m_IB_HOSO_NOIDUNG != value))
				{
					this.SendPropertyChanging("IB_HOSO_NOIDUNG");
					this.m_IB_HOSO_NOIDUNG = value;
					this.SendPropertyChanged("IB_HOSO_NOIDUNG");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_IB_HOSO_NOIDUNGUpdated = true;
				}
			}
		}

		private string m_IB_HOSO_MD5;
		private bool m_IB_HOSO_MD5Updated = false;
		/// <summary>
		/// IB_HOSO_MD5.
		/// </summary>
		public string IB_HOSO_MD5
		{
			get
			{
				return m_IB_HOSO_MD5;
			}
			set
			{
				if ((this.m_IB_HOSO_MD5 != value))
				{
					this.SendPropertyChanging("IB_HOSO_MD5");
					this.m_IB_HOSO_MD5 = value;
					this.SendPropertyChanged("IB_HOSO_MD5");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_IB_HOSO_MD5Updated = true;
				}
			}
		}

		private string m_IB_NGUOIXULY = "0";
		private bool m_IB_NGUOIXULYUpdated = false;
		/// <summary>
		/// IB_NGUOIXULY.
		/// </summary>
		public string IB_NGUOIXULY
		{
			get
			{
				return m_IB_NGUOIXULY;
			}
			set
			{
				if ((this.m_IB_NGUOIXULY != value))
				{
					this.SendPropertyChanging("IB_NGUOIXULY");
					this.m_IB_NGUOIXULY = value;
					this.SendPropertyChanged("IB_NGUOIXULY");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_IB_NGUOIXULYUpdated = true;
				}
			}
		}

		private string m_IB_NGAY_TAO = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
		private bool m_IB_NGAY_TAOUpdated = false;
		/// <summary>
		/// IB_NGAY_TAO.
		/// </summary>
		public string IB_NGAY_TAO
		{
			get
			{
				return m_IB_NGAY_TAO;
			}
			set
			{
				if ((this.m_IB_NGAY_TAO != value))
				{
					this.SendPropertyChanging("IB_NGAY_TAO");
					this.m_IB_NGAY_TAO = value;
					this.SendPropertyChanged("IB_NGAY_TAO");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_IB_NGAY_TAOUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM INBOX " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("IB_SODK", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("IB_NAMDK", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("IB_NGAYDK", ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.SelectField("IB_DONVI_MST", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("IB_DONVI_MA", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("IB_DONVI_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("IB_THUTUC_MA", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("IB_THUTUC_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("IB_CQBHXH_MA", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("IB_CQBHXH_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("IB_HOSO_NOIDUNG", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("IB_HOSO_MD5", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("IB_NGUOIXULY", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("IB_NGAY_TAO", ProType.VNDATESTRING, this.DataManagement));
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
			sbSQL.Append("INSERT INTO INBOX (IB_SODK, IB_NAMDK, IB_NGAYDK, IB_DONVI_MST, IB_DONVI_MA, IB_DONVI_TEN, IB_THUTUC_MA, IB_THUTUC_TEN, IB_CQBHXH_MA, IB_CQBHXH_TEN, IB_HOSO_NOIDUNG, IB_HOSO_MD5, IB_NGUOIXULY, IB_NGAY_TAO) VALUES(").Append(clsDAL.IsDBNULL(IB_SODK, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(IB_NAMDK, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(IB_NGAYDK, ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(IB_DONVI_MST, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(IB_DONVI_MA, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(IB_DONVI_TEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(IB_THUTUC_MA, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(IB_THUTUC_TEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(IB_CQBHXH_MA, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(IB_CQBHXH_TEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(IB_HOSO_NOIDUNG, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(IB_HOSO_MD5, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(IB_NGUOIXULY, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(IB_NGAY_TAO, ProType.VNDATESTRING, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE INBOX SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_IB_NGAYDKUpdated ? string.Format(",IB_NGAYDK = {0}", clsDAL.IsDBNULL(IB_NGAYDK, ProType.VNDATESTRING, this.DataManagement)) : string.Empty).Append(m_IB_DONVI_MSTUpdated ? string.Format(",IB_DONVI_MST = {0}", clsDAL.IsDBNULL(IB_DONVI_MST, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_IB_DONVI_MAUpdated ? string.Format(",IB_DONVI_MA = {0}", clsDAL.IsDBNULL(IB_DONVI_MA, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_IB_DONVI_TENUpdated ? string.Format(",IB_DONVI_TEN = {0}", clsDAL.IsDBNULL(IB_DONVI_TEN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_IB_THUTUC_MAUpdated ? string.Format(",IB_THUTUC_MA = {0}", clsDAL.IsDBNULL(IB_THUTUC_MA, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_IB_THUTUC_TENUpdated ? string.Format(",IB_THUTUC_TEN = {0}", clsDAL.IsDBNULL(IB_THUTUC_TEN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_IB_CQBHXH_MAUpdated ? string.Format(",IB_CQBHXH_MA = {0}", clsDAL.IsDBNULL(IB_CQBHXH_MA, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_IB_CQBHXH_TENUpdated ? string.Format(",IB_CQBHXH_TEN = {0}", clsDAL.IsDBNULL(IB_CQBHXH_TEN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_IB_HOSO_NOIDUNGUpdated ? string.Format(",IB_HOSO_NOIDUNG = {0}", clsDAL.IsDBNULL(IB_HOSO_NOIDUNG, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_IB_HOSO_MD5Updated ? string.Format(",IB_HOSO_MD5 = {0}", clsDAL.IsDBNULL(IB_HOSO_MD5, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_IB_NGUOIXULYUpdated ? string.Format(",IB_NGUOIXULY = {0}", clsDAL.IsDBNULL(IB_NGUOIXULY, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_IB_NGAY_TAOUpdated ? string.Format(",IB_NGAY_TAO = {0}", clsDAL.IsDBNULL(IB_NGAY_TAO, ProType.VNDATESTRING, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("IB_NGAYDK = {0}", clsDAL.IsDBNULL(IB_NGAYDK, ProType.VNDATESTRING, this.DataManagement)).AppendFormat(",IB_DONVI_MST = {0}", clsDAL.IsDBNULL(IB_DONVI_MST, ProType.STRING, this.DataManagement)).AppendFormat(",IB_DONVI_MA = {0}", clsDAL.IsDBNULL(IB_DONVI_MA, ProType.STRING, this.DataManagement)).AppendFormat(",IB_DONVI_TEN = {0}", clsDAL.IsDBNULL(IB_DONVI_TEN, ProType.STRING, this.DataManagement)).AppendFormat(",IB_THUTUC_MA = {0}", clsDAL.IsDBNULL(IB_THUTUC_MA, ProType.STRING, this.DataManagement)).AppendFormat(",IB_THUTUC_TEN = {0}", clsDAL.IsDBNULL(IB_THUTUC_TEN, ProType.STRING, this.DataManagement)).AppendFormat(",IB_CQBHXH_MA = {0}", clsDAL.IsDBNULL(IB_CQBHXH_MA, ProType.STRING, this.DataManagement)).AppendFormat(",IB_CQBHXH_TEN = {0}", clsDAL.IsDBNULL(IB_CQBHXH_TEN, ProType.STRING, this.DataManagement)).AppendFormat(",IB_HOSO_NOIDUNG = {0}", clsDAL.IsDBNULL(IB_HOSO_NOIDUNG, ProType.STRING, this.DataManagement)).AppendFormat(",IB_HOSO_MD5 = {0}", clsDAL.IsDBNULL(IB_HOSO_MD5, ProType.STRING, this.DataManagement)).AppendFormat(",IB_NGUOIXULY = {0}", clsDAL.IsDBNULL(IB_NGUOIXULY, ProType.STRING, this.DataManagement)).AppendFormat(",IB_NGAY_TAO = {0}", clsDAL.IsDBNULL(IB_NGAY_TAO, ProType.VNDATESTRING, this.DataManagement));
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
			return clsDAL.DeleteString("INBOX", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("IB_SODK = {0}", clsDAL.IsDBNULL(IB_SODK, ProType.OTHER, this.DataManagement)).AppendFormat(" AND IB_NAMDK = {0}", clsDAL.IsDBNULL(IB_NAMDK, ProType.OTHER, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}