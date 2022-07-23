string? inputLine = Console.ReadLine();
string? line="";


if(inputLine != null)
{
  
  int size = int.Parse(inputLine);
  int start = 0;
  while(start <size)
  {
    
    start=start+1;
    if(start% 2==0)
    {
     line=line+start+" "; 
    
    }
      
  
  
  
  
  
  }
Console.WriteLine(line); 
}
