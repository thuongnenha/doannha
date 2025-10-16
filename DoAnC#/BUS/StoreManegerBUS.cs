using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class StoreManegerBUS
    {
        StoreManegerDAO storeManegerDAO = new StoreManegerDAO();
        public int soLuongTables()
        {
            return storeManegerDAO.demTables();
        }
        public List<ProductsDTO> LayDanhSachMon()
        {
            return storeManegerDAO.LayDanhSachMon();
        }
        public List<TablesDTO> taoTables()
        {
            return storeManegerDAO.taoTables();
        }
        public decimal giaTienFood(string gia, int soluong)
        {
            decimal donGia = Convert.ToDecimal(gia);
            return donGia * soluong;
        }
        public bool LuuBillVaChiTiet(int theTV, List<BillInfoDTO> danhSachMon, decimal sum)
        {
            //storeManegerDAO.updateTables();
            return storeManegerDAO.LuuBillVaChiTiet(theTV, danhSachMon, sum);
        }
        public int LayIDMonTheoTen(string tenMon)
        {
            return storeManegerDAO.LayIDMonTheoTen(tenMon);
        }
        public int checkSdt(string sdt)
        {
            return storeManegerDAO.checkSdt(sdt);
        }

        public DataTable showData()
        {
            return storeManegerDAO.showData();
        }
        public bool chuyenTable(int chuyen)
        {
            return storeManegerDAO.chuyenTable(chuyen);
        }
        public void updateTable(int tableID)
        {
            storeManegerDAO.updateTable(tableID);
        }
        public bool ghepTable(int ghep)
        {
            return storeManegerDAO.ghepTable(ghep);
        }
        public string showSDT(int tableID)
        {
            return storeManegerDAO.showSDT(tableID);
        }
        public int? checkKM(int TableID)
        {
            return storeManegerDAO.checkKM(TableID);
        }
    }
}
