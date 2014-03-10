using System;
using Gtk;
using System.Collections.Generic;
using System.Diagnostics;

public partial class MainWindow: Gtk.Window
{	
	private Table table;
	private List <int> numeros;
	private Random random= new Random();
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		
		table=new Table(1,1,true);
		
		vbox1.Add(table);
		table.Visible=true;
		List<Button> buttons = new List<Button>();
		
		for (uint index = 0; index < 75; index++){
			
			Button button = new Button();
			button.Label = string.Format ("{0}", index+1);
			button.Visible = true;
			
			buttons.Add(button);
		
			uint fila = index / 10;
			uint columna = index % 10;
			
			table.Attach (button, columna, columna+1, fila, fila+1);
		}
		
		Gdk.Color verde = new Gdk.Color(0,255,0);
		numeros= new List <int>();
		
		//TODO 90 parece que será un parámetro de la aplicación
		for(int numero = 1; numero <= 75 ; numero++){
			numeros.Add(numero);
		}
		
		showNumeros();
		
		goForwardAction.Activated += delegate {
		
			int indexAleatorio = random.Next(numeros.Count);
			int numeroExtraido = numeros [ indexAleatorio ];
			
			entryNumero.Text = numeroExtraido.ToString();
			espeak(numeroExtraido);
			buttons[numeroExtraido-1].ModifyBg (StateType.Normal, verde);
			numeros.Remove(numeroExtraido);
			
			showNumeros();
	
		
		
		
		};
		
		
	}
	
	
	private void showNumeros(){
		foreach(int numero in numeros){
			Console.Write (numero+" ");
		}
		Console.WriteLine();
	}
	
	private void espeak (int numeroExtraido){
		string numeroCantado=numeroExtraido.ToString ();
		if(numeroCantado.Length > 1){
			string digitos = numeroCantado;
			foreach(char digito in digitos)
				numeroCantado=numeroCantado+" "+digito;
		}
	}
	
	
	
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
