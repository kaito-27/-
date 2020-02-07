package quiz;

public class Java36 {
	public static void main(String[] args) {
		int hour = 10;
		int minute = 40;
		zikan(hour, minute);
		System.out.println(zikan(hour, minute));
	}

	public static String zikan(int hour, int minute) {

		if(hour<24 && minute<60) {
			return hour + ":" + minute;

		}else {
			return "エラー";

		}
	}
}