package quiz;

class Human{
    private String name = null;
    private int age = 0;

    public Human(String name, int age) {}
    public Human(String name) {}

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