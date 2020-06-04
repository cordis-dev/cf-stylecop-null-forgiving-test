namespace A
{
    public class Test
    {
		  public ImageData Image1 { get; set; } = null!;
		  private ImageData Image2 = null!;
		
		  public void Main()
		  {
			  Person? p = Find("John");
			  var name = p!.Name;
		  }
    }
}
