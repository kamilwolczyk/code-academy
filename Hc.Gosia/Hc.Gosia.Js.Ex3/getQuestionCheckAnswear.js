var questionaire = questionaire || {};
var actions = actions || {};

(function () {
    var points = 0;
    var question = 1;
    var questionCount = 10;
    var data = {};

    // get Questions
    function getQuestions() {

        actions.hideElement("start");
        questionaire.generate(questionCount, function (questions) {

            // get question and answers
            var questionText = questions[0];
            var answears = new Array(questionText.answears.length);
            var isOK = new Array(answears.length);

            j = 0;
            for (i = 0; i < questionText.answears.length; i++) {
                answears[j] = questionText.answears[i].text;
                isOK[j] = questionText.answears[i].isCorrect;
                j++;
            }
            // true position
            var position = isOK.indexOf(true);

            var data = {};
            var data = { questionNumber: question, text: questionText.text, answears: answears, position: position }

            questionaire.renderQuestion(data);
        });
    }
    // render question
    function renderQuestion(data) {

        actions.showElement("center");
        actions.hideElement("bottom");
        //render question
        var container = document.getElementById("header").innerHTML = "Question " + data.questionNumber + "/" + questionCount + "<br>" + data.text;
        var options = document.getElementById("center").getElementsByTagName("input");

        // render answears
        t = 0;
        while (t < data.answears.length) {
            var options = document.getElementsByName("choices");
            options[t].hidden = "";
            document.getElementById("label" + t).hidden = "";
            var label = document.getElementById("label" + t);
            label.innerHTML = data.answears[t];
            t++;
        }
        actions.showElement("submit");
        if (question === 10) {

            document.getElementById("submit").innerHTML = "Send";
            document.getElementById("submit").onclick = function () { checkAnswear(data.position) };
        }
        else {
            document.getElementById("submit").innerHTML = "Next";
            document.getElementById("submit").onclick = function () { checkAnswear(data.position) };
        }

        question++;
        return data.position;
    }

    function checkAnswear(position) {

        var choice = actions.findCheckedElement("choices");

        if (choice == position) {
            points++;
        }

        if (question <= questionCount) {
            actions.setElementAsUnchecked("choices");

            getQuestions();
        }
        else {

            actions.showElement("bottom");
            var header_bottom = actions.getElementById("header_bottom"); // document.getElementById("header_bottom");
            header_bottom.innerHTML = "You have " + points + " points";
            points = 0;
            question = 1;
            actions.setElementAsUnchecked("choices");
            actions.showElement("again");
            actions.hideElement("center");
        }
    }
    questionaire.getQuestions = getQuestions;
    questionaire.checkAnswear = checkAnswear;
    questionaire.renderQuestion = renderQuestion;
})();
