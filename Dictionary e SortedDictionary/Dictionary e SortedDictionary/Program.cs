using System;
using System.Collections.Generic;

namespace Dictionary_e_SortedDictionary {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "83737388";
            Console.WriteLine(cookies["phone"]);
        }
    }
}
