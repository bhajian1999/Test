
public class aa {

	public static void main(String[] args) {
		
		tuna tunaobj1=new tuna();
		tuna tunaobj2=new tuna(3);
		tuna tunaobj3=new tuna(3,12);
		tuna tunaobj4=new tuna(3,12,34);
		System.out.printf("%s\n", tunaobj1.toMilitary());
		System.out.printf("%s\n", tunaobj2.toMilitary());
		System.out.printf("%s\n", tunaobj3.toMilitary());
		System.out.printf("%s\n", tunaobj4.toMilitary());

		
		
		potpie potobj=new potpie(4, 5, 16);
		

	}

}
