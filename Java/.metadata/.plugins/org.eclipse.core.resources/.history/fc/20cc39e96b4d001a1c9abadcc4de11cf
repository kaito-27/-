package quiz;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Java76 {
    public static void main(String[] args) throws Exception {
    	Random rd = new Random();
        List<Sample> list = new ArrayList<>();
        for(int i = 0; i < 100; i++){
            list.add(new Sample(rd.nextInt(100)));
        }
        System.out.println((new Sample()).getCounter());
    }
}
class Sample{
    private static int counter = 0;

    public Sample(){}

    public Sample(int i){
        if(i >= 50) {
            counter += 1;
        }
    }

    public int getCounter(){
        return counter;
    }
}
