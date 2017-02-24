function getQuestions(){
  if(questionaire == null){
    alert('Questionaire library has not beet found!');
  }

  var questionCount = 15;

  questionaire.generate(questionCount, function(questions){
    var question1 = questions[0];
  });
}