//#include<iostream>
//
//using namespace std;
//
//const int MAX_SIZE = 25;
//
//void inputArray(double arr[], int& size) {
//    do {
//        cout << "Enter the size of the array (N <= 25): ";
//        cin >> size;
//    } while (size <= 0 || size > MAX_SIZE);
//
//    cout << "Enter elements of the array:" << endl;
//    for (int i = 0; i < size; i++) {
//        cout << "Element " << i + 1 << ": ";
//        cin >> arr[i];
//    }
//}
//
//double calculateAverageInRange(double arr[], int size, double min, double max) {
//    int count = 0;
//    double sum = 0.0;
//
//    for (int i = 0; i < size; i++) {
//        if (arr[i] >= min && arr[i] <= max && arr[i] > 0) {
//            sum += arr[i];
//            count++;
//        }
//    }
//
//    if (count == 0) {
//        return 0.0; // to avoid division by zero
//    }
//
//    return sum / count;
//}
//
//void findMaxPositiveNumber(double arr[], int size, double& maxNumber, int& maxNumberIndex) {
//    maxNumber = 0.0; // Assuming all numbers are non-negative
//    maxNumberIndex = -1;
//
//    for (int i = 0; i < size; i++) {
//        if (arr[i] > maxNumber && arr[i] > 0) {
//            maxNumber = arr[i];
//            maxNumberIndex = i;
//        }
//    }
//}
//
//int main() {
//    double arr[MAX_SIZE];
//    int size;
//    double min, max;
//
//    inputArray(arr, size);
//
//    cout << "Enter the range [min, max] for calculating the average:" << endl;
//    cout << "min: ";
//    cin >> min;
//    cout << "max: ";
//    cin >> max;
//
//    double average = calculateAverageInRange(arr, size, min, max);
//    cout << "Average of positive numbers in the specified range: " << average << endl;
//
//    double maxNumber;
//    int maxNumberIndex;
//    findMaxPositiveNumber(arr, size, maxNumber, maxNumberIndex);
//
//    if (maxNumberIndex != -1) {
//        cout << "Max positive number in the array: " << maxNumber << " at index " << maxNumberIndex << endl;
//    }
//    else {
//        cout << "No positive numbers in the array." << endl;
//    }
//
//    cout << "Elements of the array:" << endl;
//    for (int i = 0; i < size; i++) {
//        cout << arr[i] << " ";
//    }
//
//    return 0;
//}
