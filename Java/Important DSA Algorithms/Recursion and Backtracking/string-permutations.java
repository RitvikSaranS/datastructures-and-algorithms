public class Main
{
	public static void main(String[] args) {
		permutation("", "abc");
	}
	public static void permutation(String p, String up){
	    if(up.isEmpty()) {
	        System.out.println(p);
	        return;
	    }
	    char c = up.charAt(0);
	    for(int i = 0; i <= p.length(); i++){
	        String f = p.substring(0, i);
	        String l = p.substring(i, p.length());
	        permutation(f + c + l, up.substring(1));
	    }
	}
}
