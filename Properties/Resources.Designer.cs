namespace HotelManagement.Properties {
    using System;
    using System.Drawing;
    using System.IO;

    public class Resources {
        private static global::System.Resources.ResourceManager resourceMan;
        private static global::System.Globalization.CultureInfo resourceCulture;

        internal Resources() {
        }

        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HotelManagement.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        public static global::System.Globalization.CultureInfo Culture {
            get { return resourceCulture; }
            set { resourceCulture = value; }
        }

        private static Bitmap GetBitmap(string name) {
            try {
                object obj = ResourceManager.GetObject(name, resourceCulture);
                if (obj is Bitmap bmp) return bmp;
            } catch { }

            string[] paths = new[] {
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", name + ".png"),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Resources", name + ".png"),
                Path.Combine("Resources", name + ".png"),
                Path.Combine("..", "Resources", name + ".png")
            };

            foreach (var p in paths) {
                if (File.Exists(p)) {
                    using var stream = new MemoryStream(File.ReadAllBytes(p));
                    return new Bitmap(stream);
                }
            }
            return new Bitmap(16, 16);
        }
        public static Bitmap _3people {
            get { return GetBitmap("3people"); }
        }
        public static Bitmap Add {
            get { return GetBitmap("Add"); }
        }
        public static Bitmap Address {
            get { return GetBitmap("Address"); }
        }
        public static Bitmap admin {
            get { return GetBitmap("admin"); }
        }
        public static Bitmap back {
            get { return GetBitmap("back"); }
        }
        public static Bitmap calendardark {
            get { return GetBitmap("calendardark"); }
        }
        public static Bitmap CalendarPick {
            get { return GetBitmap("CalendarPick"); }
        }
        public static Bitmap calendarwhite {
            get { return GetBitmap("calendarwhite"); }
        }
        public static Bitmap CCCD {
            get { return GetBitmap("CCCD"); }
        }
        public static Bitmap clean {
            get { return GetBitmap("clean"); }
        }
        public static Bitmap clock {
            get { return GetBitmap("clock"); }
        }
        public static Bitmap ClockPick {
            get { return GetBitmap("ClockPick"); }
        }
        public static Bitmap DaDat {
            get { return GetBitmap("DaDat"); }
        }
        public static Bitmap DangNhap {
            get { return GetBitmap("DangNhap"); }
        }
        public static Bitmap DangSuaChua {
            get { return GetBitmap("DangSuaChua"); }
        }
        public static Bitmap DangSuaChuaBlackMin {
            get { return GetBitmap("DangSuaChuaBlackMin"); }
        }
        public static Bitmap database {
            get { return GetBitmap("database"); }
        }
        public static Bitmap DatPhongChart {
            get { return GetBitmap("DatPhongChart"); }
        }
        public static Bitmap delete {
            get { return GetBitmap("delete"); }
        }
        public static Bitmap delete1 {
            get { return GetBitmap("delete1"); }
        }
        public static Bitmap details {
            get { return GetBitmap("details"); }
        }
        public static Bitmap DichVu {
            get { return GetBitmap("DichVu"); }
        }
        public static Bitmap DichVu1 {
            get { return GetBitmap("DichVu1"); }
        }
        public static Bitmap DichVu2 {
            get { return GetBitmap("DichVu2"); }
        }
        public static Bitmap DichVuChart {
            get { return GetBitmap("DichVuChart"); }
        }
        public static Bitmap DoanhThu {
            get { return GetBitmap("DoanhThu"); }
        }
        public static Bitmap DoanhThuThue {
            get { return GetBitmap("DoanhThuThue"); }
        }
        public static Bitmap edit {
            get { return GetBitmap("edit"); }
        }
        public static Bitmap email {
            get { return GetBitmap("email"); }
        }
        public static Bitmap error {
            get { return GetBitmap("error"); }
        }
        public static Bitmap fix {
            get { return GetBitmap("fix"); }
        }
        public static Bitmap fix50 {
            get { return GetBitmap("fix50"); }
        }
        public static Bitmap fixedcloseresize {
            get { return GetBitmap("fixedcloseresize"); }
        }
        public static Bitmap fixedgreenresize {
            get { return GetBitmap("fixedgreenresize"); }
        }
        public static Bitmap fixedmaxresize {
            get { return GetBitmap("fixedmaxresize"); }
        }
        public static Bitmap fixedminresize {
            get { return GetBitmap("fixedminresize"); }
        }
        public static Bitmap fixednone {
            get { return GetBitmap("fixednone"); }
        }
        public static Bitmap fixedredresize {
            get { return GetBitmap("fixedredresize"); }
        }
        public static Bitmap fixedyellowresize {
            get { return GetBitmap("fixedyellowresize"); }
        }
        public static Bitmap Gender {
            get { return GetBitmap("Gender"); }
        }
        public static Bitmap Giuong {
            get { return GetBitmap("Giuong"); }
        }
        public static Bitmap Giuong1 {
            get { return GetBitmap("Giuong1"); }
        }
        public static Bitmap heart {
            get { return GetBitmap("heart"); }
        }
        public static Bitmap hide {
            get { return GetBitmap("hide"); }
        }
        public static Bitmap HoaDon {
            get { return GetBitmap("HoaDon"); }
        }
        public static Bitmap KhachHang {
            get { return GetBitmap("KhachHang"); }
        }
        public static Bitmap Menu {
            get { return GetBitmap("Menu"); }
        }
        public static Bitmap Menu1 {
            get { return GetBitmap("Menu1"); }
        }
        public static Bitmap MenuChiTietTienNghi {
            get { return GetBitmap("MenuChiTietTienNghi"); }
        }
        public static Bitmap MenuDanhSachHoaDon {
            get { return GetBitmap("MenuDanhSachHoaDon"); }
        }
        public static Bitmap MenuDatPhong {
            get { return GetBitmap("MenuDatPhong"); }
        }
        public static Bitmap MenuLoaiPhong {
            get { return GetBitmap("MenuLoaiPhong"); }
        }
        public static Bitmap MenuPhong {
            get { return GetBitmap("MenuPhong"); }
        }
        public static Bitmap MenuQuanLy {
            get { return GetBitmap("MenuQuanLy"); }
        }
        public static Bitmap MenuQuanLyDichVu {
            get { return GetBitmap("MenuQuanLyDichVu"); }
        }
        public static Bitmap MenuQuanLyKhachHang {
            get { return GetBitmap("MenuQuanLyKhachHang"); }
        }
        public static Bitmap MenuQuanLyNhanVien {
            get { return GetBitmap("MenuQuanLyNhanVien"); }
        }
        public static Bitmap MenuQuanLyTaiKhoan {
            get { return GetBitmap("MenuQuanLyTaiKhoan"); }
        }
        public static Bitmap MenuSoDoPhong {
            get { return GetBitmap("MenuSoDoPhong"); }
        }
        public static Bitmap MenuThongKe {
            get { return GetBitmap("MenuThongKe"); }
        }
        public static Bitmap MenuTienNghi {
            get { return GetBitmap("MenuTienNghi"); }
        }
        public static Bitmap MenuTrangChu {
            get { return GetBitmap("MenuTrangChu"); }
        }
        public static Bitmap message {
            get { return GetBitmap("message"); }
        }
        public static Bitmap money {
            get { return GetBitmap("money"); }
        }
        public static Bitmap Name {
            get { return GetBitmap("Name"); }
        }
        public static Bitmap NhanVien {
            get { return GetBitmap("NhanVien"); }
        }
        public static Bitmap NhanVien1 {
            get { return GetBitmap("NhanVien1"); }
        }
        public static Bitmap none {
            get { return GetBitmap("none"); }
        }
        public static Bitmap note {
            get { return GetBitmap("note"); }
        }
        public static Bitmap password {
            get { return GetBitmap("password"); }
        }
        public static Bitmap people {
            get { return GetBitmap("people"); }
        }
        public static Bitmap PhieuThue {
            get { return GetBitmap("PhieuThue"); }
        }
        public static Bitmap PhieuThueDgv {
            get { return GetBitmap("PhieuThueDgv"); }
        }
        public static Bitmap Phone {
            get { return GetBitmap("Phone"); }
        }
        public static Bitmap Phong {
            get { return GetBitmap("Phong"); }
        }
        public static Bitmap phong_icon {
            get { return GetBitmap("phong_icon"); }
        }
        public static Bitmap pictureIcon {
            get { return GetBitmap("pictureIcon"); }
        }
        public static Bitmap pictureIconLogoHD {
            get { return GetBitmap("pictureIconLogoHD"); }
        }
        public static Bitmap pictureIconNoneBackGroundResize {
            get { return GetBitmap("pictureIconNoneBackGroundResize"); }
        }
        public static Bitmap pictureIconNoneBackGroundResize55 {
            get { return GetBitmap("pictureIconNoneBackGroundResize55"); }
        }
        public static Bitmap printer {
            get { return GetBitmap("printer"); }
        }
        public static Bitmap QuenMatKhau {
            get { return GetBitmap("QuenMatKhau"); }
        }
        public static Bitmap question {
            get { return GetBitmap("question"); }
        }
        public static Bitmap search {
            get { return GetBitmap("search"); }
        }
        public static Bitmap selection {
            get { return GetBitmap("selection"); }
        }
        public static Bitmap show {
            get { return GetBitmap("show"); }
        }
        public static Bitmap SoLuong {
            get { return GetBitmap("SoLuong"); }
        }
        public static Bitmap SoNguoi {
            get { return GetBitmap("SoNguoi"); }
        }
        public static Bitmap SoPhongDat {
            get { return GetBitmap("SoPhongDat"); }
        }
        public static Bitmap staffResize {
            get { return GetBitmap("staffResize"); }
        }
        public static Bitmap TaiKhoan {
            get { return GetBitmap("TaiKhoan"); }
        }
        public static Bitmap ThuePhongChart {
            get { return GetBitmap("ThuePhongChart"); }
        }
        public static Bitmap tick {
            get { return GetBitmap("tick"); }
        }
        public static Bitmap tickblack {
            get { return GetBitmap("tickblack"); }
        }
        public static Bitmap TienNghi {
            get { return GetBitmap("TienNghi"); }
        }
        public static Bitmap TimePicker {
            get { return GetBitmap("TimePicker"); }
        }
        public static Bitmap TimePickerBlack {
            get { return GetBitmap("TimePickerBlack"); }
        }
        public static Bitmap TimePickerWhite {
            get { return GetBitmap("TimePickerWhite"); }
        }
        public static Bitmap top1 {
            get { return GetBitmap("top1"); }
        }
        public static Bitmap top2 {
            get { return GetBitmap("top2"); }
        }
        public static Bitmap top3 {
            get { return GetBitmap("top3"); }
        }
        public static Bitmap user {
            get { return GetBitmap("user"); }
        }
        public static Bitmap warning {
            get { return GetBitmap("warning"); }
        }
        public static Bitmap x {
            get { return GetBitmap("x"); }
        }
    }
}
