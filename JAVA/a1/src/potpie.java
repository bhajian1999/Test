
public class potpie {
	private int month;
	private int day;
	private int year;
	
	public potpie(int m,int d,int y){
		month=m;
		day=d;
		year=y;
		
		System.out.printf("The Constrauctor for this is %s\n", this);
	}
	public String toString(){
		return String.format("%02d/%02d/20%02d", month,day,year);
	}

}
