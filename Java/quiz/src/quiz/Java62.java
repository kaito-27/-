package quiz;

import java.time.LocalDate;

public class Java62 {
	public static void main(String[] args) {
		LocalDate today = LocalDate.now();
		System.out.println("日付: " + today);
		System.out.println("曜日: " + today.getDayOfWeek());
	}
}
