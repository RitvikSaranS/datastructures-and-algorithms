function quickSort(arr, start, end){
    if(start > end) return;
    let pivot = start;
    let i = start;
    let j = end;
    while(i < j){
        while(arr[i] < arr[pivot]){
            i++;
        }
        while(arr[j] > arr[pivot]){
            j--;
        }
        if(i < j){
            swap(arr, i, j);
        }
    }
    swap(arr, start, j);
    quickSort(arr, j + 1, end);
    quickSort(arr, start, j - 1);
}
function swap(arr, ind1, ind2){
    let tmp = arr[ind1];
    arr[ind1] = arr[ind2];
    arr[ind2] = tmp;
}
let arr = [6,1,7,9,3,8,2,5,4,0];
quickSort(arr, 0, arr.length - 1);
console.log(arr);