package polindromo;

import java.util.Scanner;
import java.util.*;

public class Polindromo {

    boolean valor = true;
    int i, ind;
    String cadena2 = "";
    
    Scanner teclado = new Scanner(System.in);

    public boolean poli(String cadena) {

        for (int x = 0; x < cadena.length(); x++) {
            if (cadena.charAt(x) != ' ');
            cadena2 += cadena.charAt(x);
        }
        cadena = cadena2;
        ind = cadena.length();

        for (i = 0; i < (cadena.length()); i++) {
            if (cadena.substring(i, i + 1).equals(cadena.substring(ind - 1, ind)) == false) {
                valor = false;
                break;

            }
            ind--;
        }
        return valor;
    }

    public static void main(String[] args) {
        String nuevo;
        Scanner josue = new Scanner(System.in);
        Polindromo objclass = new Polindromo();
        System.out.println("Ingresa la palabra");
        nuevo = josue.nextLine();
        if (objclass.poli(nuevo)) {
            System.out.println("Palindromo");
        } else {
            System.out.println("No es Palindromo");
        }
    }
}
