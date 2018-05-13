import java.util.Arrays;
import java.util.Scanner;

public class SymmetricNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int val = Integer.parseInt(scan.nextLine());

        Integer[] array = new Integer[0];
        for (int i = 1; i <= val; i++) {
            int reversed = Integer.parseInt(new StringBuffer(String.valueOf(i)).reverse().toString());
            if (i == reversed)
                array = push(array, reversed);
        }
        Arrays.stream(array).forEach(System.out::println);
    }

    static Integer[] push(Integer[] array, int reversed) {
        Integer[] longer = new Integer[array.length + 1];
        System.arraycopy(array, 0, longer, 0, array.length);
        longer[array.length] = reversed;
        return longer;
    }
}