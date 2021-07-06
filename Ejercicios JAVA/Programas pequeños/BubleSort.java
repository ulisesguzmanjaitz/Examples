package litleexercises;

public class BubleSort {

    public static void main(String[] args) {
        int aux;
        boolean cambios = false;
        int array[] = {1, 3, 7, 2, 16, 4};
        while (true) {
            cambios = false;
            for (int i = 1; i < array.length; i++) {
                if (array[i] < array[i - 1]) {
                    aux = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = aux;
                    cambios = true;
                }

            }
            if (cambios == false) {
                break;
            }
        }
        for (int i = 0; i < array.length; i++) {
            System.out.println(array[i]);

        }
    }

}
