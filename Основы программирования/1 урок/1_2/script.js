"use strict";

let firstTrapezoidFace  = +prompt('Введите длину первой грани трапеции: '),
    secondTrapezoidFace = +prompt('Введите длину второй грани трапеции: '),
    trapezoidHeight     = +prompt('Введите высоту трапеции трапеции: ');

let trapezoidArea = (( firstTrapezoidFace + secondTrapezoidFace ) / 2) * trapezoidHeight;

alert(`Площадь трапеции будет равна ${trapezoidArea}`);