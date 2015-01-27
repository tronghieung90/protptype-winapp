using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using eBHXH;

namespace eBHXH.Qk
{
    public class Settings
    {
        //Thư mục temp
        public static string TEMP_DIR = @"C:\TempTQCX\";
        //OLE---------------------------------------------
        public static string DBService = "localhost:9999/Service.asmx";
        public static string sqlSTRINGEXPRESS = "Server=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\TQCX_DATA.mdf;Database=TQCX_DATA; Trusted_Connection=Yes;";
        public static string sqlSTRINGADO = "Data Source=(local);Initial Catalog=TQCX_DATA;User ID=sa;pwd=123456";
        public static string sqlSTRINGOLE = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\TQCX_DATA.db2;Persist Security Info=True;Jet OLEDB:Database Password=MMMMMM";
        public static string sqlSTRINGOLE_FILE = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\TQCX_DATA_FILE.db2;Persist Security Info=True;Jet OLEDB:Database Password=MMMMMM";
        public static string sqlSTRINGOLE_ORigin = string.Empty;
        public static string sqlSTRINGOLE_FILE_ORigin = string.Empty;
        public static string DBName = "TQCX_DATA.db2";
        public static string DBFileName = "TQCX_DATA_FILE.db2";
        public static string DBPath = string.Empty;
        //------------------------------------------------
        //Các thông tin điều khiển chung
        
        public static string myUserName;
        public static int myLimited = 180;
        public static long maxFileSize = 2097125;

        
      

        //Khai báo đối tượng kiểm soát toàn bộ chương trình
        public static frmMain myMDIMain = new frmMain();
        public static string myActiveForm;

        //Phần thông tin ngầm định
        public static string fTENCUCHQ = "";
        public static string fMAHQ = "";
        public static string fTENHQ = "";
        public static string fMADV = "";
        public static string fTENDV = "";
        public static string fDIACHI = "";
        public static string fSODT = "";
        public static int fLE_LUONG = 2;
        public static int fLE_GIA = 2;
        public static int fLE_TRIGIA = 4;
        public static int fLE_KHAC = 2;
        public static int fLE_DM = 6;
        public static int fLE_PHI = 6;
        public static int fLE_THUE = 0;
        public static int fLE_TGTT = 0;
        public static int fLE_HS = 8;
        public static string fLE_LEFT = "3.00";
        public static string fLE_TOP = "12.75";
        public static bool fIsNK = true;
        public static string fTenNguoiDaiDien = "";
        public static string fChucVuNguoiDaiDien = "";
        public static bool fCXDungFontUnicode = false;
        public static bool fInRiengPhi = false;
        public static bool fLuonInTGTT = false;
        public static bool fInMaVachBangAnh = true;
        public static bool fKhongKhauTruGiamGia = true;
        public static bool fNhapFileDKVaoCT = false;
        public static bool fInTheoTT15 = false;
        public static bool fSuDungHTTPS = false;
        public static bool fInGhepPhuLuc = true;
        public static bool fINPL3742=true;

        //Default của tờ khai NK CX
        public static string fCXTKN_MALH = "";
        public static string fCXTKN_NAMDK = "";
        public static string fCXTKN_PTTT = "";
        public static string fCXTKN_NGTE = "";
        public static string fCXTKN_DKGH = "";
        public static string fCXTKN_CK = "";
        public static string fCXTKN_DOITAC = "";

        //Default của tờ khai XK CX
        public static string fCXTKX_MALH = "";
        public static string fCXTKX_NAMDK = "";
        public static string fCXTKX_PTTT = "";
        public static string fCXTKX_NGTE = "";
        public static string fCXTKX_DKGH = "";
        public static string fCXTKX_CK = "";
        public static string fCXTKX_DOITAC = "";

        //--message của user control 
        public static string ctrmsg1 = "Hay chon mot gia tri trong danh sach nay!";
        public static string ctrmsg2 = "Du lieu nay khong phai la du lieu duoc chon tu danh sach!";
        public static string ctrmsg3 = "Khong duoc de trong o nay!";
        public static string ctrmsg4 = "Ngay khong hop le!";
        public static string ctrmsg5 = "Du lieu trong o nay phai la kieu so!";
        public static string ctrmsg6 = "Du lieu trong o nay khong duoc chua ky tu dac biet!";
        public static string ctrmsg7 = "Du lieu trong o nay khong duoc chua khoang trang!";
        public static string ctrmsg8 = "Hệ thống phần mềm Gia Công của Hải quan hiện chỉ sử dụng tới 6 số lẻ sau phần thập phân để tính toán. Vì thế bạn nên sử dụng phạm vi số lẻ từ 0 đến 6 để tính toán cho hợp lý. Tất nhiên đối với chương trình này, bạn có thể sử dụng bao nhiêu số lẻ tuỳ ý để phục vụ mục đích riêng!";
        public static string ctrmsg9 = "Tep tin anh khong dung dinh dang!";
        public static string ctrmsg11 = "Du lieu trong o nay phai co do dai toi thieu la ";
        public static string ctrmsg12 = " ky tu";
        public static string ctrmsg13 = "Dữ liệu nhập không hợp lệ, xin vui lòng kiểm tra lại!";
        public static string ctrmsg14 = "Hệ thống sẽ kết xuất bảng hiện tại ra Excel. Bạn có đồng ý không?";
        public static string ctrmsg15 = "Có lỗi trong quá trình ghi dữ liệu ra Excel. Nội dung lỗi: ";
        public static string ctrmsg16 = "Có lỗi khi thực hiện yêu cầu. Nội dung lỗi: ";
        public static string ctrmsg17 = "Gia tri so trong o nay phai nam trong khoang tu {0} den {1}!";
        public static string ctrmsg18 = "Gia trị nhap vao can phai {0} {1}!";

        public static string ctrmsgLoiChonDanhSach = "Hãy chọn một giá trị trong danh sách này!";
        public static string ctrmsgLoiThuocDanhSach = "Dữ liệu này không phải là dữ liệu thuộc danh sách!";
        public static string ctrmsgLoiDeTrong = "Không được để trống ô này!";
        public static string ctrmsgLoiNgayThang = "Ngày không hợp lệ!";
        public static string ctrmsgLoiKieuSo = "Dữ liệu trong ô này phải là kiểu số!";
        public static string ctrmsgLoiKyTuLa = "Dữ liệu trong ô này không được chứa ký tự đặc biệt!";
        public static string ctrmsgLoiKhoangTrang = "Dữ liệu trong ô này không được chứa khoảng trắng!";
        public static string ctrmsgLoiSoLe = "Hệ thống phần mềm Gia Công của Hải quan hiện chỉ sử dụng tới 6 số lẻ sau phần thập phân để tính toán. Vì thế bạn nên sử dụng phạm vi số lẻ từ 0 đến 6 để tính toán cho hợp lý. Tất nhiên đối với chương trình này, bạn có thể sử dụng bao nhiêu số lẻ tuỳ ý để phục vụ mục đích riêng!";
        public static string ctrmsgLoiFileAnh = "Tệp tin ảnh không đúng định dạng!";
        public static string ctrmsgLoiDoDaiMin = "Dữ liệu trong ô này phải có độ dài tối thiểu là {0} ký tự!";
        public static string ctrmsgLoiMaxMin = "Giá trị trong ô này phải nằm trong khoảng từ {0} đến {1}!";
        public static string ctrmsgLoiDuLieu = "Dữ liệu nhập không hợp lệ, xin vui lòng kiểm tra lại!";
        public static string ctrmsgHoiKetXuatExcel = "Hệ thống sẽ kết xuất bảng hiện tại ra Excel. Bạn có đồng ý không?";
        public static string ctrmsgLoiKetXuatExcel = "Có lỗi trong quá trình ghi dữ liệu ra Excel. Nội dung lỗi: ";
        public static string ctrmsgLoi = "Có lỗi khi thực hiện yêu cầu. Nội dung lỗi: ";
        public static string ctrmsgLoiSoSanh = "Giá trị nhập vào cần phải {0} {1}!";
        public static string ctrmsgPrintError = "Bạn đang sửa nội dung trong Excel. Hãy hoàn thành việc chỉnh sửa trước khi thực hiện thao tác này.";
        public static string ctrmsgNotInstallExcel = "Máy bạn đang dùng chưa cài đặt Microsoft Excel.";
        public static string[] arrStrMain = new string[] { "k", "h", "o", "n", "g", "b", "i", "e", "t", "@", "1", "2", "3", "4", "5", "6" };
        public static string ctrMain = string.Empty;
        public static string[] arrStrBackup = new string[] { "@", "1", "2", "3", "4", "5", "6" };
        public static string ctrBackup = string.Empty;
        
        //Cache data
        public static string CurrentErrorFormName = "";
        public static string CurrentErrorMessage = "";
        public static string CurrentErrorLearned = "0";
        public static bool ChoPhepTuDuyet = false;

        public static string SoftwareName = "FPT.TQCX";
        public static string SoftwareChecksum = string.Empty;
        //PHẦN THÔNG TIN NÂNG CẤP CHƯƠNG TRÌNH 
        //Phiên bản phần mềm hiện tại 
        public static int VersionNumber = 10;
        //Ngày phiên bản 
        public static string VersionDate = "06-04-2013"; 
    }
}
