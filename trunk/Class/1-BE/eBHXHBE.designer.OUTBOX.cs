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
	/// Generated Class for Table : OUTBOX.
	/// </summary>
	public partial class OUTBOX : TableBase
	{
		public OUTBOX() : base(){}

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
		private string m_OB_ID;
		/// <summary>
		/// OB_ID.
		/// </summary>
		public string OB_ID
		{
			get
			{
				return m_OB_ID;
			}
			set
			{
				if ((this.m_OB_ID != value))
				{
					this.SendPropertyChanging("OB_ID");
					this.m_OB_ID = value;
					this.SendPropertyChanged("OB_ID");
				}
			}
		}

		private string m_OB_SODK;
		private bool m_OB_SODKUpdated = false;
		/// <summary>
		/// OB_SODK.
		/// </summary>
		public string OB_SODK
		{
			get
			{
				return m_OB_SODK;
			}
			set
			{
				if ((this.m_OB_SODK != value))
				{
					this.SendPropertyChanging("OB_SODK");
					this.m_OB_SODK = value;
					this.SendPropertyChanged("OB_SODK");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_OB_SODKUpdated = true;
				}
			}
		}

		private string m_OB_NAMDK;
		private bool m_OB_NAMDKUpdated = false;
		/// <summary>
		/// OB_NAMDK.
		/// </summary>
		public string OB_NAMDK
		{
			get
			{
				return m_OB_NAMDK;
			}
			set
			{
				if ((this.m_OB_NAMDK != value))
				{
					this.SendPropertyChanging("OB_NAMDK");
					this.m_OB_NAMDK = value;
					this.SendPropertyChanged("OB_NAMDK");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_OB_NAMDKUpdated = true;
				}
			}
		}

		private string m_OB_NGAYDK;
		private bool m_OB_NGAYDKUpdated = false;
		/// <summary>
		/// OB_NGAYDK.
		/// </summary>
		public string OB_NGAYDK
		{
			get
			{
				return m_OB_NGAYDK;
			}
			set
			{
				if ((this.m_OB_NGAYDK != value))
				{
					this.SendPropertyChanging("OB_NGAYDK");
					this.m_OB_NGAYDK = value;
					this.SendPropertyChanged("OB_NGAYDK");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_OB_NGAYDKUpdated = true;
				}
			}
		}

		private string m_OB_DONVI_MST;
		private bool m_OB_DONVI_MSTUpdated = false;
		/// <summary>
		/// OB_DONVI_MST.
		/// </summary>
		public string OB_DONVI_MST
		{
			get
			{
				return m_OB_DONVI_MST;
			}
			set
			{
				if ((this.m_OB_DONVI_MST != value))
				{
					this.SendPropertyChanging("OB_DONVI_MST");
					this.m_OB_DONVI_MST = value;
					this.SendPropertyChanged("OB_DONVI_MST");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_OB_DONVI_MSTUpdated = true;
				}
			}
		}

		private string m_OB_DONVI_MA;
		private bool m_OB_DONVI_MAUpdated = false;
		/// <summary>
		/// OB_DONVI_MA.
		/// </summary>
		public string OB_DONVI_MA
		{
			get
			{
				return m_OB_DONVI_MA;
			}
			set
			{
				if ((this.m_OB_DONVI_MA != value))
				{
					this.SendPropertyChanging("OB_DONVI_MA");
					this.m_OB_DONVI_MA = value;
					this.SendPropertyChanged("OB_DONVI_MA");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_OB_DONVI_MAUpdated = true;
				}
			}
		}

		private string m_OB_DONVI_TEN;
		private bool m_OB_DONVI_TENUpdated = false;
		/// <summary>
		/// OB_DONVI_TEN.
		/// </summary>
		public string OB_DONVI_TEN
		{
			get
			{
				return m_OB_DONVI_TEN;
			}
			set
			{
				if ((this.m_OB_DONVI_TEN != value))
				{
					this.SendPropertyChanging("OB_DONVI_TEN");
					this.m_OB_DONVI_TEN = value;
					this.SendPropertyChanged("OB_DONVI_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_OB_DONVI_TENUpdated = true;
				}
			}
		}

		private string m_OB_THUTUC_MA;
		private bool m_OB_THUTUC_MAUpdated = false;
		/// <summary>
		/// OB_THUTUC_MA.
		/// </summary>
		public string OB_THUTUC_MA
		{
			get
			{
				return m_OB_THUTUC_MA;
			}
			set
			{
				if ((this.m_OB_THUTUC_MA != value))
				{
					this.SendPropertyChanging("OB_THUTUC_MA");
					this.m_OB_THUTUC_MA = value;
					this.SendPropertyChanged("OB_THUTUC_MA");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_OB_THUTUC_MAUpdated = true;
				}
			}
		}

		private string m_OB_THUTUC_TEN;
		private bool m_OB_THUTUC_TENUpdated = false;
		/// <summary>
		/// OB_THUTUC_TEN.
		/// </summary>
		public string OB_THUTUC_TEN
		{
			get
			{
				return m_OB_THUTUC_TEN;
			}
			set
			{
				if ((this.m_OB_THUTUC_TEN != value))
				{
					this.SendPropertyChanging("OB_THUTUC_TEN");
					this.m_OB_THUTUC_TEN = value;
					this.SendPropertyChanged("OB_THUTUC_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_OB_THUTUC_TENUpdated = true;
				}
			}
		}

		private string m_OB_CQBHXH_MA;
		private bool m_OB_CQBHXH_MAUpdated = false;
		/// <summary>
		/// OB_CQBHXH_MA.
		/// </summary>
		public string OB_CQBHXH_MA
		{
			get
			{
				return m_OB_CQBHXH_MA;
			}
			set
			{
				if ((this.m_OB_CQBHXH_MA != value))
				{
					this.SendPropertyChanging("OB_CQBHXH_MA");
					this.m_OB_CQBHXH_MA = value;
					this.SendPropertyChanged("OB_CQBHXH_MA");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_OB_CQBHXH_MAUpdated = true;
				}
			}
		}

		private string m_OB_CQBHXH_TEN;
		private bool m_OB_CQBHXH_TENUpdated = false;
		/// <summary>
		/// OB_CQBHXH_TEN.
		/// </summary>
		public string OB_CQBHXH_TEN
		{
			get
			{
				return m_OB_CQBHXH_TEN;
			}
			set
			{
				if ((this.m_OB_CQBHXH_TEN != value))
				{
					this.SendPropertyChanging("OB_CQBHXH_TEN");
					this.m_OB_CQBHXH_TEN = value;
					this.SendPropertyChanged("OB_CQBHXH_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_OB_CQBHXH_TENUpdated = true;
				}
			}
		}

		private string m_OB_PHANHOI_NOIDUNG;
		private bool m_OB_PHANHOI_NOIDUNGUpdated = false;
		/// <summary>
		/// OB_PHANHOI_NOIDUNG.
		/// </summary>
		public string OB_PHANHOI_NOIDUNG
		{
			get
			{
				return m_OB_PHANHOI_NOIDUNG;
			}
			set
			{
				if ((this.m_OB_PHANHOI_NOIDUNG != value))
				{
					this.SendPropertyChanging("OB_PHANHOI_NOIDUNG");
					this.m_OB_PHANHOI_NOIDUNG = value;
					this.SendPropertyChanged("OB_PHANHOI_NOIDUNG");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_OB_PHANHOI_NOIDUNGUpdated = true;
				}
			}
		}

		private string m_OB_PHANHOI_NGUOI;
		private bool m_OB_PHANHOI_NGUOIUpdated = false;
		/// <summary>
		/// OB_PHANHOI_NGUOI.
		/// </summary>
		public string OB_PHANHOI_NGUOI
		{
			get
			{
				return m_OB_PHANHOI_NGUOI;
			}
			set
			{
				if ((this.m_OB_PHANHOI_NGUOI != value))
				{
					this.SendPropertyChanging("OB_PHANHOI_NGUOI");
					this.m_OB_PHANHOI_NGUOI = value;
					this.SendPropertyChanged("OB_PHANHOI_NGUOI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_OB_PHANHOI_NGUOIUpdated = true;
				}
			}
		}

		private string m_OB_PHANHOI_NGAY;
		private bool m_OB_PHANHOI_NGAYUpdated = false;
		/// <summary>
		/// OB_PHANHOI_NGAY.
		/// </summary>
		public string OB_PHANHOI_NGAY
		{
			get
			{
				return m_OB_PHANHOI_NGAY;
			}
			set
			{
				if ((this.m_OB_PHANHOI_NGAY != value))
				{
					this.SendPropertyChanging("OB_PHANHOI_NGAY");
					this.m_OB_PHANHOI_NGAY = value;
					this.SendPropertyChanged("OB_PHANHOI_NGAY");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_OB_PHANHOI_NGAYUpdated = true;
				}
			}
		}

		private string m_OB_NGAY_TAO = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
		private bool m_OB_NGAY_TAOUpdated = false;
		/// <summary>
		/// OB_NGAY_TAO.
		/// </summary>
		public string OB_NGAY_TAO
		{
			get
			{
				return m_OB_NGAY_TAO;
			}
			set
			{
				if ((this.m_OB_NGAY_TAO != value))
				{
					this.SendPropertyChanging("OB_NGAY_TAO");
					this.m_OB_NGAY_TAO = value;
					this.SendPropertyChanged("OB_NGAY_TAO");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_OB_NGAY_TAOUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM OUTBOX " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("OB_ID", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("OB_SODK", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("OB_NAMDK", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("OB_NGAYDK", ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.SelectField("OB_DONVI_MST", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("OB_DONVI_MA", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("OB_DONVI_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("OB_THUTUC_MA", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("OB_THUTUC_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("OB_CQBHXH_MA", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("OB_CQBHXH_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("OB_PHANHOI_NOIDUNG", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("OB_PHANHOI_NGUOI", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("OB_PHANHOI_NGAY", ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.SelectField("OB_NGAY_TAO", ProType.VNDATESTRING, this.DataManagement));
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
			sbSQL.Append("INSERT INTO OUTBOX (OB_SODK, OB_NAMDK, OB_NGAYDK, OB_DONVI_MST, OB_DONVI_MA, OB_DONVI_TEN, OB_THUTUC_MA, OB_THUTUC_TEN, OB_CQBHXH_MA, OB_CQBHXH_TEN, OB_PHANHOI_NOIDUNG, OB_PHANHOI_NGUOI, OB_PHANHOI_NGAY, OB_NGAY_TAO) VALUES(").Append(clsDAL.IsDBNULL(OB_SODK, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(OB_NAMDK, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(OB_NGAYDK, ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(OB_DONVI_MST, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(OB_DONVI_MA, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(OB_DONVI_TEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(OB_THUTUC_MA, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(OB_THUTUC_TEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(OB_CQBHXH_MA, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(OB_CQBHXH_TEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(OB_PHANHOI_NOIDUNG, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(OB_PHANHOI_NGUOI, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(OB_PHANHOI_NGAY, ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(OB_NGAY_TAO, ProType.VNDATESTRING, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE OUTBOX SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_OB_SODKUpdated ? string.Format(",OB_SODK = {0}", clsDAL.IsDBNULL(OB_SODK, ProType.OTHER, this.DataManagement)) : string.Empty).Append(m_OB_NAMDKUpdated ? string.Format(",OB_NAMDK = {0}", clsDAL.IsDBNULL(OB_NAMDK, ProType.OTHER, this.DataManagement)) : string.Empty).Append(m_OB_NGAYDKUpdated ? string.Format(",OB_NGAYDK = {0}", clsDAL.IsDBNULL(OB_NGAYDK, ProType.VNDATESTRING, this.DataManagement)) : string.Empty).Append(m_OB_DONVI_MSTUpdated ? string.Format(",OB_DONVI_MST = {0}", clsDAL.IsDBNULL(OB_DONVI_MST, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_OB_DONVI_MAUpdated ? string.Format(",OB_DONVI_MA = {0}", clsDAL.IsDBNULL(OB_DONVI_MA, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_OB_DONVI_TENUpdated ? string.Format(",OB_DONVI_TEN = {0}", clsDAL.IsDBNULL(OB_DONVI_TEN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_OB_THUTUC_MAUpdated ? string.Format(",OB_THUTUC_MA = {0}", clsDAL.IsDBNULL(OB_THUTUC_MA, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_OB_THUTUC_TENUpdated ? string.Format(",OB_THUTUC_TEN = {0}", clsDAL.IsDBNULL(OB_THUTUC_TEN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_OB_CQBHXH_MAUpdated ? string.Format(",OB_CQBHXH_MA = {0}", clsDAL.IsDBNULL(OB_CQBHXH_MA, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_OB_CQBHXH_TENUpdated ? string.Format(",OB_CQBHXH_TEN = {0}", clsDAL.IsDBNULL(OB_CQBHXH_TEN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_OB_PHANHOI_NOIDUNGUpdated ? string.Format(",OB_PHANHOI_NOIDUNG = {0}", clsDAL.IsDBNULL(OB_PHANHOI_NOIDUNG, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_OB_PHANHOI_NGUOIUpdated ? string.Format(",OB_PHANHOI_NGUOI = {0}", clsDAL.IsDBNULL(OB_PHANHOI_NGUOI, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_OB_PHANHOI_NGAYUpdated ? string.Format(",OB_PHANHOI_NGAY = {0}", clsDAL.IsDBNULL(OB_PHANHOI_NGAY, ProType.VNDATESTRING, this.DataManagement)) : string.Empty).Append(m_OB_NGAY_TAOUpdated ? string.Format(",OB_NGAY_TAO = {0}", clsDAL.IsDBNULL(OB_NGAY_TAO, ProType.VNDATESTRING, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("OB_SODK = {0}", clsDAL.IsDBNULL(OB_SODK, ProType.OTHER, this.DataManagement)).AppendFormat(",OB_NAMDK = {0}", clsDAL.IsDBNULL(OB_NAMDK, ProType.OTHER, this.DataManagement)).AppendFormat(",OB_NGAYDK = {0}", clsDAL.IsDBNULL(OB_NGAYDK, ProType.VNDATESTRING, this.DataManagement)).AppendFormat(",OB_DONVI_MST = {0}", clsDAL.IsDBNULL(OB_DONVI_MST, ProType.STRING, this.DataManagement)).AppendFormat(",OB_DONVI_MA = {0}", clsDAL.IsDBNULL(OB_DONVI_MA, ProType.STRING, this.DataManagement)).AppendFormat(",OB_DONVI_TEN = {0}", clsDAL.IsDBNULL(OB_DONVI_TEN, ProType.STRING, this.DataManagement)).AppendFormat(",OB_THUTUC_MA = {0}", clsDAL.IsDBNULL(OB_THUTUC_MA, ProType.STRING, this.DataManagement)).AppendFormat(",OB_THUTUC_TEN = {0}", clsDAL.IsDBNULL(OB_THUTUC_TEN, ProType.STRING, this.DataManagement)).AppendFormat(",OB_CQBHXH_MA = {0}", clsDAL.IsDBNULL(OB_CQBHXH_MA, ProType.STRING, this.DataManagement)).AppendFormat(",OB_CQBHXH_TEN = {0}", clsDAL.IsDBNULL(OB_CQBHXH_TEN, ProType.STRING, this.DataManagement)).AppendFormat(",OB_PHANHOI_NOIDUNG = {0}", clsDAL.IsDBNULL(OB_PHANHOI_NOIDUNG, ProType.STRING, this.DataManagement)).AppendFormat(",OB_PHANHOI_NGUOI = {0}", clsDAL.IsDBNULL(OB_PHANHOI_NGUOI, ProType.STRING, this.DataManagement)).AppendFormat(",OB_PHANHOI_NGAY = {0}", clsDAL.IsDBNULL(OB_PHANHOI_NGAY, ProType.VNDATESTRING, this.DataManagement)).AppendFormat(",OB_NGAY_TAO = {0}", clsDAL.IsDBNULL(OB_NGAY_TAO, ProType.VNDATESTRING, this.DataManagement));
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
			return clsDAL.DeleteString("OUTBOX", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("OB_ID = {0}", clsDAL.IsDBNULL(OB_ID, ProType.OTHER, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}