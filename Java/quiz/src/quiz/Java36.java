package quiz;

public class Java36 {
	public static void main(String[] args) {
		int hour = 10;
		int minute = 40;
		zikan(hour, minute);
	}

	public static String zikan(int hour, int minute) {

		if(hour<24 && minute<60) {
			System.out.println(hour + ":" + minute);
			return hour + ":" + minute;

		}else {
			System.out.println("エラー");
			return "エラー";

		}
	}
}