
// -----------------------NAV COLOR CHANGE -----------------------

window.addEventListener("scroll", function (event) {
   let headerDiv = document.getElementById('nav');
   let spinner = document.querySelectorAll('.spinner');

   if (window.pageYOffset > 0){
      headerDiv.style.backgroundColor="rgba(0, 0, 0, 0.8)";
      headerDiv.children[0].style.color = 'white';
      headerDiv.children[3].style.color = 'white';
      headerDiv.children[4].style.color = 'white';
      for (i=0; i < spinner.length; i++){
         spinner[i].style.backgroundColor='white'
      };
      // logo.src = 'images/newlogoWhite.png';
   }else{
      headerDiv.style.backgroundColor="rgba(255, 255, 255, 0.0)";
      headerDiv.children[0].style.color = 'black';
      headerDiv.children[3].style.color = 'black';
      headerDiv.children[4].style.color = 'black';
      for (i=0; i < spinner.length; i++){
         spinner[i].style.backgroundColor='black'
      };
      // logo.src = 'images/newlogoDark.png';
   }
});


// -----------TOGGLE FOR SIDEMENU & Cart-Quickview-------------------

var checkbox = document.getElementById('openSidebarMenu');

checkbox.addEventListener('click', function(){
   let sidebarMenu = document.getElementById('sidebarMenu');

   if (checkbox.checked == true){
      return sidebarMenu.style.transform = 'translateX(0)';
   }else{
      sidebarMenu.style.transform = 'translateX(-250px)';
   }
});

var cartLink = document.getElementById("cartLink");
let cartQuickview = document.querySelector('.cart-quickview');

cartLink.addEventListener('mouseover', ()=>{
   cartQuickview.style.transform = "translateX(-375px)";
});
cartLink.addEventListener('mouseout', ()=>{
   cartQuickview.style.transform = "translateX(0px)";
});


//-----------------------Searchbar Toggle------------------

let searchbtn = document.getElementById('searchIcon');
let searchbar = document.getElementsByClassName('search-box')[0];

searchbtn.addEventListener('click', ()=>{
   if (searchbar.classList.contains('active')){
      searchbar.classList.remove('active');
   }else{
      searchbar.classList.add('active');
   }
}
);
// -----------------------SWIPER-------------------------------

var swiper = new Swiper('.swiper-container', {
   slidesPerGroup: 1,
   slidesPerView: 1,
   loop: true,
   loopFillGroupWithBlank: true,
   pagination: {
     el: '.swiper-pagination',
     clickable: true,
   },
   navigation: {
     nextEl: '.swiper-button-next',
     prevEl: '.swiper-button-prev',
   },
      breakpoints: {



      // when window width is <= 600px
      576: {
          slidesPerView: 2,
          spaceBetween: 10,
      },
      
      // when window width is <= 999px
      768: {

         slidesPerView: 3,
         slidesPerGroup: 3,
         spaceBetween: 8,

      },
      1200: {
         slidesPerView: 4,
         slidesPerGroup: 4,
         spaceBetween: 2,
      }


      
  },
 });
 

//-----------------Reset Catagory GIF -----------------//


// document.getElementById("test").addEventListener("mouseover", function() {
//    var loaderImg = "/images/back-img-gif.gif";
//    document.getElementById("test").style.backgroundImage="url(" + loaderImg + "?ts=" + Date.now() + ")";
//    document.getElementById("test").style.backgroundSize="cover";
// ;

//   if (this.classList.contains("active-img")) {
//     this.classList.remove("active-img");
//   } else this.classList.add("active-img");
// });


// document.getElementById("test").addEventListener("mouseout", function() {
//      this.classList.remove("active-img");
//      document.getElementById("test").style.backgroundImage="url(none)";

//  });
// ----------- item button functionality ----------
debugger;
var addButtons = document.querySelectorAll('.plus-btn');
var minusButtons = document.querySelectorAll('.minus-btn');
var itemTotals = document.querySelectorAll('.minus-btn');


addButtons.forEach( b => {
   b.addEventListener('click', ()=>{
      var itemQuantity = b.previousElementSibling.value;
      var intValue = parseInt(itemQuantity, 10);
         b.previousElementSibling.value = intValue + 1;   
   })
});
minusButtons.forEach( b => {
   b.addEventListener('click', ()=>{
      var stringValue = b.nextElementSibling.value;
      var intValue = parseInt(stringValue, 10);
      if(intValue <= 1){
         b.nextElementSibling.value = 1;
      }else{
         b.nextElementSibling.value = intValue - 1;
      }
   })
});
// for(i=0;i<addButtons.length;i++){
//    addButtons[i].addEventListener('click', ()=>{
//       var total = itemTotals[i];
//       var floatTotal = parseFloat(total);
//       var itemQuantity = addButtons[i].previousElementSibling.value;
//       var intValue = parseInt(itemQuantity, 10);
//       addButtons[i].previousElementSibling.value = intValue + 1;
//          itemTotals[i].innerHTML = 20;
// });
// };
