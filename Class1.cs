using System;
using System.Collections.Generic;

namespace burger
{
  public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Contato { get; set; }
        public int CEP { get; set; }
        public string UF { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public int Número { get; set; }
        public string Complemento { get; set; }
        public int Pedidos { get; set; }
    }
    public class Entregador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
    public class Endereco
    {
        public int Id { get; set; }
        public string Bruto { get; set; }
        public string Uf { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
    }
    public class Enderecob
    {
      public string Cep { get; set; }
      public string Logradouro { get; set; }
      public string Complemento { get; set; }
      public string Bairro { get; set; }
      public string Localidade { get; set; }
      public string Uf { get; set; }
      public string Unidade { get; set; }
      public string Ibge { get; set; }
      public string Gia { get; set; }
    }
    public class Contato
    {
        public int Id { get; set; }
        public string Ddd { get; set; }
        public string Numero { get; set; }
    }
    public class Cozinheiro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Contato { get; set; }
        public string CEP { get; set; }
        public int Número { get; set; }
        public string Complemento { get; set; }
    }
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public int Tipo { get; set; }
    }
    public class Pedido
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Entregador { get; set; }
        public string Cozinheiro { get; set; }
        public float Total { get; set; }
        public string Status { get; set; }
    }
    public class PedidoIfood
    {
      public int Id { get; set; }
      public string NumeroPedido { get; set; }
      public string NomeRestaurante { get; set; }
      public string EnderecoRestaurante { get; set; }
      public string NomeCliente { get; set; }
      public string EnderecoEntrega { get; set; }
      public DateTime DataPedido { get; set; }
      public decimal ValorTotal { get; set; }
      public List<ItemPedido> Itens { get; set; }
    }
    public class ItemPedido
    {
      public string NomeProduto { get; set; }
      public decimal PrecoUnitario { get; set; }
      public int Quantidade { get; set; }
      public decimal ValorTotal { get { return PrecoUnitario * Quantidade; } }
    }
}