var myView = myView || {};

(function (){
    var stage1 = document.getElementById("stage1");
    var stage2 = document.getElementById("stage2");
    var quest = document.getElementById("question");
    var answer = Array();
    answer[0] = document.getElementById("answer1");
    answer[1] = document.getElementById("answer2");
    answer[2] = document.getElementById("answer3");
    answer[3] = document.getElementById("answer4");
    var stage3 = document.getElementById("stage3");
    var correctAnswers = document.getElementById("correctAnswers");

    var setView2 = function (question) {
        var value = "answer";
        var isValid = false;

        quest.innerHTML = question.text;
        for (var i = 0; i < 4; i++) {
            if (i < question.answears.length) {
                value = question.answears[i].text
                isValid = true;
            }else{
                value = "";
                isValid = false;
            }
            prepareAnswer(i, value, isValid);
        }
    }

    var prepareView2 = function () {
        prepareView(stage1, stage2);
    }

    var setView3 = function (correctCounter) {
        prepareView(stage2, stage3);
        correctAnswers.innerHTML = correctCounter;
    }

    var prepareView = function (from, to) {
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
    myView.prepareQuestionView = prepareView2;
    myView.questionView = setView2;
    myView.summaryView = setView3;

})();
