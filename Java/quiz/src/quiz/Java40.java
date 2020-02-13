package quiz;

public class Java40 {
	public static void main(String[] args) {
		String base = enki("グアニン");
		System.out.println(base);
	}

	public static String enki(String base) {
		if(base.equals("グアニン") || base.equals("G")) {
			return"シトシン";
		}else if(base.equals("シトシン") || base.equals("C")) {
			return"グアニン";
		}else if(base.equals("アデニン") || base.equals("A")) {
			return"チミン";
		}else if(base.equals("チミン") || base.equals("T")) {
			return"アデニン";
		}

		return base;



	}
}
