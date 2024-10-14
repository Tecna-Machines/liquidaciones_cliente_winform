using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace UI.Utils
{
    internal class MessageUtils
    {
        public static DialogResult PopUpDeConfirmacion(string leyenda,string titulo)
        {
            return MessageBox.Show(leyenda,
                                   titulo,
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Warning);
        }

        public static DialogResult ErrorMessage(string message)
        {
            return MessageBox.Show(message, "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public static DialogResult SuccessMessage(string message)
        {
            return MessageBox.Show(message, "EXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
