using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBPT
{
    public class cApi
    {                
        public async Task<ProdutoIBPT> Get(ParametrosAPI param)
        {            
            using (var client = new HttpClient())
            {
                try
                {
                    var url = string.Format
                        (
                        "http://iws.ibpt.org.br/api/Produtos?token={0}&cnpj={1}&codigo={2}&uf={3}&ex={4}",                        
                        param.Token,
                        param.Cnpj,
                        param.Codigo,
                        param.Uf,
                        param.Ex                        
                        );
                    
                    var response = await client.GetAsync(url);
                    if (response.StatusCode == HttpStatusCode.OK )
                    {
                        var produto = await response.Content.ReadAsAsync<ProdutoIBPT>();
                        return produto;
                    }
                    if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        return null;
                    }
                    else
                    {
                        throw new Exception("Requisição Falhou!");
                    }                        
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}