package patterns.Strategy;

public class DivisionStrategy implements CalculationStrategy {

  @Override
  public int calculate(int a, int b) {
    return a / b;
  }

  @Override
  public boolean isSupported(String calculationType) {
    return calculationType.equals("d");
  }
}