//Approach 2 => T.C = O(n*logn), S.C = O(1)
import java.util.*;
public class Main
{
	public static void main(String[] args) {
	    int [] arr = {1 ,3 ,5 ,7};
	    int [] nums = {0 ,2 ,6 ,8 ,9};
	    mergeSortedArrays(arr, nums);
		for(int i : arr) System.out.print(i + " ");
		System.out.println();
		for(int i : nums) System.out.print(i + " ");
	}
	public static void mergeSortedArrays(int [] arr, int [] nums){
	    int m = arr.length;
	    int n = nums.length;
	    int gap = (int)Math.ceil((double)(m + n)/2.0); 
	    while(gap > 0){
	        int i = 0;
	        int j = gap;
	        while((i + j) <= m + n - 1){
	            if((i + j) < m && arr[i] > arr[i + j]){
	                int tmp = arr[i];
	                arr[i] = arr[i + j];
	                arr[i + j] = tmp;
	            }else if(i < m && (i + j) >= m && arr[i] > nums[(i + j) - m]){
	                int tmp = arr[i];
	                arr[i] = nums[(i + j) - m];
	                nums[(i + j) - m] = tmp;
	            }else if(i >= m && (i + j) < (m + n) && nums[i - m] > nums[(i + j) - m]){
	                int tmp = nums[i - m];
	                nums[i - m] = nums[(i + j) - m];
	                nums[(i + j) - m] = tmp;
	            }
	            i++;
	        }
	        if(gap == 1) gap = 0;
	        else gap = (int)Math.ceil((double)gap/2.0);
	    }
	}
}
