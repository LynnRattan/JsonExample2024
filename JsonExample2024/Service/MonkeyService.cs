using JsonExample2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonExample2024.Service
{
   public class MonkeyService
    {
        private MonkeyList monkeys;
        public List<Monkey> Monkeys { get => monkeys.Monkeys; }

        public MonkeyService() 
        { 
            monkeys = new MonkeyList();
        }

        public void PrintMonkeys()
        {
            foreach(Monkey m in Monkeys)
            {
                Console.WriteLine(m.ToString());
            }
        }
        public Monkey BasicMonkeyDeserializtion(string str)
        {
            return JsonSerializer.Deserialize<Monkey>(str);
        }

            public void AddJson(Monkey monkey)
        {
            string json = JsonSerializer.Serialize(monkey);
            Monkey newMonkey = BasicMonkeyDeserializtion(json);
            Monkeys.Add(newMonkey);
        }
    }
}
