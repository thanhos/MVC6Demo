﻿using System.Collections.Generic;
using System.Linq;

namespace MVC6Demo.Models
{
  public class HeroManager
  {
    private readonly List<DOTAHero> _heroes = new List<DOTAHero>
    {
      new DOTAHero
      {
        ID = 1,
        Name = "Bristleback",
        Type = "Strength"
      },
      new DOTAHero
      {
        ID = 2,
        Name = "Abbadon",
        Type = "Strength"
      },
      new DOTAHero
      {
        ID = 3,
        Name = "Spectre",
        Type = "Agility"
      },
      new DOTAHero
      {
        ID = 4,
        Name = "Juggernaut",
        Type = "Agility"
      },
      new DOTAHero
      {
        ID = 5,
        Name = "Lion",
        Type = "Intelligence"
      },
      new DOTAHero
      {
        ID = 6,
        Name = "Zues",
        Type = "Intelligence"
      },
      new DOTAHero
      {
        ID = 7,
        Name = "Trent",
        Type = "Strength"
      }
    };

    public IEnumerable<DOTAHero> GetAll => _heroes;

    public List<DOTAHero> GetHeroesByType(string type)
    {
      return _heroes.Where(o => o.Type.ToLower().Equals(type.ToLower())).ToList();
    }
  }
}