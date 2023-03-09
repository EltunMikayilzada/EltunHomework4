let from = 3;
let to = 12;

for (let i = from; i < to; i++) {
let symbol = true;
for (let j = 2; j < i; j++) {
if (i % j === 0) {
symbol = false;
break
}
}
if (symbol==true && i !== 1)
 console.log(i)
}
    