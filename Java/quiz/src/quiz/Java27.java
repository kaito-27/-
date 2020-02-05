package quiz;

public class Java27 {
	public static void main(String[] args) {
		String weather = "晴れ";
		tenki(weather);

	}
	public static void tenki(String weather) {
		if(weather.equals("晴れ")) {
			System.out.println("いい天気ですね。");
		}else if(weather.equals("曇り")) {
			System.out.println("どんよりしていますね。");
		}else if(weather.equals("雨")) {
			System.out.println("明日は晴れるといいですね。");
		}else if(weather.equals("雪")) {
			System.out.println("雪合戦しようぜ。");
		}else {
			System.out.println("不正な入力です");
		}
	}
}
