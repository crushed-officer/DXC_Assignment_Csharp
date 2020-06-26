var today = new Date();
var day = today.getDay();
var daylist = ["Sunday", "Monday", "Tuesday", "Wednesday ", "Thursday", "Friday", "Saturday"];
console.log("Today is : " + daylist[day] + ".");
var hour = today.getHours();
var minute = today.getMinutes();
var second = today.getSeconds();
var t = (hour >= 12) ? " PM " : " AM ";
hour = (hour >= 12) ? hour - 12 : hour;
if (hour === 0 && t === ' PM ') {
    if (minute === 0 && second === 0) {
        hour = 12;
        t = ' Noon';
    }
    else {
        hour = 12;
        t = ' PM';
    }
}
if (hour === 0 && t === ' AM ') {
    if (minute === 0 && second === 0) {
        hour = 12;
        t = ' Midnight';
    }
    else {
        hour = 12;
        t = ' AM';
    }
}
console.log("Current Time : " + hour + t + " : " + minute + " : " + second);
