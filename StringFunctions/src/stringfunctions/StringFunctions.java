/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package stringfunctions;

/**
 *
 * @author Mansoor Rafiq
 */
public class StringFunctions {
    public static void main(String[] args) {
        String str = new String("Hello World!");
        System.out.println("The String length is : " + str.length());
        System.out.println("The Position of 'o' length is : " + str.indexOf("o"));
        System.out.println("The Last Position of 'o' length is : " + str.lastIndexOf("o"));
        System.out.println("Concatination : " +  str.concat(" I'am Mansoor Rafiq"));
        System.out.println("The Chracter from 3 to 9 is : " + str.substring(3,9));
    }
    
}
