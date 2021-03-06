﻿using System;
using System.Runtime.InteropServices;

namespace Paradoxlost.UX.WinForms.Api
{
	public enum VirtualKey
	{
		LSHIFT = 0x10,
		SPACE = 0x20,
		LEFT = 0x25,
		RIGHT = 0x27,
		UP = 0x26,
		DOWN = 0x28,
		SCROLL = 0x91,
		PAUSE = 0x13,
		RETURN = 0x0D,
		CONTROL = 0x11,
		BACK = 0x08,
		END = 0x23,
		DELETE = 0x2E,
		PGDN = 0x22,      //PGDN

		A = 0x41,
		B = 0x42,
		C = 0x43,
		D = 0x44,
		E = 0x45,
		F = 0x46,
		G = 0x47,
		H = 0x48,
		I = 0x49,
		J = 0x4A,
		K = 0x4B,
		L = 0x4C,
		M = 0x4D,
		N = 0x4E,
		O = 0x4F,
		P = 0x50,
		Q = 0x51,
		R = 0x52,
		S = 0x53,
		T = 0x54,
		U = 0x55,
		V = 0x56,
		W = 0x57,
		X = 0x58,
		Y = 0x59,
		Z = 0x5A,
		FSLASH = 0xBF
	}

	public enum ShowWindowCommands
	{
		/// <summary>
		/// Hides the window and activates another window.
		/// </summary>
		Hide = 0,
		/// <summary>
		/// Activates and displays a window. If the window is minimized or
		/// maximized, the system restores it to its original size and position.
		/// An application should specify this flag when displaying the window
		/// for the first time.
		/// </summary>
		Normal = 1,
		/// <summary>
		/// Activates the window and displays it as a minimized window.
		/// </summary>
		ShowMinimized = 2,
		/// <summary>
		/// Maximizes the specified window.
		/// </summary>
		Maximize = 3, // is this the right value?
		/// <summary>
		/// Activates the window and displays it as a maximized window.
		/// </summary>      
		ShowMaximized = 3,
		/// <summary>
		/// Displays a window in its most recent size and position. This value
		/// is similar to <see cref="Win32.ShowWindowCommand.Normal"/>, except
		/// the window is not activated.
		/// </summary>
		ShowNoActivate = 4,
		/// <summary>
		/// Activates the window and displays it in its current size and position.
		/// </summary>
		Show = 5,
		/// <summary>
		/// Minimizes the specified window and activates the next top-level
		/// window in the Z order.
		/// </summary>
		Minimize = 6,
		/// <summary>
		/// Displays the window as a minimized window. This value is similar to
		/// <see cref="Win32.ShowWindowCommand.ShowMinimized"/>, except the
		/// window is not activated.
		/// </summary>
		ShowMinNoActive = 7,
		/// <summary>
		/// Displays the window in its current size and position. This value is
		/// similar to <see cref="Win32.ShowWindowCommand.Show"/>, except the
		/// window is not activated.
		/// </summary>
		ShowNA = 8,
		/// <summary>
		/// Activates and displays the window. If the window is minimized or
		/// maximized, the system restores it to its original size and position.
		/// An application should specify this flag when restoring a minimized window.
		/// </summary>
		Restore = 9,
		/// <summary>
		/// Sets the show state based on the SW_* value specified in the
		/// STARTUPINFO structure passed to the CreateProcess function by the
		/// program that started the application.
		/// </summary>
		ShowDefault = 10,
		/// <summary>
		///  <b>Windows 2000/XP:</b> Minimizes a window, even if the thread
		/// that owns the window is not responding. This flag should only be
		/// used when minimizing windows from a different thread.
		/// </summary>
		ForceMinimize = 11
	}

	enum WindowLongFlags : int
	{
		ExStyle = -20,
		GWLP_HINSTANCE = -6,
		GWLP_HWNDPARENT = -8,
		Id = -12,
		Style = -16,
		UserData = -21,
		WindowProc = -4,
		DWLP_USER = 0x8,
		DWLP_MSGRESULT = 0x0,
		DWLP_DLGPROC = 0x4
	}

	/// <summary>
	/// Window Styles.
	/// The following styles can be specified wherever a window style is required. After the control has been created, these styles cannot be modified, except as noted.
	/// </summary>
	[Flags]
	public enum WindowStyles : uint
	{
		/// <summary>The window has a thin-line border.</summary>
		Border = 0x800000,

		/// <summary>The window has a title bar (includes the WS_BORDER style).</summary>
		Caption = 0xc00000,

		/// <summary>The window is a child window. A window with this style cannot have a menu bar. This style cannot be used with the WS_POPUP style.</summary>
		Child = 0x40000000,

		/// <summary>Excludes the area occupied by child windows when drawing occurs within the parent window. This style is used when creating the parent window.</summary>
		ClipChildren = 0x2000000,

		/// <summary>
		/// Clips child windows relative to each other; that is, when a particular child window receives a WM_PAINT message, the WS_CLIPSIBLINGS style clips all other overlapping child windows out of the region of the child window to be updated.
		/// If WS_CLIPSIBLINGS is not specified and child windows overlap, it is possible, when drawing within the client area of a child window, to draw within the client area of a neighboring child window.
		/// </summary>
		ClipSiblings = 0x4000000,

		/// <summary>The window is initially disabled. A disabled window cannot receive input from the user. To change this after a window has been created, use the EnableWindow function.</summary>
		Disabled = 0x8000000,

		/// <summary>The window has a border of a style typically used with dialog boxes. A window with this style cannot have a title bar.</summary>
		DialogFrame = 0x400000,

		/// <summary>
		/// The window is the first control of a group of controls. The group consists of this first control and all controls defined after it, up to the next control with the WS_GROUP style.
		/// The first control in each group usually has the WS_TABSTOP style so that the user can move from group to group. The user can subsequently change the keyboard focus from one control in the group to the next control in the group by using the direction keys.
		/// You can turn this style on and off to change dialog box navigation. To change this style after a window has been created, use the SetWindowLong function.
		/// </summary>
		Group = 0x20000,

		/// <summary>The window has a horizontal scroll bar.</summary>
		HorizontalScroll = 0x100000,

		/// <summary>The window is initially maximized.</summary>
		Maximize = 0x1000000,

		/// <summary>The window has a maximize button. Cannot be combined with the WS_EX_CONTEXTHELP style. The WS_SYSMENU style must also be specified.</summary>
		MaximizeBox = 0x10000,

		/// <summary>The window is initially minimized.</summary>
		Minimize = 0x20000000,

		/// <summary>The window has a minimize button. Cannot be combined with the WS_EX_CONTEXTHELP style. The WS_SYSMENU style must also be specified.</summary>
		MinimizeBox = 0x20000,

		/// <summary>The window is an overlapped window. An overlapped window has a title bar and a border.</summary>
		OverLapped = 0x0,

		/// <summary>The window is an overlapped window.</summary>
		OverLappedWindow = OverLapped | Caption | SystemMenu | SizeFrame | MinimizeBox | MaximizeBox,

		/// <summary>The window is a pop-up window. This style cannot be used with the WS_CHILD style.</summary>
		Popup = 0x80000000u,

		/// <summary>The window is a pop-up window. The WS_CAPTION and WS_POPUPWINDOW styles must be combined to make the window menu visible.</summary>
		PopupWindow = Popup | Border | SystemMenu,

		/// <summary>The window has a sizing border.</summary>
		SizeFrame = 0x40000,

		/// <summary>The window has a window menu on its title bar. The WS_CAPTION style must also be specified.</summary>
		SystemMenu = 0x80000,

		/// <summary>
		/// The window is a control that can receive the keyboard focus when the user presses the TAB key.
		/// Pressing the TAB key changes the keyboard focus to the next control with the WS_TABSTOP style.  
		/// You can turn this style on and off to change dialog box navigation. To change this style after a window has been created, use the SetWindowLong function.
		/// For user-created windows and modeless dialogs to work with tab stops, alter the message loop to call the IsDialogMessage function.
		/// </summary>
		TabStop = 0x10000,

		/// <summary>The window is initially visible. This style can be turned on and off by using the ShowWindow or SetWindowPos function.</summary>
		Visible = 0x10000000,

		/// <summary>The window has a vertical scroll bar.</summary>
		VerticalScroll = 0x200000
	}

	[Flags]
	public enum WindowStylesEx : uint
	{
		/// <summary>Specifies a window that accepts drag-drop files.</summary>
		WS_EX_ACCEPTFILES = 0x00000010,

		/// <summary>Forces a top-level window onto the taskbar when the window is visible.</summary>
		WS_EX_APPWINDOW = 0x00040000,

		/// <summary>Specifies a window that has a border with a sunken edge.</summary>
		WS_EX_CLIENTEDGE = 0x00000200,

		/// <summary>
		/// Specifies a window that paints all descendants in bottom-to-top painting order using double-buffering.
		/// This cannot be used if the window has a class style of either CS_OWNDC or CS_CLASSDC. This style is not supported in Windows 2000.
		/// </summary>
		/// <remarks>
		/// With WS_EX_COMPOSITED set, all descendants of a window get bottom-to-top painting order using double-buffering.
		/// Bottom-to-top painting order allows a descendent window to have translucency (alpha) and transparency (color-key) effects,
		/// but only if the descendent window also has the WS_EX_TRANSPARENT bit set.
		/// Double-buffering allows the window and its descendents to be painted without flicker.
		/// </remarks>
		WS_EX_COMPOSITED = 0x02000000,

		/// <summary>
		/// Specifies a window that includes a question mark in the title bar. When the user clicks the question mark,
		/// the cursor changes to a question mark with a pointer. If the user then clicks a child window, the child receives a WM_HELP message.
		/// The child window should pass the message to the parent window procedure, which should call the WinHelp function using the HELP_WM_HELP command.
		/// The Help application displays a pop-up window that typically contains help for the child window.
		/// WS_EX_CONTEXTHELP cannot be used with the WS_MAXIMIZEBOX or WS_MINIMIZEBOX styles.
		/// </summary>
		WS_EX_CONTEXTHELP = 0x00000400,

		/// <summary>
		/// Specifies a window which contains child windows that should take part in dialog box navigation.
		/// If this style is specified, the dialog manager recurses into children of this window when performing navigation operations
		/// such as handling the TAB key, an arrow key, or a keyboard mnemonic.
		/// </summary>
		WS_EX_CONTROLPARENT = 0x00010000,

		/// <summary>Specifies a window that has a double border.</summary>
		WS_EX_DLGMODALFRAME = 0x00000001,

		/// <summary>
		/// Specifies a window that is a layered window.
		/// This cannot be used for child windows or if the window has a class style of either CS_OWNDC or CS_CLASSDC.
		/// </summary>
		WS_EX_LAYERED = 0x00080000,

		/// <summary>
		/// Specifies a window with the horizontal origin on the right edge. Increasing horizontal values advance to the left.
		/// The shell language must support reading-order alignment for this to take effect.
		/// </summary>
		WS_EX_LAYOUTRTL = 0x00400000,

		/// <summary>Specifies a window that has generic left-aligned properties. This is the default.</summary>
		WS_EX_LEFT = 0x00000000,

		/// <summary>
		/// Specifies a window with the vertical scroll bar (if present) to the left of the client area.
		/// The shell language must support reading-order alignment for this to take effect.
		/// </summary>
		WS_EX_LEFTSCROLLBAR = 0x00004000,

		/// <summary>
		/// Specifies a window that displays text using left-to-right reading-order properties. This is the default.
		/// </summary>
		WS_EX_LTRREADING = 0x00000000,

		/// <summary>
		/// Specifies a multiple-document interface (MDI) child window.
		/// </summary>
		WS_EX_MDICHILD = 0x00000040,

		/// <summary>
		/// Specifies a top-level window created with this style does not become the foreground window when the user clicks it.
		/// The system does not bring this window to the foreground when the user minimizes or closes the foreground window.
		/// The window does not appear on the taskbar by default. To force the window to appear on the taskbar, use the WS_EX_APPWINDOW style.
		/// To activate the window, use the SetActiveWindow or SetForegroundWindow function.
		/// </summary>
		WS_EX_NOACTIVATE = 0x08000000,

		/// <summary>
		/// Specifies a window which does not pass its window layout to its child windows.
		/// </summary>
		WS_EX_NOINHERITLAYOUT = 0x00100000,

		/// <summary>
		/// Specifies that a child window created with this style does not send the WM_PARENTNOTIFY message to its parent window when it is created or destroyed.
		/// </summary>
		WS_EX_NOPARENTNOTIFY = 0x00000004,

		/// <summary>Specifies an overlapped window.</summary>
		WS_EX_OVERLAPPEDWINDOW = WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE,

		/// <summary>Specifies a palette window, which is a modeless dialog box that presents an array of commands.</summary>
		WS_EX_PALETTEWINDOW = WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST,

		/// <summary>
		/// Specifies a window that has generic "right-aligned" properties. This depends on the window class.
		/// The shell language must support reading-order alignment for this to take effect.
		/// Using the WS_EX_RIGHT style has the same effect as using the SS_RIGHT (static), ES_RIGHT (edit), and BS_RIGHT/BS_RIGHTBUTTON (button) control styles.
		/// </summary>
		WS_EX_RIGHT = 0x00001000,

		/// <summary>Specifies a window with the vertical scroll bar (if present) to the right of the client area. This is the default.</summary>
		WS_EX_RIGHTSCROLLBAR = 0x00000000,

		/// <summary>
		/// Specifies a window that displays text using right-to-left reading-order properties.
		/// The shell language must support reading-order alignment for this to take effect.
		/// </summary>
		WS_EX_RTLREADING = 0x00002000,

		/// <summary>Specifies a window with a three-dimensional border style intended to be used for items that do not accept user input.</summary>
		WS_EX_STATICEDGE = 0x00020000,

		/// <summary>
		/// Specifies a window that is intended to be used as a floating toolbar.
		/// A tool window has a title bar that is shorter than a normal title bar, and the window title is drawn using a smaller font.
		/// A tool window does not appear in the taskbar or in the dialog that appears when the user presses ALT+TAB.
		/// If a tool window has a system menu, its icon is not displayed on the title bar.
		/// However, you can display the system menu by right-clicking or by typing ALT+SPACE.
		/// </summary>
		WS_EX_TOOLWINDOW = 0x00000080,

		/// <summary>
		/// Specifies a window that should be placed above all non-topmost windows and should stay above them, even when the window is deactivated.
		/// To add or remove this style, use the SetWindowPos function.
		/// </summary>
		WS_EX_TOPMOST = 0x00000008,

		/// <summary>
		/// Specifies a window that should not be painted until siblings beneath the window (that were created by the same thread) have been painted.
		/// The window appears transparent because the bits of underlying sibling windows have already been painted.
		/// To achieve transparency without these restrictions, use the SetWindowRgn function.
		/// </summary>
		WS_EX_TRANSPARENT = 0x00000020,

		/// <summary>Specifies a window that has a border with a raised edge.</summary>
		WS_EX_WINDOWEDGE = 0x00000100
	}

    public enum HookType : int
    {
        WH_JOURNALRECORD = 0,
        WH_JOURNALPLAYBACK = 1,
        WH_KEYBOARD = 2,
        WH_GETMESSAGE = 3,
        WH_CALLWNDPROC = 4,
        WH_CBT = 5,
        WH_SYSMSGFILTER = 6,
        WH_MOUSE = 7,
        WH_HARDWARE = 8,
        WH_DEBUG = 9,
        WH_SHELL = 10,
        WH_FOREGROUNDIDLE = 11,
        WH_CALLWNDPROCRET = 12,
        WH_KEYBOARD_LL = 13,
        WH_MOUSE_LL = 14
    }
}