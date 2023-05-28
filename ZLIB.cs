using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace bagpipe
{
    static class ZLIB
    {
        public static byte[] Compress(byte[] data, int offset, int len)
        {
            using var mem = new MemoryStream();
            using (var compressStream = new DeflaterOutputStream(mem))
            {
                compressStream.Write(data);
            }
            var result = mem.ToArray();
            return result;
        }

        public static byte[] Decompress(int decompressedSize, byte[] data, int offset, int len)
        {
            byte[] decompressedData = new byte[decompressedSize];
            using var mem = new MemoryStream(data);
            using var decompressStream = new InflaterInputStream(mem);
            decompressStream.Read(decompressedData, 0, decompressedData.Length);
            return decompressedData;
        }
    }
}
