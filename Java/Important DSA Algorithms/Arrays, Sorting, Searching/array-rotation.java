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

/*
Thought process.
* Let us consider sorted array as a vector like structure. (----->).
* Look at the form of the answer = ------>-->. Which before rotation was of the form -->------>.
* Now to the steps, if we reverse the first and second sorted sections seperately it gives <--<------.
* Now if we reverse this we will get the desired answer ------>-->. 
*/
