//If the array is not rotated this wont work.

// Without duplicates
public class Main
{
	public static void main(String[] args) {
	    int [] arr = {2, 3, 4, 5, 1};
	    System.out.println(findPivot(arr));
	}
	public static int findPivot(int [] arr){
	    int s = 0;
	    int e = arr.length - 1;
	    int m = -1;
	    while(s <= e){
	        m = s + (e - s)/2;
	        if(e > m && arr[m] > arr[m + 1]) return m;
	        else if(s < m && arr[m] < arr[m - 1]) return m - 1;
	        else if(arr[m] > arr[s]) s = m + 1;
	        else e = m - 1;
	    }
	    return -1;
	}
}

// With Duplicates
public class Main
{
	public static void main(String[] args) {
	    int [] arr = {2, 2, 3};
	    System.out.println(findPivotDuplicates(arr));
	}
	public static int findPivotDuplicates(int [] arr){
	    int s = 0;
	    int e = arr.length - 1;
	    int m = -1;
	    while(s <= e){
	        m = s + (e - s)/2;
	        if(e > m && arr[m] > arr[m + 1]) return m;
	        else if(s < m && arr[m] < arr[m - 1]) return m - 1;
	        while(s < e && arr[s] == arr[m] && arr[e] == arr[m]){
	            if(e != (arr.length - 1) && arr[e] > arr[e + 1]) return e;
	            s++;
	            e--;
	        }
	        if(arr[m] > arr[s]) s = m + 1;
	        else e = m - 1;
	    }
	    return -1;
	}
}