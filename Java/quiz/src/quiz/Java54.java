package quiz;

import java.util.ArrayList;

public class Java54 {
	public static void main(String[] args) {
		ArrayList<String> offices = new ArrayList<String>();

		offices.add("Excel");
		offices.add("Word");
		offices.add("PowerPoint");

		for(int i = 0; i < offices.size(); i++) {
			offices.get(i);
		}
	}
}
