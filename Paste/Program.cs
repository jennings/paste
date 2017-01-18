using System;
using System.Windows.Forms;

namespace Paste
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (Clipboard.ContainsText(TextDataFormat.UnicodeText))
            {
                var text = Clipboard.GetText(TextDataFormat.UnicodeText);
                Console.Out.Write(text);
                Console.Out.Flush();
            }
            else if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                var text = Clipboard.GetText(TextDataFormat.Text);
                Console.Out.Write(text);
                Console.Out.Flush();
            }
        }
    }
}
