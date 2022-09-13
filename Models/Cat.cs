// NOTE namespace organized the code for later utilization

using System.ComponentModel.DataAnnotations;

namespace catRoundUp.Models
{
  public class Cat
  {
    public Cat(string name, int age, string color, string gender, bool isFussy, int lives, int id)
    {
      Name = name;
      Age = age;
      Color = color;
      Gender = gender;
      IsFussy = isFussy;
      Lives = lives;
      // NOTE generate random id
      Id = id;
    }
    // NOTE wont need this going forward, just some funky ness with fake db.
    public Cat()
    {

    }

    [Required]
    [MaxLength(15)]
    public string Name { get; set; }
    public int Age { get; private set; }
    public string Color { get; set; }
    public string Gender { get; set; }
    public bool? IsFussy { get; set; }
    public int? Lives { get; set; }

    public int Id { get; set; }

  }

}