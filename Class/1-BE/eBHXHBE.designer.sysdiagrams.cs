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
	/// Generated Class for Table : sysdiagrams.
	/// </summary>
	public partial class sysdiagrams : TableBase
	{
		public sysdiagrams() : base(){}

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
		private string m_name;
		private bool m_nameUpdated = false;
		/// <summary>
		/// name.
		/// </summary>
		public string name
		{
			get
			{
				return m_name;
			}
			set
			{
				if ((this.m_name != value))
				{
					this.SendPropertyChanging("name");
					this.m_name = value;
					this.SendPropertyChanged("name");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_nameUpdated = true;
				}
			}
		}

		private string m_principal_id;
		private bool m_principal_idUpdated = false;
		/// <summary>
		/// principal_id.
		/// </summary>
		public string principal_id
		{
			get
			{
				return m_principal_id;
			}
			set
			{
				if ((this.m_principal_id != value))
				{
					this.SendPropertyChanging("principal_id");
					this.m_principal_id = value;
					this.SendPropertyChanged("principal_id");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_principal_idUpdated = true;
				}
			}
		}

		private string m_diagram_id;
		/// <summary>
		/// diagram_id.
		/// </summary>
		public string diagram_id
		{
			get
			{
				return m_diagram_id;
			}
			set
			{
				if ((this.m_diagram_id != value))
				{
					this.SendPropertyChanging("diagram_id");
					this.m_diagram_id = value;
					this.SendPropertyChanged("diagram_id");
				}
			}
		}

		private string m_version;
		private bool m_versionUpdated = false;
		/// <summary>
		/// version.
		/// </summary>
		public string version
		{
			get
			{
				return m_version;
			}
			set
			{
				if ((this.m_version != value))
				{
					this.SendPropertyChanging("version");
					this.m_version = value;
					this.SendPropertyChanged("version");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_versionUpdated = true;
				}
			}
		}

		private string m_definition;
		private bool m_definitionUpdated = false;
		/// <summary>
		/// definition.
		/// </summary>
		public string definition
		{
			get
			{
				return m_definition;
			}
			set
			{
				if ((this.m_definition != value))
				{
					this.SendPropertyChanging("definition");
					this.m_definition = value;
					this.SendPropertyChanged("definition");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_definitionUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM sysdiagrams " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(clsDAL.SelectField("name", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("principal_id", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("diagram_id", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("version", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("definition", ProType.OTHER, this.DataManagement));
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
			sbSQL.Append("INSERT INTO sysdiagrams (name, principal_id, version, definition) VALUES(").Append(clsDAL.IsDBNULL(name, ProType.STRING, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(principal_id, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(version, ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.IsDBNULL(definition, ProType.STRING, this.DataManagement)).Append(")");
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE sysdiagrams SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			sbSQL.Append(m_nameUpdated ? string.Format(",name = {0}", clsDAL.IsDBNULL(name, ProType.STRING, this.DataManagement)) : string.Empty).Append(m_principal_idUpdated ? string.Format(",principal_id = {0}", clsDAL.IsDBNULL(principal_id, ProType.OTHER, this.DataManagement)) : string.Empty).Append(m_versionUpdated ? string.Format(",version = {0}", clsDAL.IsDBNULL(version, ProType.OTHER, this.DataManagement)) : string.Empty).Append(m_definitionUpdated ? string.Format(",definition = {0}", clsDAL.IsDBNULL(definition, ProType.STRING, this.DataManagement)) : string.Empty);
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
			sbSQL.AppendFormat("name = {0}", clsDAL.IsDBNULL(name, ProType.STRING, this.DataManagement)).AppendFormat(",principal_id = {0}", clsDAL.IsDBNULL(principal_id, ProType.OTHER, this.DataManagement)).AppendFormat(",version = {0}", clsDAL.IsDBNULL(version, ProType.OTHER, this.DataManagement)).AppendFormat(",definition = {0}", clsDAL.IsDBNULL(definition, ProType.STRING, this.DataManagement));
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
			return clsDAL.DeleteString("sysdiagrams", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
			sbSQL.AppendFormat("diagram_id = {0}", clsDAL.IsDBNULL(diagram_id, ProType.OTHER, this.DataManagement));
			return sbSQL.ToString();
		}
	}
}