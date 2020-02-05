package quiz;

public class Java9 {
	public static void main (String[] args) {
		int year = 2000;

		if(year % 4 == 0){
			if(year % 400 == 0 || year % 100 != 0) {
				System.out.println("うるう年です");
			}else {
				System.out.println("うるう年じゃないです");
			}
		}
	}

}
