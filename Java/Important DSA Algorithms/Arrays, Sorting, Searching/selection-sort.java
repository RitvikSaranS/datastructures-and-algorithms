//iterative
public class Main
{
	public static void main(String[] args) {
	    int [] arr = {4, 2, 5, 1, 8};
	    selectionSort(arr);
	    for(int i : arr){
	        System.out.println(i);
	    }
	}
	public static void selectionSort(int [] arr){
	    int m = arr.length - 1;
	    while(m >= 1){
	        int index = 0;
	        for(int i = 0; i <= m; i++){
	            if(arr[i] > arr[index]){
	                index = i;
	            }
	        }
	        int temp = arr[index];
	        arr[index] = arr[m];
	        arr[m] = temp;
	        m--;
	    }
	}
}
