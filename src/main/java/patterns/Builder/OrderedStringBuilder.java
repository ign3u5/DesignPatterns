package patterns.Builder;

public class OrderedStringBuilder implements AbstractStringBuilder{
  private String header;
  private String content;
  private String footer;

  @Override
  public AbstractStringBuilder AddHeader(String header) {
    this.header = header;

    return this;
  }

  @Override
  public AbstractStringBuilder AddContent(String content) {
    this.content = content;

    return this;
  }

  @Override
  public AbstractStringBuilder AddFooter(String footer) {
    this.footer = footer;

    return this;
  }

  @Override
  public String Build() {
    return "Header: " + header + " Content: " + content + " Footer: " + footer;
  }
}
