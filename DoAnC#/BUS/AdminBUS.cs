using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class AdminBUS
    {
        // ID | CODE | PRODUCT_ID
        // 1  | ABC  | 1
        // 2  | ABC  | 2
        AdminDAO adminDAO = new AdminDAO();
        //NhanVienBUS-------------------------------------------------------------------------
        public List<NhanVienDTO> Loaddsnv()
        {
            return adminDAO.LoadDSNV();
        }

        public bool ViPhamNV(string id, string ho, string ten, string luong, string sdt, string email, string pw)
        {
            if (
            string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace
            (ho) || string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(luong) || string.IsNullOrWhiteSpace(pw) || string.IsNullOrWhiteSpace(sdt)
            || string.IsNullOrWhiteSpace(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool ViPhamEmailNV(string email)
        {
            var emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ThemNhanVien(NhanVienDTO themnv)
        {
            return adminDAO.ThemNV(themnv);
        }

        public int XoaNhanVien(NhanVienDTO xoanv)
        {
            return adminDAO.XoaNV(xoanv);
        }

        public int SuaNhanVien(NhanVienDTO suanv)
        {
            return adminDAO.SuaNV(suanv);
        }

        public List<NhanVienDTO> TimKiemNhanVien(string tennv)
        {
            return adminDAO.TKDSNV(tennv);
        }



        //ProductsBUS-------------------------------------------------------------------------
        public List<ProductsDTO> Loaddssp()
        {
            return adminDAO.LoadDSSP();
        }

        public bool ViPhamSP(string tensp, string gia, string loai, string km, string mt)
        {
            if (
            string.IsNullOrWhiteSpace(tensp) || string.IsNullOrWhiteSpace
            (gia) || string.IsNullOrWhiteSpace(loai) || string.IsNullOrWhiteSpace(km) || string.IsNullOrWhiteSpace(mt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ThemSanPham(ProductsDTO themsp)
        {
            return adminDAO.ThemSP(themsp);
        }

        public int XoaSanPham(ProductsDTO xoasp)
        {
            return adminDAO.XoaSP(xoasp);
        }

        public int SuaSanPham(ProductsDTO suasp)
        {
            return adminDAO.SuaSP(suasp);
        }

        public List<ProductsDTO> TimKiemSanPham(string ten)
        {
            return adminDAO.TKDSSP(ten);
        }



        //CategoryBUS-------------------------------------------------------------------------
        public List<CategoryDTO> Loaddsloaisp()
        {
            return adminDAO.LoadDSLOAISP();
        }

        public bool ViPhamLOAISP(string tenloai)
        {
            if (string.IsNullOrWhiteSpace(tenloai))
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public int ThemLoaisp(CategoryDTO themloai)
        {
            return adminDAO.ThemLOAISP(themloai);
        }

        public int XoaLoaisp(CategoryDTO xoaloai)
        {
            return adminDAO.XoaLOAISP(xoaloai);
        }

        public int SuaLoaisp(CategoryDTO sualoai)
        {
            return adminDAO.SuaLOAISP(sualoai);
        }

        public List<CategoryDTO> TimKiemLoaisp(string ten)
        {
            return adminDAO.TKDSLOAISP(ten);
        }

        //BillBUS-------------------------------------------------------------------------
        public List<BillDTO> Loaddsbill()
        {
            return adminDAO.LoadDSBILL();
        }

        public bool ViPhamBILL(string tableid, string nhanvienid, string theid, string tkd, string ttk, string sum)
        {
            if (
            string.IsNullOrWhiteSpace(tableid) || string.IsNullOrWhiteSpace
            (nhanvienid) || string.IsNullOrWhiteSpace(theid) || string.IsNullOrWhiteSpace(tkd) || string.IsNullOrWhiteSpace(ttk) || string.IsNullOrWhiteSpace(sum))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ThemBill(BillDTO thembill)
        {
            return adminDAO.ThemBILL(thembill);
        }

        public int XoaBill(BillDTO xoabill)
        {
            return adminDAO.XoaBILL(xoabill);
        }

        public int SuaBill(BillDTO suabill)
        {
            return adminDAO.SuaBILL(suabill);
        }



        //BanBUS-------------------------------------------------------------------------
        public List<TablesDTO> LoaddsBan()
        {
            return adminDAO.LoadDSBAN();
        }

        public bool ViPhamBAN(string tenban)
        {
            if (string.IsNullOrWhiteSpace(tenban))
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public int ThemBan(TablesDTO themban)
        {
            return adminDAO.ThemBAN(themban);
        }

        public int XoaBan(TablesDTO xoaban)
        {
            return adminDAO.XoaBAN(xoaban);
        }

        public int SuaBan(TablesDTO suaban)
        {
            return adminDAO.SuaBAN(suaban);
        }

        public List<TablesDTO> TimKiemBan(string ten)
        {
            return adminDAO.TKDSBAN(ten);
        }



        //TheBUS-------------------------------------------------------------------------
        public List<TheTVDTO> Loaddsthe()
        {
            return adminDAO.LoadDSTHETV();
        }

        public bool ViPhamTHE(string idnv, string ten, string sdt, string diachi)
        {
            if (
            string.IsNullOrWhiteSpace(idnv) || string.IsNullOrWhiteSpace
            (ten) || string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(diachi))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int ThemThetv(TheTVDTO themthe)
        {
            return adminDAO.ThemTHETV(themthe);
        }

        public int XoaThetv(TheTVDTO xoathe)
        {
            return adminDAO.XoaTHETV(xoathe);
        }

        public int SuaThetv(TheTVDTO suathe)
        {
            return adminDAO.SuaTHETV(suathe);
        }

        public List<TheTVDTO> TimKiemThetv(string tenthe)
        {
            return adminDAO.TKDSTHETV(tenthe);
        }



        //ctgdBUS-------------------------------------------------------------------------
        public List<BillInfoDTO> Loaddscthd()
        {
            return adminDAO.LoadDSCTHD();
        }

        public bool ViPhamCTHD(string billid, string sanphamid, string soluong, string gia, string thanhtien, string khuyenmai)
        {
            if (
            string.IsNullOrWhiteSpace(billid) || string.IsNullOrWhiteSpace
            (sanphamid) || string.IsNullOrWhiteSpace(soluong) || string.IsNullOrWhiteSpace(gia) || string.IsNullOrWhiteSpace(thanhtien) || string.IsNullOrWhiteSpace(khuyenmai))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Themcthd(BillInfoDTO themcthd)
        {
            return adminDAO.ThemCTHD(themcthd);
        }

        public int Xoacthd(BillInfoDTO xoacthd)
        {
            return adminDAO.XoaCTHD(xoacthd);
        }

        public int Suacthd(BillInfoDTO suacthd)
        {
            return adminDAO.SuaCTHD(suacthd);
        }



        //ccBUS-------------------------------------------------------------------------
        public List<ChamCongDTO> Loaddscc()
        {
            return adminDAO.LoadDSCC();
        }

        public bool ViPhamCC(string nhanvienid)
        {
            if (
            string.IsNullOrWhiteSpace(nhanvienid))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Themcc(ChamCongDTO themcc)
        {
            return adminDAO.ThemCC(themcc);
        }

        public int Xoacc(ChamCongDTO xoacc)
        {
            return adminDAO.XoaCC(xoacc);
        }

        public int Suacc(ChamCongDTO suacc)
        {
            return adminDAO.SuaCC(suacc);
        }
    }
}
