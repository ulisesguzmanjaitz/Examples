package litleexercises;

import java.util.Scanner;

public class PalindromeString {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter you String :");

        String str = sc.next();
        String orgString = str;
        String rev = "";

        int len = str.length();

        for (int i = len - 1; i >= 0; i--) {
            rev = rev + str.charAt(i);
        }
        if (orgString.equals(rev)) {
            System.out.println(orgString + " : Is palindrome String");
        } else {
            System.out.println(orgString + " : Is not palindrome String");
        }

    }
}
