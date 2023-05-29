//THIS HAS TWO VERSIONS TO LEARN WHAT ALL CHANGES SHOULD WE MAKE TO PREVENT MISTAKES WHILE CHOOSING END

// Taking end as arr.length
public class Main
{
	public static void main(String[] args) {
	    int [] arr = {5, 4, 3, 2, 1};
		mergeSort(arr, 0, arr.length);
		for(int e : arr){
		    System.out.println(e);
		}
	}
	public static void mergeSort(int [] arr, int s, int e){
	    if(e - s == 1) return;
	    int m = (s + e) / 2;
	    mergeSort(arr, s, m);
	    mergeSort(arr, m, e);
	    merge(arr, s, m, e);
	    return;
	}
	public static void merge(int [] arr, int s, int m, int e){
	    int [] mix = new int[e - s];
	    int i = s, j = m, k = 0;
	    while(i < m && j < e){
	        if(arr[i] < arr[j]){
	            mix[k] = arr[i];
	            k++;
	            i++;
	        }else {
	            mix[k] = arr[j];
	            k++;
	            j++;
	        }
	    }
	    while(i < m){
	        mix[k] = arr[i];
	        k++;
	        i++;
	    }
	    while(j < e){
	        mix[k] = arr[j];
	        k++;
	        j++;
	    }
	    for(int c = 0; c < (e - s); c++){
	        arr[s + c] = mix[c];
	    }
	}
}


// Taking end as arr.length - 1
public class Main
{
	public static void main(String[] args) {
	    int [] arr = {5, 4, 3, 2, 1};
		mergeSort(arr, 0, arr.length - 1);
		for(int e : arr){
		    System.out.println(e);
		}
	}
	public static void mergeSort(int [] arr, int s, int e){
	    if(e == s) return;
	    int m = (s + e) / 2;
	    mergeSort(arr, s, m);
	    mergeSort(arr, m + 1, e);
	    merge(arr, s, m, e);
	    return;
	}
	public static void merge(int [] arr, int s, int m, int e){
	    int [] mix = new int[e - s + 1];
	    int i = s, j = m + 1, k = 0;
	    while(i <= m && j <= e){
	        if(arr[i] < arr[j]){
	            mix[k] = arr[i];
	            k++;
	            i++;
	        }else {
	            mix[k] = arr[j];
	            k++;
	            j++;
	        }
	    }
	    while(i <= m){
	        mix[k] = arr[i];
	        k++;
	        i++;
	    }
	    while(j <= e){
	        mix[k] = arr[j];
	        k++;
	        j++;
	    }
	    for(int c = 0; c < (e - s + 1); c++){
	        arr[s + c] = mix[c];
	    }
	}
}

//Simplified version (using shortcuts like arr[i] = 4, i++ as arr[i++] = 4)
public class Main
{
	public static void main(String[] args) {
	    int [] arr = {7, 2, 5, 4, 1, 9};
	    mergeSort(arr, 0, arr.length - 1);
		for(int i : arr) System.out.print(i);
	}
    public static void mergeSort(int [] arr, int s, int e){
        if(s == e) return;
	    int m = (s + e)/2;
	    mergeSort(arr, s, m);
	    mergeSort(arr, m + 1, e);
        merge(arr, s, e);
    }
	public static void merge(int [] arr, int s, int e){
	    int m = (s + e)/2;
	    int i = s, n = m + 1, k = 0;
	    int [] nums = new int[e - s + 1];
	    while(s <= m && n <= e){
	        if(arr[s] < arr[n]){
	            nums[k++] = arr[s++];
	        }else {
	            nums[k++] = arr[n++];
	        }
	    }
	    while(s <= m) nums[k++] = arr[s++];
	    while(n <= e) nums[k++] = arr[n++];
	    for(int p : nums) arr[i++] = p;
	}
}