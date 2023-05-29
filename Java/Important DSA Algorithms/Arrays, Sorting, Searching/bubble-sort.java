//iteration
public class Main
{
	public static void main(String[] args) {
	    int [] arr = {4, 2, 5, 1, 8};
	    bubbleSort(arr);
	    for(int i : arr){
	        System.out.println(i);
	    }
	}
	public static void bubbleSort(int [] arr){
	    int m = arr.length - 1;
	    while(m >= 1){
	        for(int i = 0; i < m - 1; i++){
	            if(arr[i] > arr[i + 1]){
	                int temp = arr[i];
	                arr[i] = arr[i + 1];
	                arr[i + 1] = temp;
	            }
	        }
	    m--;
	    }
	}
}


//recursion
public class Main
{
	public static void main(String[] args) {
	    int [] arr = {1, 20, 9, 0, 12};
	    bubbleSort(arr, arr.length - 1);
	    for(int i : arr){
		System.out.println(i);
	    }
	}
	public static void bubbleSort(int [] arr, int end){
	    if(end == 0) return;
	    int i = 0;
	    while(i < end){
	        if(arr[i] > arr[i+1]) {
	            int temp = arr[i];
	            arr[i] = arr[i + 1];
	            arr[i + 1] = temp;
	        }
	        i++;
	    }
	    bubbleSort(arr, end - 1);
	}
}
