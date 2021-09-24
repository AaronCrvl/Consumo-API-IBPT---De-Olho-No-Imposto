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
                Framework.Banco.SQL.Inicializar("Password=P@ssw0rd; User ID=wgcapp; Initial Catalog=IBPT; Data Source=WGCSERVERSQL01; connection timeout=600;");
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
