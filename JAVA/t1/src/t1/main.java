package t1;

import java.util.Scanner;
class box{
	int a,b,c;
}
public class main {
	public static void main(String[] args){

		System.out.println("Hello Word!");
		
		box mybox=new box();
		int i,j, k;
		i = 10;
		j=1;
		k=i < 0 ? i : j; // get absolute value of i
		System.out.print("Absolute value of ");
		System.out.println(i + " " + j+ " "+k);
	
		
		Scanner reader = new Scanner(System.in);  // Reading from System.in
		System.out.println("Enter a number: ");
	   
		
	}
}

