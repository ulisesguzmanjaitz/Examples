package litleexercises;

public class SwappingTwoNumbers {

    public static void main(String[] args) {
        int a = 10;
        int b = 20;
        System.out.println("Before swapping values are : " + a + " " + b);

        //Example 1   Time : 1624816593126
        /* int t = a;
        a = b;
        b = t;
         */
        //Example 2 Use + and -  Time : 1624816959454
        /*
        a=a+b;
        b=a-b;
        a=a-b;
         */
        //Example 3  a and b != 0  Time : 1624817341409
        /*
        a=a*b;
        b=a/b;
        a=a/b;
         */
        //Example 4 Single statement  Time : 1624817556983
        b = a + b - (a = b);

        System.out.println("After swapping values are : " + a + " " + b);
        System.out.println("Tiempo estimado : " + System.currentTimeMillis());
    }
}
