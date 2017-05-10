/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package factorial;
import java.util.Scanner;
 class Factorial {
      
    public static void main(String[] args) {
       Scanner input = new Scanner(System.in);
       System.out.print("Enter a number that finds factorial : ");
       int n = input.nextInt();
       int result = 1;
          for(int i=1; i <=n; i++)
          {
              result = result * i;

          }  
          System.out.println("The factorial of a number is : " + result);
    }
    
}
