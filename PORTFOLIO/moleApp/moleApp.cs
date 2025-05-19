
const intervals = document.querySelectorAll(".wantedMole");
const birdies = document.querySelectorAll(".birdie");
const buttons = document.querySelector(".goBack")
let earnPoint = 100 ;
const image = document.querySelectorAll(".gone");
let isHungry = 0;
let stop = true
window.addEventListener("DOMContentLoaded", funcMole2Mole3);

  birdies.forEach(myBird => {
    myBird.addEventListener("click" , function(){

        
        earnPoint = earnPoint - 10
        image.forEach(worms => {
          worms.classList.remove("gone")
          worms.classList.add("winmole")
          worms.style.clipPath = `inset(0% ${earnPoint}% 0% 0%)`; 
        })
        
        if(earnPoint === 0){
          window.location.assign("molAss.html");
                 
      
                    
        }
        console.log(earnPoint)})

    
  });
 function funcMole2Mole3(){
    function run() {
      const moleArray = Array.from(intervals);

      for (let i = moleArray.length - 1; i > 0; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [moleArray[i], moleArray[j]] = [moleArray[j], moleArray[i]];
        }
      const randomMoles  = moleArray.slice(0, Math.floor(Math.random() * 4)+1);
      
       randomMoles.forEach((intervalle, index) => {
        const delay = index * 1000 + Math.floor(Math.random() * 500); // Örn: 1000ms aralıkla

    setTimeout(() => {
              
      if (Math.random() > 0.4) {
        
        mole(intervalle);
        
        intervalle.addEventListener("click", function handler() {
          next2(intervalle);
          intervalle.removeEventListener("click", handler);
        })
          
        
        
      } else {
        
        kingHungry(intervalle);
        
        intervalle.addEventListener("click", function handler() {
          kingNext2(intervalle);
          intervalle.removeEventListener("click", handler);
        })

        
      }
      }, delay);
    
    });
      const nextDelay = Math.floor(Math.random() * 7000) + 2000;
      setTimeout(run, nextDelay);
      console.log(Math.floor(Math.random() * 9000) + 2000)
     
  }
  run();
 }
function mole(intervalle) {
  
  intervalle.style.pointerEvents = "auto";
  intervalle.classList.add("birdie");
  console.log("mole çağrıldı");
      intervalle.style.display = "block";
      intervalle.src = 'img/mole-hungry.png';
      stop=true
      
      
      setTimeout(function () {
               
        next1(intervalle)
          
    }, 2000);
      
   
   }
    
  function next1(intervalle){
    if(stop===true){
        intervalle.style.pointerEvents = "none";
        intervalle.classList.remove("birdie");
        console.log("next1 çalışıyor"); 
        intervalle.src = 'img/mole-sad.png';
      setTimeout(function () {
            intervalle.src = 'img/mole-leaving.png'              
           }, 500)
           
            setTimeout(function () { 
           intervalle.style.display = "none" ; 
           
            }, 1000)
      
          
    }
    }
  
    function next2(intervalle){
      intervalle.style.pointerEvents = "none";
      intervalle.classList.remove("birdie");
      console.log("next2 çağrıldı")
      intervalle.src = 'img/mole-fed.png';
      setTimeout(function () {
      intervalle.src = 'img/mole-leaving.png'
      console.log("leave çağrıldı ")}              
      , 600)
           
       setTimeout(function () { 
           intervalle.style.display = "none" ; 
           
            }, 1100)
               
         stop=false
      
      };

    function kingHungry(intervalle) {
      intervalle.style.pointerEvents = "auto";
      intervalle.classList.add("birdie");
  
    
      console.log("kingHungry çağrıldı");
         intervalle.style.display = "block";
          intervalle.src = 'img/king-mole-hungry.png';
          stop=true
      
         setTimeout(function () {

           kinggNext1(intervalle)
          
       }, 2000);
        
   
      }
    
    function kinggNext1(intervalle){
      if(stop===true){
      intervalle.style.pointerEvents = "none";
      intervalle.classList.remove("birdie");
         console.log("kinggNext1 çalışıyor");
          intervalle.src = 'img/king-mole-sad.png';
        setTimeout(function () {
              intervalle.src = 'img/king-mole-leaving.png'              
             }, 500)
           
            setTimeout(function () { 
           intervalle.style.display = "none" ; 
           
            }, 1000)
           } 

      }


     function kingNext2(intervalle){
      intervalle.style.pointerEvents = "none";
      intervalle.classList.remove("birdie");
      intervalle.src = 'img/king-mole-fed.png';
      console.log("kingNext2 çağrıldı")
      setTimeout(function () {
      intervalle.src = 'img/king-mole-leaving.png'
      console.log("kingNext2 leave çağrıldı ")}              
        , 500)
           
      setTimeout(function () { 
      intervalle.style.display = "none" ; 
           
        }, 1000)     
        stop=false    
        };

buttons.addEventListener("click" , function(){
            window.location.assign("moleApp.html");

            })    

                    
   
    

    

   

    