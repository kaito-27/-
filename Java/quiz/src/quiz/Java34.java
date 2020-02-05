package quiz;

public class Java34 {
	public static void main(String[] args) {
		int customerKbnCode = 15;
		int customerKbnInnerCode = 7528;
		getCustomerCode(customerKbnCode, customerKbnInnerCode);
		System.out.println(customerKbnCode + customerKbnInnerCode);
	}

	public static int getCustomerCode(int customerKbnCode, int customerKbnInnerCode){
	    return String.valueOf(customerKbnCode) + String.valueOf(customerKbnInnerCode);
	}

}
