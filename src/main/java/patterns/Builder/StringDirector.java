package patterns.Builder;

public class StringDirector {
  private final AbstractStringBuilder stringBuilder;

  public StringDirector(AbstractStringBuilder stringBuilder) {
    this.stringBuilder = stringBuilder;
  }

  public String buildDefaultString() {
    return stringBuilder
      .AddHeader("header")
      .AddContent("content")
      .AddFooter("footer")
      .Build();
  }
}