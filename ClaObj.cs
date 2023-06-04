using System;

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
        public string id { get; set; }
        public string code { get; set; }
        public string fullCode { get; set; }
        public string orderId { get; set; }
        public string merchantId { get; set; }
        public string createdAt { get; set; }
    }
    public class Coordinates
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
    public class DeliveryAddress
    {
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string FormattedAddress { get; set; }
        public string Neighborhood { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Coordinates Coordinates { get; set; }
    }
    public class Delivery
    {
        public string Mode { get; set; }
        public string DeliveredBy { get; set; }
        public DateTime DeliveryDateTime { get; set; }
        public DeliveryAddress DeliveryAddress { get; set; }
    }
    public class Phone
    {
        public string Number { get; set; }
        public string Localizer { get; set; }
        public DateTime LocalizerExpiration { get; set; }
    }
    public class Merchant
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Phone Phone { get; set; }
        public int OrdersCountOnMerchant { get; set; }
        public string Segmentation { get; set; }
    }
    public class Item
    {
        public int Index { get; set; }
        public string Id { get; set; }
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public string ExternalCode { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal OptionsPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Observations { get; set; }
  }
    public class Total
    {
        public decimal SubTotal { get; set; }
        public decimal DeliveryFee { get; set; }
        public decimal Benefits { get; set; }
        public decimal OrderAmount { get; set; }
        public decimal AdditionalFees { get; set; }
    }
    public class Methods
    {
        public decimal Value { get; set; }
        public string Currency { get; set; }
        public string Method { get; set; }
        public string Type { get; set; }
        public Cash Cash { get; set; }
        public bool Prepaid { get; set; }
    }
    public class Cash
    {
        public decimal ChangeFor { get; set; }
    }
    public class Payments
    {
        public decimal Prepaid { get; set; }
        public decimal Pending { get; set; }
        public Methods[] Methods { get; set; }
    }
    public class DetalhesPedido 
    {
        public string Id { get; set; }
        public Delivery Delivery { get; set; }
        public string OrderType { get; set; }
        public string OrderTiming { get; set; }
        public string DisplayId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime PreparationStartDateTime { get; set; }
        public bool IsTest { get; set; }
        public Merchant Merchant { get; set; }
        public Customer Customer { get; set; }
        public Item[] Items { get; set; }
        public string SalesChannel { get; set; }
        public Total Total { get; set; }
        public Payments Payments { get; set; }
    }
}