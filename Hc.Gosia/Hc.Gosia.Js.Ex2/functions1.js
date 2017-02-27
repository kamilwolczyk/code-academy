var questionaire = questionaire || {};

(function () {
    var points = 0;
    var question = 1;
    var questionCount = 10;
    var data = {};

    // get Questions
    function getQuestions() {
        if (questionaire == null) {
            alert('Questionaire library has not beet found!');
        }
        questionaire.generate(questionCount, function (questions) {

            // get question and answers
            var question1 = questions[0];
            var answears = new Array(question1.answears.length);
            var isOK = new Array(answears.length);

            j = 0;
            for (i = 0; i < question1.answears.length; i++) {
                answears[j] = question1.answears[i].text;
                isOK[j] = question1.answears[i].isCorrect;
                j++;
            }

            // true position
            var position = "";
            for (r = 0; r < isOK.length; r++) {
                if (isOK[r] === true) {
                    var position = r;
                }
            }
            var data = {};
            var data = { questionNumber: question, text: question1.text, answears: answears, position: position }

            questionaire.renderQuestion(data);
        });       
    }
    // render question
    function renderQuestion(data) {
   
        test.innerHTML = "<h2>" + "Question " + data.questionNumber + "<br>" + data.text + "</h3>";
        t = 0;
        while
                (t < data.answears.length) {
            test.innerHTML += "<input type='radio' name='choices' value=" + t + "> " + data.answears[t] + "<br>";
            t++;
        }
        

        test.innerHTML += "<br><button onclick='questionaire.checkAnswear(" + data.position + ")'>Submit Answer</button>";

        question++;
        return data.position;
    }

    function checkAnswear(position) {

        var choice = 10;
        choices = document.getElementsByName("choices");
        for (var i = 0; i < (choices.length); i++) {
            if (choices[i].checked) {
                choice = choices[i].value;

            }
        } 
        if (choice == position) {
            points++;
        }
        
        if (question <= questionCount) {
            getQuestions();
        }
        else {
            test.innerHTML = "<h2>You have " + points + " points<br></h2>";
            points = 0;
            question = 1;
            test.innerHTML += "<button onclick='questionaire.getQuestions()'>Do it again</button>";
        }
    }

    questionaire.getQuestions = getQuestions;
    questionaire.checkAnswear = checkAnswear;
    questionaire.renderQuestion = renderQuestion;
})();




/*
zadanie domowe:
Przygotować program przeprowadzający quiz. Zadaniem programu będzie
wyświetlać pytania w kolejności 1 - 10. Po każdym pytaniu użytkownik 
musi podać jedną odpowiedź [a, b, c, d]. Na koniec quizu (po 10 pytaniu) 
użytkownik musi zobaczyć liczbę punktów [0,10]. Po zakończeniu quizu i 
wyświetleniu wyniku, program pyta użytkownika czy chce zacząć jeszcze raz
od razy dodam opis API biblioteki z pytaniami, którą Wam napiszę:
biblioteka będzie udostępniała następujące możliwości:
quiz.start() - zwróci tablicę pytań
obiekt w tablicy:
question = { text: string,  answears: object[] }
obiekt odpowiedzi
answear = { text: string, isCorrect: boolean }
*/