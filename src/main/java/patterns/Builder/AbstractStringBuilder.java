package patterns.Builder;

public interface AbstractStringBuilder {
  public AbstractStringBuilder AddHeader(String header);

  public AbstractStringBuilder AddContent(String content);

  public AbstractStringBuilder AddFooter(String footer);

  public String Build();
}