package quiz;

public class Java78 {
	public static void main(String[] args) {
		SuperHuman human = new SuperHuman();
        human.sleep();
        human.fly();
        human.run();
	}
}

class Human78{
    public void run(){
        System.out.println("走る");
    }
}

class SuperHuman extends Human78{
    public void sleep(){
        System.out.println("寝る");
    }
    public void fly(){
        System.out.println("飛ぶ");
    }
    public void run(){
        System.out.println("めっちゃ速く走る");
    }
}
