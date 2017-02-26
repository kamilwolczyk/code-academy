var quiz = quiz || {};



(function () {
    var questionCount = 4;
    var score = 0;
    var letters = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'];
    var questionText;
    var questionsArray;


    function getQuestionAnswer(questionCount) {
        if (questionaire == null) {
            alert('Questionaire library not found!');
        }

        questionaire.generateAsync(questionCount, function (questions) {
            questionsArray = questions;
            start();
        });



    }

    function prepareQuestionText(questionIndex) {
        var currentQuestion = questionsArray[questionIndex];
        questionText = 'This is question numer' + questionIndex + "\n" + currentQuestion.text + '\n';

        for (var ix = 0; ix < currentQuestion.answears.length; ix++) {
            questionText += letters[ix] + '). ' + currentQuestion.answears[ix].text;
            if (ix < currentQuestion.answears.length - 1) {
                questionText += '\n';
            }

        }


    }
    function showQGetA(questionIndex) {
        var currentQuestion = questionsArray[questionIndex];
        var correctanswerLetter = false;
        var addonce = false;
        do {
            var answer = prompt(questionText);
            var selectedAnswerIndex = letters.indexOf(answer);

            if (selectedAnswerIndex !== -1 && selectedAnswerIndex <= currentQuestion.answears.length - 1) {
                calculateScore(questionIndex, selectedAnswerIndex);
                correctanswerLetter = true;
            } else {
                if (!addonce) {
                    addonce = true;
                    questionText = questionText + "\n" + "Possible anwers:";
                    for (var ix = 0; ix < currentQuestion.answears.length; ix++) {
                        questionText = questionText + " " + letters[ix];

                    }
                }
            }
        }
        while (!correctanswerLetter)

    }

    function calculateScore(questionIndex, selectedAnswerIndex) {
        if (questionsArray[questionIndex].answears[selectedAnswerIndex].isCorrect) {
            score += 1;
        }
    }



    function showSummary() {
        document.write("Your scoure is " + score + " out of " + questionCount);
    }



    function start() {
        if (!questionsArray || !questionsArray.length) {
            throw new Error('QuestionsArray not found');
        }
        for (var i = 0; i < questionCount; i++) {
            prepareQuestionText(i)
            showQGetA(i)
        }
        showSummary()
    }

    function prepareQuestionsArrayAndStart() {
        getQuestionAnswer(questionCount)
    }



    quiz.start = prepareQuestionsArrayAndStart;

})();