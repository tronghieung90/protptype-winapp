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
	/// Generated Class for Table : THUHIENQUYTRINH.
	/// </summary>
	public partial class THUHIENQUYTRINH : TableBase
	{
		public THUHIENQUYTRINH() : base(){}

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
		private string m_TH_HS_SOHS;
		/// <summary>
		/// TH_HS_SOHS.
		/// </summary>
		public string TH_HS_SOHS
		{
			get
			{
				return m_TH_HS_SOHS;
			}
			set
			{
				if ((this.m_TH_HS_SOHS != value))
				{
					this.SendPropertyChanging("TH_HS_SOHS");
					this.m_TH_HS_SOHS = value;
					this.SendPropertyChanged("TH_HS_SOHS");
				}
			}
		}

		private string m_TH_HS_NAMDK;
		/// <summary>
		/// TH_HS_NAMDK.
		/// </summary>
		public string TH_HS_NAMDK
		{
			get
			{
				return m_TH_HS_NAMDK;
			}
			set
			{
				if ((this.m_TH_HS_NAMDK != value))
				{
					this.SendPropertyChanging("TH_HS_NAMDK");
					this.m_TH_HS_NAMDK = value;
					this.SendPropertyChanged("TH_HS_NAMDK");
				}
			}
		}

		private string m_TH_HS_THUTUC_MA;
		/// <summary>
		/// TH_HS_THUTUC_MA.
		/// </summary>
		public string TH_HS_THUTUC_MA
		{
			get
			{
				return m_TH_HS_THUTUC_MA;
			}
			set
			{
				if ((this.m_TH_HS_THUTUC_MA != value))
				{
					this.SendPropertyChanging("TH_HS_THUTUC_MA");
					this.m_TH_HS_THUTUC_MA = value;
					this.SendPropertyChanged("TH_HS_THUTUC_MA");
				}
			}
		}

		private string m_TH_QT_MACQ;
		/// <summary>
		/// TH_QT_MACQ.
		/// </summary>
		public string TH_QT_MACQ
		{
			get
			{
				return m_TH_QT_MACQ;
			}
			set
			{
				if ((this.m_TH_QT_MACQ != value))
				{
					this.SendPropertyChanging("TH_QT_MACQ");
					this.m_TH_QT_MACQ = value;
					this.SendPropertyChanged("TH_QT_MACQ");
				}
			}
		}

		private string m_TH_QT_MAPHONG;
		/// <summary>
		/// TH_QT_MAPHONG.
		/// </summary>
		public string TH_QT_MAPHONG
		{
			get
			{
				return m_TH_QT_MAPHONG;
			}
			set
			{
				if ((this.m_TH_QT_MAPHONG != value))
				{
					this.SendPropertyChanging("TH_QT_MAPHONG");
					this.m_TH_QT_MAPHONG = value;
					this.SendPropertyChanged("TH_QT_MAPHONG");
				}
			}
		}

		private string m_TH_QT_THUTUTHUCHIEN;
		/// <summary>
		/// TH_QT_THUTUTHUCHIEN.
		/// </summary>
		public string TH_QT_THUTUTHUCHIEN
		{
			get
			{
				return m_TH_QT_THUTUTHUCHIEN;
			}
			set
			{
				if ((this.m_TH_QT_THUTUTHUCHIEN != value))
				{
					this.SendPropertyChanging("TH_QT_THUTUTHUCHIEN");
					this.m_TH_QT_THUTUTHUCHIEN = value;
					this.SendPropertyChanged("TH_QT_THUTUTHUCHIEN");
				}
			}
		}

		private string m_TH_NGUOITHUCHIEN;
		/// <summary>
		/// TH_NGUOITHUCHIEN.
		/// </summary>
		public string TH_NGUOITHUCHIEN
		{
			get
			{
				return m_TH_NGUOITHUCHIEN;
			}
			set
			{
				if ((this.m_TH_NGUOITHUCHIEN != value))
				{
					this.SendPropertyChanging("TH_NGUOITHUCHIEN");
					this.m_TH_NGUOITHUCHIEN = value;
					this.SendPropertyChanged("TH_NGUOITHUCHIEN");
				}
			}
		}

		private bool m_TH_NGUOITHUCHIENLALANHDAO;
		/// <summary>
		/// TH_NGUOITHUCHIENLALANHDAO.
		/// </summary>
		public bool TH_NGUOITHUCHIENLALANHDAO
		{
			get
			{
				return m_TH_NGUOITHUCHIENLALANHDAO;
			}
			set
			{
				if ((this.m_TH_NGUOITHUCHIENLALANHDAO != value))
				{
					this.SendPropertyChanging("TH_NGUOITHUCHIENLALANHDAO");
					this.m_TH_NGUOITHUCHIENLALANHDAO = value;
					this.SendPropertyChanged("TH_NGUOITHUCHIENLALANHDAO");
				}
			}
		}

		private bool m_TH_XACNHANHOSOHOPLE;
		/// <summary>
		/// TH_XACNHANHOSOHOPLE.
		/// </summary>
		public bool TH_XACNHANHOSOHOPLE
		{
			get
			{
				return m_TH_XACNHANHOSOHOPLE;
			}
			set
			{
				if ((this.m_TH_XACNHANHOSOHOPLE != value))
				{
					this.SendPropertyChanging("TH_XACNHANHOSOHOPLE");
					this.m_TH_XACNHANHOSOHOPLE = value;
					this.SendPropertyChanged("TH_XACNHANHOSOHOPLE");
				}
			}
		}

		private string m_TH_GHICHUKHITHUCHIEN;
		private bool m_TH_GHICHUKHITHUCHIENUpdated = false;
		/// <summary>
		/// TH_GHICHUKHITHUCHIEN.
		/// </summary>
		public string TH_GHICHUKHITHUCHIEN
		{
			get
			{
				return m_TH_GHICHUKHITHUCHIEN;
			}
			set
			{
				if ((this.m_TH_GHICHUKHITHUCHIEN != value))
				{
					this.SendPropertyChanging("TH_GHICHUKHITHUCHIEN");
					this.m_TH_GHICHUKHITHUCHIEN = value;
					this.SendPropertyChanged("TH_GHICHUKHITHUCHIEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TH_GHICHUKHITHUCHIENUpdated = true;
				}
			}
		}

		private string m_TH_NGAYTHUCHIEN;
		private bool m_TH_NGAYTHUCHIENUpdated = false;
		/// <summary>
		/// TH_NGAYTHUCHIEN.
		/// </summary>
		public string TH_NGAYTHUCHIEN
		{
			get
			{
				return m_TH_NGAYTHUCHIEN;
			}
			set
			{
				if ((this.m_TH_NGAYTHUCHIEN != value))
				{
					this.SendPropertyChanging("TH_NGAYTHUCHIEN");
					this.m_TH_NGAYTHUCHIEN = value;
					this.SendPropertyChanged("TH_NGAYTHUCHIEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TH_NGAYTHUCHIENUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM THUHIENQUYTRINH " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("TH_HS_SOHS", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TH_HS_NAMDK", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TH_HS_THUTUC_MA", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TH_QT_MACQ", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TH_QT_MAPHONG", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TH_QT_THUTUTHUCHIEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TH_NGUOITHUCHIEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TH_NGUOITHUCHIENLALANHDAO", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TH_XACNHANHOSOHOPLE", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TH_GHICHUKHITHUCHIEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TH_NGAYTHUCHIEN", ProType.VNDATESTRING, this.DataManagement));
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
			sbSQL.Append("INSERT INTO THUHIENQUYTRINH (TH_HS_SOHS, TH_HS_NAMDK, TH_HS_THUTUC_MA, TH_QT_MACQ, TH_QT_MAPHONG, TH_QT_THUTUTHUCHIEN, TH_NGUOITHUCHIEN, TH_NGUOITHUCHIENLALANHDAO, TH_XACNHANHOSOHOPLE, TH_GHICHUKHITHUCHIEN, TH_NGAYTHUCHIEN) VALUES(").Append(clsDAL.IsDBNULL(TH_HS_SOHS, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TH_HS_NAMDK, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TH_HS_THUTUC_MA, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TH_QT_MACQ, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TH_QT_MAPHONG, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TH_QT_THUTUTHUCHIEN, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TH_NGUOITHUCHIEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TH_NGUOITHUCHIENLALANHDAO, ProType.BOOL, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TH_XACNHANHOSOHOPLE, ProType.BOOL, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TH_GHICHUKHITHUCHIEN, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(TH_NGAYTHUCHIEN, ProType.VNDATESTRING, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE THUHIENQUYTRINH SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_TH_GHICHUKHITHUCHIENUpdated ? string.Format(",TH_GHICHUKHITHUCHIEN = {0}", clsDAL.IsDBNULL(TH_GHICHUKHITHUCHIEN, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_TH_NGAYTHUCHIENUpdated ? string.Format(",TH_NGAYTHUCHIEN = {0}", clsDAL.IsDBNULL(TH_NGAYTHUCHIEN, ProType.VNDATESTRING, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("TH_GHICHUKHITHUCHIEN = {0}", clsDAL.IsDBNULL(TH_GHICHUKHITHUCHIEN, ProType.STRING, this.DataManagement)).AppendFormat(",TH_NGAYTHUCHIEN = {0}", clsDAL.IsDBNULL(TH_NGAYTHUCHIEN, ProType.VNDATESTRING, this.DataManagement));
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
			return clsDAL.DeleteString("THUHIENQUYTRINH", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("TH_HS_SOHS = {0}", clsDAL.IsDBNULL(TH_HS_SOHS, ProType.OTHER, this.DataManagement)).AppendFormat(" AND TH_HS_NAMDK = {0}", clsDAL.IsDBNULL(TH_HS_NAMDK, ProType.OTHER, this.DataManagement)).AppendFormat(" AND TH_HS_THUTUC_MA = {0}", clsDAL.IsDBNULL(TH_HS_THUTUC_MA, ProType.STRING, this.DataManagement)).AppendFormat(" AND TH_QT_MACQ = {0}", clsDAL.IsDBNULL(TH_QT_MACQ, ProType.STRING, this.DataManagement)).AppendFormat(" AND TH_QT_MAPHONG = {0}", clsDAL.IsDBNULL(TH_QT_MAPHONG, ProType.STRING, this.DataManagement)).AppendFormat(" AND TH_QT_THUTUTHUCHIEN = {0}", clsDAL.IsDBNULL(TH_QT_THUTUTHUCHIEN, ProType.OTHER, this.DataManagement)).AppendFormat(" AND TH_NGUOITHUCHIEN = {0}", clsDAL.IsDBNULL(TH_NGUOITHUCHIEN, ProType.STRING, this.DataManagement)).AppendFormat(" AND TH_NGUOITHUCHIENLALANHDAO = {0}", clsDAL.IsDBNULL(TH_NGUOITHUCHIENLALANHDAO, ProType.BOOL, this.DataManagement)).AppendFormat(" AND TH_XACNHANHOSOHOPLE = {0}", clsDAL.IsDBNULL(TH_XACNHANHOSOHOPLE, ProType.BOOL, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}