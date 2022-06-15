using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakciLib
{
    public class KiralikEv:Ev
    {
        #region Field
        //Field
        double depozito;
        double kira;
        #endregion

        //Constructar

        #region Constructar
        public KiralikEv(int katno,int odasayisi,string semt,double alan,double depozito,double kira) : base(odasayisi,katno,semt,alan)
        {
            //// Ev Sınıfından Geçen Bilgiler
            //base.Odasayisi = odasayisi;
            //base.Katno = katno;
            //base.Semt = semt;            {{ BU ŞEKİLDE YAZMAK ÇOK UZUN SÜRÜYOR }}
            //base.Alan = alan;
            ////----------------------------
            
            this.Depozito = depozito;
            this.Kira = kira;
        }

        public KiralikEv()
        {

        }
        #endregion

        //Properties (Kapsülleme)

        #region Properties
        public double Depozito
        {
            get { return depozito; }

            set { this.depozito = Math.Abs(value); }
        }
        public double Kira
        {
            get { return kira; }

            set { this.kira = Math.Abs(value); }
        }
        #endregion

        //Metods

        public override string GetirEvBilgisi()
        {
            return base.GetirEvBilgisi() + string.Format("\nKira : {0}\nDepozito : {1}", kira, depozito);
        }



    }

}
