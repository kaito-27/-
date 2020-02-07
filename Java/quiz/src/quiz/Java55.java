package quiz;

import java.util.ArrayList;

public class Java55 {
	public static void main(String[] args) {
		Human h1 = new Human("福田魁斗",21);

		ArrayList<Human> list = new ArrayList<Human>();
		list.add(h1);

		for(int i = 0; i < list.size(); i++) {
			Human value =list.get(i);
			System.out.println(i + "番目に格納されたの人の名前は" + h1 + "です。");
		}
	}
}
