package patterns.Strategy;

public class CalculationStrategyFactory {
  public CalculationStrategy createStrategy(String calculationType) {
    switch(calculationType) {
      case "d": return new DivisionStrategy();
      case "m": return new MultiplicationStrategy();
      default: return null;
    }
  }
}