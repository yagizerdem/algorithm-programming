import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Scanner;


// Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`,
// then press Enter. You can now see whitespace characters in your code.
public class Main {


    public static void main(String[] args) {


        Scanner scanner = new Scanner(System.in);
        int soruno = scanner.nextInt();

        switch (soruno) {
            case 1:
                String sayi1 = "936";
                String sayi2 = "899";
                String sum = "";
                int counter = 1, elde = 0;
                ;
                for (int i = sayi1.length() - 1; i >= 0; i--) {
                    int basamaktoplamı = 0;

                    if (sayi2.length() - counter >= 0) {
                        basamaktoplamı = Character.getNumericValue(sayi1.charAt(i)) + Character.getNumericValue(sayi2.charAt(sayi2.length() - counter)) + elde;
                    } else {
                        basamaktoplamı = Character.getNumericValue(sayi1.charAt(i)) + elde;
                    }
                    elde = 0;
                    if (basamaktoplamı >= 10) {
                        if (i == 0) {
                            String s = Integer.toString(basamaktoplamı);
                            String temp = "";
                            temp += Character.toString(s.charAt(1));
                            temp += Character.toString(s.charAt(0));
                            basamaktoplamı = Integer.parseInt(temp);
                        } else {
                            basamaktoplamı = basamaktoplamı - 10;
                        }
                        elde = 1;
                    }
                    sum += basamaktoplamı;
                    counter++;
                }

                String result = "";
                for (int i = sum.length() - 1; i >= 0; i--) {
                    result += sum.charAt(i);
                }
                System.out.println(result);
                break;

            case 2:
                String input = "((lajf)(flaj)";
                int count = 0;
                for(int i = 0 ; i<input.length() ; i++){
                    if(input.charAt(i) == '('){
                        count++;
                    }
                    if(input.charAt(i) == ')'){
                        count--;
                    }
                }
                if(count<0 || count>0){
                    System.out.println("hatalı");
                }else{
                    System.out.println("hatasız");
                }

                break;
        }


    }

}