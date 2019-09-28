using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFapp
{
    public class BirthDay
    {
        private int nascitaGiorno;
        private int nascitaMese;
        private int nascitaAnno;

        public BirthDay(int nascitaGiorno, int nascitaMese, int nascitaAnno)
        {
            this.nascitaGiorno = nascitaGiorno;
            this.nascitaMese = nascitaMese;
            this.nascitaAnno = nascitaAnno;
        }
        public int CalcolaAnni()
        {
            DateTime today = DateTime.Today;
            int anni = today.Year - nascitaAnno;
            return anni;
        }
    }
}
