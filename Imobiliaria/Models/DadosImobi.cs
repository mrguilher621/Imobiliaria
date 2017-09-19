using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Imobiliaria.Models
{
    public class DadosImobi
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("cidade")]
        public string Cidade { get; set; }

        [JsonProperty("banheiros")]
        public string Banheiros { get; set; }

        [JsonProperty("area_total")]
        public string AreaTotal { get; set; }

        [JsonProperty("area_privativa")]
        public string AreaPrivativa { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("categoria")]
        public string Categoria { get; set; }

        [JsonProperty("churrasqueira")]
        public string Churrasqueira { get; set; }

        [JsonProperty("descricao")]
        public string Descricao { get; set; }

        [JsonProperty("condominio")]
        public string Condominio { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("dependencia")]
        public string Dependencia { get; set; }

        [JsonProperty("elevador")]
        public string Elevador { get; set; }

        [JsonProperty("dormitorios")]
        public string Dormitorios { get; set; }

        [JsonProperty("endereco")]
        public string Endereco { get; set; }

        [JsonProperty("planta")]
        public string Planta { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("imagens")]
        public string[] Imagens { get; set; }

        [JsonProperty("imagem_principal")]
        public string ImagemPrincipal { get; set; }

        [JsonProperty("iptu")]
        public string Iptu { get; set; }

        [JsonProperty("mostrar_mapa")]
        public string MostrarMapa { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("suites")]
        public string Suites { get; set; }

        [JsonProperty("sacada")]
        public string Sacada { get; set; }

        [JsonProperty("portaria")]
        public string Portaria { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("vagas")]
        public string Vagas { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("valor_aluguel")]
        public string ValorAluguel { get; set; }

        [JsonProperty("valor_venda")]
        public string ValorVenda { get; set; }
    }
}