function subarraygen(arr, ind, op){
    if(ind > arr.length - 1) return;
    op.forEach(i => {
        let tmp = [...i];
        tmp.push(arr[ind]);
        op.push(tmp);
    })
    subarraygen(arr, ind + 1, op);
}
let op = [[]];
subarraygen([1, 2, 3], 0, op);
console.log(op);