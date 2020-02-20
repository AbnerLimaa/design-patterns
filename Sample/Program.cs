using Common;
using Common.Composite;
using Sample.Problems.MathematicalExpressions;
using Sample.Weave;
using Sample.Weave.Requests;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a Design Pattern");
            IList<DesignPatternId> designPatterns = Enum.GetValues(typeof(DesignPatternId)).Cast<DesignPatternId>().ToList();
            IDictionary<int, DesignPatternId> dictionary = new Dictionary<int, DesignPatternId>();

            for (int i = 0; i < designPatterns.Count; i++)
            {
                DesignPatternId id = designPatterns[i];
                dictionary.Add(i, id);
                Console.WriteLine("{0} - {1}", i, id.ToString());
            }

            int option = Convert.ToInt32(Console.ReadLine());
            DesignPatternId designPattern;
            dictionary.TryGetValue(option, out designPattern);

            IWeave weave = new WeaveConfig();
            IRequest request = new DesignPatternRequest(designPattern);
            weave.Execute(request);
        }
    }
}
