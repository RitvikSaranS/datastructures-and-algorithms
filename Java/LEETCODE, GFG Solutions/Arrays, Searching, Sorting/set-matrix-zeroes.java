public class Main
{
	public static void main(String[] args) {
	    int [][] arr = {{1},{0}};
	    setMatrixZeroes(arr);
		printMatrix(arr);
	}
	public static void setMatrixZeroes(int [][] arr){
	    int colmark = 0;
	    int rowmark = 0;
	    for(int i = 0; i < arr.length; i++){
	        for(int j = 0; j < arr[i].length; j++){
	            if(i == 0 && arr[0][j] == 0) rowmark = 1;
	            if(j == 0 && arr[i][0] == 0) colmark = 1;
	            else if(arr[i][j] == 0) arr[0][j] = arr[i][0] = 0;
	        }
	    }
	    for(int i = 1; i < arr.length; i++){
	        for(int j = 1; j < arr[i].length; j++){
	            if(arr[i][0] == 0 || arr[0][j] == 0) arr[i][j] = 0;
	        }
	    }
	    if(rowmark == 1) {
	        for(int i = 0; i < arr[0].length; i++) arr[0][i] = 0;
	    }
	    if(colmark == 1) {
	        for(int i = 0; i < arr.length; i++) arr[i][0] = 0;
	    }
	}
	public static void printMatrix(int [][] matrix){
	    for(int [] arr : matrix){
		    for(int i : arr) System.out.print(i + " ");
		    System.out.println();
		}
	}
}