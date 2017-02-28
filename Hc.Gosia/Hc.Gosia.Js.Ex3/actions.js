var actions = actions || {};

(function () {
    function hideElement(id) {
        document.getElementById(id).hidden = 'hidden';
    }
    actions.hideElement = hideElement;

    function showElement(id) {
        document.getElementById(id).hidden = "";
    }
    actions.showElement = showElement;

    function getElementById(id) {
        return document.getElementById(id);
    }
    actions.getElementById = getElementById;

    function onClickAction(id, fun) {
        return document.getElementById(id).onclick = function () { fun };
    }
    actions.onClickAction = onClickAction;

    function setElementAsUnchecked(name) {
        choices = document.getElementsByName(name);
        for (var i = 0; i < (choices.length) ; i++) {
            if (choices[i].checked) {
                choices[i].checked = false;
            }
        }
    }
    actions.setElementAsUnchecked = setElementAsUnchecked;

    function findCheckedElement(name) {
        var choice = 10;
        choices = document.getElementsByName("choices");
        for (var i = 0; i < (choices.length) ; i++) {
            if (choices[i].checked) {
                choice = choices[i].value;
            }
        }
        return choice;
    }
    actions.findCheckedElement = findCheckedElement;
})();