var myController = myController || {};

(function () {

    var currentQuestion = 0;
    var myQuestions;
    var correctCounter = 0;

    function getQuestions() {
        if (questionaire == null) {
            alert('Questionaire library has not beet found!');
        }

        var questionCount = 5;

        questionaire.generateAsync(questionCount, function (questions) {
            myQuestions = questions;
            if (myQuestions.length == 0) {
                alert('No questions found!');
            } else {
                questionaireStart();
            }
        });

    }


    function questionaireStart() {
        myView.prepareQuestionView();
        myView.questionView(myQuestions[0]);
    }

    function checkQuestion(id) {
        if (myQuestions[currentQuestion].answears[id].isCorrect) {
            correctCounter++;
        }
        nextQuestion();
    }

    function nextQuestion() {
        currentQuestion++;
        if (currentQuestion == myQuestions.length) {
            summary();
        } else {
            myView.questionView(myQuestions[currentQuestion]);
        }
    }

    function summary() {
        myView.summaryView(correctCounter);
    }

    myController.getQuestions = getQuestions;
    myController.checkQuestion = checkQuestion;
})();
