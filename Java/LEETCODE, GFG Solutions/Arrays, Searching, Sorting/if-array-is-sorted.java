public class Main
{
	public static void main(String[] args) {
	    int [] arr = {1, 2, 3};
		System.out.println(isSorted(arr, 0));
	}
	public static boolean isSorted(int [] arr, int ind){
	    if(ind == arr.length - 1) return true;
	    if(arr[ind] <= arr[ind+1]) return isSorted(arr, ind+1);
	    else return false;
	}
}
