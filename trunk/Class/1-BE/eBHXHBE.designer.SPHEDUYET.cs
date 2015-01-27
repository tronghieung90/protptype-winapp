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
	/// Generated Class for Table : SPHEDUYET.
	/// </summary>
	public partial class SPHEDUYET : TableBase
	{
		public SPHEDUYET() : base(){}

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
		private string m_PD_MACQ;
		/// <summary>
		/// PD_MACQ.
		/// </summary>
		public string PD_MACQ
		{
			get
			{
				return m_PD_MACQ;
			}
			set
			{
				if ((this.m_PD_MACQ != value))
				{
					this.SendPropertyChanging("PD_MACQ");
					this.m_PD_MACQ = value;
					this.SendPropertyChanged("PD_MACQ");
				}
			}
		}

		private string m_PD_MAPHONG;
		/// <summary>
		/// PD_MAPHONG.
		/// </summary>
		public string PD_MAPHONG
		{
			get
			{
				return m_PD_MAPHONG;
			}
			set
			{
				if ((this.m_PD_MAPHONG != value))
				{
					this.SendPropertyChanging("PD_MAPHONG");
					this.m_PD_MAPHONG = value;
					this.SendPropertyChanged("PD_MAPHONG");
				}
			}
		}

		private string m_PD_TAIKHOAN_LANHDAO;
		/// <summary>
		/// PD_TAIKHOAN_LANHDAO.
		/// </summary>
		public string PD_TAIKHOAN_LANHDAO
		{
			get
			{
				return m_PD_TAIKHOAN_LANHDAO;
			}
			set
			{
				if ((this.m_PD_TAIKHOAN_LANHDAO != value))
				{
					this.SendPropertyChanging("PD_TAIKHOAN_LANHDAO");
					this.m_PD_TAIKHOAN_LANHDAO = value;
					this.SendPropertyChanged("PD_TAIKHOAN_LANHDAO");
				}
			}
		}

		private bool m_PD_NOIBO_HOSODUNG = true;
		private bool m_PD_NOIBO_HOSODUNGUpdated = false;
		/// <summary>
		/// PD_NOIBO_HOSODUNG.
		/// </summary>
		public bool PD_NOIBO_HOSODUNG
		{
			get
			{
				return m_PD_NOIBO_HOSODUNG;
			}
			set
			{
				if ((this.m_PD_NOIBO_HOSODUNG != value))
				{
					this.SendPropertyChanging("PD_NOIBO_HOSODUNG");
					this.m_PD_NOIBO_HOSODUNG = value;
					this.SendPropertyChanged("PD_NOIBO_HOSODUNG");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_PD_NOIBO_HOSODUNGUpdated = true;
				}
			}
		}

		private bool m_PD_NOIBO_HOSOSAI = true;
		private bool m_PD_NOIBO_HOSOSAIUpdated = false;
		/// <summary>
		/// PD_NOIBO_HOSOSAI.
		/// </summary>
		public bool PD_NOIBO_HOSOSAI
		{
			get
			{
				return m_PD_NOIBO_HOSOSAI;
			}
			set
			{
				if ((this.m_PD_NOIBO_HOSOSAI != value))
				{
					this.SendPropertyChanging("PD_NOIBO_HOSOSAI");
					this.m_PD_NOIBO_HOSOSAI = value;
					this.SendPropertyChanged("PD_NOIBO_HOSOSAI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_PD_NOIBO_HOSOSAIUpdated = true;
				}
			}
		}

		private bool m_PD_NOIBO_HOSOSAI_DONOIBO = true;
		private bool m_PD_NOIBO_HOSOSAI_DONOIBOUpdated = false;
		/// <summary>
		/// PD_NOIBO_HOSOSAI_DONOIBO.
		/// </summary>
		public bool PD_NOIBO_HOSOSAI_DONOIBO
		{
			get
			{
				return m_PD_NOIBO_HOSOSAI_DONOIBO;
			}
			set
			{
				if ((this.m_PD_NOIBO_HOSOSAI_DONOIBO != value))
				{
					this.SendPropertyChanging("PD_NOIBO_HOSOSAI_DONOIBO");
					this.m_PD_NOIBO_HOSOSAI_DONOIBO = value;
					this.SendPropertyChanged("PD_NOIBO_HOSOSAI_DONOIBO");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_PD_NOIBO_HOSOSAI_DONOIBOUpdated = true;
				}
			}
		}

		private bool m_PD_BENNGOAI_HOSODUNG = false;
		private bool m_PD_BENNGOAI_HOSODUNGUpdated = false;
		/// <summary>
		/// PD_BENNGOAI_HOSODUNG.
		/// </summary>
		public bool PD_BENNGOAI_HOSODUNG
		{
			get
			{
				return m_PD_BENNGOAI_HOSODUNG;
			}
			set
			{
				if ((this.m_PD_BENNGOAI_HOSODUNG != value))
				{
					this.SendPropertyChanging("PD_BENNGOAI_HOSODUNG");
					this.m_PD_BENNGOAI_HOSODUNG = value;
					this.SendPropertyChanged("PD_BENNGOAI_HOSODUNG");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_PD_BENNGOAI_HOSODUNGUpdated = true;
				}
			}
		}

		private bool m_PD_BENNGOAI_HOSOSAI = false;
		private bool m_PD_BENNGOAI_HOSOSAIUpdated = false;
		/// <summary>
		/// PD_BENNGOAI_HOSOSAI.
		/// </summary>
		public bool PD_BENNGOAI_HOSOSAI
		{
			get
			{
				return m_PD_BENNGOAI_HOSOSAI;
			}
			set
			{
				if ((this.m_PD_BENNGOAI_HOSOSAI != value))
				{
					this.SendPropertyChanging("PD_BENNGOAI_HOSOSAI");
					this.m_PD_BENNGOAI_HOSOSAI = value;
					this.SendPropertyChanged("PD_BENNGOAI_HOSOSAI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_PD_BENNGOAI_HOSOSAIUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM SPHEDUYET " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("PD_MACQ", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("PD_MAPHONG", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("PD_TAIKHOAN_LANHDAO", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("PD_NOIBO_HOSODUNG", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("PD_NOIBO_HOSOSAI", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("PD_NOIBO_HOSOSAI_DONOIBO", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("PD_BENNGOAI_HOSODUNG", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("PD_BENNGOAI_HOSOSAI", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO SPHEDUYET (PD_MACQ, PD_MAPHONG, PD_TAIKHOAN_LANHDAO, PD_NOIBO_HOSODUNG, PD_NOIBO_HOSOSAI, PD_NOIBO_HOSOSAI_DONOIBO, PD_BENNGOAI_HOSODUNG, PD_BENNGOAI_HOSOSAI) VALUES(").Append(clsDAL.IsDBNULL(PD_MACQ, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(PD_MAPHONG, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(PD_TAIKHOAN_LANHDAO, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(PD_NOIBO_HOSODUNG, ProType.BOOL, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(PD_NOIBO_HOSOSAI, ProType.BOOL, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(PD_NOIBO_HOSOSAI_DONOIBO, ProType.BOOL, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(PD_BENNGOAI_HOSODUNG, ProType.BOOL, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(PD_BENNGOAI_HOSOSAI, ProType.BOOL, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE SPHEDUYET SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_PD_NOIBO_HOSODUNGUpdated ? string.Format(",PD_NOIBO_HOSODUNG = {0}", clsDAL.IsDBNULL(PD_NOIBO_HOSODUNG, ProType.BOOL, this.DataManagement)) : string.Empty).Append(m_PD_NOIBO_HOSOSAIUpdated ? string.Format(",PD_NOIBO_HOSOSAI = {0}", clsDAL.IsDBNULL(PD_NOIBO_HOSOSAI, ProType.BOOL, this.DataManagement)) : string.Empty).Append(m_PD_NOIBO_HOSOSAI_DONOIBOUpdated ? string.Format(",PD_NOIBO_HOSOSAI_DONOIBO = {0}", clsDAL.IsDBNULL(PD_NOIBO_HOSOSAI_DONOIBO, ProType.BOOL, this.DataManagement)) : string.Empty).Append(m_PD_BENNGOAI_HOSODUNGUpdated ? string.Format(",PD_BENNGOAI_HOSODUNG = {0}", clsDAL.IsDBNULL(PD_BENNGOAI_HOSODUNG, ProType.BOOL, this.DataManagement)) : string.Empty).Append(m_PD_BENNGOAI_HOSOSAIUpdated ? string.Format(",PD_BENNGOAI_HOSOSAI = {0}", clsDAL.IsDBNULL(PD_BENNGOAI_HOSOSAI, ProType.BOOL, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("PD_NOIBO_HOSODUNG = {0}", clsDAL.IsDBNULL(PD_NOIBO_HOSODUNG, ProType.BOOL, this.DataManagement)).AppendFormat(",PD_NOIBO_HOSOSAI = {0}", clsDAL.IsDBNULL(PD_NOIBO_HOSOSAI, ProType.BOOL, this.DataManagement)).AppendFormat(",PD_NOIBO_HOSOSAI_DONOIBO = {0}", clsDAL.IsDBNULL(PD_NOIBO_HOSOSAI_DONOIBO, ProType.BOOL, this.DataManagement)).AppendFormat(",PD_BENNGOAI_HOSODUNG = {0}", clsDAL.IsDBNULL(PD_BENNGOAI_HOSODUNG, ProType.BOOL, this.DataManagement)).AppendFormat(",PD_BENNGOAI_HOSOSAI = {0}", clsDAL.IsDBNULL(PD_BENNGOAI_HOSOSAI, ProType.BOOL, this.DataManagement));
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
			return clsDAL.DeleteString("SPHEDUYET", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("PD_MACQ = {0}", clsDAL.IsDBNULL(PD_MACQ, ProType.STRING, this.DataManagement)).AppendFormat(" AND PD_MAPHONG = {0}", clsDAL.IsDBNULL(PD_MAPHONG, ProType.STRING, this.DataManagement)).AppendFormat(" AND PD_TAIKHOAN_LANHDAO = {0}", clsDAL.IsDBNULL(PD_TAIKHOAN_LANHDAO, ProType.STRING, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}