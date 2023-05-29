public class Main
{
	public static void main(String[] args) {
		int [] arr = {3,7,7,10,10};
		int s = 0;
		int e = arr.length - 1;
		int m = -1;
		while(s < e){
		    m = s + (e - s)/2;
		    if((m % 2 == 1 && arr[m] == arr[m - 1]) || (m % 2 == 0 && arr[m] == arr[m + 1])){
		        s = m + 1;
		    }else {
		        e = m;
		    }
		}
	    System.out.println(arr[e]);
	}
}
