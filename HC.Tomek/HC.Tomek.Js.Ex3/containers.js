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
    var questionText = document.createElement("p");
    var questionAnswerRadio = document.createElement("input");
    questionAnswerRadio.setAttribute("type", "radio");
    var questionAnswerText = document.createElement("label");
    questionaire.generateAsync(questionNumber, function (questions) {
        //for (var i = 1; i < questionNumber + 1; i++) {
            questionText.innerHTML = questions[0].text;
            quizContainer.appendChild(questionText);
            questionAnswerText.innerHTML = questions[0].answears[0].text;
            quizContainer.appendChild(questionAnswerRadio);
            quizContainer.appendChild(questionAnswerText);

        }

        //quizContainer.innerHTML = JSON.stringify(questions);
    );
    
}


