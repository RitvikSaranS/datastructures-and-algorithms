import java.util.*;
public class Main
{
	public static void main(String[] args) {
		int [] arr = {1, 2, 3, 4, 5, 6};
		System.out.println("Enter the rotation count");
		Scanner sc = new Scanner(System.in);
		int a = sc.nextInt();
		System.out.println();
		a %= arr.length;
		rotateArray(arr, a);
		for(int i : arr) System.out.println(i);
	}
	public static void rotateArray(int [] arr, int a){
	    reverseArray(arr, 0, a - 1);
	    reverseArray(arr, a, arr.length - 1);
	    reverseArray(arr, 0, arr.length - 1);
	}
	public static void reverseArray(int [] arr, int s, int e){
	    while(s < e){
	        int temp = arr[s];
	        arr[s] = arr[e];
	        arr[e] = temp;
	        s++;
	        e--;
	    }
	}
}

