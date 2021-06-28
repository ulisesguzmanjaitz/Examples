package litleexercises;

public class CountNumbers {

    public static void main(String[] args) {

        int num = 9875321;
        int count = 0;
        while (num > 0) {
            num = num / 10;
            count++;
        }
        System.out.println("Number of characters :  " + count);

    }
}
