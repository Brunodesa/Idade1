using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade
{
    class diamesano
    {
        private DateTime data = new DateTime().Date;


        public string recebe
        {
            set
            {
                data = Convert.ToDateTime(value);
            }
        }
        public string envia
        {
            get
            {
                DateTime today = DateTime.Now;

                int anos = today.Year - data.Year;
                int meses = today.Month - data.Month;
                if (meses < 0)
                {
                    anos--;
                    meses += 12;
                }

                int dias = today.Day - data.Day;
                if (meses < 0)
                {
                    meses--;
                    dias += 30;
                }

                string frase = "A sua idade é ";
                frase += anos.ToString() + " anos ";
                frase += meses.ToString() + " meses ";
                frase += dias.ToString() + " dias.";


                return frase;
            }
        }

    }
}