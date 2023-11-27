using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket
{
    internal static class GlobalState
    {
        public static string username { get; set; }
        public static string password { get; set; }
        public static string employeeId { get; set; }
        public static List<string> funcs { get; set; }
    }
}
