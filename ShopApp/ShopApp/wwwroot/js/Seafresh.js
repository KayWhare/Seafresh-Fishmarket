
// -----------------------NAV COLOR CHANGE -----------------------

window.addEventListener("scroll", function (event) {
    let headerDiv = document.getElementById('nav');
    let spinner = document.querySelectorAll('.spinner');

    if (window.pageYOffset > 0) {
        headerDiv.style.backgroundColor = "rgba(0, 0, 0, 0.8)";
        headerDiv.children[0].style.color = 'white';
        headerDiv.children[3].style.color = 'white';
        headerDiv.children[4].style.color = 'white';
        for (i = 0; i < spinner.length; i++) {
            spinner[i].style.backgroundColor = 'white'
        };
        // logo.src = 'images/newlogoWhite.png';
    } else {
        headerDiv.style.backgroundColor = "rgba(255, 255, 255, 0.0)";
        headerDiv.children[0].style.color = 'black';
        headerDiv.children[3].style.color = 'black';
        headerDiv.children[4].style.color = 'black';
        for (i = 0; i < spinner.length; i++) {
            spinner[i].style.backgroundColor = 'black'
        };
        // logo.src = 'images/newlogoDark.png';
    }
});


// -----------TOGGLE FOR SIDEMENU & Cart-Quickview-------------------

var checkbox = document.getElementById('openSidebarMenu');

checkbox.addEventListener('click', function () {
    let sidebarMenu = document.getElementById('sidebarMenu');

    if (checkbox.checked == true) {
        return sidebarMenu.style.transform = 'translateX(0)';
    } else {
        sidebarMenu.style.transform = 'translateX(-250px)';
    }
});

var cartLink = document.getElementById("cartLink");
let cartQuickview = document.querySelector('.cart-quickview');

cartLink.addEventListener('mouseover', () => {
    cartQuickview.style.transform = "translateX(-375px)";
});
cartLink.addEventListener('mouseout', () => {
    cartQuickview.style.transform = "translateX(0px)";
});


//-----------------------Searchbar Toggle------------------

let searchbtn = document.getElementById('searchIcon');
let searchbar = document.getElementsByClassName('search-box')[0];

searchbtn.addEventListener('click', () => {
    if (searchbar.classList.contains('active')) {
        searchbar.classList.remove('active');
    } else {
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

// ----------- item button functionality ----------

let addButtons = document.querySelectorAll('.plus-btn');
let minusButtons = document.querySelectorAll('.minus-btn');
let quantityInput = document.querySelectorAll(".quantity-input");
let cartTotal = document.getElementById('total-price');
let cartItemCollection = document.querySelectorAll('.cart-item-price');
let removeButtons = document.querySelectorAll('.cart-item-delete-btn');



quantityInput.forEach(i => {
    i.defaultValue = "1";
    i.setAttribute('readonly', true)
});


addButtons.forEach(b => {
    b.addEventListener('click', () => {
        let itemQuantity = b.previousElementSibling.value;
        let intValue = parseInt(itemQuantity, 10);
        let totalPrice = b.parentElement.nextElementSibling.firstElementChild;
        let intPrice = parseFloat(totalPrice.innerHTML);


        itemQuantity = intValue + 1;
        b.previousElementSibling.value = itemQuantity;
        intPrice = (intPrice * itemQuantity) / (itemQuantity - 1);
        totalPrice.innerHTML = intPrice.toFixed(2);

    })
});
minusButtons.forEach(b => {
    b.addEventListener('click', () => {
        var itemQuantity = b.nextElementSibling.value;
        var intValue = parseInt(itemQuantity, 10);
        let totalPrice = b.parentElement.nextElementSibling.firstElementChild;
        var intPrice = parseFloat(totalPrice.innerHTML);

        if (itemQuantity <= 1) {
            b.nextElementSibling.value = 1;
        } else {
            intPrice = (intPrice * (itemQuantity - 1)) / itemQuantity;
            totalPrice.innerHTML = intPrice.toFixed(2);

            itemQuantity -= 1;
            b.nextElementSibling.value = itemQuantity;

        }
    })
});

