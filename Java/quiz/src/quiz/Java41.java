package quiz;

public class Java41 {
	public static void main(String[] args) {
		double measuredSeismicIntensity = 1;
		JMAShindo(measuredSeismicIntensity);

	}

	public static String JMAShindo(double measuredSeismicIntensity) {


		if(measuredSeismicIntensity<0.5) {
			return "0";
		}
		else if(measuredSeismicIntensity<1.5) {
			return "1";
		}
		else if(measuredSeismicIntensity<2.5) {
			return "2";
		}
		else if(measuredSeismicIntensity<3.5) {
			return "3";
		}
		else if(measuredSeismicIntensity<4.5) {
			return "4";
		}
		else if(measuredSeismicIntensity<5.0) {
			return "5弱";
		}
		else if(measuredSeismicIntensity<5.5) {
			return "5強";
		}
		else if(measuredSeismicIntensity<6.0) {
			return "6弱";
		}
		else if(measuredSeismicIntensity<6.5) {
			return "6強";
		}
		else
			return "7";
	}


}
