
const doggos = document.querySelector(".doggos");

let dogg = document.querySelector(".imgSelect2");

const animation  = document.querySelector(".anm");

animation.style.display = "none" ;

function loadBreeds() {
  fetch("https://dog.ceo/api/breeds/list/all")
    .then(res => res.json())
    .then(data => {
      const breeds = data.message;

      for (let breed in breeds) {
        if (breeds[breed].length === 0) {
          // Örn: "beagle"
          const option = document.createElement("option");
          option.value = breed;
          option.textContent = breed;
          dogg.appendChild(option);
          
        } 
        
      }

      // İlk ırk seçili olsun ve resim gösterilsin
      
    });
}
window.addEventListener("DOMContentLoaded", loadBreeds);

dogg.addEventListener("change", function(showDog){
    
  let selectedBreed = this.value
  const url = `https://dog.ceo/api/breed/${selectedBreed}/images/random`;
  
  animation.style.display = "block";
    
    fetch(url)
  .then(res => res.json())
  .then(data => {
    
    console.log(data); // resim URL’si
     doggos.innerHTML = ""

     
    const img = document.createElement("img");
         img.src = data.message;
         img.alt = "Cute doggo";

  img.onload = function () {

    console.log("Resim tamamen yüklendi ✅");
    animation.style.display = "none"; // Animasyonu gizle
    };
  img.onerror = function () {
        console.log("Resim yüklenemedi ❌");
        animation.textContent = "Resim yüklenemedi.";
      };

  doggos.appendChild(img);
  doggos.style.display= ("flex");
  doggos.style.justifyContent= ("center");
  doggos.style.marginTop= ("2rem");
  
})
})




