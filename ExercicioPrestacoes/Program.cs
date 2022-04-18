using System;
using System.Globalization;
using ExercicioPrestacoes.Entities;
using ExercicioPrestacoes.Services;
using ExercicioPrestacoes.Services.ServicosContrataveis;

namespace ExercicioPrestacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do contrato");
            Console.Write("Número do contrato: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data do Contrato: ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor total do Contrato: ");
            double valorTotalDoContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            IServicoDePagamento contratoDeParcelamento = new PayPal();
            Console.Write("Número de parcelas: ");
            int numeroDeParcelas = int.Parse(Console.ReadLine());

            Contrato c1 = new Contrato(numero, data, valorTotalDoContrato, numeroDeParcelas, contratoDeParcelamento);
            c1.calcularParcelas();
            Console.WriteLine(c1);

        }
    }
}
