/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package methodoverloading;

public class Methodoverloading {

    public int Calculation(int a,int b) {
        return a + b;
    }
    
    public int Calculation(int a,int b,int c) {
        return a + b - c;
    }
    
    public float Calculation(float a,int b) {
        return a * b;
    }
    
    public double Calculation(float a,float b) {
        return a / b;
    }
    
    public static void main(String[] args) {
       Methodoverloading def = new Methodoverloading();
       System.out.println("The Addition of two numbers is : " + def.Calculation(12, 24));
       System.out.println("The Addition and Subtraction of three numbers is : " + def.Calculation(12, 36,12));
       System.out.println("The Product of two numbers is : " + def.Calculation(12, 5));
       System.out.println("The Division of two numbers is : " + def.Calculation(3, 9));
    }
    
}
