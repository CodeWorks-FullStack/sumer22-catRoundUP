using System.Collections.Generic;
using catRoundUp.Models;
using catRoundUp.Repositories;

namespace catRoundUp.Services
{
  public class CatsService
  {
    // NOTE this line says it WILL have a _catRepo
    private readonly CatsRepository _catRepo;

    // NOTE the constructor here actually assigns one
    public CatsService(CatsRepository catRepo)
    {
      _catRepo = catRepo;
    }

    internal List<Cat> GetCats()
    {
      List<Cat> cats = _catRepo.GetCats();
      return cats;
    }

    internal Cat GetCatById(int id)
    {
      Cat cat = _catRepo.GetCatById(id);
      return cat;
    }

    internal Cat CreateCat(Cat body)
    {
      Cat cat = _catRepo.CreateCat(body);
      return cat;
    }

    internal Cat UpdateCat(Cat update)
    {
      return _catRepo.UpdateCat(update);
    }
    internal string DeleteCat(int id)
    {
      return _catRepo.DeleteCat(id);
    }

  }
}