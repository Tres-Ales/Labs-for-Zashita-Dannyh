#pragma once
void WhileIncorect() {
	int i;
	while (i < (i+1))
	{
		std::cout << i;
	}
}

void ForIncorrect() {
	for (int i; i < 2; i++) {
		i += 2;
	}
}

double Divide(int a, int b) {
	double result = 0;
	return a/b;
}

void ptr(int* p)
{
	*p = 0;
}

bool isNegative(int x)
{
	if (!!(x < 0)) return true;
}