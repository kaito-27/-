package quiz;

import java.time.LocalDate;

public class Java63 {
	public static void main(String[] args) {
		LocalDate day = LocalDate.now();
		System.out.println("3か月前: " + day.minusMonths(3));

	}
}
