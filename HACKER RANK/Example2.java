
package hackerrankjava;


import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Example2 
{
    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args)
 {
     /* Example 1
        int N = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");
        if(N%2!=0)
        {
            System.out.println("Weird");
        }
        else if(N >=2&&N<=5)
        {
            System.out.println("Not Weird");
        }
        else if(N>=6 && N <= 20)
        {    
            System.out.println("Weird");
        }
        else if(N>=20)
        {
            System.out.println("Not Weird");
        }
        scanner.close();
    */
    //Example 2
        Scanner sc=new Scanner(System.in);
        int n = sc.nextInt();
        System.out.println((n%2==1 || (n>=6 && n<=20)) ? "Weird" : ((n>=2 && n <=5) || n > 20) ? "Not Weird" : "Weird");
            
 }  
        
}
