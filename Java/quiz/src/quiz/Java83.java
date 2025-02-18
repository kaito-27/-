package quiz;

import java.util.ArrayList;

public class Java83 {
	public static void main(String[] args) {
		ArrayList<Human83> human = new ArrayList<>();
		human.add(new Human83("太郎","男",170.2));
		human.add(new Human83("次郎","男",168.9));
		human.add(new Human83("花子","女",150.2));
		human.add(new Human83("良子","女",155.4));
		human.add(new Human83("三郎","男",171.8));
		human.add(new Human83("順子","女",149.7));

		human.stream()
        .filter(x -> x.getSex().equals("女"))
        .map(x -> x.getHeight())
        .mapToDouble(x -> x)
        .average()
        .ifPresent(System.out::println);
	}
}

class Human83{
	private String name;
	private String sex;
	private double height;

	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}

	public String getSex() {
		return sex;
	}
	public void setSex(String sex) {
		this.sex = sex;
	}

	public double getHeight() {
		return height;
	}
	public  void setHeight(double height) {
		this.height = height;
	}

	public Human83(String name, String sex, double height) {
		this.name = name;
		this.sex = sex;
		this.height = height;
	}
}