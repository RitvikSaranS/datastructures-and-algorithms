public class Main
{
	public static void main(String[] args) {
	    int [] arr = {1, 2, 5, 7, 8, 8, 8, 9, 13};
	    int target = 8;
	    int s = 0;
	    int e = arr.length - 1;
	    int m = -1;
	    while(s <= e){
	        m = s + (e - s)/2;
	        if(arr[m] == target){
	            firstAndLast(arr, m + 1, e, target, true);
	            firstAndLast(arr, s, m - 1, target, false);
	            return;
	        }else if(arr[m] > target) e = m - 1;
	        else if(arr[m] < target) s = m + 1;
	    }
	    System.out.println("element not found");
	}
	public static void firstAndLast(int [] arr, int s, int e, int target, boolean check){
	    int m = -1;
	    while(s<=e){
	        m = s + (e - s)/2;
	        if(arr[m] == target){
	            if(check && m < e) firstAndLast(arr, m + 1, e, target, check);
	            else if(!check && s < m) firstAndLast(arr, s, m - 1, target, check);
	            return;
	        }else if(arr[m] > target) e = m - 1;
	        else s = m + 1;
	    }
	    if(check) System.out.println("Right index is " + e);
	    else System.out.println("Left index is " + s);
	}
}