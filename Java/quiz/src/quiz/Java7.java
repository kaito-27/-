package quiz;

public class Java7 {
	public static void main(String[] args) {
		int score = 90;

		if(score>=80) {
			System.out.println("優");
		}else if(score>=70) {
			System.out.println("良");
		}else if(score>=60) {
			System.out.println("可");
		}else if(score<=59) {
			System.out.println("不可");
		}

	}
}
