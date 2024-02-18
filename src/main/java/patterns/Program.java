package patterns;

import patterns.Decorator.Calculator;
import patterns.Decorator.ComplexCalculator;
import patterns.Decorator.ConsoleCalculatorDecorator;
import patterns.Decorator.DecoratorPattern;
import patterns.Factory.Vehicle;
import patterns.Factory.VehicleFactory;
import patterns.Utils.Console;
import patterns.Utils.IO;

public class Program {
  public static void main(String...args) {
    IO io = new Console();

    // DECORATOR PATTERN
    // Calculator calculator = new ComplexCalculator();
    // Calculator consoleCalculator = new ConsoleCalculatorDecorator(io, calculator);

    // DecoratorPattern decoratorPattern = new DecoratorPattern(io, consoleCalculator);
  }
}