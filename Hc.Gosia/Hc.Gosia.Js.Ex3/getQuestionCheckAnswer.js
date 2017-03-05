var questionaire = questionaire || {};
var actions = actions || {};
var data = data || {};

(function () {
    var points = 0;
    var questionNo = 0;
    var questionCount = 10;
    var data = {};
    // get Questions
    function getQuestions() {
        actions.hideElement("start");
        questionaire.generate(questionCount, function (questions) {
            // get questions and answers
            var question = questions;
            data.question = question;
            renderQuestion(data.question);
        });       
    }
    // render question
    function renderQuestion(question) {
        actions.showElement("center");
        actions.hideElement("bottom");
        //render question
        var showQuestionNo = questionNo + 1;
        var container = actions.getElementById("header").innerHTML = "Question " + showQuestionNo + "/" + questionCount + "<br>" + question[questionNo].text;
        var options = actions.getElementById("center").getElementsByTagName("input");
        // render answers
        var newLabel = document.getElementsByTagName("label");
        for (i = 0; i < options.length; i++)
        {
            options[i].hidden = "hidden";
            newLabel[i].hidden = "hidden";
        }
        i = 0; 
        var answers = question[questionNo].answers;
        while (i < answers.length) {
            // ukrywanie odpowiedzi po petli
            options[i].hidden = "";
            newLabel[i].hidden = "";
            newLabel[i].innerHTML = answers[i].text;
            i++;
        }
        actions.showElement("submit");
        var submitButton = actions.getElementById("submit");
        if (questionNo === (questionCount - 1)) {
           actions.changeButtonName("submit", "Send");
           submitButton.onclick = function () { checkAnswer(answers) };
        }
        else {
            actions.changeButtonName("submit", "Next");
            submitButton.onclick = function () { checkAnswer(answers) };
        }      
        return answers;
    }
    function checkAnswer(answers) {
        var choice = actions.findCheckedElement("choices"); 
        if (choice !=null && answers[choice].isCorrect === true ) {
            points++;
        }
       if (questionNo < (questionCount - 1)) {
            actions.setElementAsUnchecked("choices");
            questionNo++;
            renderQuestion(data.question);
        }
        else {
            actions.showElement("bottom");
            var header_bottom = actions.getElementById("header_bottom");
            header_bottom.innerHTML = "You have " + points + " points";
            points = 0;
            questionNo = 0;
            actions.setElementAsUnchecked("choices");
            actions.showElement("again");
            actions.hideElement("center");
        }
    }
    questionaire.getQuestions = getQuestions;
})();
