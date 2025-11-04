namespace UI.Utils
{
    internal static class Dialog
    {
        public static DialogResult PopUpDeConfirmacion(string leyenda, string titulo)
        {
            return MessageBox.Show(leyenda,
                                   titulo,
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Warning);
        }

        public static DialogResult Error(string message)
        {
            return MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Success(string message)
        {
            return MessageBox.Show(message, "EXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
