// Given an integer numRows, return the first numRows of Pascal's triangle.
// In Pascal's triangle, each number is the sum of the two numbers directly above it as shown

var generate = function(numRows) {
    let arr = []
    let pascalTriangle = []

    for(i=1; i<numRows; i++) {
        for(j=arr.length-1; j>0; j--){
            arr[j] += arr[j-1]
        }
        arr.push(1)

        pascalTriangle.push([...arr])
    }

    return pascalTriangle;
}