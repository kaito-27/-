package quiz;

import java.math.BigDecimal;
import java.math.RoundingMode;

public class Java85 {
	public static void main(String[] arfs) {

		BigDecimal num = new BigDecimal("4.1");
		BigDecimal num2 = new BigDecimal("93.03");
		System.out.println(num.multiply(num2));

		BigDecimal a = BigDecimal.valueOf(1);
		BigDecimal b = BigDecimal.valueOf(3);

		BigDecimal value = a.divide(b, 3, RoundingMode.HALF_UP);
		System.out.println(value);
	}
}
