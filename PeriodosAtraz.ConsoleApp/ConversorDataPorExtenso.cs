using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtraz.ConsoleApp
{
    public class ConversorDataPorExtenso
    {
        int numeroDias;
        int numeroMeses;
        int numeroAnos;

        bool deveUsarHoras = false;

        int segundos;
        int minutos;
        int horas;

        public string horaPorExtenso;

        public ConversorDataPorExtenso(DateTime data)
        {
            numeroDias = data.Day;
            numeroMeses = data.Month;
            numeroAnos = data.Year;

            if (DatasTemMesmoDiaDoAno(data))
            {
                horas = data.Hour;
                minutos = data.Minute;
                segundos = data.Second;
                deveUsarHoras = true;
            }

            PegarHoraPorExtenso();
        }

        private void PegarHoraPorExtenso()
        {
            ConversorUnidades conversor = new ConversorUnidades(numeroDias);
            string valor1 = conversor.valorPorExtenso;

            conversor = new ConversorUnidades(numeroMeses);
            string valor2 = conversor.valorPorExtenso;

            conversor = new ConversorUnidades(numeroAnos);
            string valor3 = conversor.valorPorExtenso;


            horaPorExtenso = "";
        }

        private bool DatasTemMesmoDiaDoAno(DateTime data)
        {
            return data.Day == DateTime.Now.Day && data.Month == DateTime.Now.Month && data.Year == DateTime.Now.Year;
        }
    }
}
