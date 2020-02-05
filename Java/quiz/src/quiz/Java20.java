package quiz;

public class Java20 {
	public static void main(String[] args) {
		int x = 5;
		char c = '%';

        for (int i = 0; i < x; i++) {
            for (int j = 0; j < i + 1; j++) {
                System.out.print(c);
            }
            System.out.println();
        }

	}
}