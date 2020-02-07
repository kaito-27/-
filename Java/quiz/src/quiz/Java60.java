package quiz;

import java.util.ArrayList;
import java.util.List;

public class Java60 {
	public static void main(String[] args) {
		List<String> fruits = new ArrayList<>();
		fruits.add("りんご");
		fruits.add("みかん");
		fruits.add("ぶどう");

		for(String name : fruits) {
			System.out.println(name);
		}
	}
}