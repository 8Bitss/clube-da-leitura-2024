﻿using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloMulta;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo
{
    internal class Emprestimo : EntidadeBase
    {
        public string Status { get; set; }

        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }

        private DateTime dataAtual = DateTime.Now;


        public Revista Revista { get; set; }
        public Amigo Amigo { get; set; }


        public ArrayList erros = new ArrayList();


        public Emprestimo(Amigo amigo, Revista revista, DateTime dataEmprestimo)
        {
        
            Amigo = amigo;
            Revista = revista;

            DataEmprestimo = dataEmprestimo;
            
            
            DataDevolucao = dataEmprestimo.AddDays(revista.Caixa.QuantidadeDiasEmprestado);


            Status = VerificaStatus();
        }




        public override ArrayList Validar()
        {

            if (Amigo == null)
                erros.Add("O campo \"Amigo\" é obrigatório");
            
            if (Revista == null)
                erros.Add("O campo \"Revista\" é obrigatório");

            if (DataEmprestimo == null)
                erros.Add("O campo \"Data de Emprestimo\" é obrigatório");


            return erros;
        }


        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Emprestimo novasInformacoes = (Emprestimo)novoRegistro;

            this.Amigo = novasInformacoes.Amigo;
            this.Revista = novasInformacoes.Revista;
            this.DataDevolucao = novasInformacoes.DataDevolucao;
            this.Status = novasInformacoes.Status;
        }



        public string VerificaStatus()
        {
            if (DataDevolucao < dataAtual)
                return "Atrasado";

            else
                return "Válido";
        }

        public void VerificaMultasEmAberto(bool multaPendente)
        {
            if (multaPendente)
                erros.Add("O amigo possui uma multa em aberto. Para realizar a ação, quite-a primeiro.");
        }
    }
}
