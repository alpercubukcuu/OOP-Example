using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakciLib
{
    public class SatilikEv : Ev
        
    {
        //Field
        double fiyat;
        double depozito1;

        //Constructar

        public SatilikEv(int odasayisi,int katno,string semt,double alan,double depozito1,double fiyat):
            base(odasayisi,katno,semt,alan)
        {
            this.Fiyat = fiyat;
            this.Depozito1 = depozito1;
        }
        public SatilikEv()
        {

        }

        //Properties

        public double Fiyat
        {
            get { return fiyat; }
            set { this.fiyat = Math.Abs(value); }
        }
        public double Depozito1
        {
            get { return depozito1; }
            set { this.depozito1 = Math.Abs(value); }
        }

        //Metods

        public override string GetirEvBilgisi()
        {
            return base.GetirEvBilgisi() + string.Format("\nFiyat : {0}\nDepozito1 : {1}", fiyat, depozito1);
        }


    }
}
