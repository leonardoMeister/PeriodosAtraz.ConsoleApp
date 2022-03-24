using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtraz.ConsoleApp
{
    public class ConversorOficial
    {
        int anos = 0;
        int meses = 0;
        int semanas = 0;
        int dias = 0;
        int horas = 0;
        int minutos = 0;
        int segundos = 0;
        bool diasIguais = false;

        public string diasPorExtenso = "";
        public ConversorOficial(DateTime dataUsada)
        {
            PegarDias(dataUsada);
            PegarPorExtenso();
        }

        private void PegarPorExtenso()
        {
            string auxFinal = "";
            ConversorUnidades conversor;
            if (diasIguais)
            {
                PegarHorasPorExtenso();
                return;
            }

            if (anos != 0)
            {
                conversor = new ConversorUnidades(anos);
                string aux = conversor.valorPorExtenso;
                auxFinal += aux + " anos ";
            }
            if (meses != 0)
            {
                conversor = new ConversorUnidades(meses);
                string aux = conversor.valorPorExtenso;
                auxFinal += aux + " meses ";
            }
            if (semanas != 0)
            {
                conversor = new ConversorUnidades(semanas);
                string aux = conversor.valorPorExtenso;
                auxFinal += aux + " semanas ";
            }
            if (dias != 0)
            {
                conversor = new ConversorUnidades(dias);
                string aux = conversor.valorPorExtenso;
                auxFinal += aux + " dias ";
            }
            auxFinal += " atras";

            diasPorExtenso = auxFinal;

        }

        private void PegarHorasPorExtenso()
        {
            ConversorUnidades conversor;
            string auxFinal = "";

            if (horas != 0)
            {
                conversor = new ConversorUnidades(horas);
                string aux = conversor.valorPorExtenso;
                auxFinal += aux + " horas ";
            }
            if (minutos != 0)
            {
                conversor = new ConversorUnidades(minutos);
                string aux = conversor.valorPorExtenso;
                auxFinal += aux + " minutos ";
            }
            if (segundos != 0)
            {
                conversor = new ConversorUnidades(segundos);
                string aux = conversor.valorPorExtenso;
                auxFinal += aux + " segundos ";
            }
            auxFinal += " atras";

            diasPorExtenso = auxFinal;

        }

        private void PegarDias(DateTime data)
        {
            TimeSpan tempo = DateTime.Now - data;

            int numeroDias = tempo.Days;
            if (numeroDias == 0)
            {
                diasIguais = true;
                horas = DateTime.Now.Hour - data.Hour;
                minutos = DateTime.Now.Minute - data.Minute;
                segundos = DateTime.Now.Second - data.Second;
                return;
            }

            if (numeroDias > 365)
            {
                anos = numeroDias / 365;
                numeroDias = numeroDias % 365;
            }

            if (numeroDias > 30)
            {
                meses = numeroDias / 30;
                numeroDias = numeroDias % 30;
            }
            if (numeroDias > 7)
            {
                semanas = numeroDias / 7;
                numeroDias = numeroDias % 7;
            }

            dias = numeroDias;
        }
    }
}
