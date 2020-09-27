using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Trainer> trainersNames = new Dictionary<string, Trainer>();

            while (input != "Tournament")
            {
                string[] splitedInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string trainerName = splitedInput[0];
                string pokemonName = splitedInput[1];
                string pokemonElement = splitedInput[2];
                int pokemonHealth = int.Parse(splitedInput[3]);

                if (!trainersNames.ContainsKey(trainerName))
                {
                    trainersNames.Add(trainerName, new Trainer(trainerName));
                }

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                trainersNames[trainerName].Pokemons.Add(pokemon);

                input = Console.ReadLine();
            }
            //"{trainerName} {badges} {numberOfPokemon}"

            string element = Console.ReadLine();

            while (element != "End")
            {
                foreach (var currentTrainer in trainersNames)
                {
                    if (currentTrainer.Value.Pokemons.Any(x => x.Element == element))
                    {
                        currentTrainer.Value.Badges++;
                    }
                    else
                    {
                        //currentTrainer.Value.Pokemons.ForEach(p => p.Heath -= 10);
                        foreach (var curremtpokemon in currentTrainer.Value.Pokemons)
                        {
                            curremtpokemon.Heath -= 10;
                        }

                        currentTrainer.Value.Pokemons.RemoveAll(p => p.Heath <= 0);
                    }
                }
                element = Console.ReadLine();
            }
            trainersNames.OrderByDescending(t => t.Value.Badges)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Key} {x.Value.Badges} {x.Value.Pokemons.Count}"));
        }
    }
}