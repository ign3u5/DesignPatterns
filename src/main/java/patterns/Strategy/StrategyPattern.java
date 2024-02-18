package patterns.Strategy;

import patterns.Utils.IO;

public class StrategyPattern {
  private final IO io;

  public StrategyPattern(IO io) {
    this.io = io;
  }

  public void run() {
    String calculationType = io.read();
    
    CalculationStrategy calculationStrategy = getCalculationStrategy(calculationType);

    int answer = calculationStrategy.calculate(5, 5);

    io.write(Integer.toString(answer));
  }

  private CalculationStrategy getCalculationStrategy(String calculationType) {
    switch(calculationType) {
      case "d": return new DivisionStrategy();
      case "m": return new MultiplicationStrategy();
      default: return null;
    }
  }
}

// public class StrategyPattern {
//   private final IO io;
//   private final AbstractCalculationStrategyFactory calculationStrategyFactory;

//   public StrategyPattern(IO io, AbstractCalculationStrategyFactory calculationStrategyFactory) {
//     this.io = io;
//     this.calculationStrategyFactory = calculationStrategyFactory;
//   }

//   public void run() {
//     String calculationType = io.read();
    
//     CalculationStrategy calculationStrategy = calculationStrategyFactory.createStrategy(calculationType);

//     int answer = calculationStrategy.calculate(5, 5);

//     io.write(Integer.toString(answer));
//   }
// }

// public class StrategyPattern {
//   private final IO io;
//   private final CalculationStrategy[] calculationStrategies;

//   public StrategyPattern(IO io, CalculationStrategy[] calculationStrategies) {
//     this.io = io;
//     this.calculationStrategies = calculationStrategies;
//   }

//   public void run() {
//     String calculationType = io.read();
    
//     CalculationStrategy calculationStrategy = getCalculationStrategy(calculationType);
    
//     int answer = calculationStrategy.calculate(5, 5);
    
//     io.write(Integer.toString(answer));
//   }
  
//   private CalculationStrategy getCalculationStrategy(String calculationType) {
//     for (CalculationStrategy calculationStrategy : calculationStrategies) {
//       if (calculationStrategy.isSupported(calculationType)) {
//         return calculationStrategy;
//       }
//     }

//     return null;
//   }
// }
