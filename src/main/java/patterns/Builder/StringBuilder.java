package patterns.Builder;

public class StringBuilder implements AbstractStringBuilder{

  private String result;

  @Override
  public AbstractStringBuilder AddHeader(String header) {
    result = result + " Header: " + header;

    return this;
  }

  @Override
  public AbstractStringBuilder AddContent(String content) {
    result = result + " Content: " + content;

    return this;
  }

  @Override
  public AbstractStringBuilder AddFooter(String footer) {
    result = result + " Content: " + footer;

    return this;
  }

  @Override
  public String Build() {
    return result;
  }
}
