let runninTotal = 0;
let currentNumber = "0";
let logicSymbol ;
let otherSymbol ;


const screen = document.querySelector(".screen");

document.querySelector(".calc-buttons").addEventListener("click" , function(event) {
    buttonClick(event.target.innerText); }
);


function buttonClick(value) {

    
    console.log(value); 

    if((value === "+") || (value === "÷") || (value === "×") || (value === "-")   )      
        handleSymbol(value);
    
    else if((value === "C") || (value === "←"))
        handleOtherSymbol(value)

    else if (value === "=")
        handleExecute(value)

    else if(!isNaN(value))
        handleNumber(value)
}
function handleNumber(value) {
    if (currentNumber === "0") {
        currentNumber = value; // baştaki sıfırı sil ve yeni sayı yaz
    } else {
        currentNumber = currentNumber + value
        
        console.log(runninTotal)
        
        
    }

    screen.innerText = currentNumber;
}
console.log(runninTotal)

function handleSymbol(value){
    runninTotal = Number(currentNumber);
    logicSymbol = value;
    currentNumber = "0"; // ekranı sıfırla, yeni sayı girilecek
    screen.innerText = "0";
}





function handleExecute(value) {
    
    const crnmbr = Number(currentNumber);
    
    if(logicSymbol === "+"){
    runninTotal += crnmbr
    screen.innerText = runninTotal
    console.log(runninTotal)
    
}
    if(logicSymbol === "-"){
    runninTotal -= crnmbr
    screen.innerText = runninTotal
    console.log(runninTotal)
}
    if(logicSymbol === "÷"){
    runninTotal /= crnmbr
    screen.innerText = runninTotal
    console.log(runninTotal)
}
    if(logicSymbol === "×"){
    runninTotal *= crnmbr
    screen.innerText = runninTotal
    console.log(runninTotal)
}
    currentNumber = "0";
    logicSymbol = null;
}
function handleOtherSymbol(value) {
    switch (value) {
        case "C":
          currentNumber = "0";
          runningTotal = "0";
          screen.innerText = currentNumber
          break;
        case "←":
            currentNumber = currentNumber.substring(0, currentNumber.length - 1);
            screen.innerText = currentNumber
            return;
          }

        
   
}
    
