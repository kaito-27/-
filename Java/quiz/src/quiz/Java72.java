package quiz;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class Java72 {
	public static void main(String[] args) {
		LocalDateTime ldt = LocalDateTime.now();


		DateTimeFormatter datetimeformatter = DateTimeFormatter.ofPattern("yyyy/M/d(E)");


		String datetimeformated = datetimeformatter.format(ldt);

		System.out.println(datetimeformated);
	}

}
