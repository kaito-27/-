package quiz;

public class Java35 {
	public static void main(String[] args) {
		int customerKbnCode = 15;
		int customerKbnInnerCode = 7528;
		getCustomerCode(customerKbnCode, customerKbnInnerCode);


	}

	public static int getCustomerCode(int customerKbnCode, int customerKbnInnerCode){
		String str = String.valueOf(customerKbnCode);
		String str2 = String.valueOf(customerKbnInnerCode);

		System.out.println(str + str2);

		return customerKbnCode + customerKbnInnerCode;
	}

}
