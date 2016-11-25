import java.util.EnumSet;

public class app {
public static void main(String[] arges){
	
	for(tuna people:tuna.values())
		System.out.printf("%s\t\t%s\t\t%s\n", people,people.getDesc(),people.getAge());
	
	System.out.println("--------------------");
	
	for(tuna people: EnumSet.range(tuna.beh, tuna.ali))
		System.out.printf("%s\t\t%s\t\t%s\n", people,people.getDesc(),people.getAge());
	
	
	
}
}
