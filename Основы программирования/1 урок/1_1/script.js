"use strict";

/* курс на 04.03.2020 по ЦБ с округлением до ближайшего целого */
const dollarRate = 66;
const euroRate   = 74;

let userCashConvert = +prompt( 'Добрый день! Сколько вы хотите сконвертировать рублей в иностранную валюту?' );

/* Выводим получившийся расчет, немного сократив итоговые значения до сотых для красоты */
alert( 'У вас будет ' + (userCashConvert / dollarRate).toFixed(2) + ' долларов или ' + 
                        (userCashConvert / euroRate).toFixed(2) + ' евро.' );