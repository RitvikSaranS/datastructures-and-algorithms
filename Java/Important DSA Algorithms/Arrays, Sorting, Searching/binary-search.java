public class Main
{
	public static void main(String[] args) {
	    int [] arr = { 1, 2, 3, 5, 8, 12 };
		System.out.println(binarysearch(arr, 5));
	}
	public static int binarysearch(int [] arr, int target){
	    int s = 0;
	    int e = arr.length - 1;
	    int m = -1;
	    while(s <= e){
	        m = s + (e - s)/2;
	        if(arr[m] > target) e = m - 1;
	        else if(arr[m] < target) s = m + 1;
	        else return m;
	    }
	    return -1;
	}
}

