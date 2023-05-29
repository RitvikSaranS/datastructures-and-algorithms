public class Main
{
	public static void main(String[] args) {
	    int [] arr = {5, 4, 3, 2, 1};
		quickSort(arr, 0, arr.length - 1);
		for(int e : arr){
		    System.out.println(e);
		}
	}
	public static void quickSort(int [] arr, int low, int high){
	    if(low >= high) return;
	    int s = low;
	    int e = high;
	    int m = s + (e - s)/2;
	    int pivot = arr[m];
	    while(s <= e){
	        while(arr[s] < pivot){
	            s++;
	        }
	        while(arr[e] > pivot){
	            e--;
	        }
	        if(s <= e){
	            int temp = arr[s];
	            arr[s] = arr[e];
	            arr[e] = temp;
	            s++;
	            e--;
	        }
	    }
	    quickSort(arr, low, e);
	    quickSort(arr, s, high);
	}
}


// This method ensures that in each pass the pivot ends up in the correct index
public class Main
{
	public static void main(String[] args) {
		int [] arr = {1, 4, 2, 5, 7, 6, 3};
		quickSort(arr, 0, arr.length - 1);
		for(int i : arr){
		    System.out.println(i);
		}
	}public static void quickSort(int [] arr, int low, int high){
	    if(low >= high) return;
	    int s = low;
	    int e = high - 1;
	    int pivot = arr[high];
	    while(s <= e){
	        while(arr[s] < pivot){
	            s++;
	        }
	        while(arr[e] > pivot){
	            e--;
	        }
	        if(s <= e){
	            int temp = arr[s];
	            arr[s] = arr[e];
	            arr[e] = temp;
	            s++;
	            e--;
	        }
	    }
	    int temp = arr[s];
	    arr[s] = arr[high];
	    arr[high] = temp;
	    System.out.println();
	    quickSort(arr, low, e - 1);
	    quickSort(arr, s + 1, high);
	}
}
