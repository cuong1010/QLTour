using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusAndModel.Model;
namespace WinTour
{
    class Database
    {
        Model1Container db = new Model1Container();
        public object Laytatcathongtin(string bang)
        {

            db = new Model1Container();
            if (bang == "Tours") return (from c in db.Tours select c).DefaultIfEmpty().ToList();
            else if (bang == "TinhThanhs") return (from c in db.TinhThanhs select c).DefaultIfEmpty().ToList();
            else if (bang == "DiaDiems") return (from c in db.DiaDiems select c).DefaultIfEmpty().ToList();
            else if (bang == "LoaiDLs") return (from c in db.LoaiDLs select c).DefaultIfEmpty().ToList();
            else return (from c in db.CTTours select c).DefaultIfEmpty().ToList();
        }
        public int Them(object a)
        {
            Model1Container db = new Model1Container();
            try
            {
                if (a.GetType().ToString().IndexOf("Tour") > 1) db.Tours.Add((Tour)a);
                else
                if (a.GetType().ToString().IndexOf("TinhThanh") > 1) db.TinhThanhs.Add((TinhThanh)a);
                else
                if (a.GetType().ToString().IndexOf("DiaDiem") > 1) db.DiaDiems.Add((DiaDiem)a);
                else
                if (a.GetType().ToString().IndexOf("LoaiDLs") > 1) db.LoaiDLs.Add((LoaiDL)a);
                else
                    if (a.GetType().ToString().IndexOf("CTTour") > 1) db.CTTours.Add((CTTour)a);
                db.SaveChanges();
                return 1;
            }
            catch { return 0; }
        }
    }
    
}
