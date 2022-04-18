using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using ExercicioPrestacoes.Services;
using ExercicioPrestacoes.Entities;

namespace ExercicioPrestacoes.Services.ServicosContrataveis
{
    class PayPal : IServicoDePagamento
    {
        private double _TaxaMensal = 0.01;
        private double _TaxDePagamento = 0.02;
        private double _ValorFixo;
        private double _ValorParcela;

        public List<Parcela> ValorMensalidade(double valor, int numeroParcelas, DateTime data)
        {
            _ValorFixo = valor / numeroParcelas;
            List<Parcela> list = new List<Parcela>();

            for (int i = 1; i <= numeroParcelas; i++)
            {
                DateTime d = data.AddMonths(i);
                double valorTaxaMensal = _ValorFixo + (_ValorFixo * (_TaxaMensal * i));
                _ValorParcela = (valorTaxaMensal + (valorTaxaMensal * _TaxDePagamento));
                Parcela x = new Parcela(d, _ValorParcela);
                list.Add(x);
            }
            return list;
        }

    }
}
