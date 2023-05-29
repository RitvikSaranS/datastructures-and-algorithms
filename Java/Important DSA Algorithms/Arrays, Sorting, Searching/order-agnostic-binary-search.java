public class Main
{
	public static void main(String[] args) {
		int [] arr1 = {2, 3, 4, 5, 6};
		int [] arr2 = {8, 5, 3, 2, 1};
		System.out.println(orderagnosticBS(arr1, 6));
		System.out.println(orderagnosticBS(arr2, 5));
	}
	public static int orderagnosticBS(int [] arr, int target){
	    int s = 0;
	    int e = arr.length - 1;
	    boolean asc = false;
	    //check if ascending
	    if(arr[e] > arr[s]) asc = true;
	    int m = -1;
	    while(s <= e){
	        m = s + (e - s)/2;
	        if(arr[m] == target) return m;
	        //ascending case
	        if(asc){
	            if(arr[m] < target) s = m + 1;
	            else e = m - 1;
	        //descending case
	        }else {
	            if(arr[m] > target) s = m + 1;
	            else e = m - 1;
	        }
       }
   return -1;
   }
}
