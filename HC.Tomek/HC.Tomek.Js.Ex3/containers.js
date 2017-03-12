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
    var correctAnswers = 0;
    var currentQuestionNumber = 0;
    var questionText = new Array(questionNumber);
    
    var questionAnswerRadio = new Array(questionNumber);
    var questionAnswerText = new Array(questionNumber);
    var answerControl = new Array(questionNumber);
    for (var z = 0; z < maximumAnswers; z++) {
        questionAnswerRadio[z] = new Array(maximumAnswers);
        questionAnswerText[z]= new Array(maximumAnswers);
        answerControl[z] = new Array(maximumAnswers);
    }
    
    var questionStatus = document.createElement("label");
    questionStatus.innerHTML = (currentQuestionNumber + 1) + " / " + questionNumber + " ";
    quizContainer.appendChild(questionStatus);
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
                answerControl[j][i] = document.createElement("p");
                questionAnswerRadio[j][i] = document.createElement("input");
                questionAnswerRadio[j][i].setAttribute("type", "radio");
                questionAnswerRadio[j][i].name = "answer";
                questionAnswerRadio[j][i].onchange = onRadioClick(j,i);
                questionAnswerText[j][i] = document.createElement("label");
                questionAnswerText[j][i].innerHTML = questions[j].answears[i].text;
                answerControl[j][i].appendChild(questionAnswerRadio[j][i]);
                answerControl[j][i].appendChild(questionAnswerText[j][i]);
                if (j>0) {
                    answerControl[j][i].style.display = "none";
                }
                quizContainer.appendChild(answerControl[j][i]);

            }

        }
        nextButton.addEventListener("click", function () {
            
            
            if (currentQuestionNumber >= questionNumber-1) {
                nextButton.style.display = "none";
                questionStatus.style.display = "none";
                questionText[currentQuestionNumber].style.display = "none";
                for (var c = 0; c < questions[currentQuestionNumber].answears.length; c++) {
                    answerControl[currentQuestionNumber][c].style.display = "none";
                    if ((questionAnswerRadio[currentQuestionNumber][c].checked == true) &&
                        (questions[currentQuestionNumber].answears[c].isCorrect == true)) {
                        correctAnswers++;
                    }
                }
                
                resultPage(correctAnswers, questionNumber);
            }
            else {
                questionText[currentQuestionNumber].style.display = "none";
                for (var c = 0; c < questions[currentQuestionNumber].answears.length; c++) {
                    answerControl[currentQuestionNumber][c].style.display = "none";
                    if ((questionAnswerRadio[currentQuestionNumber][c].checked == true) &&
                        (questions[currentQuestionNumber].answears[c].isCorrect == true)) {
                        correctAnswers++;
                    }
                    }
                
                questionText[currentQuestionNumber + 1].style.display = "";
                for (var g = 0; g < questions[currentQuestionNumber + 1].answears.length; g++) {
                    answerControl[currentQuestionNumber + 1][g].style.display = "";
                }
                if (currentQuestionNumber >= questionNumber - 2) nextButton.innerHTML = "End";

            }
            currentQuestionNumber++;
            questionStatus.innerHTML = (currentQuestionNumber + 1) + " / " + questionNumber + " ";
            
        });

        });
    
}

function resultPage(correctAnswers,questionNumber) {
    var result = document.getElementById("result");
    result.style.display = "";
    var wynik = document.createElement("label");
    wynik.innerHTML = "Wynik: " + correctAnswers +"/" + questionNumber;
    result.appendChild(wynik);
    
}



