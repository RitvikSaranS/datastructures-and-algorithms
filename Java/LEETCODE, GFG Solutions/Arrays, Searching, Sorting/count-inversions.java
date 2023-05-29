public class Main
{
	public static void main(String[] args) {
	    int [] arr = {8, 4, 2, 1};
	    System.out.print(mergeSort(arr, 0, arr.length - 1));
	}
    public static int mergeSort(int [] arr, int s, int e){
        if(s == e) return 0;
	    int m = (s + e)/2;
	    int l = mergeSort(arr, s, m);
	    int r = mergeSort(arr, m + 1, e);
        return (l + r + merge(arr, s, e));
    }
	public static int merge(int [] arr, int s, int e){
	    int count = 0;
	    int m = (s + e)/2;
	    int i = s, n = m + 1, k = 0;
	    int [] nums = new int[e - s + 1];
	    while(s <= m && n <= e){
	        if(arr[s] < arr[n]){
	            nums[k++] = arr[s++];
	        }else {
	            nums[k++] = arr[n++];
	            count += (m - s) + 1;
	        }
	    }
	    while(s <= m) nums[k++] = arr[s++];
	    while(n <= e) nums[k++] = arr[n++];
	    for(int p : nums) arr[i++] = p;
	    return count;
	}
}