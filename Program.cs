using GenericsDemo;

//array
int[] number = new int [3];
number [0] = 10;
number [1] = 12;
number [2] = 21;
string[] names = { "Ankit", "Sumit", "Manu" };
double[] values = { 23.4, 24.3, 28.3 };
char[] arrNew = { 'A', 'B', 'C' };

//for example in example static method is used so no need to create object
Example.ShowArray(number);
Example.ShowArray(names);
Example.ShowArray(values);
Example.ShowArray(arrNew);
//forGenclass
new Genclass<int>(number).PrintArray();
new Genclass<string>(names).PrintArray();
new Genclass<double>(values).PrintArray();
new Genclass<char>(arrNew).PrintArray();
