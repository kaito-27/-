package quiz;

public class Java45 {
	public static void main(String[] args) {
		Human45 human = new Human45();
		human.setName("福田魁斗");
		human.setAge(21);
	}
}

class Human45{
    private String name;
    private int age;

    public void setName(String name){
        this.name = name;
    }

    public String getName(){
        return name;
    }

    public void setAge(int age){
        this.age = age;
    }

    public int getAge(){
        return age;
    }
}
