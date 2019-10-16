package examen;

import java.util.InputMismatchException;
import java.util.Scanner;

public class Habitacion {

    float largo;
    float ancho;
    public float total;
    Scanner josue = new Scanner (System.in);

    public void metodo(){
        do {
            try {
            System.out.print("Ingres el ancho de la habitacion: ");
            ancho = josue.nextFloat();

        } catch (InputMismatchException ime) {
            System.out.println("Erro vuelve a ingresar");
            josue.next();
        }

    }
    while (ancho< 1);

        do{       
            try {
            System.out.print("Ingrese el largo de la habitacion: ");
            largo = josue.nextFloat();
        } catch (InputMismatchException ime) {
            System.out.println("Error");
            josue.next();
        }
    }
    while(largo< 1);
        
        
        total  = ancho * largo;

        System.out.println(total+" metros");
        
    }
            
        }
