package litleexercises;

public class EvenDigitsAndOddDigits {

    public static void main(String[] args) {

        int num = 987623;
        int even_count = 0;
        int odd_count = 0;

        while (num > 0) {
            int rem = num % 10;
            if (rem % 2 == 0) {
                even_count++;
            } else {
                odd_count++;
            }

            num = num / 10;
        }
        System.out.println("Even count is " + even_count + " and odd count is " + odd_count);
    }
}
