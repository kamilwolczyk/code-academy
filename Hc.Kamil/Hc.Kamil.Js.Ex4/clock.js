var clock = clock || {};

(function(){
  var hoursSpan;
  var minutesSpan;
  var secondsSpan;

  var setItem = function(container, value){
    container.innerHTML = value < 10 ? ("0" + value) : value;
  } 

  var updateClock = function(){
    var date = new Date();
    setItem(hoursSpan, date.getHours());
    setItem(minutesSpan, date.getMinutes());
    setItem(secondsSpan, date.getSeconds());
  }
  
  clock.start = function(){
    hoursSpan = document.getElementById('hours');
    minutesSpan = document.getElementById('minutes');
    secondsSpan = document.getElementById('seconds');

    setInterval(updateClock, 1000);
  }
})();

clock.start();