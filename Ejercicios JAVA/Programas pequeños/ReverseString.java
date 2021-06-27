package litleexercises;

public class ReverseString {

    public static void main(String[] args) {

        
        String str = "ABCD";
        String rev = "";
        
        /*
        //  1- Using String concatenation
        int len = str.length();
        for (int i = len - 1; i >= 0; i--) {
            rev = rev + str.charAt(i);
        }
        
        //Time : 1624763642818
        */
        
       // 2- Using character array
       /*
        char a[] = str.toCharArray();
        int len = a.length;
        
        for (int i = len - 1; i >= 0; i--) {
            rev = rev + a[i];
        }
        //Time: 1624764154791
        */
        // 3- Using String Buffer class
        
        StringBuffer sb = new StringBuffer(str);

        System.out.println("Reverse string is : " + sb.reverse());
        
        //Time : 1624764435342
        // System.out.println("Reverse string is "+rev);
        System.out.println("Tiempo estimado : " + System.currentTimeMillis());
    }

}
