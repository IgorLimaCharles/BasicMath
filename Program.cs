using System;


// Perímetro do Quadrado
int PerimetroDoQuadrado (int basee) {
    return basee * 4;
}

int pQ = PerimetroDoQuadrado(10);
Console.WriteLine($"O perímetro do quadrado é {pQ}");



// Área do Triângulo
int CalcAreaTriang (int b, int height) {
    return (b * height) / 2;
}

int aT = CalcAreaTriang(20, 12);
Console.WriteLine(aT);



// Área da Circunferência
double Circ (double raio) {
    return Math.Round((Math.Pow(2, raio) * Math.PI), 2);
}

double aC = Circ(2);
Console.WriteLine(aC);



// Qual quadrado é maior baseado em perímetro?
string CompQuadrados (int b1, int b2) {
    int q1 = PerimetroDoQuadrado(b1);
    int q2 = PerimetroDoQuadrado(b2);

    string x = string.Empty;
    
    if (q1 == q2)
        x = "Os dois quadrados são iguais";
    if (q1 > q2)
        x = "O quadrado 1 é maior que o quadrado 2";
    else
        x = "O quadrado 2 é maior que o quadrado 1";

    return x;
}

string cQ = CompQuadrados(4, 5);
Console.WriteLine(cQ);


//Volume de um cubo simples

double VolCuboSimples (int b) {
    return Math.Pow(b, 3);
}

double vC = VolCuboSimples(5);
Console.WriteLine(vC);


// Volume de um cubo composto

double volCuboComp (int b, int h, int r) {
    return ((b*h)*r);
}

double vCc = volCuboComp(5, 5, 5);
Console.WriteLine(vCc);


