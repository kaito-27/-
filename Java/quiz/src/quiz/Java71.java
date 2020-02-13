package quiz;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;

public class Java71 {
	public static void main(String[] args) {
		String hiduke = "2020/2/12";
        DateTimeFormatter datetime = DateTimeFormatter.ofPattern("yyyy/M/d");
        LocalDate date = LocalDate.parse(hiduke, datetime);
        System.out.println(date);
	}
}
