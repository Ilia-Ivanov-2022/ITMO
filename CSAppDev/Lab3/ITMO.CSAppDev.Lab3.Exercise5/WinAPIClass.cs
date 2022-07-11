using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AnimatedWindow
{
    public class WinAPIClass
    {
        #region Window animation
        /// <summary>
        /// Window animation type. Enum returns the data type int
        /// after the conversion. Each element of the enumeration 
        /// is assigned with own int type.
        /// </summary>
        [Flags]
        public enum AnimateWindowFlags : int
        {
            AW_HOR_POSITIVE = 1,
            AW_HOR_NEGATIVE = 2,
            AW_VER_POSITIVE = 4,
            AW_VER_NEGATIVE = 8,
            AW_CENTER = 16,
            AW_HIDE = 65536,
            AW_ACTIVATE = 131072,
            AW_SLIDE = 262144,
            AW_BLEND = 524288
        };
        /// <summary>
        /// Window animation
        /// </summary>
        /// <param name = "hwnd">Window.</param>
        /// <param name= "dwTime">Time.</param>
        /// <param name="dwFlags">Animation type. If an enum is used
        /// in unmanaged code, it must be converted to int data type.</param>
        /// <returns></returns>

        [DllImportAttribute("user32.dll", EntryPoint = "AnimateWindow", SetLastError = true)]
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        /// <summary>
        /// Window Animation.
        /// </summary>
        /// <param name="ctrl">Window.</param>
        /// <param name="dwTime">Time.</param>
        /// <param name="Flags">Flags.</param>
        /// <returns></returns>
        public static bool AnimateWindow(Control ctrl, int dwTime, AnimateWindowFlags Flags)
        {
            return AnimateWindow(ctrl.Handle, dwTime, (int)Flags);
        }
        #endregion
    }
}