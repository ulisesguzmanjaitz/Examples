package litleexercises;

public class InsertionSort {

    public static void main(String[] args) {
        int aux, contador1, contador2;
        int array[] = {6, 2, 87, 1};
        for (contador1 = 1; contador1 < array.length; contador1++) {
            aux = array[contador1];
            for (contador2 = contador1-1; contador2 >= 0 && array[contador2] > aux; contador2--) {
                array[contador2 + 1] = array[contador2];
                array[contador2] = aux;

            }

        }
        for (int i = 0; i < array.length; i++) {
            System.out.println(array[i]);

        }
    }
}
