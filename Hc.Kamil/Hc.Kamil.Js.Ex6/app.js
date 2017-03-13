var app = app || {};

(function(){
  var home = "<h1>Home page...</h1>",
      data = "<h1>Data...</h1>",
      contact = "<h1>Contact...</h1>",
      notFound = "<h1>404 - Page not found!</h1>";
  
  var getContent = function(page){
    switch(page) {
      case 'home': return home;
      case 'data': return data;
      case 'contact': return contact;
      default: return notFound;
    }
  }

  app.redirect = function(page){
    $('#content').html(getContent(page));
  }
})();

$(document).ready(function(){
  app.redirect('home');
});

