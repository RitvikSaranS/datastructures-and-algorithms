//Approach 1 => T.C = O(2n), S.C = O(n)
public class Main
{
	public static void main(String[] args) {
		int [] arr = {3,1,2,5,3};
		findDuplicateMissing(arr);
	}
	public static void findDuplicateMissing(int [] arr){
	    int [] temp = new int[arr.length];
	    for(int i = 0; i < arr.length; i++){
	        temp[arr[i] - 1]++;
	    }
	    for(int i =0; i < temp.length; i++){
	        if(temp[i] == 0) System.out.println("Missing number is " + (i + 1));
	        if(temp[i] == 2) System.out.println("Duplicate number is " + (i + 1));
	    }
	}
}

//Approach 2 => T.C = O(n), S.C = O(1)
import java.util.*;
public class Main
{
	public static void main(String[] args) {
		int [] arr = {3,1,2,5,4,6,7,5};
		findDuplicateMissing(arr);
	}
	public static void findDuplicateMissing(int [] arr){
	    int xorval = arr[0] ^ 1;
	    for(int i = 1; i < arr.length; i++){
	        xorval ^= arr[i] ^ (i + 1);
	    }
	    int lastsetbit = xorval & (~(xorval - 1));
	    int duplicate = 0;
	    int missing = 0;
	    for(int i = 0; i < arr.length; i++){
	        if((arr[i] & lastsetbit) == lastsetbit) duplicate ^= arr[i];
	        if((arr[i] & lastsetbit) == 0) missing ^= arr[i];
	    }
	    for(int i = 1; i <= arr.length; i++){
	        if((i & lastsetbit) == lastsetbit) duplicate ^= i;
	        if((i & lastsetbit) == 0) missing ^= i;
	    }
	    System.out.println("Duplicate number is " + duplicate);
	    System.out.println("Missing number is " + missing);
	    // not neccessary that duplicate is the duplicate number, it can also be the missing number
	    // so again run a loop to confirm which is missing and which is not.
	}
}
