function a3(x) {
    return function(y) {
        return x*y
    }
}
function add(v) {
    let sum=0
    for (let i=0; i<v.length; i++)
        sum += v[i]
    return sum
}
function iterate(num, f, vec) {
    let amount = num
    let result = 0
    if (vec.length<amount)
        amount=vec.length
    for (let i=0; i<amount; i++)
        result += f(vec[i])
    return result
}
let myArray = [3, 5, 7, 11]
console.log(iterate(2, a3, myArray))
//console.log(iterate(2, a3(2), myArray))
//console.log(iterate(2, add, myArray))
//console.log(add(myArray))
//console.log(iterate(5, a3(3), myArray))
//console.log(iterate(5, a3(1), myArray))
