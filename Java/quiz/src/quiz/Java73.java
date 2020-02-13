package quiz;

import java.time.LocalDate;
import java.util.HashMap;
import java.util.Map;

public class Java73 {
	public static void main(String[] args) {
		Map<String, LocalDate> vocaloidsBirthdayMap = new HashMap<>();

		vocaloidsBirthdayMap.put("初音ミク", LocalDate.of(2007, 8, 31));
		vocaloidsBirthdayMap.put("鏡音リン", LocalDate.of(2007, 12, 27));
		vocaloidsBirthdayMap.put("鏡音レン", LocalDate.of(2007, 12, 27));
		vocaloidsBirthdayMap.put("巡音ルカ", LocalDate.of(2009, 1, 30));

		for(Map.Entry<String, LocalDate>entry : vocaloidsBirthdayMap.entrySet()) {
			System.out.println(entry.getKey() + "の誕生日は" + entry.getValue() + "です");
		}
	}
}
