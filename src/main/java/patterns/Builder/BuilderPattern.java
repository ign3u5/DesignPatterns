package patterns.Builder;

import patterns.Utils.IO;

public class BuilderPattern {
  private final IO io;

  // what else does this allow us to do? (hint: H1 instead of Header:)
  private final AbstractStringBuilder stringBuilder;
  private final StringDirector stringDirector;

  public BuilderPattern(IO io, AbstractStringBuilder stringBuilder, StringDirector stringDirector) {
    this.io = io;
    this.stringBuilder = stringBuilder; 
    this.stringDirector = stringDirector;
  }

  public void run() {
    String result = stringBuilder
      .AddFooter("footer")
      .AddHeader("header")
      .AddContent("content")
      .Build();

    result = stringDirector.buildDefaultString();

    io.write(result);
  }
}
