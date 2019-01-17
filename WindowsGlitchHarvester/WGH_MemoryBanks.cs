using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsGlitchHarvester
{
    static class WGH_MemoryBanks
    {
        public static byte[][] ReadFile (string path)
        {
            try
            {
                const int maxBankSize = Int32.MaxValue/20;

                long fileLength = new System.IO.FileInfo(path).Length;
                int tailBankSize = Convert.ToInt32(fileLength % maxBankSize);
                bool multipleBanks = fileLength > maxBankSize;
                int banksCount = 1;

                if (multipleBanks)
                {
                    banksCount = Convert.ToInt32((fileLength - tailBankSize) / maxBankSize);

                    if (tailBankSize != 0) //an addition bank exists if the filesize's length isn't a multiplier of int32 maxvalue
                        banksCount++;
                }

                byte[][] Banks = new byte[banksCount][];

                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    for(int i = 0; i<banksCount; i++)
                    {
                        int bankSize;
                        long addressStart;

                        if (!multipleBanks)
                        {
                            bankSize = Convert.ToInt32(fileLength);
                            addressStart = 0;
                        }
                        else
                        {
                            bool isLastBank = (i == banksCount - 1);

                            if (isLastBank)
                                bankSize = tailBankSize;
                            else
                                bankSize = maxBankSize;

                            addressStart = i * maxBankSize;

                        }

                        byte[] readBytes = new byte[bankSize];
                        stream.Position = addressStart;
                        stream.Read(readBytes, 0, bankSize);

                        Banks[i] = readBytes;
                    }
                }

                return Banks;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
