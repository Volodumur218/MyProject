using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public static class TextBoxExtensions
{
    private const uint ECM_FIRST = 0x1500;
    private const uint EM_SETCUEBANNER = ECM_FIRST + 1;

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
    private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);

    public static void SetCueText(this TextBox textBox, string cueText)
    {
        SendMessage(textBox.Handle, EM_SETCUEBANNER, (IntPtr)1, cueText);
    }
}

