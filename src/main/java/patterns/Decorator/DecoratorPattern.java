package patterns.Decorator;

import patterns.Utils.IO;

public class DecoratorPattern {
  private final IO io;
  private final Calculator calculator;

  public DecoratorPattern(IO io, Calculator calculator) {
    this.io = io;
    this.calculator = calculator;
  }

  public void run() {
    int result = calculator.calculate(5, 6);

    int finalResult = calculator.calculate(result, 7) + 5;

    io.write("The final result is: " + finalResult);
  }
}
