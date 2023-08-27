using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUrunService
    {
        List<Urun> GetList();
        void SatisAdd(Urun urun);
        void SatisDelete(Urun urun);
        void SatisUpdate(Urun urun);
        Urun GetByID(int id);
    }
}

