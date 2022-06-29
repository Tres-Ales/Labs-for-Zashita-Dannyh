using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMZI_lr3
{
    class FileService
    {
        public static List<byte[]> ReadFromDocument(Stream file)
        {
            List<byte[]> listBytes = new List<byte[]>(3);

            using (BinaryReader br = new BinaryReader(file))
            {
                int certLength = br.ReadInt32();
                int signatureLength = br.ReadInt32();

                listBytes.Add(br.ReadBytes(certLength));
                listBytes.Add(br.ReadBytes(signatureLength));
                listBytes.Add(br.ReadBytes((int)(br.BaseStream.Length - br.BaseStream.Position)));
            }

            return listBytes;
        }
        public static void WriteToDocument(Stream file, int certLength, int signatureLength, byte[] cert, byte[] signature, byte[] data)
        {
            using (BinaryWriter bw = new BinaryWriter(file))
            {
                bw.Write(certLength);
                bw.Write(signatureLength);
                bw.Write(cert);
                bw.Write(signature);
                bw.Write(data);
            }
        }
    }
}
