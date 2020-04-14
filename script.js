
// -----------------------NAV COLOR CHANGE -----------------------

window.addEventListener("scroll", function (event) {
   let headerDiv = document.getElementById('nav');
   let spinner = document.querySelectorAll('.spinner');


   if (window.pageYOffset > 0){
      headerDiv.style.backgroundColor="rgba(0, 0, 0, 0.3)";
      headerDiv.children[0].style.color = 'white';
      headerDiv.children[2].style.color = 'white';
      headerDiv.children[3].style.color = 'white';
      for (i=0; i < spinner.length; i++){
         spinner[i].style.backgroundColor='white'
      };
   }else{
      headerDiv.style.backgroundColor="rgba(255, 255, 255, 0.6)";
      headerDiv.children[0].style.color = 'black';
      headerDiv.children[2].style.color = 'black';
      headerDiv.children[3].style.color = 'black';
      for (i=0; i < spinner.length; i++){
         spinner[i].style.backgroundColor='black'
      };
   }
});


// ----------------------TOGGLE FOR SIDEMENU-------------------

var checkbox = document.getElementById('openSidebarMenu');

checkbox.addEventListener('click', function(){
   let sidebarMenu = document.getElementById('sidebarMenu');

   if (checkbox.checked == true){
      return sidebarMenu.style.transform = 'translateX(0)';
   }else{
      sidebarMenu.style.transform = 'translateX(-250px)';
   }
});

//-----------------------Searchbar playaround------------------

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
   loop: false,

   loopFillGroupWithBlank: true,

   pagination: {
     el: '.swiper-pagination',
     clickable: true,
   },

   breakpoints: {


       // when window width is <= 499px
      499: {
         slidesPerGroup: 1,
          slidesPerView: 1,
          spaceBetween: 0,
      },
      // when window width is <= 600px
      600: {
          slidesPerView: 2,
          spaceBetween: 30,
      },
      
      // when window width is <= 999px
      999: {
         slidesPerView: 3,
         spaceBetween: 30,
         slidesPerGroup: 3,
      }
      
  }

 });



 //--------------------Media Query for SWIPER ------------------


const mediaSm = matchMedia('(min-width: 600px)');

mediaSm.addEventListener("change", function(){

   swiper.SlidesPerView = 1;
   swiper.slidesPerGroup = 1;

}) 