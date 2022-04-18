using System;
using System.Collections.Generic;
using System.Text;
using ExercicioPrestacoes.Services;

namespace ExercicioPrestacoes.Entities
{
    class Contrato
    {
        int Numero;
        int NumeroDeParcelas;
        DateTime Data;
        double ValorTotal;
        public IServicoDePagamento ServicoDePagamento;
        List<Parcela> Parcelas;

        public Contrato(int numero, DateTime date, double valorTotal, int numeroDeParcelas, IServicoDePagamento servicoDePagamento)
        {
            Numero = numero;
            Data = date;
            ValorTotal = valorTotal;
            NumeroDeParcelas = numeroDeParcelas;
            ServicoDePagamento = servicoDePagamento;
        }
       public void calcularParcelas()
        {
            Parcelas = new List<Parcela>(ServicoDePagamento.ValorMensalidade(ValorTotal, NumeroDeParcelas, Data));
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Parcelas:");
            foreach (Parcela parcela in Parcelas)
            {
                sb.AppendLine(parcela.ToString());
            }
            return sb.ToString();
        }
    }
}
