using System;
using System.Collections.Generic;
using System.Text;
using ExercicioPrestacoes.Entities;

namespace ExercicioPrestacoes.Services
{
    interface IServicoDePagamento
    {
        public List<Parcela> ValorMensalidade(double valor, int numeroParcelas, DateTime date);
       
    }
}
