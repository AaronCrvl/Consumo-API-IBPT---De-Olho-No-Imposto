using Framework.CacheTransacional;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBPT
{
    public partial class Visualizacao : Form
    {
        ListaProdutosIBPT lst = new ListaProdutosIBPT();
        cApi api = new cApi();

        public void CarregarGrid()
        {
            List<ProdutoIBPT> lstProduto = new List<ProdutoIBPT>();
            DGV.DataSource = lstProduto;
        }
        public Visualizacao()
        {
            InitializeComponent();
        }

        #region Eventos        
        private void bbtnRetornarProdutos_Click(object sender, EventArgs e)
        {
            using (Transacao t = new Transacao())
            {
                try
                {
                    var dadosLista = lst.CarregarTodos();
                    NumReg.Text = "Num. Registros: " + dadosLista.Tables[0].Rows.Count.ToString();
                    DGV.DataSource = dadosLista.Tables[0];
                }
                catch (Exception ex)
                {
                    t.RollBack();
                    throw ex;
                }
            }
        }

        private async void bbtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {                
                bbtnLimpar.Visible = false;                
                var dadosLista = lst.CarregarTodos();
                ProdutoIBPT p = new ProdutoIBPT();                
                p.AtualizaTabelaIBPT(dadosLista.Tables[0], pbar, NaoConcluido, Concluido, bbtnRodaProcedure, bbtnLimpar, bbtnAtualizar, bbtnRodaProcedure);               
            }
            catch (Exception ex)
            {                
                throw ex;
            }           
        }

        private void bbtnLimpar_Click(object sender, EventArgs e)
        {
            Concluido.BackColor = System.Drawing.Color.White;
            NaoConcluido.BackColor = System.Drawing.Color.White;
            NumReg.Text = "Num. Registros: ";
            DGV.DataSource = null;
        }

        private void bbtnRodaProcedure_Click(object sender, EventArgs e)
        {
            using (Transacao t = new Transacao())
            {
                try
                {
                    Framework.Banco.SQL.Transactional_Executar_SP_Gravacao("PR_AtualizaTabelasIBPT", 3600);
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.RollBack();
                    throw ex;
                    //Framework.Log.LogArquivo.GravaLogArqComDataHora("Erro no método ManutencaoDados. Erro: " + ex.Message);
                    //Framework.Log.LogArquivo.GravaLogArq(ex.StackTrace);
                }
            }
        }
        #endregion


    }
}
