package t4;
import java.util.Random;
public class main {



	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int bah[] = new int[10];
		//Random bb=new Random();
		
		for (int i = 0; i < 10; i++) {
			bah[i] = i;
			System.out.println(bah[i]);
		}
		System.out.println("--------------------------------------------------");
		for(int x:bah) 
			System.out.println(bah[x]);
		

	}

}
