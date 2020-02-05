package quiz;

public class java8 {
	public static void main (String[] args) {
		int score1 = 59;
		int score2 = 70;

		if(score1>=60&&score2>60) {
			System.out.println("合格");
		}else if(score1+score2>=130) {
			System.out.println("合格");
		}else if(score1+score2>=100&&score1>=90||score2>=90) {
			System.out.println("合格");
		}else {
			System.out.println("不合格");
		}
}

}
