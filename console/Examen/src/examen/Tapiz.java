
package examen;

import java.util.InputMismatchException;
import java.util.Scanner;


public class Tapiz {
    Scanner josue = new Scanner (System.in);
   public int costo;
    
    public void getCosT(){
        do{
        try {

        System.out.println("Ingrese el costo del metro cuadrdo");
        costo = josue .nextInt();
         } catch (InputMismatchException ime) {
             System.out.println("Error");
             josue.next();
        }
    }while(costo<1);
        
    } 
}
