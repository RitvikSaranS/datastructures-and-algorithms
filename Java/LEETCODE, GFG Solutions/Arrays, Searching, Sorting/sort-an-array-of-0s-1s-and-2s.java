//Approach 1 T.C = O(2n)
public class Main
{
	public static void main(String[] args) {
	    int [] arr = {1 , 0 , 2 , 0 , 1 , 2 , 2 , 1 , 1 , 0 };
	    count0s1s2s(arr);
		for(int i : arr) System.out.println(i);
	}
	public static void count0s1s2s(int [] arr){
	    int zeroCount = 0;
	    int oneCount = 0;
	    int twoCount = 0;
	    for(int i : arr){
	        if(i == 0) zeroCount++;
	        if(i == 1) oneCount++;
	        if(i == 2) twoCount++;
	    }
	    for(int j = 0; j < zeroCount; j++){
	        arr[j] = 0;
	    }
	    for(int j = zeroCount; j < zeroCount + oneCount; j++){
	        arr[j] = 1;
	    }
	    for(int j = zeroCount + oneCount; j < zeroCount + oneCount + twoCount; j++){
	        arr[j] = 2;
	    }
	}
}

//Approach 2 T.C = O(n)
public class Main
{
	public static void main(String[] args) {
	    int [] arr = {1 , 0 , 2 , 0 , 1 , 2 , 2 , 1 , 1 , 0 };
	    count0s1s2s(arr);
		for(int i : arr) System.out.println(i);
	}
	public static void count0s1s2s(int [] arr){
	    int div1 = 0;
	    int mid = 0;
	    int div2 = arr.length - 1;
	    while(mid < div2){
	        while(arr[mid] == 1) mid++;
	        if(arr[mid] == 0){
	            int tmp = arr[mid];
	            arr[mid] = arr[div1];
	            arr[div1] = tmp;
	            div1++;
	            mid++;
	        }
	        if(arr[mid] == 2){
	            int tmp = arr[mid];
	            arr[mid] = arr[div2];
	            arr[div2] = tmp;
	            div2--;
	        }
	    }
	}
}
