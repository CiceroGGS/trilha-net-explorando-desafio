using System;
using System.Collections.Generic;

namespace _02_Sistema_De_Hospedagem_Hotel
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; private set; }
        public Suite Suite { get; private set; }
        public int DiasReservados { get; private set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite == null)
                throw new Exception("Suíte não cadastrada. Cadastre uma suíte antes de adicionar hóspedes.");

            if (hospedes == null || hospedes.Count == 0)
                throw new Exception("A lista de hóspedes não pode ser vazia ou nula.");

            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception($"Capacidade insuficiente. A suíte {Suite.TipoSuite} suporta {Suite.Capacidade} hóspedes, mas {hospedes.Count} foram recebidos.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes?.Count ?? 0;
        }

        public decimal CalcularValorDiaria()
        {
            if (Suite == null)
                throw new Exception("Suíte não cadastrada. Não é possível calcular o valor da diária.");

            return Suite.ValorDiaria;
        }

        public decimal CalcularValorTotal()
        {
            if (Suite == null)
                throw new Exception("Suíte não cadastrada. Não é possível calcular o valor total.");

            decimal valorTotal = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valorTotal *= 0.90m;
            }

            return valorTotal;
        }
    }
}