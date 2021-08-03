// Reverse bits of a given 32 bits unsigned integer.

// Input: n = 00000010100101000001111010011100
// Output:    964176192 (00111001011110000010100101000000)
// Explanation: The input binary string 00000010100101000001111010011100 represents the unsigned integer 43261596, so return 964176192 which its binary representation is 00111001011110000010100101000000.

/**
 * @param {number} n - a positive integer
 * @return {number} - a positive integer
 */
 var reverseBits = function (n) {
   const reversed = `${"0".repeat(32 - n.toString(2).length)}${n.toString(2)}`
    .split("")
    .reverse()
    .join()

    let num = 0
    for(let i = 0 ; i <32; i ++) {
        if(parseInt(reversed[reversed.length - 1 - i])) {
            num +=Math.pow(2,i)
        }
    }

    return num
  }