package quiz;

import java.time.LocalDate;
import java.util.ArrayList;

public class Java66 {
	public static void main(String[] args) {
		ArrayList<String> animes = getBroadcastedAnimes(LocalDate.of(1985,5,10));
		System.out.println(animes);
	}

	public static ArrayList<String> getBroadcastedAnimes(LocalDate date){
		 LocalDate Sazae = LocalDate.of(1969,  10,  5);
		 LocalDate Doraemon = LocalDate.of(1979,  4,  2);
		 LocalDate Maruko = LocalDate.of(1990, 1, 7);
		 LocalDate Shinnosuke = LocalDate.of(1992, 4, 13);

		 ArrayList<String> animes = new ArrayList<String>();

		 if(date.isEqual(Sazae) || date.isAfter(Sazae)) {
			 animes.add("サザエさん");
		 }
		 if(date.isEqual(Doraemon) || date.isAfter(Doraemon)) {
			 animes.add("ドラえもん");
		 }
		 if(date.isEqual(Maruko) || date.isAfter(Maruko)) {
			 animes.add("ちびまる子ちゃん");
		 }
		 if(date.isEqual(Shinnosuke) || date.isAfter(Shinnosuke)) {
			 animes.add("クレヨンしんちゃん");
		 }
		 return animes;
	}
}
