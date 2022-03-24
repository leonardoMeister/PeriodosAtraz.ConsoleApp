using System;
using System.Collections.Generic;

namespace PeriodosAtraz.ConsoleApp
{
    public class ConversorUnidades
    {
        List<int> lista = new List<int>();
        public string valorPorExtenso;

        public ConversorUnidades(int unidade)
        {
            string unidades = Convert.ToString(unidade);
            AdicionarValoresLista(unidades);
            Conversor();
        }

        private void AdicionarValoresLista(string unidade)
        {
            for (int i = 0; i < unidade.Length; i++)
            {
                lista.Add(Convert.ToInt32(unidade.Substring(i, 1)));
            }
        }

        public void Conversor()
        {
            int quantidade = lista.Count;

            switch (quantidade)
            {
                case 1:
                    ConversorUmNumero();
                    break;
                case 2:
                    ConvertaDoisNumeros();
                    break;
                case 3:
                    ConversorTresNumeros();
                    break;
                case 4:
                    ConvertaQuatroNumeros();
                    break;
            }
        }

        private void ConversorTresNumeros()
        {
            Dicionario dic = new Dicionario();

            string valor1e2 = "";
            string valor1 = "";

            if (lista[0] == 1 && lista[1]==0 && lista[2]==0)
            {
                valorPorExtenso = "cem";
                return;
            }else if (lista[0] == 1)
            {
                valor1 = "cento";
            }
            else
            {
                string aux = lista[0] + "00";
                valor1 = dic.diciCentena[Convert.ToInt32(aux)];
            }


            lista.Remove(lista[0]);
            ConvertaDoisNumeros();
            valor1e2 = valorPorExtenso;

            valorPorExtenso = valor1 + " e " + valor1e2;

        }

        private void ConversorUmNumero()
        {
            Dicionario dic = new Dicionario();

            string auxNumero = "" + lista[0];
            int numero = Convert.ToInt32(auxNumero);

            valorPorExtenso = dic.diciUnidade[numero];
        }

        private void ConvertaDoisNumeros()
        {
            Dicionario dic = new Dicionario();
            string auxValorPorExtenso = "";
            if (lista[0] == 1)
            {
                string auxNumero = lista[0] + "" + lista[1];
                int numero = Convert.ToInt32(auxNumero);
                auxValorPorExtenso = dic.diciDezenaUm[numero];

                valorPorExtenso = auxValorPorExtenso;
            }else if(lista[0] == 0)
            {
                string auxNumero = lista[1] + "";
                int numero = Convert.ToInt32(auxNumero);

                auxValorPorExtenso = dic.diciUnidade[numero];
                valorPorExtenso= auxValorPorExtenso;
            }
            else
            {
                string auxNumero = lista[0] + "" + 0;
                int numero = Convert.ToInt32(auxNumero);
                auxValorPorExtenso = dic.diciDezenaZero[numero];

                auxNumero = lista[1] + "";
                numero = Convert.ToInt32(auxNumero);
                if (numero == 0) { valorPorExtenso = auxValorPorExtenso; return; }
                auxValorPorExtenso += " e " + dic.diciUnidade[numero];

                valorPorExtenso = auxValorPorExtenso;
            }
        }

        private void ConvertaQuatroNumeros()
        {
            Dicionario dic = new Dicionario();
            string valor1 = "";
            string valor2 = "";
            string valor3e4 = "";


            valor1 = dic.diciUnidade[Convert.ToInt32(lista[0])];

            if (lista[1] == 1)
            {
                valor2 = "cento";
            }
            else if (lista[1] != 0)
            {
                string aux = lista[1] + "00";
                valor2 = dic.diciCentena[Convert.ToInt32(aux)];
            }

            lista.Remove(lista[0]);
            lista.Remove(lista[0]);

            ConvertaDoisNumeros();

            valor3e4 = valorPorExtenso;

            if(valor2 == "")
            {
                valorPorExtenso = valor1 + " mil e " + valor3e4;
            }
            else
            {
                valorPorExtenso = valor1 + valor2 + " e " + valor3e4;
            }


        }
    }
}
