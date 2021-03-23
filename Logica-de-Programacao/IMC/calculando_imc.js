function main() {
    var peso, altura, imc;
    
    peso = window.prompt('Enter a value for peso');
    altura = window.prompt('Enter a value for altura');
    imc = peso / (altura * altura);
    if (imc <= 18.5) {
        window.alert("Seu IMC é " + imc.toFixed(2) + ". Status: Magreza");
    } else {
        if (imc >= 18.8 && imc <= 24.9) {
            window.alert("Seu imc é " + imc.toFixed(2) + ". Status: Normal");
        } else {
            if (imc >= 25 && imc <= 29.9) {
                window.alert("Seu imc é " + imc.toFixed(2) + ". Status: Sobrepeso");
            } else {
                if (imc >= 30 && imc <= 39.9) {
                    window.alert("Seu IMC é " + imc.toFixed(2) + ". Status: Obesidade");
                } else {
                    if (imc >= 40) {
                        window.alert("Seu IMC é " + imc.toFixed(2) + ". Status: Obesidade Grave");
                    }
                }
            }
        }
    }
}
