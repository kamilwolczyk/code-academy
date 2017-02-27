var questionaire = questionaire || {};

(function () {

    function startQuiz() {
        test.innerHTML += "<br><button onclick='questionaire.getQuestions()'>Start Quiz</button>";
    }
    questionaire.startQuiz = startQuiz;
})();
