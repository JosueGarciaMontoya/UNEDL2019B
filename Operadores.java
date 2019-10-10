package operadores;

import java.util.Scanner;

public class Operadores {

    Scanner josue = new Scanner(System.in);
    int total;

    public static void main(String[] args) {

        Operaciones operador = new Operaciones();
        operador.metodo();
     
            if (operador.total>=1 && operador.total<=4){
            switch (operador.total) {
                case 1:
                    System.out.println("SUMA");
                    operador.suma();
                    break;

                case 2:
                    System.out.println("RESTA");
                    operador.resta();

                    break;

                case 3:
                    System.out.println("MULTIPLICACION");
                    operador.multiplicacion();
                    break;
                case 4:
                    System.out.println("DIVISION");
                    operador.division();
            }
            }else{
                
            }
        
    }
}
