class Solution {
    public int largestRectangleArea(int[] heights) {
        if(heights.length == 1) return heights[0];
	    int [] nsl = new int[heights.length];
	    int [] nsr = new int[heights.length];
	    Stack<int[]> s1 = new Stack<>();
	    Stack<int[]> s2 = new Stack<>();
	    s1.push(new int[]{heights[0], 0});
	    s2.push(new int[]{heights[heights.length - 1], heights.length - 1});
	    for(int i = 0; i < heights.length; i++){
	        int temp = heights[i];
	        while(!s1.isEmpty() && temp < (s1.peek())[0]){
	            s1.pop();
	        }
	        if(s1.isEmpty()) nsl[i] = i;
	        else nsl[i] = (s1.peek())[1];
	        s1.push(new int[]{temp, i});
	        int index = heights.length - 1 - i; 
	        temp = heights[index];
	        while(s2.isEmpty() == false && temp < (s2.peek())[0]){
	            s2.pop();
	        }
	        if(s2.isEmpty()) nsr[index] = index + 1;
	        else nsr[index] = (s2.peek())[1];
	        s2.push(new int[]{temp, index});
	    }
	    int max = 0;
	    for(int i = 0; i < heights.length; i++){
	        int area = -1;
	        if(i == heights.length - 1 || i == 0) {
	            area = (nsr[i] - nsl[i]) * heights[i];
	        }else{
	            area = (nsr[i] - nsl[i] - 1) * heights[i];
	        }
	        if(area > max) max = area;
	    }
	    return max;
    }
}