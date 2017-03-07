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
    var questionNumber = 3;
    var maximumAnswers = 4;
    var currentQuestionNumber = 0;
    var questionText = new Array(questionNumber);
    
    var questionAnswerRadio = new Array(questionNumber, maximumAnswers);
    var questionAnswerText = new Array(questionNumber, maximumAnswers);
    var answerControl = new Array(questionNumber, maximumAnswers);
    var questionControl = new Array(questionNumber);

    var nextButton = document.createElement("button");
    nextButton.innerHTML = "Next";
    quizContainer.appendChild(nextButton);

    questionaire.generateAsync(questionNumber, function (questions) {
        for (var j = 0; j < questionNumber; j++) {
            questionText[j] = document.createElement("p");
            questionText[j].innerHTML = questions[j].text;
            
            var answerNumber = questions[j].answears.length;
            if (j>0) {
                questionText[j].style.display = "none";
            }
            quizContainer.appendChild(questionText[j]);
            for (var i = 0; i < answerNumber; i++) {
                answerControl[j,i] = document.createElement("p");
                questionAnswerRadio[j,i] = document.createElement("input");
                questionAnswerRadio[j,i].setAttribute("type", "radio");
                questionAnswerText[j,i] = document.createElement("label");
                questionAnswerText[j,i].innerHTML = questions[j].answears[i].text;
                answerControl[j,i].appendChild(questionAnswerRadio[j,i]);
                answerControl[j,i].appendChild(questionAnswerText[j,i]);
                if (j>0) {
                    answerControl[j,i].style.display = "none";
                }
                quizContainer.appendChild(answerControl[j,i]);

            }
            
       

        }
        nextButton.addEventListener("click", function () {
            
            for (var k = 0; k < questionNumber; k++) {
                if (k == currentQuestionNumber) {
                    questionText[k].style.display = "";
                    for (var g = 0; g < questions[k].answears.length; g++) {
                        answerControl[k,g].style.display = "";
                    }
                }
                else {
                    questionText[k].style.display = "none";
                    for (var c = 0; c < questions[k].answears.length; c++) {
                        answerControl[k,c].style.display = "none";
                    }

                }
                currentQuestionNumber++;
            }

        });

        });
    
}


