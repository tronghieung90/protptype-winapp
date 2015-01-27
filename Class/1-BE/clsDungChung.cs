using System;
using System.Collections.Generic;
using System.Text;


namespace eBHXH
{
    public class EventArgs<T> : EventArgs 
    {
        protected T m_Data = default(T);
        public EventArgs(T data)
        {
            this.m_Data = data;
        }

        public T Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }
    }

    public class ListItem
    {
        public ListItem()
        {
        }

        public ListItem(string id, string name)
        {
            _Id = id;
            _Name = name;
        }

        protected string _Name = string.Empty;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        protected string _Id = string.Empty;
        public string ID
        {
            get { return _Id; }
            set { _Id = value; }
        }
    }

    public class USBSerialNumber
    {

        string _serialNumber;
        string _driveLetter;

        public string getSerialNumberFromDriveLetter(string driveLetter)
        {
            this._driveLetter = driveLetter.ToUpper();

            if (!this._driveLetter.Contains(":"))
            {
                this._driveLetter += ":";
            }

            if (this._driveLetter.Length > 2)
            {
                this._driveLetter = this._driveLetter.Substring(0, 2);
            }

            matchDriveLetterWithDeviceID();

            return this._serialNumber;
        }

        private void matchDriveLetterWithDeviceID()
        {

            //string[] diskArray;
            //string driveNumber;
            //string driveLetter;

            //ManagementObjectSearcher searcher1 = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDiskToPartition");
            //foreach (ManagementObject dm in searcher1.Get())
            //{
            //    diskArray = null;
            //    driveLetter = getValueInQuotes(dm["Dependent"].ToString());
            //    diskArray = getValueInQuotes(dm["Antecedent"].ToString()).Split(',');
            //    driveNumber = diskArray[0].Remove(0, 6).Trim();
            //    if (driveLetter == this._driveLetter)
            //    {
            //        /* This is where we get the drive serial */
            //        ManagementObjectSearcher disks = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            //        foreach (ManagementObject disk in disks.Get())
            //        {

            //            if (disk["Name"].ToString() == ("\\\\.\\PHYSICALDRIVE" + driveNumber) & disk["InterfaceType"].ToString() == "USB")
            //            {
            //                this._serialNumber = disk["PNPDeviceID"].ToString().Replace("\\", "-").Replace("&", "-");
            //            }
            //        }
            //    }
            //}
        }

        private string getValueInQuotes(string inValue)
        {
            string parsedValue = "";

            int posFoundStart = 0;
            int posFoundEnd = 0;

            posFoundStart = inValue.IndexOf("\"");
            posFoundEnd = inValue.IndexOf("\"", posFoundStart + 1);

            parsedValue = inValue.Substring(posFoundStart + 1, (posFoundEnd - posFoundStart) - 1);

            return parsedValue;
        }

    }

    public class Luồng
    {
        string _TenLuong;
        public string TenLuong
        {
            get { return _TenLuong; }
            set { _TenLuong = value; }
        }

        string _MaLuong;
        public string MaLuong
        {
            get { return _MaLuong; }
            set { _MaLuong = value; }
        }
    }

    public class DieuKienIn
    {
        public int? FromIndex { get; set; }
        public int? ToIndex { get; set; }
        public bool ChuaKhai { get; set; }
        public bool ChuaCoSoTN { get; set; }
        public bool DaCoSoTN { get; set; }
        public bool DaCoSoTK { get; set; }
        public bool DaPhanLuong { get; set; }
        public bool DaThongQuan { get; set; }
    }

    public class NoiDungThayDoi
    {
        public NoiDungThayDoi() { }
        public NoiDungThayDoi(object stt, object mt, object ndc, object ndm)
        {
            STT = stt;
            MOTA = mt;
            NOIDUNGCU = ndc;
            NOIDUNGMOI = ndm;
        }

        public object STT { get; set; }
        public object MOTA { get; set; }
        public object NOIDUNGCU { get; set; }
        public object NOIDUNGMOI { get; set; }
    }

    public class LoaiNhomChungTu
    {
        public const string GiayPhep = "GP";
        public const string VanDon = "VD";
        public const string CO = "CO";
        public const string HoaDon = "HDN";
        public const string HopDong = "HD";
        public const string HopDongGC = "HDGC";
        public const string ToKhai = "TK";
        public const string ToKhaiCT = "TKCT";
        public const string ToKhaiTG1 = "TG1";
        public const string CCK = "CCK";
        public const string DinhKem = "DK";
        public const string DangKyKT = "GDK";
        public const string KetQuaKT = "GKQ";
        public const string ChungThuGD = "CTH";
        public const string GiayNopTien = "GNT";
        public const string CongVanNoChungTu = "CTN";
        public const string HSNK = "NK";
        public const string HSXK = "XK";
        public const string HSNC = "NC";
        public const string HSXC = "XC";
        public const string HSNT = "NT";
    }

    public class LoaiThue
    {
        public const string XNK = "XNK";
        public const string VAT = "VAT";
        public const string TTDB = "TTDB";
        public const string BVMT = "TVCBPG";
        public const string KHAC = "KHAC";
        public const string XNK_MA = "1";
        public const string VAT_MA = "2";
        public const string TTDB_MA = "3";
        public const string BVMT_MA = "4";
        public const string KHAC_MA = "5";
    }
}
