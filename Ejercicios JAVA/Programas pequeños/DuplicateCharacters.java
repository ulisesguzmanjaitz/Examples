package javaapplication2;

class JavaApplication2 {

    //class String(String1)
    public static void main(String[] args) {
        String text1 = "HelloWorld".toUpperCase();
        String text2 = "hola a todos".toUpperCase();
        String str11 = "";
        String str12 = "";
        char[] char1 = text1.toCharArray();
        char[] char2 = text2.toCharArray();
        String letters = "";
        for (int i = 0; i < char1.length; i++) {
            if (!str11.contains(char1[i] + "")) {
                str11 += char1[i];
            }
        }
        for (int i = 0; i < char2.length; i++) {
            if (!str12.contains(char2[i] + "")) {
                str12 += char2[i];
            }
        }
        char[] ch11 = str11.toCharArray();
        char[] ch12 = str12.toCharArray();
        for (int i = 0; i < ch11.length; i++) {
            for (int j = 0; j < ch12.length; j++) {
                if (ch11[i] == ch12[j]) {
                    letters = letters + ch11[i];
                }
            }
        }
        System.out.println("Repeated letters : " + letters);
    }
}
