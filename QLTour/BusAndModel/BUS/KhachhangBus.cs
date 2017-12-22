using BusAndModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusAndModel.BUS
{
    public class KhachhangBus
    {
        private Model1Container db = new Model1Container();
        public bool CreateKhachHang(KhachHang kh)
        {
            try
            {
                db.KhachHangs.Add(kh);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public bool DeleteKhachHang(int? id)
        {
            try
            {
                KhachHang khachHang = db.KhachHangs.Find(id);
                db.KhachHangs.Remove(khachHang);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool UpdateKhachHang(KhachHang khachhang)
        {
            try
            {
                db.Entry(khachhang).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public List<KhachHang> getList()
        {
            try { return db.KhachHangs.ToList(); }
            catch (Exception ex)
            {

                return null;
            }
        }
        public KhachHang FindbyId(int? id)
        {
            try { return db.KhachHangs.Find(id); }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
