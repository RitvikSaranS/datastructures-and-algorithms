public class Main
{
	public static void main(String[] args) {
	    int [] arr = {-2, -3, 4, -1, -2, 1, 5, -3};
	    System.out.println(kadaneAlgo(arr));
	}
	public static int kadaneAlgo(int [] arr){
	    int sum = 0;
	    int max = arr[0];
	    for(int i = 0; i < arr.length; i++){
	        sum += arr[i];
	        if(sum > max) max = sum;
	        if(sum < 0) sum = 0;
	    }
	    return max;
	}
}
 