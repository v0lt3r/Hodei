package letrascomunes4_03;

import java.io.*;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;

public class LetrasComunes4_03 {

    public static void main(String[] args)
    {
        String palabra1 = "";
        String palabra2 = "";
        
        System.out.println("Escriba la palabra 1");
        try {
                BufferedReader entrada =
                new BufferedReader(new InputStreamReader(System.in)); palabra1 = entrada.readLine();
            }
            catch (IOException e) {}
        
        System.out.println("Escriba la palabra 2");
        try {
                BufferedReader entrada =
                new BufferedReader(new InputStreamReader(System.in)); palabra2 = entrada.readLine();
            }
            catch (IOException e) {}
        
        for (int i = 0; i < palabra1.length(); i++) 
        {
            for (int j = 0; j < palabra2.length(); j++) 
            {
                if (palabra1.charAt(i) == palabra2.charAt(j)) 
                {
                    System.out.println(palabra1.substring(i,i+1));
                }
            }
        }      
    }
}

