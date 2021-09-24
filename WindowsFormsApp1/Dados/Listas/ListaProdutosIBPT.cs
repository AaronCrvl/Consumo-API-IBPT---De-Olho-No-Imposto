using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBPT
{
    public partial class ListaProdutosIBPT : CollectionBase
    {
        #region Construtores
        public ListaProdutosIBPT() : base()
        {
        }
        #endregion

        #region Métodos
        public IBPT.ParametrosAPI this[int index]
        {
            get
            {
                if (List.Count > 0)
                    if (index >= 0 && index < List.Count)
                        return (IBPT.ParametrosAPI)List[index];
                    else
                        throw new IndexOutOfRangeException("Atenção, o índice passado está fora da faixa aceitável de valores.");
                else
                    return null;
            }
        }

        public DataSet CarregarTodos()
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT TOP 30000 ");
                sql.Append(" CI.NR_CODIGO_NCM");
                sql.Append(", ");
                sql.Append(" CI.TX_DESCRICAO_NCM");
                sql.Append(", ");
                sql.Append(" CI.NR_PERCENTUAL_ESTADUAL");
                sql.Append(", ");
                sql.Append(" CI.NR_PERCENTUAL_IMPORTADOSFEDERAL");
                sql.Append(", ");
                sql.Append(" CI.NR_PERCENTUAL_MUNICIPAL");
                sql.Append(", ");
                sql.Append(" CI.NR_PERCENTUAL_NACIONALFEDERAL");
                sql.Append(", ");
                sql.Append(" CI.TX_CHAVE");
                sql.Append(", ");
                sql.Append(" CI.TX_VERSAO");
                sql.Append(", ");
                sql.Append(" CI.TX_UF");
                sql.Append(" FROM CalculoImpostos CI (NOLOCK) ");
                return Framework.Banco.SQL.Transactional_Executar_Query_Leitura_Parametros_DataSet(sql.ToString().ToUpper());
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion
    }
}
