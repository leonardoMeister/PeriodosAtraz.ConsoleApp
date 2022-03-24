using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtraz.ConsoleApp
{
    public class Dicionario
    {
        public IDictionary<int, string> diciUnidade = new Dictionary<int, string>()
        {
            {1,"um"},
            {2,"dois"},
            {3,"três"},
            {4,"quatro"},
            {5,"cinco"},
            {6,"seis"},
            {7,"sete"},
            {8,"oito"},
            {9,"nove"},
        };
        public IDictionary<int, string> diciDezenaUm = new Dictionary<int, string>()
        {
            {10, "dez" },
            {11,"onze"},
            {12,"doze"},
            {13,"treze"},
            {14,"quatorze"},
            {15,"quinze"}, 
            {16,"dezesseis"},
            {17,"dezessete"},
            {18,"dezoito"},
            {19,"dezenove"},
        };
        public IDictionary<int, string> diciDezenaZero = new Dictionary<int, string>()
        {
            {20,"vinte"},
            {30,"trinta"},
            {40,"quarenta"},
            {50,"cinquenta"},
            {60,"sessenta"},
            {70,"setenta"},
            {80,"oitenta"},
            {90,"noventa"},
        };

        public IDictionary<int, string> diciCentena = new Dictionary<int, string>()
        {
            {100,"cem"},
            {200,"duzentos"},
            {300,"trezentos"},
            {400,"quatrocentos"},
            {500,"quinhentos"},
            {600,"seiscentos"},
            {700,"setecentos"},
            {800,"oitocentos"},
            {900,"novecentos"},
        };

    }
}
