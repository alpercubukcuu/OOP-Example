using System;

namespace EmlakciLib
{
    public class Ev
    {   //Field

        #region Field  
        private int katno;
        private int odasayisi;
        private string semt;
        private double alan;
        #endregion

        //Constructar (Kurucu Metod)

        #region Constructar
        public Ev(int katno,int odasayisi,string semt,double alan)
        {
            Katno = katno;
            Odasayisi = odasayisi;
            Semt = semt;
            Alan = alan;
        }
       
        public Ev() { }
        #endregion

        //Properties

        #region Properties
    
        public int Katno
        {
            get { return katno; }
            set { katno = value; }
            
        }
        public int Odasayisi
        {
            get { return odasayisi; }
            set { this.odasayisi = Math.Abs(value); }

        }

        public string Semt
        {
            get { return semt; }
            set { this.semt = value.Trim().ToUpper(); }
        }

        public double Alan
        {
            get { return alan; }
            set { this.alan = Math.Abs(value); }
        }
        #endregion

        //Metods

        #region Metods
        public virtual string GetirEvBilgisi() 
        {
            return string.Format("Kat No : {0}\nOda Sayisi : {1}\nSemt : {2}\nAlan : {3}", katno, odasayisi, semt, alan);
        }
    }
    #endregion

}
