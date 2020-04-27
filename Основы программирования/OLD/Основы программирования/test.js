"use strict";

let vkladSum = +prompt("Введите сумму вклада:",''),
    vkladPercent = +prompt("Введите годовой процент по вкладу:",''),
    sumYear = 0;

sumYear = vkladSum + ( vkladSum * (vkladPercent / 100));
console.log(sumYear);
// for(let i=0; i > 5; i++){
//     sumYear = vkladSum + ( vkladSum * (vkladPercent / 100));

//     alert(sumYear);
// };