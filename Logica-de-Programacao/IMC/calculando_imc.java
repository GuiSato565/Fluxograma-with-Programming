import java.util.*;
import java.lang.Math;

public class JavaApplication {
    private static Scanner input = new Scanner(System.in);

    public static void main(String[] args) {
        double peso, altura, imc;
        
        peso = input.nextDouble();
        altura = input.nextDouble();
        imc = peso / (altura * altura);
        if (imc <= 18.5) {
            System.out.println("Seu IMC é " + toFixed(imc,2) + ". Status: Magreza");
        } else {
            if (imc >= 18.8 && imc <= 24.9) {
                System.out.println("Seu imc é " + toFixed(imc,2) + ". Status: Normal");
            } else {
                if (imc >= 25 && imc <= 29.9) {
                    System.out.println("Seu imc é " + toFixed(imc,2) + ". Status: Sobrepeso");
                } else {
                    if (imc >= 30 && imc <= 39.9) {
                        System.out.println("Seu IMC é " + toFixed(imc,2) + ". Status: Obesidade");
                    } else {
                        if (imc >= 40) {
                            System.out.println("Seu IMC é " + toFixed(imc,2) + ". Status: Obesidade Grave");
                        }
                    }
                }
            }
        }
    }
    
    private static String toFixed(double value, int digits) {
        return String.format("%." + digits + "f", value);
    }
}
