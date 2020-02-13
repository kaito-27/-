package quiz;

import java.time.LocalDate;
import java.time.MonthDay;
import java.util.Random;

public class Java70 {
	public static void main (String[] args) {
		System.out.println(getFortune("福田 魁斗", LocalDate.of(1998,  2,  27)));
	}

	public static String getSeiza(LocalDate birthday){
		MonthDay md = MonthDay.from(birthday);
		if(md.isBefore(MonthDay.of(1, 20))) {
			return "やぎ座";
		}
		else if(md.isBefore(MonthDay.of(2, 19))) {
			return "みずがめ座";
		}
		else if(md.isBefore(MonthDay.of(3, 21))) {
			return "うお座";
		}
		else if(md.isBefore(MonthDay.of(4, 20))) {
			return "おひつじ座";
		}
		else if(md.isBefore(MonthDay.of(5,21))) {
			return "おうし座";
		}
		else if(md.isBefore(MonthDay.of(6, 22))) {
			return "ふたご座";
		}
		else if(md.isBefore(MonthDay.of(7, 23))) {
			return "かに座";
		}
		else if(md.isBefore(MonthDay.of(8, 23))) {
			return "しし座";
		}
		else if(md.isBefore(MonthDay.of(9, 23))) {
			return "おとめ座";
		}
		else if(md.isBefore(MonthDay.of(10, 24))) {
			return "てんびん座";
		}
		else if(md.isBefore(MonthDay.of(11, 23))) {
			return "さそり座";
		}
		else if(md.isBefore(MonthDay.of(12,  22))){
			return "いて座";
		}
		else {
			return "やぎ座";
		}

	}

	public static String getFortune(String name, LocalDate birthday) {
		Random r = new Random();
		int num= r.nextInt(4);
		String fortune = new String[] {"大吉", "中吉", "吉", "凶"}[num];

		StringBuilder sb = new StringBuilder();
		sb.append("こんにちは、");
		sb.append(name);
		sb.append("さん! ");
		sb.append(getSeiza(birthday));
		sb.append("のあなたの今日の運勢は");
		sb.append(fortune);
		sb.append("! ラッキーアイテムはたわし!!!");
		return sb.toString();
	}
}
