    //Scroll
    var mybutton = document.getElementById("myBtn");
    window.onscroll = function () { scrollFunction() };

    function scrollFunction() {
      if (document.body.scrollTop > 80 || document.documentElement.scrollTop > 80) {
        mybutton.style.display = "block";
      } else {
        mybutton.style.display = "none";
      }
    }
    //Cộng trừ số lượng
    var sl = Number(document.getElementById('quantity-number').textContent);
    console.log(sl);
    function minusQuantity() {
        if (sl > 1) {
            document.getElementById('quantity-number').innerHTML = (--sl);
        }
    }
    function plusQuantity() {
        document.getElementById('quantity-number').innerHTML = (++sl);
        console.log(sl);
    }

    //Modal quickview
    var modal = document.getElementById('myModal');
     
    // Lấy phần button mở Modal
    var btn = document.getElementsByClassName("btn-search");
 
    // Lấy phần span đóng Modal
    var span = document.getElementsByClassName("close")[0];
 
    // Khi button được click thi mở Modal
    for(var i=0;i<btn.length;i++){
        btn[i].onclick = function() {
            modal.style.display = "block";
        }
    }
    // Khi span được click thì đ
    // span.onclick = function() {
    //     modal.style.display = "none";
    // }
 
    // Khi click ngoài Modal thì đóng Modal
    window.onclick = function(event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    }

    $('.logo').on('click', function(e) {
        e.preventDefault();
        $('.nav-toggle').removeClass('open');
        $('.menu-left').removeClass('collapse');
        $('html, body').animate({
          scrollTop: 0
        }, 750, 'easeInOutQuad')
      });
      // LINKS TO ANCHORS
      $('a[href^="#"]').on('click', function(event) {
      
        var $target = $(this.getAttribute('href'));
      
        if($target.length) {
          event.preventDefault();
          $('html, body').stop().animate({
            scrollTop: $target.offset().top
          }, 750, 'easeInOutQuad');
        }
      });
      
      // TOGGLE HAMBURGER & COLLAPSE NAV
      $('.nav-toggle').on('click', function() {
        $(this).toggleClass('open');
        $('.menu-left').toggleClass('collapse');
      });
      // REMOVE X & COLLAPSE NAV ON ON CLICK
      $('.menu-left a').on('click', function() {
        $('.nav-toggle').removeClass('open');
        $('.menu-left').removeClass('collapse');
      });
      
      // SHOW/HIDE NAV
      
      // Hide Header on on scroll down
      var didScroll;
      var lastScrollTop = 0;
      var delta = 5;
      var navbarHeight = $('header').outerHeight();
      
      $(window).scroll(function(event){
          didScroll = true;
      });
      
      setInterval(function() {
          if (didScroll) {
              hasScrolled();
              didScroll = false;
          }
      }, 250);
      
      function hasScrolled() {
          var st = $(this).scrollTop();
      
          // Make sure they scroll more than delta
          if(Math.abs(lastScrollTop - st) <= delta)
              return;
      
          // If they scrolled down and are past the navbar, add class .nav-up.
          // This is necessary so you never see what is "behind" the navbar.
          if (st > lastScrollTop && st > navbarHeight){
              // Scroll Down
              $('header').removeClass('show-nav').addClass('hide-nav');
              $('.nav-toggle').removeClass('open');
              $('.menu-left').removeClass('collapse');
          } else {
              // Scroll Up
              if(st + $(window).height() < $(document).height()) {
                  $('header').removeClass('hide-nav').addClass('show-nav');
              }
          }
      
          lastScrollTop = st;
      }
      $(window).load(function () {
        $('#modal_subcribe').modal('show');
        
      });
      $(".closemodal").click(function(){
              $("#modal_subcribe").modal('hide');
          });
function callAjaxSubcriber() {
  if(document.getElementById('email_subcriber').value==""){
    alert("Vui lòng điền email của bạn");
  }
  else
  $("#modal_subcribe").modal('hide');
}
          
