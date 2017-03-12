var myView = myView || {};

(function (){
    var startStage = document.getElementById("startStage");
    var questionStage = document.getElementById("questionStage");
    var quest = document.getElementById("question");
    var answer = Array();
    var resultStage = document.getElementById("resultStage");
    var correctAnswers = document.getElementById("correctAnswers");

    var showQuestionView = function (question) {
        var value = "answer";
        var isValid = false;

        quest.innerHTML = question.text;
        for (var i = 0; i < 4; i++) {
            if (i < question.answears.length) {
                value = question.answears[i].text;
                isValid = true;
            }else{
                value = "";
                isValid = false;
            }
            prepareAnswer(i, value, isValid);
        }
    }

    var createQuestionViewDomElements = function () {
        setContainersVisibility(startStage, questionStage);
        for (var i = 0; i < 4; i++) {
            //answer[i] = document.getElementById("answer["+i+"]");
            answer[i] = document.createElement("button");
            answer[i].myId = i;
            questionStage.appendChild(answer[i]);
            answer[i].addEventListener("click", function () {
                myController.checkQuestion(this.myId)
            },false);
        }
    }

    var showAnswerView = function (correctCounter) {
        setContainersVisibility(questionStage, resultStage);
        correctAnswers.innerHTML = correctCounter;
    }

    var setContainersVisibility = function (from, to) {
        from.className += " hidden";
        from.classList.remove("visible");
        to.className += " visible";
    }

    var prepareAnswer = function (id, value, isValid) {
        if (isValid) {
            answer[id].classList.remove("hidden");
        } else {
            answer[id].className += " hidden";
        }
        answer[id].innerHTML = value;
    }

    myView.prepareQuestionView = createQuestionViewDomElements;
    myView.questionView = showQuestionView;
    myView.summaryView = showAnswerView;

})();
