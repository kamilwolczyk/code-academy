var quiz = quiz || {};

(function(){
  var letters = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'];
  var points;
  var questionNumber;
  var questions;
  var currentQuestion;

  function showSummary() {
    return prompt('Your score is '+ points + ' point(s)\n\nOne more time?\n[yes|no]')
      .toLowerCase()
      .trim() === 'yes';
  }

  function getUserAnswear(selected) {
    var selectedIndex = letters.indexOf(selected);

    if (selectedIndex < 0) {
        return false;
    }
    
    if(currentQuestion.answears[selectedIndex].isCorrect){
      points += 1;
    }
  }

  function showQuestion() {
    var questionNumberText = 'QUESTION '+ (questionNumber+1) + '/' + questions.length +'\n\n';
    var promptText = questionNumberText + questions[questionNumber].text + '\n';
    
    for(var i=0; i<currentQuestion.answears.length; i++){ 
      promptText += letters[i] + ') '+ currentQuestion.answears[i].text;
      if(i < currentQuestion.answears.length - 1){
        promptText += '\n';
      }
    }

    var iteration = 0;

    do {
      if(iteration == 1){
        promptText = 'Invalid option!!! Do it one more time! \n\n' + promptText;
      }

      var selectedLetter = prompt(promptText);
      var selectedIndex = letters.indexOf(selectedLetter);

      if(selectedIndex !== -1){
        return selectedIndex;
      }

      iteration+=1;
    } while(true);
  }

  function nextQuestion() {
    currentQuestion = questions[questionNumber];
    var response = showQuestion();
    getUserAnswear(response);

    if(questionNumber == questions.length - 1) {
      return showSummary();
    }

    questionNumber += 1;    
    return nextQuestion();
  }
    

  function runQuiz(questionArray){
    if(!questionArray || !questionArray.length){
      throw new Error('Questions have not been found');
    }

    questions = questionArray;
    questionNumber = 0;
    points = 0;
    var onceAgain = nextQuestion();

    if(onceAgain){
      runQuiz(questionArray);
    }
  }

  quiz.start = runQuiz;
})();