#include <iostream>
#include <string>
#include <time.h>
#include <stack>

using namespace std;

//CREACION DE PILA PRINCIPAL
stack<int> s;
//PILA AUXILIAR
stack<int> b;

//Lee los elementos del stack principal para comprobrar que no haya elementos repetidos en la pila
bool leerstack(int r) {
	bool comp = true;

	if (s.empty()) {
		return true;
	}

	while (s.empty()== false) {

		int aux2 = 0;
		aux2 = s.top();

		if (aux2 == r) {
			comp = false;
		}
		s.pop();
		b.push(aux2);
	}
	while (b.empty() == false) {
		int aux2 = 0;
		aux2 = b.top();
		b.pop();
		s.push(aux2);
	}
	
	if (comp == true) {
		return true;
	}
	else if (comp == false) {
		return false;
	}
}

//Genera un random, el cual luego es metido a la pila (Si no existe ya ese numero dentro de la pila), hasta tener n cantidad
//de elementos en la pila
void random(int n){
	int aux = 0;

	while (aux < n) {

		int random = 1 + rand() % (n);

		if (leerstack(random)==true) {

			s.push(random);
			aux++;
		}

	}

}


int main() {

	int n;
	cout << "Ingrese el numero de casos posibles: ";
	cin >> n;

	random(n);

	cout << "\nLOS VALORES SON: "<<endl;
	int i = 0;
	while (s.empty() == false) {
		int aux3 = s.top();
		cout << i + 1 << ". " << aux3 << endl;
		s.pop();
		i++;
	}



	return 0;
}