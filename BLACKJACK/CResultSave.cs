using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public class CResultSave : ISave
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime SaveDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Winner { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsGameDirectoryExsist { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CreateGameDirectory(string gamePath)
        {
            throw new NotImplementedException();
        }

        public void GetGameResult()
        {
            throw new NotImplementedException();
        }

        public void SaveGameResultToFile()
        {
            throw new NotImplementedException();
        }
    }
}
