public class Main
{
	public static void main(String[] args) {
	    int [] arr = {-1, 2, -3, 4, 5, 6, -7, 8, 9};
	    rearrange(arr);
		for(int i : arr) System.out.println(i);
	}
	public static void rearrange(int [] arr){
	    int s = 0;
	    int e = 1;
	    while(s < arr.length && e < arr.length){
	        while(s < arr.length && arr[s] > 0) s+=2;
	        while(e < arr.length && arr[e] <= 0) e+=2;
	        if(s < arr.length && e < arr.length){
	            int temp = arr[s];
	            arr[s] = arr[e];
	            arr[e] = temp;
	        }
	    }
	}
}
