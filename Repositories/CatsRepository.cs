using System;
using System.Collections.Generic;
using catRoundUp.db;
using catRoundUp.Models;

namespace catRoundUp.Repositories
{

  public class CatsRepository
  {
    // NOTE fake db stuff will change in the future


    internal List<Cat> GetCats()
    {
      return Db.Cats;
    }

    internal Cat CreateCat(Cat body)
    {
      // NOTE we won't be assigning ids after today
      body.Id = Db.Cats.Count + 1;

      Db.Cats.Add(body);
      return body;
    }

    internal Cat GetCatById(int id)
    {
      // NOTE this is what we want to do but cause we are fakeing it now it is weird
      Cat cat = Db.Cats.Find(c => c.Id == id);
      if (cat != null)
      {
        return cat;
      }
      throw new Exception("No cat at that id");
    }

    internal Cat UpdateCat(Cat update)
    {
      Cat original = GetCatById(update.Id);
      original.Name = update.Name != null ? update.Name : original.Name;
      //   NOTE updating numbers and bools are funky
      original.Lives = update.Lives ?? original.Lives;
      original.IsFussy = update.IsFussy ?? original.IsFussy;
      //   save to data base (or do nothing if your database is fake)
      return original;
    }
    internal string DeleteCat(int id)
    {
      Cat cat = Db.Cats.Find(c => c.Id == id);
      if (!Db.Cats.Remove(cat))
      {
        throw new Exception("no cat at that id");
      }
      return $"{cat.Name} was deleted";
    }

  }
}