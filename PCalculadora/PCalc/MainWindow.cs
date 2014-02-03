using System;
using Gtk;

//TODO Al hacer click en buttonSumar, sumar los números en entry1 y entry2 mostrando el resultado en entryResult

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		
		buttonSumar.Clicked +=delegate{
			decimal d = decimal.Parse(entry1.Text) + decimal.Parse(entry2.Text);
			entryResult.Text = d.ToString();
		};
	
			
		buttonRestar.Clicked +=delegate{
			decimal d = decimal.Parse (entry1.Text) - decimal.Parse (entry2.Text);
			entryResult.Text = d.ToString();
		};
		
		buttonMultiplicar.Clicked +=delegate{
			decimal d = decimal.Parse (entry1.Text) * decimal.Parse (entry2.Text);
			entryResult.Text = d.ToString();
		};
		
		buttonDividir.Clicked +=delegate{
			decimal d = decimal.Parse (entry1.Text) / decimal.Parse (entry2.Text);
			entryResult.Text = d.ToString();
		};
			
		
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		
		Application.Quit ();
		a.RetVal = true;
		
	}
}