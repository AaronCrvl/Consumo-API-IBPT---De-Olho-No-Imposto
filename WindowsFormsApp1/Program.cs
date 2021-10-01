using IBPT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Framework.CacheTransacional;
using System.Windows.Forms;

namespace FormsIBPT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            try
            {
                //Inicie aqui a conexão com banco de dados. ========================================================================
                Framework.Banco.SQL.Inicializar("Password=P@ssw0rd; User ID=; Initial Catalog=; Data Source=; connection timeout=;");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Visualizacao());
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
