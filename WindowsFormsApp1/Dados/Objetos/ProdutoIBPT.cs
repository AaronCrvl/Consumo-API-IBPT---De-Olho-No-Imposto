using DevExpress.Office.Utils;
using Framework.CacheTransacional;
using Framework.Dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IBPT
{
    public class ProdutoIBPT
    {
        #region Construtores
        public ProdutoIBPT() { }
        #endregion

        #region Variáveis Privadas        
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string UF { get; set; }
        public int EX { get; set; }
        public string Nacional { get; set; }
        public string Estadual { get; set; }
        public string Importado { get; set; }
        public string Municipal { get; set; }
        public string Tipo { get; set; }
        public string VigenciaInicio { get; set; }
        public string VigenciaFim { get; set; }
        public string Chave { get; set; }
        public string Versao { get; set; }
        public string Fonte { get; set; }
        #endregion

        #region Métodos

        public async void AtualizaTabelaIBPT(DataTable Tabela, ProgressBar pb, PictureBox NaoConcluiu, PictureBox Concluiu, Button bbtnProcedure, Button bbtnLimpar, Button Atualizar, Button Retornar)
        {
            try
            {
                cApi chamadaAPI = new cApi();
                List<ProdutoIBPTDTO> lista = new List<ProdutoIBPTDTO>();

                #region Inicia Propriedades do Forms
                pb.Maximum = 0;
                pb.Visible = true;
                pb.Maximum = Tabela.Rows.Count;
                pb.Show();
                Atualizar.Enabled = false;
                Retornar.Enabled = false;
                Concluiu.Visible = true;
                NaoConcluiu.Visible = true;
                NaoConcluiu.BackColor = System.Drawing.Color.Yellow;
                Concluiu.BackColor = System.Drawing.Color.White;
                #endregion

                foreach (DataRow linha in Tabela.Rows)
                {
                    pb.Increment(1);
                    ParametrosAPI param = new ParametrosAPI(linha);
                    ProdutoIBPTDTO produto = new ProdutoIBPTDTO();

                    var retorno = await chamadaAPI.Get(param);
                    if (retorno != null)
                    {
                        produto.Codigo = retorno.Codigo;
                        produto.Importado = retorno.Importado;
                        produto.Municipal = retorno.Municipal;
                        produto.Estadual = retorno.Estadual;
                        produto.Nacional = retorno.Nacional;
                        produto.UF = retorno.UF;
                        lista.Add(produto);
                    }
                }
                InsertTabela(lista);

                #region Tratativa de Propriedades do Forms
                pb.Dispose();
                Atualizar.Enabled = true;
                Retornar.Enabled = true;
                bbtnProcedure.Visible = true;
                bbtnLimpar.Visible = true;
                NaoConcluiu.BackColor = System.Drawing.Color.White;
                Concluiu.BackColor = System.Drawing.Color.LightGreen;
                #endregion   
            }
            catch (Exception e)
            {
                Concluiu.BackColor = System.Drawing.Color.Red;
                NaoConcluiu.BackColor = System.Drawing.Color.Red;
                throw e;
            }
        }

        void InsertTabela(List<ProdutoIBPTDTO> lista)
        {
            using (Transacao t = new Transacao())
            {
                try
                {
                    foreach (var produto in lista)
                    {
                        StringBuilder sql = new StringBuilder();
                        sql.Append(" INSERT INTO CalculoImpostosTemp ");
                        //sql.Append(" " +
                        //    " ( " +
                        //    "NR_CODIGO_NCM, NR_PERCENTUAL_NACIONALFEDERAL, " +
                        //    "NR_PERCENTUAL_IMPORTADOSFEDERAL, " +
                        //    "NR_PERCENTUAL_ESTADUAL, " +
                        //    "NR_PERCENTUAL_MUNICIPAL, " +
                        //    "UF" +
                        //    " ) ");
                        sql.Append(" VALUES ");
                        sql.Append(" ( ");
                        sql.Append("3" + produto.Codigo.ToString() + ", ");
                        sql.Append("3" + produto.Nacional.ToString() + ", ");
                        sql.Append("3" + produto.Importado.ToString() + ", ");
                        sql.Append("3" + produto.Estadual.ToString() + ", ");
                        sql.Append("3" + produto.Municipal.ToString() + ", ");
                        sql.Append("'" + produto.UF.ToString() + "'");
                        sql.Append(" ) ");
                        Framework.Banco.SQL.Transactional_Executar_Query_Gravacao(sql.ToString());
                    }
                }
                catch (Exception e)
                {
                    t.RollBack();
                    throw e;
                }
            }
        }

        void UpdateTabela(List<ProdutoIBPTDTO> lista)
        {
            using (Transacao t = new Transacao())
            {
                try
                {
                    foreach (var produto in lista)
                    {
                        StringBuilder sql = new StringBuilder();
                        sql.Append(" UPDATE CalculoImpostosTemp ");
                        sql.Append(" SET ");
                        sql.Append(" NR_PERCENTUAL_NACIONALFEDERAL = " + produto.Nacional.ToString());
                        sql.Append(" , ");
                        sql.Append(" NR_PERCENTUAL_IMPORTADOSFEDERAL = " + produto.Importado.ToString());
                        sql.Append(" , ");
                        sql.Append(" NR_PERCENTUAL_ESTADUAL = " + produto.Estadual.ToString());
                        sql.Append(" , ");
                        sql.Append(" NR_PERCENTUAL_MUNICIPAL = " + produto.Municipal.ToString());
                        sql.Append(" , ");
                        sql.Append(" WHERE NR_CODIGO_NCM = " + produto.Codigo.ToString());
                        sql.Append(" ");
                        sql.Append(" AND TX_UF = " + produto.UF.ToString());

                        Framework.Banco.SQL.Transactional_Executar_Query_Gravacao_Parametros(sql.ToString());
                    }
                }
                catch (Exception e)
                {
                    t.RollBack();
                    throw e;
                }
            }
        }
        #endregion
    }


}
