package patterns.Utils;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Console implements IO {

  @Override
  public void write(String message) {
    System.out.println(message);
  }

  @Override
  public String read() {
    BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

    String output = "";

    try {
      output = reader.readLine();
    } catch (IOException e) {
      e.printStackTrace();
    }
    
    return output;
  }
}