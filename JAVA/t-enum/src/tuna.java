
public enum  tuna {
bah("man","41"),
beh("claver","35"),
eli("woman","38"),
assa("dough","5"),
shah("brother","45"),
ali("dad","75"),
azam("mom","65");
	
	private final String  desc;
	private final String age;
	
	tuna(String description,String birthday){
		desc=description;
		age=birthday;
	}
	
	public String getDesc(){
		return desc;
	}
	public String getAge(){
		return age;
	}
	
}
