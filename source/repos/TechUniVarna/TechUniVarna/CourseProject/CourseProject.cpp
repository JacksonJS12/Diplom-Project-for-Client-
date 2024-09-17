#include<iostream>
#include<iomanip>

using namespace std;

void inputArray(float P[], int& N);
float averageSum(float P[], int N, float min, float max);
void findMaxPositiveNumber(float P[], int N, float& maxPositive, int& maxPositiveIndex);
void displayResults(float P[], int N, float min, float max, float arithmeticMean, float maxPositive, int maxPositiveIndex);

int main() {
	const int MAX_SIZE = 25;
	float P[MAX_SIZE];
	int N;
	float min, max;

	cout << "1. Vuvedi masiv\n";
	cout << "2. Presmetni srednoaritmetichnata stoinost v zadaeniq interval\n";
	cout << "3. Nameri nai-golqmoto positivno chislo\n";
	cout << "4. Izhod\n";

	int choice;
	do {
		cout << "\nIzberi funkciq (1-4): ";
		cin >> choice;

		switch (choice) {
		case 1:
			inputArray(P, N);
			break;
		case 2:
			cout << "Zadai interval [min, max]:\n";

			cout << "min: ";
			cin >> min;

			cout << "max: ";
			cin >> max;
			if (N > 0) {
				float arithmeticMean = averageSum(P, N, min, max);
				displayResults(P, N, min, max, arithmeticMean, 0, 0);
			}
			else {
				cout << "Masivut e prazen. Purvo vuvedi masiv.\n";
			}
			break;
		case 3:
			if (N > 0) {
				float maxPositive;
				int maxPositiveIndex;
				findMaxPositiveNumber(P, N, maxPositive, maxPositiveIndex);
				displayResults(P, N, 0, 0, 0, maxPositive, maxPositiveIndex);
			}
			else {
				cout << "Masivut e prazen. Purvo vuvedi masiv.\n";
			}
			break;
		case 4:
			cout << "Programata prikluchi. Dovijdane!\n";
			break;
		default:
			cout << "Nevaliden izbor. Molq vuvedete nomer na validna funkciq.\n";
		}
	} while (choice != 4);

	return 0;
}

void inputArray(float P[], int& N) {
	cout << "Vuvedi razmeri na masiva (N <= 25): ";
	cin >> N;

	if (N > 0 && N <= 25) {
		cout << "Vuvedi elemnti v masiva:\n";
		for (int i = 0; i < N; ++i) {
			cout << "P[" << i << "]: ";
			cin >> P[i];
		}
		cout << "Vuvejdaneto na masiva beshe uspeshno.\n";
	}
	else {
		cout << "Nevalidni razmeri na masiva. Vuvedi validni.\n";
		N = 0;
	}
}

float averageSum(float P[], int N, float min, float max) {
	int count = 0;
	float sum = 0;

	for (int i = 0; i < N; ++i) {
		if (P[i] > 0 && P[i] >= min && P[i] <= max) {
			sum += P[i];
			++count;
		}
	}

	if (count > 0) {
		return sum / count;
	}
	else {
		cout << "Nqma pozitivni chisla v zadadeniq interval.\n";
		return 0;
	}
}

void findMaxPositiveNumber(float P[], int N, float& maxPositive, int& maxPositiveIndex) {
	maxPositive = P[0];
	maxPositiveIndex = 0;

	for (int i = 1; i < N; ++i) {
		if (P[i] > maxPositive) {
			maxPositive = P[i];
			maxPositiveIndex = i;
		}
	}
}

void displayResults(float P[], int N, float min, float max, float arithmeticMean, float maxPositive, int maxPositiveIndex) {
	cout << "\nElementi v masiva:\n";
	for (int i = 0; i < N; ++i) {
		cout << "P[" << i << "]: " << P[i] << endl;
	}

	if (min != 0 || max != 0) {
		cout << fixed << setprecision(2);
		cout << "\nSrednoaritmetichna suma v interval [" << min << ", " << max << "]: " << arithmeticMean << endl;
	}

	if (maxPositive != 0) {
		cout << "\nNai-golqmoto pozitivno chislo e: " << maxPositive << endl;
		cout << "Poziciq v masiva: " << maxPositiveIndex << endl;
	}
}
