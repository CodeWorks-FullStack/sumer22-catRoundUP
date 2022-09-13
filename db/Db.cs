using System.Collections.Generic;
using catRoundUp.Models;

namespace catRoundUp.db
{
  public static class Db
  {
    public static List<Cat> Cats { get; set; } = new List<Cat>(){
     new Cat("Mr. Wrinklebum", 12, "Black and white", "M", true, 8, 1),
     new Cat("Mrs. Wrinklebum", 13, "white", "F", false, 0, 2),
     new Cat("Little Wrinkle bottom", 2, "white", "F", true, 9, 3),
     new Cat("Wrinklebum .jr", 3, "Gray", "M", true, 9, 4),
     new Cat("Harrington", 2, "Black", "F", false, 9, 5),
     new Cat("Toby", 10, "Calico", "F", true, 7, 6)
    };
  }
}