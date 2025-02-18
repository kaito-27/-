package quiz;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;

public class Java80 {
	public static void main(String[] args) {

		ArrayList<City> city = new ArrayList<>();

		city.add(new City("高槻市", 348_369));
		city.add(new City("東大阪市", 495_011));
		city.add(new City("茨木市", 282_671));
		city.add(new City("吹田市", 381_038));
		city.add(new City("豊中市", 399_731));
		city.add(new City("八尾市", 266_296));

		Collections.sort(city, Comparator.reverseOrder());
        for(City c : city) {
        	System.out.println(c.getName() + ";" + c.getPopulation());
        }
	}
}

class City implements Comparable<City> {
	private String name;
	private int population;

	public City(String name, int population) {
		this.name = name;
		this.population = population;
	}

	public String getName() {
		return name;
	}

	public void  setName(String name) {
		this.name = name;
	}

	public int getPopulation() {
		return population;
	}

	public void setPopulation(int population) {
		this.population = population;
	}

	@Override
	public int compareTo(City other) {
		return this.population - other.getPopulation();
	}
}