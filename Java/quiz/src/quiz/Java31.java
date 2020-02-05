package quiz;

public class Java31 {
	public static void main(String[] args) {
		int x = num(13);
		System.out.println(x);
	}

	public static int num(int x) {
		if(x % 2 == 0) {
			return x * 2;
		}else {
		return x;
		}
	}
}