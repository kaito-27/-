package quiz;

public class Java84 {
	public static void main(String[] args) {
		Employee e = new Employee("匿名太郎");
		String str = e.toString();

		System.out.println(str);
	}
}

class Employee {
	String name;

	public Employee(String name) {
		this.name = name;
	}

	public String toString() {
		return name;
	}

}
