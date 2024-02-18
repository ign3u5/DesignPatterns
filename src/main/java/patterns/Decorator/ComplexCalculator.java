package patterns.Decorator;

public class ComplexCalculator implements Calculator {

  @Override
  public int calculate(int a, int b) {
    return a + b;
  }
}