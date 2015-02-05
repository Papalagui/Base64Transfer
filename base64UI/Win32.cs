﻿/****************************** Module Header ******************************\ 
* Module Name:  Win32.cs
* Project:      CSWPFClipboardViewer
* Copyright (c) Microsoft Corporation.
* 
* The CSWPFClipboardViewer project provides the sample on how to monitor
* Windows clipboard changes in a WPF application.

 This source is subject to the Microsoft Public License.
 See http://www.microsoft.com/en-us/openness/resources/licenses.aspx#MPL
 All other rights reserved.

 THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
 EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
 WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using System;
using System.Runtime.InteropServices;

namespace base64UI
{
    /// <summary>
    /// This static class holds the Win32 function declarations and constants needed by
    /// this sample application.
    /// </summary>
    internal static class Win32
    {
        /// <summary>
        /// The WM_DRAWCLIPBOARD message notifies a clipboard viewer window that 
        /// the content of the clipboard has changed. 
        /// </summary>
        internal const int WM_DRAWCLIPBOARD = 0x0308;

        /// <summary>
        /// A clipboard viewer window receives the WM_CHANGECBCHAIN message when 
        /// another window is removing itself from the clipboard viewer chain.
        /// </summary>
        internal const int WM_CHANGECBCHAIN = 0x030D;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        internal static extern int GetWindowLong(IntPtr hwnd, int index);

        [DllImport("user32.dll")]
        internal static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

        [DllImport("user32.dll")]
        internal static extern bool SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter, int x, int y, int width, int height, uint flags);


        internal const int GWL_EXSTYLE = -20;
        internal const int WS_EX_DLGMODALFRAME = 0x0001;
        internal const int SWP_NOSIZE = 0x0001;
        internal const int SWP_NOMOVE = 0x0002;
        internal const int SWP_NOZORDER = 0x0004;
        internal const int SWP_FRAMECHANGED = 0x0020;
        internal const uint WM_SETICON = 0x0080;
    }
}
