
// -----------------------NAV COLOR CHANGE -----------------------

window.addEventListener("scroll", function (event) {
    let headerDiv = document.getElementById('nav');
    let spinner = document.querySelectorAll('.spinner');

    if (window.pageYOffset > 0) {
        headerDiv.style.backgroundColor = "rgba(0, 0, 0, 0.8)";
        headerDiv.style.height = "60px";
        headerDiv.children[0].style.color = 'white';
        headerDiv.children[3].style.color = 'white';
        headerDiv.children[4].style.color = 'white';
        for (i = 0; i < spinner.length; i++) {
            spinner[i].style.backgroundColor = 'white'
        };
    } else {
        headerDiv.style.backgroundColor = "rgba(255, 255, 255, 0.0)";
        headerDiv.style.height = "80px";
        headerDiv.children[0].style.color = 'black';
        headerDiv.children[3].style.color = 'black';
        headerDiv.children[4].style.color = 'black';
        for (i = 0; i < spinner.length; i++) {
            spinner[i].style.backgroundColor = 'black'
        };
    }
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

var cartTotals = document.querySelectorAll('.cart-item-price');
let overalltotal = document.querySelector("#total-price");


function totalTally() {
    var tally = 0;
    cartTotals.forEach(total => {
        tally += parseFloat(total.innerHTML);
    });
    overalltotal.innerHTML = tally.toFixed(2);
};


let addButtons = document.querySelectorAll('.plus-btn');
let minusButtons = document.querySelectorAll('.minus-btn');
let itemForms = document.querySelectorAll(".shop-item");
let quantityInput = document.querySelectorAll(".quantity-input");


quantityInput.forEach(i => {
    i.setAttribute('readonly', true)
});


function plusbtn(e) {
    var b = e.currentTarget;
    let itemQuantity = b.previousElementSibling;
    let newIntQuantity = (parseInt((itemQuantity.value), 10)) + 1;
    itemQuantity.value = newIntQuantity;

    let totalPrice = b.parentElement.nextElementSibling.firstElementChild;
    let itemPrice = b.parentElement.previousElementSibling.value;
    totalPrice.innerHTML = (newIntQuantity * (parseFloat(itemPrice))).toFixed(2);
    totalTally();
}

function minusbtn(e) {
    var b = e.currentTarget;
    var itemQuantity = b.nextElementSibling;
    let newIntQuantity = (parseInt((itemQuantity.value), 10)) - 1;
    if (newIntQuantity < 1) {
        newIntQuantity = 1;
    } else {
        itemQuantity.value = newIntQuantity;
    };

    let totalPrice = b.parentElement.nextElementSibling.firstElementChild;
    let itemPrice = b.parentElement.previousElementSibling.value;
    totalPrice.innerHTML = (newIntQuantity * (parseFloat(itemPrice))).toFixed(2);
    totalTally();
}



//=================AddtoCart Posts with FetchAPI ================

let addToCartButtons = document.querySelectorAll(".addToCart");
let quickviewParent = document.querySelector('.cart-quickview').parentElement;


addToCartButtons.forEach(button => {
    button.addEventListener('click', (e) => {
        e.preventDefault();
        var form = e.currentTarget.closest('form');
        var formData = new URLSearchParams(new FormData(form));
        fetch('/SeafreshStore/', {
            body: formData,
            method: "post",
        }).then(() => {
            fetch('/SeafreshStore/Quickview', {
                body: null,
                method: "get"
            }).then(res => {
                return res.text();
            }).then(res => {
                quickviewParent.innerHTML = res;
                quickviewParent.firstElementChild.style.transform = "translateX(-385px)";
                setTimeout(() => {
                    quickviewParent.firstElementChild.style.transform = "translateX(0px)";
                }, 3000);
            }).catch(err => {
                console.warn('Something went wrong.', err);
            });
        form.reset();
        })
    })
});

//=================DeleteItem with Fetch================
let ShoppingCartContainer = document.querySelector(".shopping-cart");


function deleteItem(e) {

    var form = e.currentTarget.closest('form');
    var formData = new URLSearchParams(new FormData(form));
    fetch('/SeafreshCart/Delete', {
        body: formData,
        method: "post",
    }).then(() => {
        fetch('/SeafreshCart/UpdateCartView', {
            body: null,
            method: "get"
        }).then(res => {
            return res.text();
        }).then(res => {
            ShoppingCartContainer.innerHTML = res;
        }).catch(err => {
            console.warn('Something went wrong.', err);
        }).then(() => {
            fetch('/SeafreshStore/Quickview', {
                body: null,
                method: "get"
            }).then(res => {
                return res.text();
            }).then(res => {
                quickviewParent.innerHTML = res;
            })
        })
    })
};

//function refreshCartTotal(e) {
//    var form = e.currentTarget.closest('form');
//    var formData = new URLSearchParams(new FormData(form));
//    fetch('/SeafreshCart/', {
//        body: formData,
//        method: "post",
//    }).then(() => {
//        fetch('/SeafreshCart/UpdateCartView', {
//            body: null,
//            method: "get"
//        }).then(res => {
//            return res.text();
//        }).then(res => {
//            ShoppingCartContainer.innerHTML = res;
//        }).catch(err => {
//            console.warn('Something went wrong.', err);
//        });
//    })
//}




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

cartLink.addEventListener('mouseover', () => {
    quickviewParent.firstElementChild.style.transform = "translateX(-385px)";
    setTimeout(() => {
        quickviewParent.firstElementChild.style.transform = "translateX(0px)";
    }, 3000);
});




