package serpis.ed;

import java.util.Random;
import java.util.Scanner;

//Genera un número aleatorio entre 1 y 1000 (ambos inclusive)

public class Adivina {

	public static void main(String[] args) {
		
		Random random = new Random ();
		int numeroAleatorio = random.nextInt(1000) +1;
		int contador = 1;
		System.out.println("He generado un número entre 1 y 1000. \n" +"Intenta adivinarlo..." +numeroAleatorio);
		
		Scanner scanner = new Scanner(System.in);
		
		while (true) {
		
			//System.out.println("Intento número "+ );	
			System.out.print("Introduce en número: ");
			
			int numeroIntroducido = scanner.nextInt();
			
			if (numeroIntroducido == numeroAleatorio) break; 
			
			if(numeroIntroducido < numeroAleatorio)
				
				
				System.out.println("Di uno mayor");
					
			 
		
			else // numeroIntroducido > numeroAleatorio
				
				
				System.out.println("Di uno menor");			
				
					System.out.println("Llevas "+ contador + " intentos ");
					contador=contador+1;
		}
		//Esto está fuera del ciclo, al pasar por break
		
		System.out.println("Has acertado. Enhorabuena. ");
	}	

}
