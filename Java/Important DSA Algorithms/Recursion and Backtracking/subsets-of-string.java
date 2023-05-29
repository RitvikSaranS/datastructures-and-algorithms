public class Main
{
	public static void main(String[] args) {
		subsets("", "abc");
	}
	public static void subsets(String p, String un){
	    if(un.isEmpty()) {
	        System.out.println(p);
	        return;
	    }
	    subsets(p + un.charAt(0), un.substring(1));
	    subsets(p , un.substring(1));
	}
}
