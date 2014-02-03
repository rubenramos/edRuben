using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	

	int valor1, valor2;
	
	
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		buttonSuma.Clicked += delegate {
		valor1 = Convert.ToInt32(Button2.Text);
		valor2 = Convert.ToInt32(Button3.Text);
			
	    Button1.Text = (valor1 + valor2).ToString();
			
		};
		
		Build ();
	}
		
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
