﻿using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnTextview1InsertAtCursor (object o, InsertAtCursorArgs args)
	{
		throw new NotImplementedException ();
	}

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		throw new NotImplementedException ();
	}
}
