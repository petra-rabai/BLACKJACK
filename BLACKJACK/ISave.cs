using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public interface ISave
    {
        string Name { get; set; }
        DateTime SaveDate { get; set; }
        string Winner { get; set; }
        bool IsGameDirectoryExsist { get; set; }
        void CreateGameDirectory(string gamePath);
        void GetGameResult();
        void SaveGameResultToFile();
    }
}
