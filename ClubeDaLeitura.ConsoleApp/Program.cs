﻿using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloEmprestimo;
using ClubeDaLeitura.ConsoleApp.ModuloReserva;

using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using ClubeDaLeitura.ConsoleApp.ModuloMulta;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classe "Amigo"
            RepositorioAmigo repositorioAmigo = new RepositorioAmigo();

            TelaAmigo telaAmigo = new TelaAmigo();
            telaAmigo.tipoEntidade = "Amigo";
            telaAmigo.repositorio = repositorioAmigo;

            telaAmigo.CadastrarEntidadeTeste();
            #endregion

            #region Classe "Caixa"
            RepositorioCaixa repositorioCaixa = new RepositorioCaixa();

            TelaCaixa telaCaixa = new TelaCaixa();
            telaCaixa.tipoEntidade = "Caixa";
            telaCaixa.repositorio = repositorioCaixa;

            telaCaixa.CadastrarCaixaNovidade();
            #endregion

            #region Classe "Revista"
            RepositorioRevista repositorioRevista = new RepositorioRevista();

            TelaRevista telaRevista = new TelaRevista();
            telaRevista.tipoEntidade = "Revista";
            telaRevista.repositorio = repositorioRevista;


            telaRevista.telaCaixa = telaCaixa;
            telaRevista.repositorioCaixa = repositorioCaixa;

            telaRevista.CadastrarEntidadeTeste();
            #endregion

            #region Classe "Multa"
            RepositorioMulta repositorioMulta = new RepositorioMulta();

            TelaMulta telaMulta = new TelaMulta();
            telaMulta.tipoEntidade = "Multa";
            telaMulta.repositorio = repositorioMulta;
            #endregion

            #region Classe "Emprestimo"
            RepositorioEmprestimo repositorioEmprestimo = new RepositorioEmprestimo();

            TelaEmprestimo telaEmprestimo = new TelaEmprestimo();
            telaEmprestimo.tipoEntidade = "Emprestimo";
            telaEmprestimo.repositorio = repositorioEmprestimo;

            telaEmprestimo.telaAmigo = telaAmigo;
            telaEmprestimo.repositorioAmigo = repositorioAmigo;

            telaEmprestimo.telaRevista = telaRevista;
            telaEmprestimo.repositorioRevista = repositorioRevista;

            telaEmprestimo.telaMulta = telaMulta;
            telaEmprestimo.repositorioMulta = repositorioMulta;;

            telaEmprestimo.CadastrarEntidadeTeste();
            #endregion

            #region Classe "Reserva"
            RepositorioReserva repositorioReserva = new RepositorioReserva();

            TelaReserva telaReserva = new TelaReserva();
            telaReserva.tipoEntidade = "Reserva";
            telaReserva.repositorio = repositorioReserva;

            telaReserva.telaAmigo = telaAmigo;
            telaReserva.telaRevista = telaRevista;
            telaReserva.telaEmprestimo = telaEmprestimo;

            telaReserva.repositorioAmigo = repositorioAmigo;
            telaReserva.repositorioRevista = repositorioRevista;

            telaReserva.CadastrarEntidadeTeste();
            #endregion




            while (true)
            {
                char opcaoPrincipalEscolhida = TelaPrincipal.ApresentarMenuPrincipal();

                if (opcaoPrincipalEscolhida == 'S' || opcaoPrincipalEscolhida == 's')
                    break;

                TelaBase tela = null;

                if (opcaoPrincipalEscolhida == '1')
                    tela = telaAmigo;

                else if (opcaoPrincipalEscolhida == '2')
                    tela = telaCaixa;

                else if (opcaoPrincipalEscolhida == '3')
                    tela = telaRevista;

                else if (opcaoPrincipalEscolhida == '4')
                    tela = telaEmprestimo;

                else if (opcaoPrincipalEscolhida == '5')
                    tela = telaReserva;

                else if (opcaoPrincipalEscolhida == '6')
                    tela = telaMulta;


                char operacaoEscolhida = tela.ApresentarMenu();



                if (operacaoEscolhida == 'S' || operacaoEscolhida == 's')
                    continue;

                if (operacaoEscolhida == '1')
                    tela.Registrar();

                else if (operacaoEscolhida == '2')
                    tela.Editar();

                else if (operacaoEscolhida == '3')
                    tela.Excluir();

                else if (operacaoEscolhida == '4')
                    tela.VisualizarRegistros(true);
            }
        }
    }
}
