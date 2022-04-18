using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioPrestacoes.Entities
{
    class Parcela
    {
        DateTime DataDaParcela;
        double ValorDaParcela;

        public Parcela(DateTime data, double valor)
        {
            DataDaParcela = data;
            ValorDaParcela = valor;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DataDaParcela.ToShortDateString());
            sb.Append(" - ");
            sb.Append(ValorDaParcela.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
