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
	/// Generated Class for Table : LICHSUPHANCONG.
	/// </summary>
	public partial class LICHSUPHANCONG : TableBase
	{
		public LICHSUPHANCONG() : base(){}

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
		private string m_LSPC_HS_SOHS;
		/// <summary>
		/// LSPC_HS_SOHS.
		/// </summary>
		public string LSPC_HS_SOHS
		{
			get
			{
				return m_LSPC_HS_SOHS;
			}
			set
			{
				if ((this.m_LSPC_HS_SOHS != value))
				{
					this.SendPropertyChanging("LSPC_HS_SOHS");
					this.m_LSPC_HS_SOHS = value;
					this.SendPropertyChanged("LSPC_HS_SOHS");
				}
			}
		}

		private string m_LSPC_HS_NAMDK;
		/// <summary>
		/// LSPC_HS_NAMDK.
		/// </summary>
		public string LSPC_HS_NAMDK
		{
			get
			{
				return m_LSPC_HS_NAMDK;
			}
			set
			{
				if ((this.m_LSPC_HS_NAMDK != value))
				{
					this.SendPropertyChanging("LSPC_HS_NAMDK");
					this.m_LSPC_HS_NAMDK = value;
					this.SendPropertyChanged("LSPC_HS_NAMDK");
				}
			}
		}

		private string m_LSPC_ID;
		/// <summary>
		/// LSPC_ID.
		/// </summary>
		public string LSPC_ID
		{
			get
			{
				return m_LSPC_ID;
			}
			set
			{
				if ((this.m_LSPC_ID != value))
				{
					this.SendPropertyChanging("LSPC_ID");
					this.m_LSPC_ID = value;
					this.SendPropertyChanged("LSPC_ID");
				}
			}
		}

		private string m_LSPC_NGUOIPHANCONG;
		private bool m_LSPC_NGUOIPHANCONGUpdated = false;
		/// <summary>
		/// LSPC_NGUOIPHANCONG.
		/// </summary>
		public string LSPC_NGUOIPHANCONG
		{
			get
			{
				return m_LSPC_NGUOIPHANCONG;
			}
			set
			{
				if ((this.m_LSPC_NGUOIPHANCONG != value))
				{
					this.SendPropertyChanging("LSPC_NGUOIPHANCONG");
					this.m_LSPC_NGUOIPHANCONG = value;
					this.SendPropertyChanged("LSPC_NGUOIPHANCONG");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_LSPC_NGUOIPHANCONGUpdated = true;
				}
			}
		}

		private string m_LSPC_NGUOIXULYHOSO;
		private bool m_LSPC_NGUOIXULYHOSOUpdated = false;
		/// <summary>
		/// LSPC_NGUOIXULYHOSO.
		/// </summary>
		public string LSPC_NGUOIXULYHOSO
		{
			get
			{
				return m_LSPC_NGUOIXULYHOSO;
			}
			set
			{
				if ((this.m_LSPC_NGUOIXULYHOSO != value))
				{
					this.SendPropertyChanging("LSPC_NGUOIXULYHOSO");
					this.m_LSPC_NGUOIXULYHOSO = value;
					this.SendPropertyChanged("LSPC_NGUOIXULYHOSO");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_LSPC_NGUOIXULYHOSOUpdated = true;
				}
			}
		}

		private string m_LSPC_GHICHU;
		private bool m_LSPC_GHICHUUpdated = false;
		/// <summary>
		/// LSPC_GHICHU.
		/// </summary>
		public string LSPC_GHICHU
		{
			get
			{
				return m_LSPC_GHICHU;
			}
			set
			{
				if ((this.m_LSPC_GHICHU != value))
				{
					this.SendPropertyChanging("LSPC_GHICHU");
					this.m_LSPC_GHICHU = value;
					this.SendPropertyChanged("LSPC_GHICHU");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_LSPC_GHICHUUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM LICHSUPHANCONG " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("LSPC_HS_SOHS", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("LSPC_HS_NAMDK", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("LSPC_ID", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("LSPC_NGUOIPHANCONG", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("LSPC_NGUOIXULYHOSO", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("LSPC_GHICHU", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO LICHSUPHANCONG (LSPC_HS_SOHS, LSPC_HS_NAMDK, LSPC_NGUOIPHANCONG, LSPC_NGUOIXULYHOSO, LSPC_GHICHU) VALUES(").Append(clsDAL.IsDBNULL(LSPC_HS_SOHS, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(LSPC_HS_NAMDK, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(LSPC_NGUOIPHANCONG, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(LSPC_NGUOIXULYHOSO, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(LSPC_GHICHU, ProType.STRING, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE LICHSUPHANCONG SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_LSPC_NGUOIPHANCONGUpdated ? string.Format(",LSPC_NGUOIPHANCONG = {0}", clsDAL.IsDBNULL(LSPC_NGUOIPHANCONG, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_LSPC_NGUOIXULYHOSOUpdated ? string.Format(",LSPC_NGUOIXULYHOSO = {0}", clsDAL.IsDBNULL(LSPC_NGUOIXULYHOSO, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_LSPC_GHICHUUpdated ? string.Format(",LSPC_GHICHU = {0}", clsDAL.IsDBNULL(LSPC_GHICHU, ProType.STRING, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("LSPC_NGUOIPHANCONG = {0}", clsDAL.IsDBNULL(LSPC_NGUOIPHANCONG, ProType.STRING, this.DataManagement)).AppendFormat(",LSPC_NGUOIXULYHOSO = {0}", clsDAL.IsDBNULL(LSPC_NGUOIXULYHOSO, ProType.STRING, this.DataManagement)).AppendFormat(",LSPC_GHICHU = {0}", clsDAL.IsDBNULL(LSPC_GHICHU, ProType.STRING, this.DataManagement));
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
			return clsDAL.DeleteString("LICHSUPHANCONG", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("LSPC_HS_SOHS = {0}", clsDAL.IsDBNULL(LSPC_HS_SOHS, ProType.OTHER, this.DataManagement)).AppendFormat(" AND LSPC_HS_NAMDK = {0}", clsDAL.IsDBNULL(LSPC_HS_NAMDK, ProType.OTHER, this.DataManagement)).AppendFormat(" AND LSPC_ID = {0}", clsDAL.IsDBNULL(LSPC_ID, ProType.OTHER, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}