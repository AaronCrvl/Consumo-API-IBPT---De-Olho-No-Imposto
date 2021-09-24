using System;
using System.Collections.Generic;
using System.Data;

namespace IBPT
{
    public class ParametrosAPI
    {
        #region Construtores
        public ParametrosAPI()
        {
        }

        public ParametrosAPI(string token, string cnpj, string codigo, string uf, int ex, string codigoInterno = "", string descricao = "", string unidadeMedida = "", decimal valor = 0, string gtin = "")
        {
            this.Token = token;
            this.Cnpj = cnpj;
            this.Uf = uf;
            this.Ex = ex;
            this.CodigoInterno = codigoInterno;
            this.Descricao = descricao;
            this.UnidadeMedida = unidadeMedida;
            this.Valor = valor;
            this.Gtin = gtin;
        }

        public ParametrosAPI(DataRow dt)
        {
            this.Token = "z2sSwbofWiOUJY6WBl9xOTWL399B-LnlfSeP0ubZdjuStr2ywcDeEpA6O-St1oxP";    //fixed
            this.Cnpj = "09624235000129";                                                       // fixed
            this.Codigo = dt["NR_CODIGO_NCM"].ToString();
            this.Uf = dt["TX_UF"].ToString();
            this.Ex = 0;
            this.CodigoInterno = "";
            this.Descricao = "";                                                                             
            this.UnidadeMedida = "";
            this.Valor = 0;
            this.Gtin = "";
        }
        #endregion

        #region Variáveis Para Requisição
        //Required
        public string Token { get; set; }
        //Required
        public string Cnpj { get; set; }
        //Required
        public string Codigo { get; set; }
        //Required
        public string Uf { get; set; }
        //Required
        public int Ex { get; set; }
        public string CodigoInterno { get; set; }
        public string Descricao { get; set; }
        public string UnidadeMedida { get; set; }
        public decimal Valor { get; set; }
        public string Gtin { get; set; }        
        #endregion
    }
}
