package quiz;

public class Java19 {
	public static void main(String[] args) {
		int x = 1;

		if(x==2 || x==3) {
			System.out.println("素数です");
		}else if(x%2==0 || x%3==0 || x==1) {
			System.out.println("素数ではありません");
		}else {
			System.out.println("素数です");
		}
	}
}
