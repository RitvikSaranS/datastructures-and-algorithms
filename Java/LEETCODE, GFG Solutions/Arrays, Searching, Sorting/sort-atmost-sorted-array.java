public class Main
{
	public static void main(String[] args) {
		int [] arr = {3, 2, 10, 4, 40};
		int target = 10;
		int s = 0;
		int e = arr.length - 1;
		int m = -1;
		while(s <= e){
		    m = s + (e - s)/2;
		    if(arr[m] == target) {
		        System.out.println(m);
		        return;
		    }
		    if(target > arr[m]){
		        if(target == arr[m - 1]) {
		            System.out.println(m - 1);
		            return;
		        }
		        else s = m + 1;
		    }else if(target < arr[m]){
		        if(target == arr[m + 1]) {
		            System.out.println(m + 1);
		            return;
		        }
		        else e = m - 1;
		    }
		}
		System.out.println(-1);
	}
}
