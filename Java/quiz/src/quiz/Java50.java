package quiz;

public class Java50 {

}

class Human50{
	private String name;
    private int age = 0;

    public Human50(String name, int age) {
    	this.name = name;
    	this.age = age;
    }
    public Human50(String name) {
    	this.name = name;
    }

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
