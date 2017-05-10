/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package string.reverse;
import java.util.Scanner;
import java.lang.StringBuilder;

public class StringReverse {

   
    public static void main(String[] args) {
        Scanner stringinput = new Scanner(System.in);
        System.out.println("Enter a sentence : ");
        StringBuilder sentence = new StringBuilder(stringinput.nextLine());
        System.out.println("The reverse of a string is :" + sentence.reverse());
    }
    
}
