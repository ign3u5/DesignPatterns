package patterns.Strategy;

public interface CalculationStrategy extends Supported {
  public int calculate(int a, int b);
}