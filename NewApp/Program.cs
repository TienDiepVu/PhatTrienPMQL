using NewApp.Models;
public class Program
{
    public static void Main(string[] args)
    {
        SinhVien st = new SinhVien();
        st.HoTen = "Vu Tien Diep" ;
        st.DiaChi= "Ha Noi";
        st.Tuoi = 22;
        st.SoDienThoai = "0984523361";
        st.HienThiThongTinSV();
    }
}
