package patterns.Strategy;

public interface AbstractCalculationStrategyFactory {
  public CalculationStrategy createStrategy(String calculationType);
}