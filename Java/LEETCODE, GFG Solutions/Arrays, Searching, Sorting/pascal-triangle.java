public class Main
{
	public static void main(String[] args) {
		pascalsTriangle_nth_row(5);
		pascalsTriangle_nth_row_mth_element(5, 1);
	}
	public static void pascalsTriangle_nth_row(int n){
	    if(n == 1) {
	        System.out.println("1");
	        return;
	    }
	    n -= 1;
	    System.out.print("1 ");
	    int temp = 1;
	    for(int i = 1; i <= n; i++){
	        temp = (temp * (n - i + 1) / i);
	        System.out.print(temp + " ");
	    }
	    System.out.println();
	}
	public static void pascalsTriangle_nth_row_mth_element(int n, int m){
	    n -= 1;
	    int temp = 1;
	    for(int i = 1; i < m; i++){
	        temp = (temp * (n - i + 1) / i);
	    }
	    System.out.println(temp);
	}
}
