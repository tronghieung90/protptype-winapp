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
	/// DB context sử dụng trong using.
	/// </summary>
	public partial class eBHXHBEDBContext : IDisposable
	{
		private string m_ConnectionString = default(string);
		private IDbConnection m_Connection = null;
		private Dictionary<Type, object> m_Tables = default(Dictionary<Type,object>);
		private List<object> l_Tables = default(List<object>);
		/// <summary>
		/// Khởi tạo dữ liệu.
		/// </summary>
		private void Initialization()
		{
			m_Tables = new Dictionary<Type, object>();
			l_Tables = new List<object>();
		}

		/// <summary>
		/// Hàm khởi tạo.
		/// </summary>
		/// <param name="conn">Connection đến DB</param>
		public eBHXHBEDBContext(IDbConnection conn)
		{
			m_Connection = conn;
			m_ConnectionString = conn.ConnectionString;
			Initialization();
		}

		/// <summary>
		/// Hàm khởi tạo.
		/// </summary>
		/// <param name="conString">ConnectionString đến DB</param>
		public eBHXHBEDBContext(string conString)
			: this(conString, clsDAL.defaultDBMan)
		{
		}

		/// <summary>
		/// Hàm khởi tạo.
		/// </summary>
		/// <param name="conString">ConnectionString đến DB</param>
		public eBHXHBEDBContext(string conString, DBManagement DBMan)
			: this(clsConn.getConnection(conString, DBMan))
		{
			_dataManagement = DBMan;
		}

		/// <summary>
		/// Hàm khởi tạo. với connection mặc định
		/// </summary>
		public eBHXHBEDBContext()
			: this(clsDAL.defaultDBMan)
		{
		}

		/// <summary>
		/// Hàm khởi tạo. với connection mặc định
		/// </summary>
		public eBHXHBEDBContext(DBManagement DBMan)
			: this(clsConn.getConnection(DBMan))
		{
			_dataManagement = DBMan;
		}

		public void Dispose()
		{
			if (m_Connection != null && m_Connection.State == ConnectionState.Open)
				m_Connection.Close();
			m_Connection = null;
			if (m_Tables!=null)
				m_Tables.Clear();
			m_Tables = null;
		}

		private DBManagement _dataManagement;
		/// <summary>
		/// Hệ quản trị CSDL.
		/// </summary>
		public DBManagement DataManagement { get { return _dataManagement; } set { _dataManagement = value; } }
		/// <summary>
		/// Lấy ra Table kiểu T.
		/// </summary>
		protected DBTable<T> GetTable<T>()
		{
			if (!m_Tables.ContainsKey(typeof(T)))
			{
				DBTable<T> tbl = new DBTable<T>(m_Connection, this.DataManagement);
				l_Tables.Add(tbl);
				m_Tables.Add(typeof(T), tbl);
			}
			return m_Tables[typeof(T)] as DBTable<T>;
		}

		/// <summary>
		/// Lấy ra View kiểu T.
		/// </summary>
		protected DBView<T> GetView<T>()
		{
			if (!m_Tables.ContainsKey(typeof(T)))
			{
				m_Tables.Add(typeof(T), new DBView<T>(m_Connection, this.DataManagement));
			}
			return m_Tables[typeof(T)] as DBView<T>;
		}

		/// <summary>
		/// Thuộc tính đại diện cho bảng THUHIENQUYTRINH.
		/// </summary>
		public DBTable<THUHIENQUYTRINH> THUHIENQUYTRINHs
		{
			get
			{
				return GetTable<THUHIENQUYTRINH>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng sysdiagrams.
		/// </summary>
		public DBTable<sysdiagrams> sysdiagramss
		{
			get
			{
				return GetTable<sysdiagrams>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng STHUTUCBANGKE.
		/// </summary>
		public DBTable<STHUTUCBANGKE> STHUTUCBANGKEs
		{
			get
			{
				return GetTable<STHUTUCBANGKE>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng STHUTUC.
		/// </summary>
		public DBTable<STHUTUC> STHUTUCs
		{
			get
			{
				return GetTable<STHUTUC>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng STAIKHOAN.
		/// </summary>
		public DBTable<STAIKHOAN> STAIKHOANs
		{
			get
			{
				return GetTable<STAIKHOAN>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng SQUYTRINH.
		/// </summary>
		public DBTable<SQUYTRINH> SQUYTRINHs
		{
			get
			{
				return GetTable<SQUYTRINH>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng SPHONGBOPHAN.
		/// </summary>
		public DBTable<SPHONGBOPHAN> SPHONGBOPHANs
		{
			get
			{
				return GetTable<SPHONGBOPHAN>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng SPHEDUYET.
		/// </summary>
		public DBTable<SPHEDUYET> SPHEDUYETs
		{
			get
			{
				return GetTable<SPHEDUYET>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng SPHANCONG.
		/// </summary>
		public DBTable<SPHANCONG> SPHANCONGs
		{
			get
			{
				return GetTable<SPHANCONG>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng SNHANVIEN.
		/// </summary>
		public DBTable<SNHANVIEN> SNHANVIENs
		{
			get
			{
				return GetTable<SNHANVIEN>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng SMACDINH.
		/// </summary>
		public DBTable<SMACDINH> SMACDINHs
		{
			get
			{
				return GetTable<SMACDINH>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng SLINHVUCTHUTUC.
		/// </summary>
		public DBTable<SLINHVUCTHUTUC> SLINHVUCTHUTUCs
		{
			get
			{
				return GetTable<SLINHVUCTHUTUC>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng SLINHVUC.
		/// </summary>
		public DBTable<SLINHVUC> SLINHVUCs
		{
			get
			{
				return GetTable<SLINHVUC>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng SDONVI.
		/// </summary>
		public DBTable<SDONVI> SDONVIs
		{
			get
			{
				return GetTable<SDONVI>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng SCOQUAN.
		/// </summary>
		public DBTable<SCOQUAN> SCOQUANs
		{
			get
			{
				return GetTable<SCOQUAN>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng SBANGKE.
		/// </summary>
		public DBTable<SBANGKE> SBANGKEs
		{
			get
			{
				return GetTable<SBANGKE>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng PHIEUGIAONHAN.
		/// </summary>
		public DBTable<PHIEUGIAONHAN> PHIEUGIAONHANs
		{
			get
			{
				return GetTable<PHIEUGIAONHAN>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng OUTBOX.
		/// </summary>
		public DBTable<OUTBOX> OUTBOXs
		{
			get
			{
				return GetTable<OUTBOX>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng LICHSUPHANCONG.
		/// </summary>
		public DBTable<LICHSUPHANCONG> LICHSUPHANCONGs
		{
			get
			{
				return GetTable<LICHSUPHANCONG>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng INBOX.
		/// </summary>
		public DBTable<INBOX> INBOXs
		{
			get
			{
				return GetTable<INBOX>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng HOSO.
		/// </summary>
		public DBTable<HOSO> HOSOs
		{
			get
			{
				return GetTable<HOSO>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng D02TS.
		/// </summary>
		public DBTable<D02TS> D02TSs
		{
			get
			{
				return GetTable<D02TS>();
			}
		}
		/// <summary>
		/// Thuộc tính đại diện cho bảng ATTACTFILE.
		/// </summary>
		public DBTable<ATTACTFILE> ATTACTFILEs
		{
			get
			{
				return GetTable<ATTACTFILE>();
			}
		}
		/// <summary>
		/// Cập nhật tất các thay đổi vào DB với transaction.
		/// </summary>
		/// <returns>Số dòng thay đổi</returns>
		public int SubmitAllChange()
		{
			int intReturn = 0;
			if (m_Connection == null) m_Connection = clsConn.getConnection(m_ConnectionString, this.DataManagement);
			if (m_Connection.State != ConnectionState.Open)
				m_Connection.Open();
			IDbTransaction trans = m_Connection.BeginTransaction();
			try
			{
				foreach (object table in l_Tables)
				{
					IDBTable tbl = table as IDBTable;
					if (tbl!=null)
						intReturn += tbl.SubmitAll(trans);
				}
				trans.Commit();
			}
			catch (Exception ex)
			{
				trans.Rollback();
				throw ex;
			}
			finally
			{
				m_Tables.Clear();
				l_Tables.Clear();
				m_Connection.Close();
			}
			return intReturn;
		}
	}
}