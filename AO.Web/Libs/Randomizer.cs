using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AO.Web.Libs
{
    public static class Randomizer
    {
        private static Random _random = new Random();

        public static string GetRandomArrayContent(string[] arr)
        {
            if (arr == null || !arr.Any())
                return string.Empty;

            return arr
                .Select(a => new KeyValuePair<int, string>(_random.Next(), a))
                .OrderBy(a => a.Key)
                .Select(a => a.Value)
                .First();
        }

    }
}