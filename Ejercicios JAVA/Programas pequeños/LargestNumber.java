package litleexercises;

import java.util.Scanner;

public class LargestNumber {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter first number :");
        int a = sc.nextInt();
        System.out.println("Enter second number :");
        int b = sc.nextInt();
        System.out.println("Enter third number :");
        int c = sc.nextInt();

        //Example 1
        /*
        if (a > b && a > c) {
            System.out.println(a + " is largest number");
        } else if (b > a && b > c) {
            System.out.println(b + " is largest number");
        } else {
            System.out.println(c + " is largest number");
        }
         */
        int largest = a > b ? a : b; //largest of a & b
        largest = c > largest ? c : largest;
        System.out.println(largest + " is largest number");

    }
}
