package quiz;

public class Java38 {
	public static void main(String[] args) {
		int year = 2020;
		String[] Eto = {
                "子年", "丑年", "寅年", "卯年", "辰年", "巳年",
                "午年", "未年",
                "申年", "酉年", "戌年", "亥年"};
        int i = (year + 8) % 12;
        System.out.println(Eto[i] + "です。");

	}
}