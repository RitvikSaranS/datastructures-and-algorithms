public class Main
{
	public static void main(String[] args) {
		towerOfHanoi(3, 'A', 'B', 'C');
	}
	public static void towerOfHanoi(int n, char _from, char _to, char _temp){
	    if(n == 1) {
	        System.out.println(" move " + n + " from " + _from + " to " + _to);
	        return;
	    }
	    towerOfHanoi(n - 1, _from, _temp, _to);
	    System.out.println(" move " + n + " from " + _from + " to " + _to);
	    towerOfHanoi(n - 1, _to, _temp, _from);
	}
}
