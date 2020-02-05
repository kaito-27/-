package quiz;

public class Java25 {
	public static void main(String[] args) {
		int[] list = { 125, 87, 204, 69, 112, 100 };
			for(int i=0; i<list.length; i++) {
				if(list[i]>=100) {
					System.out.println(list[i]*2);
				}
			}
	}
}
