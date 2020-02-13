package quiz;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class Java72 {
	public static void main(String[] args) {
		LocalDateTime LDT = LocalDateTime.now();


		DateTimeFormatter datetimeformatter = DateTimeFormatter.ofPattern("yyyy/M/d(E)");


		String datetimeformated = datetimeformatter.format(LDT);

		System.out.println(datetimeformated);
	}

}
