function startPage() {
    document.getElementById("quiz").style.display = "none";
    document.getElementById("result").style.display = "none";
    var startContainer = document.getElementById("start");
    var startButton = document.createElement("button");
    startButton.innerHTML = "Start";
    startContainer.appendChild(startButton);
    startButton.addEventListener("click", function () {
        document.getElementById("start").style.display = "none";
        document.getElementById("quiz").style.display = "";
        quizPage();
    })
}
startPage();

function quizPage() {
    var quizContainer = document.getElementById("quiz");
    var questionNumber = 2;
    var questionText = new Array(questionNumber);
    
    var questionAnswerRadio = new Array(questionNumber);
    var questionAnswerText = new Array(questionNumber);
    var answerControl = new Array(questionNumber);

    questionaire.generateAsync(questionNumber, function (questions) {
        for (var j = 0; j < questionNumber; j++) {
            questionText[j] = document.createElement("p");
            questionText[j].innerHTML = questions[j].text;
            var answerNumber = questions[j].answears.length;
            quizContainer.appendChild(questionText[j]);
            for (var i = 0; i < answerNumber; i++) {
                answerControl[i] = document.createElement("p");
                questionAnswerRadio[i] = document.createElement("input");
                questionAnswerRadio[i].setAttribute("type", "radio");
                questionAnswerText[i] = document.createElement("label");
                questionAnswerText[i].innerHTML = questions[j].answears[i].text;
                answerControl[i].appendChild(questionAnswerRadio[i]);
                answerControl[i].appendChild(questionAnswerText[i]);
                quizContainer.appendChild(answerControl[i]);

            }
            var nextButton = document.createElement("button");
            nextButton.innerHTML = "Next";
            quizContainer.appendChild(nextButton);
            nextButton.addEventListener("click", function () {
                //questionText[j].style.display = "none";
                for (var i = 0; i < answerNumber; i++) {
                    answerControl[i].style.display = "none";
                }
            });

        }

        }

        //quizContainer.innerHTML = JSON.stringify(questions);
    );
    
}


