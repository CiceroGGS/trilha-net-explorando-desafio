using System;
using System.Collections.Generic;

namespace _02_Sistema_De_Hospedagem_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> hospedes = new List<Pessoa>();

            Pessoa p1 = new Pessoa(nome: "Hóspede 1");
            Pessoa p2 = new Pessoa(nome: "Hóspede 2");

            hospedes.Add(p1);
            hospedes.Add(p2);

            Suite suite = new Suite(tipoSuite: "Premium", capacidade:3, valorDiaria: 10);

            Reserva reserva = new Reserva(diasReservados: 10);
            reserva.CadastrarSuite(suite);
            
            try
            {
                reserva.CadastrarHospedes(hospedes);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}"); 
            }

            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}"); 
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
        }
    }
}