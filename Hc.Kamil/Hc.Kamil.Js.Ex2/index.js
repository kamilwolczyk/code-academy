function getQuestions(){
  if(questionaire == null){
    alert('Questionaire library has not beet found!');
  }

  var questionCount = 3;

  //opcja 1 - synchroniczne pobranie (od razu dostajemy wartości)
  var questions = questionaire.generate(questionCount);

  //opcja 2 - asynchroniczne pobranie (pytania dopiero po czasie)
  // questionaire.generateAsync(questionCount, function(questions){
  //   var question1 = questions[0];
  // });

  quiz.start(questions);
}