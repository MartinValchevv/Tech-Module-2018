import java.util.Arrays;
import java.util.Scanner;

public class ThreeIntegersSum {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] array = Arrays.stream(scan.nextLine().split(" "))
                .map(Integer::parseInt).mapToInt(i->i).toArray();

        if (array[0]+array[1]==array[2])
            System.out.printf("%d + %d = %d",Math.min(array[0],array[1]),Math.max(array[0],array[1]),array[2]);
        else if(array[1]+array[2]==array[0])
            System.out.printf("%d + %d = %d",Math.min(array[1],array[2]),Math.max(array[1],array[2]),array[0]);
        else if (array[0]+array[2]==array[1])
            System.out.printf("%d + %d = %d",Math.min(array[0],array[2]),Math.max(array[0],array[2]),array[1]);
        else
            System.out.println("No");
    }
}

