package operadores;

import java.util.Scanner;

public class Operaciones {

    Scanner josue = new Scanner(System.in);
    float numero1;
    float numero2;
int sum;
    int rest;
    int mult;
    float div;
    int total;

    public void metodo() {
        System.out.println("ingresa la operacion que decea realizar: "
                + "\n1-.Suma "
                + "\n2-.Resta"
                + "\n3-.Multiplicacion"
                + "\n4-.Divicion"
                + "\n5-.Ninguna");
        System.out.print("escoga una operacion: ");
        total = josue.nextInt();
    }

    public void suma() {
        System.out.println("Ingrese un numero");
        numero1=josue.nextInt();
        System.out.println("Ingrese el segundo numero");
        numero2=josue.nextInt();
        int sum =  (int) (numero1 + numero2);
        System.out.println("Total: "+sum);
        
    }

    public void resta() {
         System.out.println("Ingrese un numero");
        numero1=josue.nextInt();
        System.out.println("Ingrese el segundo numero");
        numero2=josue.nextInt();
        int rest = (int) (numero1 - numero2);
        System.out.println("Total: "+rest);
    }

    public void multiplicacion() {
         System.out.println("Ingrese un numero");
        numero1=josue.nextInt();
        System.out.println("Ingrese el segundo numero");
        numero2=josue.nextInt();
        int mult = (int) (numero1 * numero2);
        System.out.println("Total: "+mult);
    }

    public void division() {
         System.out.println("Ingrese un numero");
        numero1=josue.nextInt();
        System.out.println("Ingrese el segundo numero");
        numero2=josue.nextInt();
        float div = numero1 / numero2;
        System.out.println("Total: "+div);
    }

}
