import java.util.Scanner;

public class SumNIntegers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int val = Integer.parseInt(scan.nextLine());

        int sum = 0;
        for (int i = 0; i < val; i++){
            int num = Integer.parseInt(scan.nextLine());

            sum+= num;
        }
        System.out.println("Sum = "+sum);
    }
}

