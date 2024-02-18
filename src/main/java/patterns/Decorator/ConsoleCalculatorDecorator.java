package patterns.Decorator;

import patterns.Utils.IO;

public class ConsoleCalculatorDecorator implements Calculator {
  private final IO io;
  private final Calculator innerCalculator;

  public ConsoleCalculatorDecorator(IO io, Calculator innerCalculator) {
    this.io = io;
    this.innerCalculator = innerCalculator;
  }

  @Override
  public int calculate(int a, int b) {
    int result = innerCalculator.calculate(a, b);
    
    io.write("The result is: " + result);

    return result;
  }
  
}
