using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmoReport.DAL
{
    internal class SachDAL
    {
        private DuLieuSachEntities dbContext;

        public SachDAL()
        {
            dbContext = new DuLieuSachEntities();
        }
        //Lấy tất cả sách
        public List<Sach> GetAlls()
        {
            return dbContext.Saches.ToList();
        }
        //Lấy tất cả sách dựa trên năm Xuất bản

        public List<Sach> GetSachsByNamXB(int namXB) {
            
            return dbContext.Saches.Where(s=>s.NamXB == namXB).ToList();

        }
    }
}
