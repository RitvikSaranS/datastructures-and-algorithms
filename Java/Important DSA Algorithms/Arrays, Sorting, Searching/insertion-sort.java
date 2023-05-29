public class Main
{
	public static void main(String[] args) {
	    int [] arr = {12, 2, 9, 5, 4, 1};
	    insertionSort(arr);
	    for(int i : arr){
	        System.out.println(i);
	    }
	}
	public static void insertionSort(int [] arr){
	    int m = 1;
	    while(m <= arr.length - 1){
	        for(int i = m; i > 0; i--){
	            if(arr[i] < arr[i-1]){
	                int temp = arr[i];
	                arr[i] = arr[i - 1];
	                arr[i - 1] = temp;
	            }else{
	                break;
	            }
	        }
	        m++;
	    }
	}
}
