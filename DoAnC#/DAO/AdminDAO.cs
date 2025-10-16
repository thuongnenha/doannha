using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class AdminDAO
    {
        //NhanVienDAO-------------------------------------------------------------------------
        public List<NhanVienDTO> LoadDSNV()
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            List<NhanVienDTO> dsnv = new List<NhanVienDTO>();

            try
            {
                conn.Open();
                string select = "select * from nhanvien";
                SqlDataReader dr = DataConnect.TruyVan(select, conn);
                while (dr.Read())
                {
                    NhanVienDTO nv = new NhanVienDTO();
                    nv.ID = dr["ID"].ToString();
                    nv.Ho = dr["Ho"].ToString();
                    nv.Ten = dr["Ten"].ToString();
                    nv.Luong = Decimal.Parse(dr["Luong"].ToString());
                    nv.PhoneNumber = dr["PhoneNumber"].ToString();
                    nv.Email = dr["Email"].ToString();
                    nv.Password = dr["Password"].ToString();
                    dsnv.Add(nv);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong LoadDSNV: " + ex.ToString());
            }

            return dsnv;
        }


        public int ThemNV(NhanVienDTO nv)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string them = "insert into nhanvien(ID ,Ho, Ten, Luong, PhoneNumber, Email, Password) values(@ID, @Ho, @Ten, @Luong, @PN, @Email, @PW)";
                SqlParameter[] spm = new SqlParameter[7];
                spm[0] = new SqlParameter("@ID", nv.ID);
                spm[1] = new SqlParameter("@Ho", nv.Ho);
                spm[2] = new SqlParameter("@Ten", nv.Ten);
                spm[3] = new SqlParameter("@Luong", nv.Luong);
                spm[4] = new SqlParameter("@PN", nv.PhoneNumber);
                spm[5] = new SqlParameter("@Email", nv.Email);
                spm[6] = new SqlParameter("@PW", nv.Password);
                int kq = DataConnect.ThucThi(them, spm, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong ThemNV: " + ex.ToString());
            }
            return 0;
        }

        public int XoaNV(NhanVienDTO nv)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string xoa = "delete from nhanvien where ID = @ID";
                SqlCommand cmd = new SqlCommand(xoa, conn);
                cmd.Parameters.AddWithValue("@ID", nv.ID);
                int kq = cmd.ExecuteNonQuery();
                conn.Close();

                return kq;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong XoaNV: " + ex.ToString());
            }
            return 0;

        }

        public int SuaNV(NhanVienDTO nv)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string sua = "update nhanvien set Ho = @Ho, Ten = @Ten, Luong = @Luong, PhoneNumber = @PN, Email = @Email, Password = @PW where ID = @ID";
                SqlParameter[] spm = new SqlParameter[7];
                spm[0] = new SqlParameter("@ID", nv.ID);
                spm[1] = new SqlParameter("@Ho", nv.Ho);
                spm[2] = new SqlParameter("@Ten", nv.Ten);
                spm[3] = new SqlParameter("@Luong", nv.Luong);
                spm[4] = new SqlParameter("@PN", nv.PhoneNumber);
                spm[5] = new SqlParameter("@Email", nv.Email);
                spm[6] = new SqlParameter("@PW", nv.Password);
                int kq = DataConnect.ThucThi(sua, spm, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong SuaNV: " + ex.ToString());
            }
            return 0;

        }

        public List<NhanVienDTO> TKDSNV(string tennv)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            List<NhanVienDTO> dsnv = new List<NhanVienDTO>();

            try
            {
                conn.Open();
                string timkiem = $"select * from nhanvien where ten like @ten";
                SqlCommand cmd = new SqlCommand(timkiem, conn);
                cmd.Parameters.AddWithValue("@ten", "%" + tennv + "%");
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhanVienDTO nv = new NhanVienDTO();
                    nv.ID = dr["ID"].ToString();
                    nv.Ho = dr["Ho"].ToString();
                    nv.Ten = dr["Ten"].ToString();
                    nv.Luong = Decimal.Parse(dr["Luong"].ToString());
                    nv.PhoneNumber = dr["PhoneNumber"].ToString();
                    nv.Email = dr["Email"].ToString();
                    nv.Password = dr["Password"].ToString();
                    dsnv.Add(nv);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong TKDSNV: " + ex.ToString());
            }

            return dsnv;
        }



        //ProductsDAO-------------------------------------------------------------------------
        public List<ProductsDTO> LoadDSSP()
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            List<ProductsDTO> dssp = new List<ProductsDTO>();

            try
            {
                conn.Open();
                string select = "select * from products";
                SqlDataReader dr = DataConnect.TruyVan(select, conn);
                while (dr.Read())
                {
                    ProductsDTO sp = new ProductsDTO();
                    sp.ID = int.Parse(dr["ID"].ToString());
                    sp.Name = dr["Name"].ToString();
                    sp.Gia = decimal.Parse(dr["Gia"].ToString());
                    sp.CategoryID = int.Parse(dr["CategoryID"].ToString());
                    sp.MoTa = dr["MoTa"].ToString();
                    sp.KhuyenMai = int.Parse(dr["KhuyenMai"].ToString());
                    sp.TrangThai = Convert.ToBoolean(dr["TrangThai"]);
                    sp.ImageFood = dr["ImageFood"].ToString();
                    dssp.Add(sp);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong LoadDSSP: " + ex.ToString());
            }

            return dssp;
        }


        public int ThemSP(ProductsDTO sp)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string them = "insert into products(Name, Gia, CategoryID, Mota, KhuyenMai, TrangThai) values(@Name, @Gia, @CID, @MoTa, @KM, @TT)";
                SqlParameter[] spm = new SqlParameter[6];
                spm[0] = new SqlParameter("@Name", sp.Name);
                spm[1] = new SqlParameter("@Gia", sp.Gia);
                spm[2] = new SqlParameter("@CID", sp.CategoryID);
                spm[3] = new SqlParameter("@MoTa", sp.MoTa);
                spm[4] = new SqlParameter("@KM", sp.KhuyenMai);
                spm[5] = new SqlParameter("@TT", sp.TrangThai);

                int kq = DataConnect.ThucThi(them, spm, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong ThemSP: " + ex.ToString());
            }
            return 0;

        }

        public int XoaSP(ProductsDTO sp)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string xoa = $"delete from Products where ID = {sp.ID}";
                int kq = DataConnect.Xoa(xoa, conn);
                conn.Close();

                return kq;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong XoaSP: " + ex.ToString());
            }
            return 0;

        }

        public int SuaSP(ProductsDTO sp)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string sua = "update products set Name = @Name, Gia = @Gia, CategoryID = @CID, MoTa = @MoTa, KhuyenMai = @KM, TrangThai = @TT where ID = @ID";
                SqlParameter[] spm = new SqlParameter[7];
                spm[0] = new SqlParameter("@ID", sp.ID);
                spm[1] = new SqlParameter("@Name", sp.Name);
                spm[2] = new SqlParameter("@Gia", sp.Gia);
                spm[3] = new SqlParameter("@CID", sp.CategoryID);
                spm[4] = new SqlParameter("@MoTa", sp.MoTa);
                spm[5] = new SqlParameter("@KM", sp.KhuyenMai);
                spm[6] = new SqlParameter("@TT", sp.TrangThai);

                int kq = DataConnect.ThucThi(sua, spm, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong SuaSP: " + ex.ToString());
            }
            return 0;

        }

        public List<ProductsDTO> TKDSSP(string tensp)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            List<ProductsDTO> dssp = new List<ProductsDTO>();

            try
            {
                conn.Open();
                string timkiem = $"select * from products where Name like @name";
                SqlCommand cmd = new SqlCommand(timkiem, conn);
                cmd.Parameters.AddWithValue("@name", "%" + tensp + "%");
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ProductsDTO sp = new ProductsDTO();
                    sp.ID = int.Parse(dr["ID"].ToString());
                    sp.Name = dr["Name"].ToString();
                    sp.Gia = decimal.Parse(dr["Gia"].ToString());
                    sp.CategoryID = int.Parse(dr["CategoryID"].ToString());
                    sp.MoTa = dr["MoTa"].ToString();
                    sp.KhuyenMai = int.Parse(dr["KhuyenMai"].ToString());
                    sp.TrangThai = Convert.ToBoolean(dr["TrangThai"]);
                    sp.ImageFood = dr["ImageFood"].ToString();
                    dssp.Add(sp);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong TKDSSP: " + ex.ToString());
            }

            return dssp;
        }



        //CategoryDAO-------------------------------------------------------------------------
        public List<CategoryDTO> LoadDSLOAISP()
        {
            List<CategoryDTO> dsloaisp = new List<CategoryDTO>();
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string load = "select *  from Category";
                SqlDataReader dr = DataConnect.TruyVan(load, conn);
                while (dr.Read())
                {
                    CategoryDTO ctgr = new CategoryDTO();
                    ctgr.ID = int.Parse(dr["ID"].ToString());
                    ctgr.Name = dr["Name"].ToString();
                    dsloaisp.Add(ctgr);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong LoadDSLOAISP: " + ex.ToString());
            }
            return dsloaisp;
        }

        public int ThemLOAISP(CategoryDTO loai)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string them = "insert into category(Name) values(@Name)";
                SqlParameter[] spm = new SqlParameter[1];
                spm[0] = new SqlParameter("@Name", loai.Name);

                int kq = DataConnect.ThucThi(them, spm, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong ThemLOAISP: " + ex.ToString());
            }
            return 0;

        }

        public int XoaLOAISP(CategoryDTO loai)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string xoa = $"delete from Category where ID = {loai.ID}";
                int kq = DataConnect.Xoa(xoa, conn);
                conn.Close();

                return kq;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong XoaLOAISP: " + ex.ToString());
            }
            return 0;
        }

        public int SuaLOAISP(CategoryDTO loai)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string sua = "update Category set Name = @Name where ID = @ID";
                SqlParameter[] spm = new SqlParameter[2];
                spm[0] = new SqlParameter("@ID", loai.ID);
                spm[1] = new SqlParameter("@Name", loai.Name);

                int kq = DataConnect.ThucThi(sua, spm, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong SuaLOAISP: " + ex.ToString());
            }
            return 0;
        }

        public List<CategoryDTO> TKDSLOAISP(string tenloai)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            List<CategoryDTO> dsloai = new List<CategoryDTO>();

            try
            {
                conn.Open();
                string timkiem = $"select * from Category where Name like @name";
                SqlCommand cmd = new SqlCommand(timkiem, conn);
                cmd.Parameters.AddWithValue("@name", "%" + tenloai + "%");
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CategoryDTO loai = new CategoryDTO();
                    loai.ID = int.Parse(dr["ID"].ToString());
                    loai.Name = dr["Name"].ToString();
                    dsloai.Add(loai);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong TKDSLOAISP: " + ex.ToString());
            }

            return dsloai;
        }

        //BillDAO-------------------------------------------------------------------------
        public List<BillDTO> LoadDSBILL()
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            List<BillDTO> dsbill = new List<BillDTO>();

            try
            {
                conn.Open();
                string select = "select * from bill";
                SqlDataReader dr = DataConnect.TruyVan(select, conn);
                while (dr.Read())
                {
                    BillDTO bill = new BillDTO();
                    bill.ID = int.Parse(dr["ID"].ToString());
                    bill.TableID = int.Parse(dr["TableID"].ToString());
                    bill.UserID = dr["UserID"].ToString();
                    bill.TheID = dr["TheID"] != DBNull.Value ? Convert.ToInt32(dr["TheID"]) : (int?)null;
                    bill.TienKhachDua = dr["TienKhachDua"] == DBNull.Value ? 0 : Convert.ToDecimal(dr["TienKhachDua"]);
                    bill.TienTraKhach = dr["TienTraKhach"] == DBNull.Value ? 0 : Convert.ToDecimal(dr["TienTraKhach"]);
                    bill.Sum = decimal.Parse(dr["Sum"].ToString());
                    bill.Status = Convert.ToBoolean(dr["Status"]);
                    dsbill.Add(bill);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong LoadDSBILL: " + ex.ToString());
            }

            return dsbill;
        }


        public int ThemBILL(BillDTO bill)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string them = "insert into Bill(TableID, UserID, TheID, TienKhachDua, TienTraKhach, Sum, Status) values(@tbID, @nvID, @theID, @TKD, @TTK, @SUM, @TT)";
                SqlParameter[] spm = new SqlParameter[7];
                spm[0] = new SqlParameter("@tbID", bill.TableID);
                spm[1] = new SqlParameter("@nvID", bill.UserID);
                spm[2] = new SqlParameter("@theID", bill.TheID);
                spm[3] = new SqlParameter("@TKD", bill.TienKhachDua);
                spm[4] = new SqlParameter("@TTK", bill.TienTraKhach);
                spm[5] = new SqlParameter("@SUM", bill.Sum);
                spm[6] = new SqlParameter("@TT", bill.Status);


                int kq = DataConnect.ThucThi(them, spm, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong ThemBILL: " + ex.ToString());
            }
            return 0;

        }

        public int XoaBILL(BillDTO bill)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string xoa = $"delete from Bill where ID = {bill.ID}";
                int kq = DataConnect.Xoa(xoa, conn);
                conn.Close();

                return kq;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong XoaBILL: " + ex.ToString());
            }
            return 0;
        }

        public int SuaBILL(BillDTO bill)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string sua = "update Bill set TableID = @tbID, UserID = @nvID, TheID = @TheID, TienKhachDua = @TKD, TienTraKhach = @TTK, Sum = @SUM, Status = @TT where ID = @ID";
                SqlParameter[] spm = new SqlParameter[8];
                spm[0] = new SqlParameter("@ID", bill.ID);
                spm[1] = new SqlParameter("@tbID", bill.TableID);
                spm[2] = new SqlParameter("@nvID", bill.UserID);
                spm[3] = new SqlParameter("@TheID", bill.TheID);
                spm[4] = new SqlParameter("@TKD", bill.TienKhachDua);
                spm[5] = new SqlParameter("@TTK", bill.TienTraKhach);
                spm[6] = new SqlParameter("@SUM", bill.Sum);
                spm[7] = new SqlParameter("@TT", bill.Status);

                int kq = DataConnect.ThucThi(sua, spm, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong SuaBILL: " + ex.ToString());
            }
            return 0;
        }



        //BanDAO-------------------------------------------------------------------------
        public List<TablesDTO> LoadDSBAN()
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            List<TablesDTO> dsban = new List<TablesDTO>();

            try
            {
                conn.Open();
                string select = "select * from tables";
                SqlDataReader dr = DataConnect.TruyVan(select, conn);
                while (dr.Read())
                {
                    TablesDTO ban = new TablesDTO();
                    ban.ID = int.Parse(dr["ID"].ToString());
                    ban.Name = dr["Name"].ToString();
                    ban.Status = Convert.ToBoolean(dr["Status"]);
                    dsban.Add(ban);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong LoadDSBBAN: " + ex.ToString());
            }

            return dsban;
        }


        public int ThemBAN(TablesDTO ban)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string them = "insert into Tables(Name, Status) values(@Name, @TT)";
                SqlParameter[] spm = new SqlParameter[2];
                spm[0] = new SqlParameter("@Name", ban.Name);
                spm[1] = new SqlParameter("@TT", ban.Status);

                int kq = DataConnect.ThucThi(them, spm, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong ThemBBAN: " + ex.ToString());
            }
            return 0;

        }

        public int XoaBAN(TablesDTO ban)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string xoa = $"delete from tables where ID = {ban.ID}";
                int kq = DataConnect.Xoa(xoa, conn);
                conn.Close();

                return kq;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong XoaBAN: " + ex.ToString());
            }
            return 0;
        }

        public int SuaBAN(TablesDTO ban)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string sua = "update tables set Name = @Name, Status = @TT where ID = @ID";
                SqlParameter[] spm = new SqlParameter[3];
                spm[0] = new SqlParameter("@ID", ban.ID);
                spm[1] = new SqlParameter("@Name", ban.Name);
                spm[2] = new SqlParameter("@TT", ban.Status);

                int kq = DataConnect.ThucThi(sua, spm, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong SuaBAN: " + ex.ToString());
            }
            return 0;
        }

        public List<TablesDTO> TKDSBAN(string tenban)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            List<TablesDTO> dsban = new List<TablesDTO>();

            try
            {
                conn.Open();
                string timkiem = $"select * from tables where Name like @name";
                SqlCommand cmd = new SqlCommand(timkiem, conn);
                cmd.Parameters.AddWithValue("@name", "%" + tenban + "%");
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TablesDTO ban = new TablesDTO();
                    ban.ID = int.Parse(dr["ID"].ToString());
                    ban.Name = dr["Name"].ToString();
                    ban.Status = Convert.ToBoolean(dr["Status"]);
                    dsban.Add(ban);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong TKDSBAN: " + ex.ToString());
            }

            return dsban;
        }


        //TheDAO-------------------------------------------------------------------------
        public List<TheTVDTO> LoadDSTHETV()
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            List<TheTVDTO> dsthe = new List<TheTVDTO>();

            try
            {
                conn.Open();
                string select = "select * from theTV";
                SqlDataReader dr = DataConnect.TruyVan(select, conn);
                while (dr.Read())
                {
                    TheTVDTO the = new TheTVDTO();
                    the.ID = int.Parse(dr["ID"].ToString());
                    the.UserID = dr["UserID"].ToString();
                    the.FullName = dr["FullName"].ToString();
                    the.PhoneNumber = dr["PhoneNumber"].ToString();
                    the.DiaChi = dr["DiaChi"].ToString();
                    the.TrangThai = dr["TrangThai"] != DBNull.Value && Convert.ToBoolean(dr["TrangThai"]);
                    dsthe.Add(the);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong LoadDSTHETV: " + ex.ToString());
            }

            return dsthe;
        }


        public int ThemTHETV(TheTVDTO the)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string them = "insert into theTV(UserID, FullName, PhoneNumber, DiaChi, TrangThai) values(@NVID, @FN, @PN, @DC, @TT)";
                SqlParameter[] spm = new SqlParameter[5];
                spm[0] = new SqlParameter("@NVID", the.UserID);
                spm[1] = new SqlParameter("@FN", the.FullName);
                spm[2] = new SqlParameter("@PN", the.PhoneNumber);
                spm[3] = new SqlParameter("@DC", the.DiaChi);
                spm[4] = new SqlParameter("@TT", the.TrangThai);
                int kq = DataConnect.ThucThi(them, spm, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong ThemTHETV: " + ex.ToString());
            }
            return 0;
        }

        public int XoaTHETV(TheTVDTO the)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string xoa = "delete from theTV where ID = @ID";
                SqlCommand cmd = new SqlCommand(xoa, conn);
                cmd.Parameters.AddWithValue("@ID", the.ID);
                int kq = cmd.ExecuteNonQuery();
                conn.Close();

                return kq;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong XoaTHETV: " + ex.ToString());
            }
            return 0;

        }

        public int SuaTHETV(TheTVDTO the)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string sua = "update theTV set UserID = @NVID, FullName = @FN, PhoneNumber = @PN, DiaChi = @DC, TrangThai = @TT where ID = @ID";
                SqlParameter[] spm = new SqlParameter[6];
                spm[0] = new SqlParameter("@ID", the.ID);
                spm[1] = new SqlParameter("@NVID", the.UserID);
                spm[2] = new SqlParameter("@FN", the.FullName);
                spm[3] = new SqlParameter("@PN", the.PhoneNumber);
                spm[4] = new SqlParameter("@DC", the.DiaChi);
                spm[5] = new SqlParameter("@TT", the.TrangThai);
                int kq = DataConnect.ThucThi(sua, spm, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong SuaTHETV: " + ex.ToString());
            }
            return 0;

        }

        public List<TheTVDTO> TKDSTHETV(string sdt)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            List<TheTVDTO> dsthe = new List<TheTVDTO>();

            try
            {
                conn.Open();
                string timkiem = $"select * from theTV where PhoneNumber like @PN";
                SqlCommand cmd = new SqlCommand(timkiem, conn);
                cmd.Parameters.AddWithValue("@PN", "%" + sdt + "%");
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TheTVDTO the = new TheTVDTO();
                    the.ID = int.Parse(dr["ID"].ToString());
                    the.UserID = dr["UserID"].ToString();
                    the.FullName = dr["FullName"].ToString();
                    the.PhoneNumber = dr["PhoneNumber"].ToString();
                    the.DiaChi = dr["DiaChi"].ToString();
                    the.TrangThai = Convert.ToBoolean(dr["TrangThai"]);
                    dsthe.Add(the);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong TKDSTHETV: " + ex.ToString());
            }

            return dsthe;
        }



        //cthdDAO-------------------------------------------------------------------------
        public List<BillInfoDTO> LoadDSCTHD()
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            List<BillInfoDTO> dscthd = new List<BillInfoDTO>();

            try
            {
                conn.Open();
                string select = "select * from billInfo";
                SqlDataReader dr = DataConnect.TruyVan(select, conn);
                while (dr.Read())
                {
                    BillInfoDTO bif = new BillInfoDTO();
                    bif.ID = int.Parse(dr["ID"].ToString());
                    bif.BillID = int.Parse(dr["BillID"].ToString());
                    bif.ProductsID = int.Parse(dr["ProductsID"].ToString());
                    bif.SoLuong = int.Parse(dr["SoLuong"].ToString());
                    bif.Gia = decimal.Parse(dr["Gia"].ToString());
                    bif.ThanhTien = decimal.Parse(dr["ThanhTien"].ToString());
                    bif.KhuyenMai = int.Parse(dr["KhuyenMai"].ToString());
                    dscthd.Add(bif);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong LoadDCTHD: " + ex.ToString());
            }

            return dscthd;
        }


        public int ThemCTHD(BillInfoDTO bif)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string them = "insert into BillInfo(BillID, ProductsID, SoLuong, Gia, ThanhTien, KhuyenMai) values(@BID, @PID, @SL, @GIA, @TTien, @KM)";
                SqlParameter[] spm = new SqlParameter[6];
                spm[0] = new SqlParameter("@BID", bif.BillID);
                spm[1] = new SqlParameter("@PID", bif.ProductsID);
                spm[2] = new SqlParameter("@SL", bif.SoLuong);
                spm[3] = new SqlParameter("@GIA", bif.Gia);
                spm[4] = new SqlParameter("@TTien", bif.ThanhTien);
                spm[5] = new SqlParameter("@KM", bif.KhuyenMai);


                int kq = DataConnect.ThucThi(them, spm, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong ThemCTHD: " + ex.ToString());
            }
            return 0;

        }

        public int XoaCTHD(BillInfoDTO bif)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string xoa = $"delete BillInfo  where ID = {bif.ID}";
                int kq = DataConnect.Xoa(xoa, conn);
                conn.Close();

                return kq;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong XoaCTHD: " + ex.ToString());
            }
            return 0;
        }

        public int SuaCTHD(BillInfoDTO bif)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string sua = "update BillInfo set BillID = @BID, ProductsID = @PID, SoLuong = @SL, Gia = @GIA, ThanhTien = @TTien, KhuyenMai = @KM where ID = @ID";
                SqlParameter[] spm = new SqlParameter[7];
                spm[0] = new SqlParameter("@ID", bif.ID);
                spm[1] = new SqlParameter("@BID", bif.BillID);
                spm[2] = new SqlParameter("@PID", bif.ProductsID);
                spm[3] = new SqlParameter("@SL", bif.SoLuong);
                spm[4] = new SqlParameter("@GIA", bif.Gia);
                spm[5] = new SqlParameter("@TTien", bif.ThanhTien);
                spm[6] = new SqlParameter("@KM", bif.KhuyenMai);

                int kq = DataConnect.ThucThi(sua, spm, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong SuaCTHD: " + ex.ToString());
            }
            return 0;
        }



        //ccDAO-------------------------------------------------------------------------
        public List<ChamCongDTO> LoadDSCC()
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            List<ChamCongDTO> dscc = new List<ChamCongDTO>();

            try
            {
                conn.Open();
                string select = "select * from ChamCong";
                SqlDataReader dr = DataConnect.TruyVan(select, conn);
                while (dr.Read())
                {   
                    ChamCongDTO cc = new ChamCongDTO();
                    cc.ID = int.Parse(dr["ID"].ToString());
                    cc.UserID = dr["UserID"].ToString();
                    cc.Ngay = dr["Ngay"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["Ngay"]);
                    cc.GioVao = dr["GioVao"] == DBNull.Value ? (TimeSpan?)null : (TimeSpan)dr["GioVao"];
                    cc.GioRa = dr["GioRa"] == DBNull.Value ? (TimeSpan?)null : (TimeSpan)dr["GioRa"];
                    cc.WorkingTime = dr["WorkingTime"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["WorkingTime"]);
                    dscc.Add(cc);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong LoadDSCC: " + ex.ToString());
            }

            return dscc;
        }


        public int ThemCC(ChamCongDTO cc)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string them = "insert into ChamCong(UserID, Ngay, GioVao, gioRa, WorkingTime) values(@nvID, @Ngay, @GV, @GR, @WT)";
                SqlParameter[] spm = new SqlParameter[5];
                spm[0] = new SqlParameter("@nvID", cc.UserID);
                spm[1] = new SqlParameter("@Ngay", cc.Ngay);
                spm[2] = new SqlParameter("@GV", cc.GioVao);
                spm[3] = new SqlParameter("@GR", cc.GioRa);
                spm[4] = new SqlParameter("@WT", cc.WorkingTime);

                int kq = DataConnect.ThucThi(them, spm, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong ThemCC: " + ex.ToString());
            }
            return 0;

        }

        public int XoaCC(ChamCongDTO cc)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string xoa = $"delete ChamCong where ID = {cc.ID}";
                int kq = DataConnect.Xoa(xoa, conn);
                conn.Close();

                return kq;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong XoaCC: " + ex.ToString());
            }
            return 0;
        }

        public int SuaCC(ChamCongDTO cc)
        {
            SqlConnection conn = DataConnect.TaoKetNoi();
            try
            {
                conn.Open();
                string sua = "update ChamCong set UserID = @nvID, Ngay = @Ngay, GioVao = @GV, GioRa = @GR, WorkingTime = @WT where ID = @ID";
                SqlParameter[] spm = new SqlParameter[6];
                spm[0] = new SqlParameter("@ID", cc.ID);
                spm[1] = new SqlParameter("@nvID", cc.UserID);
                spm[2] = new SqlParameter("@Ngay", cc.Ngay);
                spm[3] = new SqlParameter("@GV", cc.GioVao);
                spm[4] = new SqlParameter("@GR", cc.GioRa);
                spm[5] = new SqlParameter("@WT", cc.WorkingTime);

                int kq = DataConnect.ThucThi(sua, spm, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong SuaCC: " + ex.ToString());
            }
            return 0;
        }
    }
}
