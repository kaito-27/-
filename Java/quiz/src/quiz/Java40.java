package quiz;

public class Java40 {
	public static void main(String[] args) {
		String base = enso("T");
		System.out.println(base);
	}

	public static String enso(String base) {
		if(base.equals("グアニン")) {
			return"シトシン";
		}else if(base.equals("G")) {
			return"シトシン";
		}else if(base.equals("シトシン")) {
			return"グアニン";
		}else if(base.equals("C")) {
			return"グアニン";
		}else if(base.equals("アデニン")) {
			return"チミン";
		}else if(base.equals("A")) {
			return"チミン";
		}else if(base.equals("チミン")) {
			return"アデニン";
		}else if(base.equals("T")) {
			return"アデニン";
		}

		return base;



	}
}
