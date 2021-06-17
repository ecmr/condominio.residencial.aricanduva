using System;
using System.Collections.Generic;

namespace Residencial.AricanduvaBus
{
    public class Morador
    {
        public int IdMorador { get; set; }
        public string Bloco { get; set; }
        public string Apartamento { get; set; }
        public Pessoa Pessoa { get; set; }
        public Proprietario Proprietario { get; set; }
        public Inquilino Inquilino { get; set; }
        public List<Veiculo> Veiculos { get; set; }
    }

    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Telefone3 { get; set; }

    }

    public class Veiculo
    {
        public int IdVeiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
    }

    public class AcessoVeiculo
    {
        public int IdAcessoVeiculo { get; set; }

        /// <summary>
        /// Registrar a TAG do Sem Parar 
        /// </summary>
        public string RegistroAcesso { get; set; }

        public Veiculo Veiculo { get; set; }
    }

    public class Proprietario
    {
        public int IdProprietario { get; set; }
        public string NumeroMatricula { get; set; }
    }

    public class Inquilino
    {
        public int IdInquilino { get; set; }
        public string NumeroContrato { get; set; }
    }
}
