document.getElementById("choose_figure").addEventListener('change', (event) => {
    document.getElementById("calculate_button").value = event.target.value;
    document.getElementById("calculate_button").disabled = false;
    document.getElementById("InputData").style.display = "inline";
    console.log(event.target.value);
    var description = document.getElementById("description");
    if (event.target.value === "Oblicz pole kwadratu"){
        description.innerText = "Podaj wartość długości jednego boku kwadratu np.:1";
    }
    else if (event.target.value === "Oblicz pole prostokąta") {
        description.innerText = "Podaj wartość długości dwóch boków, oddzielone jedną spacją np.:1 2";
    }
    else if (event.target.value === "Oblicz pole równoległoboku") {
        description.innerText = "Podaj wartość długości podstawy oraz wysokości, oddzielone jedną spacją np.:1 2";
    }
    else if (event.target.value === "Oblicz pole trapezu") {
        description.innerText = "Podaj wartość długości dwóch podstaw oraz wysokości, oddzielone jedną spacją np.:1 2 3";
    }
    else if (event.target.value === "Oblicz pole koła") {
        description.innerText = "Podaj wartość promienia np.:1";
    }
    else if (event.target.value === "Oblicz pole trójkąta") {
        description.innerText = "Podaj wartość podstawy oraz wysokość oddzielone jedną spacją np.:1 2";
    }
    else if (event.target.value === "Oblicz pole rombu") {
        description.innerText = "Podaj wartość długości dwóch przekątnych, oddzielonych jedną spacją np.:1 2";
    }
});