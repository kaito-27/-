package quiz;


import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class Java59 {
	public static void main(String[] args) {
		List<String> arashi = new ArrayList<String>();
		arashi.add("相葉雅紀");
		arashi.add("松本潤");
		arashi.add("二宮和也");
		arashi.add("大野智");
		arashi.add("櫻井翔");

		List<String> smap = new ArrayList<String>();
		smap.add("中居正広");
		smap.add("草彅剛");
		smap.add("木村拓哉");
		smap.add("香取慎吾");
		smap.add("稲垣吾郎");

		List<String> tokio = new  ArrayList<String>();
		tokio.add("国分太一");
		tokio.add("城島茂");
		tokio.add("松岡昌宏");
		tokio.add("長瀬智也");

		Map<String, String> Johnnys = new HashMap<>();
		String i = "嵐";
		for(String str : arashi) {
            Johnnys.put(i, str);
		}

		String j = "SMAP";
		for(String str : arashi) {
            Johnnys.put(j, str);
		}

		String k = "TOKIO";
		for(String str : arashi) {
            Johnnys.put(k, str);
		}






	}
}
