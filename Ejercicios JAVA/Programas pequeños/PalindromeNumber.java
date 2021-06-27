package litleexercises;

import java.util.Scanner;

public class PalindromeNumber {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter a number :");
        int num = sc.nextInt();
        int orgNum = num;
        int rev = 0;
        while (num != 0) {
            rev = rev * 10 + num % 10;
            num = num / 10;
        }

        if (orgNum == rev) {
            System.out.println(orgNum + " Palindrome number");
        } else {
            System.out.println(orgNum + " Not palindrome number");
        }

        System.out.println(rev);
    }

}
