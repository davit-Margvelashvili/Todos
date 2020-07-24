using System.Windows.Forms;
using Todos.Core.Utils;

namespace Todos.WinFormsUi
{
    public static class Utils
    {
        public static bool Validate(this TextBox textBox, Label label)
        {
            if (textBox.Text.IsNullOrWhiteSpace())
            {
                label.Visible = true;
                return false;
            }

            label.Visible = false;
            return true;
        }
    }
}