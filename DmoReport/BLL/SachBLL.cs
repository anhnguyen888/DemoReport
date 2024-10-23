using DmoReport.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmoReport.BLL
{
    internal class SachBLL
    {
        private SachDAL sachDAL;
        public SachBLL()
        {
            sachDAL = new SachDAL();
        }
        //lay tat ca sach theo nam XB

        public List<Sach> GetSachsByNamXB(int namXB)
        {
            if (namXB <= 0)
            {
                throw new Exception("Nam xuat ban khong hop le!");
            }
            return sachDAL.GetSachsByNamXB(namXB);
        }
    }
}
