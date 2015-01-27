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
	/// Generated Class for Table : HOSO.
	/// </summary>
	public partial class HOSO : TableBase
	{
		public HOSO() : base(){}

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
		private string m_HS_SOHS;
		/// <summary>
		/// HS_SOHS.
		/// </summary>
		public string HS_SOHS
		{
			get
			{
				return m_HS_SOHS;
			}
			set
			{
				if ((this.m_HS_SOHS != value))
				{
					this.SendPropertyChanging("HS_SOHS");
					this.m_HS_SOHS = value;
					this.SendPropertyChanged("HS_SOHS");
				}
			}
		}

		private string m_HS_NAMDK;
		/// <summary>
		/// HS_NAMDK.
		/// </summary>
		public string HS_NAMDK
		{
			get
			{
				return m_HS_NAMDK;
			}
			set
			{
				if ((this.m_HS_NAMDK != value))
				{
					this.SendPropertyChanging("HS_NAMDK");
					this.m_HS_NAMDK = value;
					this.SendPropertyChanged("HS_NAMDK");
				}
			}
		}

		private string m_HS_NGAYDK;
		private bool m_HS_NGAYDKUpdated = false;
		/// <summary>
		/// HS_NGAYDK.
		/// </summary>
		public string HS_NGAYDK
		{
			get
			{
				return m_HS_NGAYDK;
			}
			set
			{
				if ((this.m_HS_NGAYDK != value))
				{
					this.SendPropertyChanging("HS_NGAYDK");
					this.m_HS_NGAYDK = value;
					this.SendPropertyChanged("HS_NGAYDK");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_HS_NGAYDKUpdated = true;
				}
			}
		}

		private string m_HS_DONVI_MST;
		private bool m_HS_DONVI_MSTUpdated = false;
		/// <summary>
		/// HS_DONVI_MST.
		/// </summary>
		public string HS_DONVI_MST
		{
			get
			{
				return m_HS_DONVI_MST;
			}
			set
			{
				if ((this.m_HS_DONVI_MST != value))
				{
					this.SendPropertyChanging("HS_DONVI_MST");
					this.m_HS_DONVI_MST = value;
					this.SendPropertyChanged("HS_DONVI_MST");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_HS_DONVI_MSTUpdated = true;
				}
			}
		}

		private string m_HS_DONVI_MA;
		private bool m_HS_DONVI_MAUpdated = false;
		/// <summary>
		/// HS_DONVI_MA.
		/// </summary>
		public string HS_DONVI_MA
		{
			get
			{
				return m_HS_DONVI_MA;
			}
			set
			{
				if ((this.m_HS_DONVI_MA != value))
				{
					this.SendPropertyChanging("HS_DONVI_MA");
					this.m_HS_DONVI_MA = value;
					this.SendPropertyChanged("HS_DONVI_MA");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_HS_DONVI_MAUpdated = true;
				}
			}
		}

		private string m_HS_DONVI_TEN;
		private bool m_HS_DONVI_TENUpdated = false;
		/// <summary>
		/// HS_DONVI_TEN.
		/// </summary>
		public string HS_DONVI_TEN
		{
			get
			{
				return m_HS_DONVI_TEN;
			}
			set
			{
				if ((this.m_HS_DONVI_TEN != value))
				{
					this.SendPropertyChanging("HS_DONVI_TEN");
					this.m_HS_DONVI_TEN = value;
					this.SendPropertyChanged("HS_DONVI_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_HS_DONVI_TENUpdated = true;
				}
			}
		}

		private string m_HS_DONVI_DEXUAT;
		private bool m_HS_DONVI_DEXUATUpdated = false;
		/// <summary>
		/// HS_DONVI_DEXUAT.
		/// </summary>
		public string HS_DONVI_DEXUAT
		{
			get
			{
				return m_HS_DONVI_DEXUAT;
			}
			set
			{
				if ((this.m_HS_DONVI_DEXUAT != value))
				{
					this.SendPropertyChanging("HS_DONVI_DEXUAT");
					this.m_HS_DONVI_DEXUAT = value;
					this.SendPropertyChanged("HS_DONVI_DEXUAT");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_HS_DONVI_DEXUATUpdated = true;
				}
			}
		}

		private string m_HS_GIAY_NGUOINOP_TEN;
		private bool m_HS_GIAY_NGUOINOP_TENUpdated = false;
		/// <summary>
		/// HS_GIAY_NGUOINOP_TEN.
		/// </summary>
		public string HS_GIAY_NGUOINOP_TEN
		{
			get
			{
				return m_HS_GIAY_NGUOINOP_TEN;
			}
			set
			{
				if ((this.m_HS_GIAY_NGUOINOP_TEN != value))
				{
					this.SendPropertyChanging("HS_GIAY_NGUOINOP_TEN");
					this.m_HS_GIAY_NGUOINOP_TEN = value;
					this.SendPropertyChanged("HS_GIAY_NGUOINOP_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_HS_GIAY_NGUOINOP_TENUpdated = true;
				}
			}
		}

		private string m_HS_GIAY_NGUOINOP_EMAIL;
		private bool m_HS_GIAY_NGUOINOP_EMAILUpdated = false;
		/// <summary>
		/// HS_GIAY_NGUOINOP_EMAIL.
		/// </summary>
		public string HS_GIAY_NGUOINOP_EMAIL
		{
			get
			{
				return m_HS_GIAY_NGUOINOP_EMAIL;
			}
			set
			{
				if ((this.m_HS_GIAY_NGUOINOP_EMAIL != value))
				{
					this.SendPropertyChanging("HS_GIAY_NGUOINOP_EMAIL");
					this.m_HS_GIAY_NGUOINOP_EMAIL = value;
					this.SendPropertyChanged("HS_GIAY_NGUOINOP_EMAIL");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_HS_GIAY_NGUOINOP_EMAILUpdated = true;
				}
			}
		}

		private string m_HS_GIAY_NGUOINOP_DT;
		private bool m_HS_GIAY_NGUOINOP_DTUpdated = false;
		/// <summary>
		/// HS_GIAY_NGUOINOP_DT.
		/// </summary>
		public string HS_GIAY_NGUOINOP_DT
		{
			get
			{
				return m_HS_GIAY_NGUOINOP_DT;
			}
			set
			{
				if ((this.m_HS_GIAY_NGUOINOP_DT != value))
				{
					this.SendPropertyChanging("HS_GIAY_NGUOINOP_DT");
					this.m_HS_GIAY_NGUOINOP_DT = value;
					this.SendPropertyChanged("HS_GIAY_NGUOINOP_DT");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_HS_GIAY_NGUOINOP_DTUpdated = true;
				}
			}
		}

		private string m_HS_GIAY_NGAYNHAN;
		private bool m_HS_GIAY_NGAYNHANUpdated = false;
		/// <summary>
		/// HS_GIAY_NGAYNHAN.
		/// </summary>
		public string HS_GIAY_NGAYNHAN
		{
			get
			{
				return m_HS_GIAY_NGAYNHAN;
			}
			set
			{
				if ((this.m_HS_GIAY_NGAYNHAN != value))
				{
					this.SendPropertyChanging("HS_GIAY_NGAYNHAN");
					this.m_HS_GIAY_NGAYNHAN = value;
					this.SendPropertyChanged("HS_GIAY_NGAYNHAN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_HS_GIAY_NGAYNHANUpdated = true;
				}
			}
		}

		private string m_HS_GIAY_NGAYHENTRA;
		private bool m_HS_GIAY_NGAYHENTRAUpdated = false;
		/// <summary>
		/// HS_GIAY_NGAYHENTRA.
		/// </summary>
		public string HS_GIAY_NGAYHENTRA
		{
			get
			{
				return m_HS_GIAY_NGAYHENTRA;
			}
			set
			{
				if ((this.m_HS_GIAY_NGAYHENTRA != value))
				{
					this.SendPropertyChanging("HS_GIAY_NGAYHENTRA");
					this.m_HS_GIAY_NGAYHENTRA = value;
					this.SendPropertyChanged("HS_GIAY_NGAYHENTRA");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_HS_GIAY_NGAYHENTRAUpdated = true;
				}
			}
		}

		private string m_HS_GIAY_NGUOITIEPNHAN;
		private bool m_HS_GIAY_NGUOITIEPNHANUpdated = false;
		/// <summary>
		/// HS_GIAY_NGUOITIEPNHAN.
		/// </summary>
		public string HS_GIAY_NGUOITIEPNHAN
		{
			get
			{
				return m_HS_GIAY_NGUOITIEPNHAN;
			}
			set
			{
				if ((this.m_HS_GIAY_NGUOITIEPNHAN != value))
				{
					this.SendPropertyChanging("HS_GIAY_NGUOITIEPNHAN");
					this.m_HS_GIAY_NGUOITIEPNHAN = value;
					this.SendPropertyChanged("HS_GIAY_NGUOITIEPNHAN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_HS_GIAY_NGUOITIEPNHANUpdated = true;
				}
			}
		}

		private string m_HS_GIAY_NGUOINHANKQ;
		private bool m_HS_GIAY_NGUOINHANKQUpdated = false;
		/// <summary>
		/// HS_GIAY_NGUOINHANKQ.
		/// </summary>
		public string HS_GIAY_NGUOINHANKQ
		{
			get
			{
				return m_HS_GIAY_NGUOINHANKQ;
			}
			set
			{
				if ((this.m_HS_GIAY_NGUOINHANKQ != value))
				{
					this.SendPropertyChanging("HS_GIAY_NGUOINHANKQ");
					this.m_HS_GIAY_NGUOINHANKQ = value;
					this.SendPropertyChanged("HS_GIAY_NGUOINHANKQ");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_HS_GIAY_NGUOINHANKQUpdated = true;
				}
			}
		}

		private string m_HS_GIAY_NGAYTRAKQ;
		private bool m_HS_GIAY_NGAYTRAKQUpdated = false;
		/// <summary>
		/// HS_GIAY_NGAYTRAKQ.
		/// </summary>
		public string HS_GIAY_NGAYTRAKQ
		{
			get
			{
				return m_HS_GIAY_NGAYTRAKQ;
			}
			set
			{
				if ((this.m_HS_GIAY_NGAYTRAKQ != value))
				{
					this.SendPropertyChanging("HS_GIAY_NGAYTRAKQ");
					this.m_HS_GIAY_NGAYTRAKQ = value;
					this.SendPropertyChanged("HS_GIAY_NGAYTRAKQ");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_HS_GIAY_NGAYTRAKQUpdated = true;
				}
			}
		}

		private string m_HS_THUTUC_MA;
		private bool m_HS_THUTUC_MAUpdated = false;
		/// <summary>
		/// HS_THUTUC_MA.
		/// </summary>
		public string HS_THUTUC_MA
		{
			get
			{
				return m_HS_THUTUC_MA;
			}
			set
			{
				if ((this.m_HS_THUTUC_MA != value))
				{
					this.SendPropertyChanging("HS_THUTUC_MA");
					this.m_HS_THUTUC_MA = value;
					this.SendPropertyChanged("HS_THUTUC_MA");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_HS_THUTUC_MAUpdated = true;
				}
			}
		}

		private string m_HS_THUTUC_TEN;
		private bool m_HS_THUTUC_TENUpdated = false;
		/// <summary>
		/// HS_THUTUC_TEN.
		/// </summary>
		public string HS_THUTUC_TEN
		{
			get
			{
				return m_HS_THUTUC_TEN;
			}
			set
			{
				if ((this.m_HS_THUTUC_TEN != value))
				{
					this.SendPropertyChanging("HS_THUTUC_TEN");
					this.m_HS_THUTUC_TEN = value;
					this.SendPropertyChanged("HS_THUTUC_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_HS_THUTUC_TENUpdated = true;
				}
			}
		}

		private string m_HS_CQBHXH_MA;
		private bool m_HS_CQBHXH_MAUpdated = false;
		/// <summary>
		/// HS_CQBHXH_MA.
		/// </summary>
		public string HS_CQBHXH_MA
		{
			get
			{
				return m_HS_CQBHXH_MA;
			}
			set
			{
				if ((this.m_HS_CQBHXH_MA != value))
				{
					this.SendPropertyChanging("HS_CQBHXH_MA");
					this.m_HS_CQBHXH_MA = value;
					this.SendPropertyChanged("HS_CQBHXH_MA");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_HS_CQBHXH_MAUpdated = true;
				}
			}
		}

		private string m_HS_CQBHXH_TEN;
		private bool m_HS_CQBHXH_TENUpdated = false;
		/// <summary>
		/// HS_CQBHXH_TEN.
		/// </summary>
		public string HS_CQBHXH_TEN
		{
			get
			{
				return m_HS_CQBHXH_TEN;
			}
			set
			{
				if ((this.m_HS_CQBHXH_TEN != value))
				{
					this.SendPropertyChanging("HS_CQBHXH_TEN");
					this.m_HS_CQBHXH_TEN = value;
					this.SendPropertyChanged("HS_CQBHXH_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_HS_CQBHXH_TENUpdated = true;
				}
			}
		}

		private string m_HS_NGUOIXULY;
		private bool m_HS_NGUOIXULYUpdated = false;
		/// <summary>
		/// HS_NGUOIXULY.
		/// </summary>
		public string HS_NGUOIXULY
		{
			get
			{
				return m_HS_NGUOIXULY;
			}
			set
			{
				if ((this.m_HS_NGUOIXULY != value))
				{
					this.SendPropertyChanging("HS_NGUOIXULY");
					this.m_HS_NGUOIXULY = value;
					this.SendPropertyChanged("HS_NGUOIXULY");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_HS_NGUOIXULYUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM HOSO " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("HS_SOHS", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_NAMDK", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_NGAYDK", ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_DONVI_MST", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_DONVI_MA", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_DONVI_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_DONVI_DEXUAT", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_GIAY_NGUOINOP_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_GIAY_NGUOINOP_EMAIL", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_GIAY_NGUOINOP_DT", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_GIAY_NGAYNHAN", ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_GIAY_NGAYHENTRA", ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_GIAY_NGUOITIEPNHAN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_GIAY_NGUOINHANKQ", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_GIAY_NGAYTRAKQ", ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_THUTUC_MA", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_THUTUC_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_CQBHXH_MA", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_CQBHXH_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("HS_NGUOIXULY", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO HOSO (HS_SOHS, HS_NAMDK, HS_NGAYDK, HS_DONVI_MST, HS_DONVI_MA, HS_DONVI_TEN, HS_DONVI_DEXUAT, HS_GIAY_NGUOINOP_TEN, HS_GIAY_NGUOINOP_EMAIL, HS_GIAY_NGUOINOP_DT, HS_GIAY_NGAYNHAN, HS_GIAY_NGAYHENTRA, HS_GIAY_NGUOITIEPNHAN, HS_GIAY_NGUOINHANKQ, HS_GIAY_NGAYTRAKQ, HS_THUTUC_MA, HS_THUTUC_TEN, HS_CQBHXH_MA, HS_CQBHXH_TEN, HS_NGUOIXULY) VALUES(").Append(clsDAL.IsDBNULL(HS_SOHS, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_NAMDK, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_NGAYDK, ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_DONVI_MST, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_DONVI_MA, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_DONVI_TEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_DONVI_DEXUAT, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_GIAY_NGUOINOP_TEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_GIAY_NGUOINOP_EMAIL, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_GIAY_NGUOINOP_DT, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_GIAY_NGAYNHAN, ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_GIAY_NGAYHENTRA, ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_GIAY_NGUOITIEPNHAN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_GIAY_NGUOINHANKQ, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_GIAY_NGAYTRAKQ, ProType.VNDATESTRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_THUTUC_MA, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_THUTUC_TEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_CQBHXH_MA, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_CQBHXH_TEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(HS_NGUOIXULY, ProType.STRING, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE HOSO SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_HS_NGAYDKUpdated ? string.Format(",HS_NGAYDK = {0}", clsDAL.IsDBNULL(HS_NGAYDK, ProType.VNDATESTRING, this.DataManagement)) : string.Empty).Append(m_HS_DONVI_MSTUpdated ? string.Format(",HS_DONVI_MST = {0}", clsDAL.IsDBNULL(HS_DONVI_MST, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_HS_DONVI_MAUpdated ? string.Format(",HS_DONVI_MA = {0}", clsDAL.IsDBNULL(HS_DONVI_MA, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_HS_DONVI_TENUpdated ? string.Format(",HS_DONVI_TEN = {0}", clsDAL.IsDBNULL(HS_DONVI_TEN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_HS_DONVI_DEXUATUpdated ? string.Format(",HS_DONVI_DEXUAT = {0}", clsDAL.IsDBNULL(HS_DONVI_DEXUAT, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_HS_GIAY_NGUOINOP_TENUpdated ? string.Format(",HS_GIAY_NGUOINOP_TEN = {0}", clsDAL.IsDBNULL(HS_GIAY_NGUOINOP_TEN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_HS_GIAY_NGUOINOP_EMAILUpdated ? string.Format(",HS_GIAY_NGUOINOP_EMAIL = {0}", clsDAL.IsDBNULL(HS_GIAY_NGUOINOP_EMAIL, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_HS_GIAY_NGUOINOP_DTUpdated ? string.Format(",HS_GIAY_NGUOINOP_DT = {0}", clsDAL.IsDBNULL(HS_GIAY_NGUOINOP_DT, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_HS_GIAY_NGAYNHANUpdated ? string.Format(",HS_GIAY_NGAYNHAN = {0}", clsDAL.IsDBNULL(HS_GIAY_NGAYNHAN, ProType.VNDATESTRING, this.DataManagement)) : string.Empty).Append(m_HS_GIAY_NGAYHENTRAUpdated ? string.Format(",HS_GIAY_NGAYHENTRA = {0}", clsDAL.IsDBNULL(HS_GIAY_NGAYHENTRA, ProType.VNDATESTRING, this.DataManagement)) : string.Empty).Append(m_HS_GIAY_NGUOITIEPNHANUpdated ? string.Format(",HS_GIAY_NGUOITIEPNHAN = {0}", clsDAL.IsDBNULL(HS_GIAY_NGUOITIEPNHAN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_HS_GIAY_NGUOINHANKQUpdated ? string.Format(",HS_GIAY_NGUOINHANKQ = {0}", clsDAL.IsDBNULL(HS_GIAY_NGUOINHANKQ, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_HS_GIAY_NGAYTRAKQUpdated ? string.Format(",HS_GIAY_NGAYTRAKQ = {0}", clsDAL.IsDBNULL(HS_GIAY_NGAYTRAKQ, ProType.VNDATESTRING, this.DataManagement)) : string.Empty).Append(m_HS_THUTUC_MAUpdated ? string.Format(",HS_THUTUC_MA = {0}", clsDAL.IsDBNULL(HS_THUTUC_MA, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_HS_THUTUC_TENUpdated ? string.Format(",HS_THUTUC_TEN = {0}", clsDAL.IsDBNULL(HS_THUTUC_TEN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_HS_CQBHXH_MAUpdated ? string.Format(",HS_CQBHXH_MA = {0}", clsDAL.IsDBNULL(HS_CQBHXH_MA, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_HS_CQBHXH_TENUpdated ? string.Format(",HS_CQBHXH_TEN = {0}", clsDAL.IsDBNULL(HS_CQBHXH_TEN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_HS_NGUOIXULYUpdated ? string.Format(",HS_NGUOIXULY = {0}", clsDAL.IsDBNULL(HS_NGUOIXULY, ProType.STRING, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("HS_NGAYDK = {0}", clsDAL.IsDBNULL(HS_NGAYDK, ProType.VNDATESTRING, this.DataManagement)).AppendFormat(",HS_DONVI_MST = {0}", clsDAL.IsDBNULL(HS_DONVI_MST, ProType.STRING, this.DataManagement)).AppendFormat(",HS_DONVI_MA = {0}", clsDAL.IsDBNULL(HS_DONVI_MA, ProType.STRING, this.DataManagement)).AppendFormat(",HS_DONVI_TEN = {0}", clsDAL.IsDBNULL(HS_DONVI_TEN, ProType.STRING, this.DataManagement)).AppendFormat(",HS_DONVI_DEXUAT = {0}", clsDAL.IsDBNULL(HS_DONVI_DEXUAT, ProType.STRING, this.DataManagement)).AppendFormat(",HS_GIAY_NGUOINOP_TEN = {0}", clsDAL.IsDBNULL(HS_GIAY_NGUOINOP_TEN, ProType.STRING, this.DataManagement)).AppendFormat(",HS_GIAY_NGUOINOP_EMAIL = {0}", clsDAL.IsDBNULL(HS_GIAY_NGUOINOP_EMAIL, ProType.STRING, this.DataManagement)).AppendFormat(",HS_GIAY_NGUOINOP_DT = {0}", clsDAL.IsDBNULL(HS_GIAY_NGUOINOP_DT, ProType.STRING, this.DataManagement)).AppendFormat(",HS_GIAY_NGAYNHAN = {0}", clsDAL.IsDBNULL(HS_GIAY_NGAYNHAN, ProType.VNDATESTRING, this.DataManagement)).AppendFormat(",HS_GIAY_NGAYHENTRA = {0}", clsDAL.IsDBNULL(HS_GIAY_NGAYHENTRA, ProType.VNDATESTRING, this.DataManagement)).AppendFormat(",HS_GIAY_NGUOITIEPNHAN = {0}", clsDAL.IsDBNULL(HS_GIAY_NGUOITIEPNHAN, ProType.STRING, this.DataManagement)).AppendFormat(",HS_GIAY_NGUOINHANKQ = {0}", clsDAL.IsDBNULL(HS_GIAY_NGUOINHANKQ, ProType.STRING, this.DataManagement)).AppendFormat(",HS_GIAY_NGAYTRAKQ = {0}", clsDAL.IsDBNULL(HS_GIAY_NGAYTRAKQ, ProType.VNDATESTRING, this.DataManagement)).AppendFormat(",HS_THUTUC_MA = {0}", clsDAL.IsDBNULL(HS_THUTUC_MA, ProType.STRING, this.DataManagement)).AppendFormat(",HS_THUTUC_TEN = {0}", clsDAL.IsDBNULL(HS_THUTUC_TEN, ProType.STRING, this.DataManagement)).AppendFormat(",HS_CQBHXH_MA = {0}", clsDAL.IsDBNULL(HS_CQBHXH_MA, ProType.STRING, this.DataManagement)).AppendFormat(",HS_CQBHXH_TEN = {0}", clsDAL.IsDBNULL(HS_CQBHXH_TEN, ProType.STRING, this.DataManagement)).AppendFormat(",HS_NGUOIXULY = {0}", clsDAL.IsDBNULL(HS_NGUOIXULY, ProType.STRING, this.DataManagement));
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
			return clsDAL.DeleteString("HOSO", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("HS_SOHS = {0}", clsDAL.IsDBNULL(HS_SOHS, ProType.OTHER, this.DataManagement)).AppendFormat(" AND HS_NAMDK = {0}", clsDAL.IsDBNULL(HS_NAMDK, ProType.OTHER, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}