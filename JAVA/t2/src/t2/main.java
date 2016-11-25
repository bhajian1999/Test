package t2;

/* This program demonstrates the difference between
public and private.
*/
class Test {
	int a; // default access
	public int b; // public access
	private int c; // private access
	
	// methods to access c

	void sssetc(int i) { // set c's value
		c = i;
	}
	

	int ggetc() { // get c's value
		return c;
	}
}

class main {

	public static void main(String args[]) {
		Test ob = new Test();
		// These are OK/ a and b may be accessed directly
		ob.a = 10;
		ob.b = 20;
		// This is not OK and will cause an error
		// ob.c = 100; // Error!
		// You must access c through its methods
		ob.sssetc(100); // OK
		//ob.setd(200);
		System.out.println("a/ b/ and c :" + ob.a + " " + ob.b + " " + ob.ggetc()+"\n"+ob.ggetc());
	}
}