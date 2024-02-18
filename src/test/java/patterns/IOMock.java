package patterns;

import patterns.Utils.IO;

public class IOMock implements IO {
  public String input;
  public String output;

  public String read() {
    return input;
  }

  public void write(String output) {
    this.output = output;
  }
}