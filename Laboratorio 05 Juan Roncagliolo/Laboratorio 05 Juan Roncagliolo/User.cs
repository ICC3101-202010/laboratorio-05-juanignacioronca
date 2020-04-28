using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_05_Juan_Roncagliolo
{
    public class User
    {
        public delegate void EmailVerifiedEventHandler(object source, EventArgs args);
        public event EmailVerifiedEventHandler EmailVerified;
        protected virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
            { EmailVerified(this, EventArgs.Empty); }
        }
        public void OnEmailSent(object source, EventArgs e)
        {
            Console.WriteLine("Desea verificar su email?\nescriba 1 Si 2 No");
            int a_1 = Convert.ToInt32(Console.ReadLine());
            if (a_1==1)
            {
                OnEmailVerified();
            }
        }
    }
}
