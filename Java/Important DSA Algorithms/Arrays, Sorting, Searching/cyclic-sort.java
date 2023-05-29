public class Main
{
	public static void main(String[] args) {
	    int [] arr = {2, 3, 5, 4, 1};
	    cyclicSort(arr);
	    for(int i : arr){
	        System.out.println(i);
	    }
	}
	public static void cyclicSort(int [] arr){
	    int i = 0;
	    while(i < arr.length){
	        int correct = arr[i] - 1;
	        if(arr[i] != arr[correct]){
	            int temp = arr[i];
	            arr[i] = arr[correct];
	            arr[correct] = temp;
	        }
	        else{
	            i++;
	        }
	    }
	}
}