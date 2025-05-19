const nextBtn = document.querySelector(".next");
const prevBtn = document.querySelector(".prev");
const allImg  = document.querySelectorAll(".gallery-img");
let currentImg = 0 ;


nextBtn.addEventListener("click", function(e) {
    next();
  });

prevBtn.addEventListener("click", function() {
    prev();
  });

function next(){
    console.log(allImg.length);
    allImg[currentImg].classList.remove("active")
    currentImg++
    allImg[currentImg].classList.add("active")
    prevBtn.disabled = false;
    if(allImg.length === currentImg + 1 ){
        nextBtn.disabled = true;
    }
    
}

function prev(){
    if(currentImg >= 1) {
        allImg[currentImg].classList.remove("active")
        currentImg = currentImg - 1
        nextBtn.disabled = false
        allImg[currentImg].classList.add("active")
    }
    if(currentImg === 0){
        prevBtn.disabled = true;
    }
    

}